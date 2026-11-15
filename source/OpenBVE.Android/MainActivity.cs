// DroidBVE - main activity.
//
// Hosts the SimGameView (OpenGL ES surface) with touch controls overlaid.
// Flow mirrors the headless smoke test in source/Mobile/OpenBve.Headless, with
// content loading moved onto the GL thread (object loading creates GL
// resources) and the simulation ticking per rendered frame like the desktop
// architecture.

using System;
using System.IO;
using System.Text;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Widget;
using OpenBveApi.FileSystem;
using OpenBveApi.Interface;
using OpenBveApi.Runtime;
using OpenBveApi.Routes;
using OpenBveApi.Trains;
using OpenTK;
using RouteManager2;
using TrainManager;
using TrainManager.Handles;
using TrainManager.Trains;

namespace DroidBVE
{
	[Activity(Label = "DroidBVE", MainLauncher = true, ScreenOrientation = ScreenOrientation.SensorLandscape, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.KeyboardHidden)]
	public class MainActivity : Activity
	{
		private AndroidHost host;
		private AndroidOptions options;
		private FileSystem fileSystem;
		private AndroidRenderer renderer;
		private AndroidTrainManager trainManager;
		private AndroidSounds sounds;
		private SimGameView gameView;
		private TrainBase playerTrain;

		private TextView statusText;
		private TextView speedText;
		private TextView positionText;
		private TextView messageText;
		private SeekBar powerBar;
		private SeekBar brakeBar;

		private readonly object simLock = new object();
		private int uiUpdateCounter;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			AndroidAudioBootstrap.Initialize();

			// --- services ---
			host = new AndroidHost();
			options = new AndroidOptions();
			options.TrainStart = TrainStartMode.ServiceBrakesAts;

			// Android asset packs are not real files: unpack what the
			// parsers need (data folder + test content) to app storage.
			string filesDir = FilesDir.AbsolutePath;
			string dataFolder = Path.Combine(filesDir, "Data");
			string testData = Path.Combine(filesDir, "TestData");
			CopyAssetFolder(Assets, "Compatibility", Path.Combine(dataFolder, "Compatibility"));
			CopyAssetFolder(Assets, "Languages", Path.Combine(dataFolder, "Languages"));
			CopyAssetFolder(Assets, "TestData", testData);

			fileSystem = FileSystem.FromCommandLineArgs(new string[0], host);
			fileSystem.DataFolder = dataFolder;
			fileSystem.SettingsFolder = Path.Combine(filesDir, "Settings");
			fileSystem.InitialRouteFolder = Path.Combine(filesDir, "Railway");
			fileSystem.InitialTrainFolder = Path.Combine(filesDir, "Train");
			fileSystem.CreateFileSystem();

			Translations.LoadLanguageFiles(fileSystem.GetDataFolder("Languages"));

			renderer = new AndroidRenderer(host, options, fileSystem);
			trainManager = new AndroidTrainManager(host, renderer, options, fileSystem);
			sounds = new AndroidSounds(host);
			host.Renderer = renderer;
			host.Sounds = sounds;
			host.MessageReceived += message => RunOnUiThread(() => messageText.Text = message);

			// --- UI: GL surface + overlay ---
			FrameLayout root = new FrameLayout(this);
			gameView = new SimGameView(this, renderer);
			gameView.ContextReady = LoadSimulation;
			gameView.UpdateFrame += OnUpdateFrame;
			root.AddView(gameView);

			LinearLayout overlay = new LinearLayout(this) { Orientation = Orientation.Vertical };
			statusText = new TextView(this) { TextSize = 14 };
			speedText = new TextView(this) { TextSize = 48 };
			positionText = new TextView(this) { TextSize = 14 };
			messageText = new TextView(this) { TextSize = 12 };
			powerBar = new SeekBar(this);
			brakeBar = new SeekBar(this);
			overlay.AddView(statusText);
			overlay.AddView(speedText);
			overlay.AddView(positionText);
			overlay.AddView(new TextView(this) { Text = "Throttle" });
			overlay.AddView(powerBar);
			overlay.AddView(new TextView(this) { Text = "Brake" });
			overlay.AddView(brakeBar);
			overlay.AddView(messageText);
			root.AddView(overlay);
			SetContentView(root);

			statusText.Text = "Loading simulation...";

			// Start the render loop; the simulation content is loaded from the
			// ContextReady callback once the GLES context exists.
			gameView.Run(60.0);
		}

		protected override void OnPause()
		{
			base.OnPause();
			gameView.Pause();
		}

		protected override void OnResume()
		{
			base.OnResume();
			gameView.Resume();
		}

		protected override void OnDestroy()
		{
			gameView.Stop();
			base.OnDestroy();
		}

		/// <summary>Loads the simulation content. Runs on the GL thread.</summary>
		private void LoadSimulation()
		{
			try
			{
				string filesDir = FilesDir.AbsolutePath;
				string testData = Path.Combine(filesDir, "TestData");
				string routeFile = Path.Combine(testData, "TestRoute.csv");
				string trainFolder = Path.Combine(testData, "TestTrain");

				// Content plugins are registered statically on Android (dynamic
				// assembly loading is restricted on mobile platforms).
				ContentLoadingPlugin objectPlugin = new ContentLoadingPlugin("builtin:Object.CsvB3d");
				objectPlugin.Object = new Object.CsvB3d.Plugin();
				objectPlugin.Object.Load(host, fileSystem);
				ContentLoadingPlugin texturePlugin = new ContentLoadingPlugin("builtin:Texture.BmpGifJpegPngTiff");
				texturePlugin.Texture = new Plugin.Plugin();
				texturePlugin.Texture.Load(host, fileSystem, options);
				host.Plugins = new[] { objectPlugin, texturePlugin };

				// Audio (optional: the OpenAL Soft native library may be absent
				// if native/build-openal-soft.sh has not been run yet)
				try
				{
					sounds.Initialize(SoundRange.Small);
					host.AudioEnabled = true;
				}
				catch (Exception ex)
				{
					Android.Util.Log.Warn("DroidBVE", "Audio disabled: " + ex.Message);
				}

				// route
				CsvRwRouteParser.Plugin routePlugin = new CsvRwRouteParser.Plugin();
				routePlugin.Load(host, fileSystem, options, trainManager);
				CurrentRoute currentRoute = new CurrentRoute(host, renderer);
				host.CurrentRoute = currentRoute;
				object route = currentRoute;
				if (!routePlugin.LoadRoute(routeFile, Encoding.UTF8, trainFolder, testData, testData, false, ref route))
				{
					RunOnUiThread(() => statusText.Text = "Route failed to load, see logcat.");
					return;
				}

				// train
				Train.OpenBve.Plugin trainPlugin = new Train.OpenBve.Plugin();
				trainPlugin.Load(host, fileSystem, options, renderer);
				playerTrain = new TrainBase(TrainState.Pending, TrainType.LocalPlayerTrain);
				TrainManagerBase.PlayerTrain = playerTrain;
				AbstractTrain abstractTrain = playerTrain;
				Control[] controls = new Control[0];
				if (!trainPlugin.LoadTrain(Encoding.UTF8, trainFolder, ref abstractTrain, ref controls))
				{
					RunOnUiThread(() => statusText.Text = "Train failed to load, see logcat.");
					return;
				}

				TrainManagerBase.CurrentRoute = (CurrentRoute)route;
				playerTrain.PlaceCars(50.0);
				// PlaceCars only positions the followers; prime the world
				// coordinates so the physics adhesion model works immediately.
				for (int i = 0; i < playerTrain.Cars.Length; i++)
				{
					playerTrain.Cars[i].FrontAxle.Follower.UpdateAbsolute(playerTrain.Cars[i].FrontAxle.Follower.TrackPosition, true, false);
					playerTrain.Cars[i].RearAxle.Follower.UpdateAbsolute(playerTrain.Cars[i].RearAxle.Follower.TrackPosition, true, false);
				}
				playerTrain.Handles.Reverser.Actual = ReverserPosition.Forwards;
				playerTrain.Handles.Reverser.Driver = ReverserPosition.Forwards;

				// renderer post-load initialization (GL thread - creates VAOs)
				renderer.InitializeVisibility();
				renderer.Camera.CurrentMode = CameraViewMode.InteriorLookAhead;
				playerTrain.Cars[playerTrain.DriverCar].UpdateCamera();
				renderer.CameraTrackFollower.UpdateAbsolute(-1.0, true, false);
				renderer.UpdateVisibility(true);
				renderer.UpdateViewingDistances(600.0);

				// driving controls
				RunOnUiThread(() =>
				{
					powerBar.Max = Math.Max(1, playerTrain.Handles.Power.MaximumNotch);
					brakeBar.Max = Math.Max(1, playerTrain.Handles.Brake.MaximumNotch);
					powerBar.ProgressChanged += (s, e) =>
					{
						lock (simLock)
						{
							playerTrain.Handles.Power.Driver = e.Progress;
							playerTrain.Handles.Power.Actual = e.Progress;
						}
					};
					brakeBar.ProgressChanged += (s, e) =>
					{
						lock (simLock)
						{
							playerTrain.Handles.Brake.Driver = e.Progress;
							playerTrain.Handles.Brake.Actual = e.Progress;
						}
					};
					statusText.Text = "Ready - drag the throttle to drive.";
				});
			}
			catch (Exception ex)
			{
				Android.Util.Log.Error("DroidBVE", "Load failed: " + ex);
				RunOnUiThread(() => statusText.Text = "Load failed: " + ex.Message);
			}
		}

		/// <summary>Simulation tick - runs on the render thread before each frame.</summary>
		private void OnUpdateFrame(object sender, FrameEventArgs e)
		{
			TrainBase train = playerTrain;
			if (train == null)
			{
				return;
			}
			lock (simLock)
			{
				train.Update(e.Time);
				if (host.AudioEnabled)
				{
					sounds.Update(e.Time);
				}
				train.Cars[train.CameraCar].UpdateCamera();
				renderer.UpdateVisibility(false);
			}

			if (++uiUpdateCounter % 10 == 0)
			{
				double kmh = train.CurrentSpeed * 3.6;
				double position = train.Cars[0].FrontAxle.Follower.TrackPosition;
				RunOnUiThread(() =>
				{
					speedText.Text = kmh.ToString("0.0") + " km/h";
					positionText.Text = "Position: " + position.ToString("0") + " m";
				});
			}
		}

		/// <summary>Recursively unpacks an Android asset folder into real files.</summary>
		private static void CopyAssetFolder(Android.Content.Res.AssetManager assets, string assetPath, string targetFolder)
		{
			string[] children;
			try
			{
				children = assets.List(assetPath);
			}
			catch
			{
				return;
			}
			if (children == null || children.Length == 0)
			{
				// Leaf = file
				string fileName = Path.GetFileName(assetPath);
				string target = Path.Combine(targetFolder, fileName);
				Directory.CreateDirectory(Path.GetDirectoryName(target));
				using (Stream input = assets.Open(assetPath))
				using (FileStream output = File.Create(target))
				{
					input.CopyTo(output);
				}
				return;
			}
			Directory.CreateDirectory(targetFolder);
			foreach (string child in children)
			{
				CopyAssetFolder(assets, assetPath.Length == 0 ? child : assetPath + "/" + child, Path.Combine(targetFolder, child));
			}
		}
	}
}