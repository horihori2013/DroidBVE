// Minimal Android host implementation of the OpenBVE API.
//
// Bridges the simulation core to the renderer / sound engine / content plugins
// in the same way the desktop host does (see source/OpenBVE/System/Host.cs).
// Messages go to logcat. The Tracks property bridges to the loaded route.

using System;
using System.Collections.Generic;
using System.IO;
using Android.Util;
using LibRender2;
using OpenBveApi;
using OpenBveApi.FileSystem;
using OpenBveApi.Graphics;
using OpenBveApi.Hosts;
using OpenBveApi.Interface;
using OpenBveApi.Math;
using OpenBveApi.Objects;
using OpenBveApi.Routes;
using OpenBveApi.Sounds;
using OpenBveApi.Textures;
using OpenBveApi.Trains;
using SoundManager;
using TrainManager;

namespace DroidBVE
{
	internal class AndroidHost : HostInterface
	{
		private const string Tag = "DroidBVE";

		/// <summary>The route currently loaded into the simulation.</summary>
		internal CurrentRoute CurrentRoute;

		/// <summary>The renderer hosting LibRender2 (set once created).</summary>
		internal AndroidRenderer Renderer;

		/// <summary>The sound engine (set once created).</summary>
		internal AndroidSounds Sounds;

		/// <summary>Whether the OpenAL Soft native library loaded and audio is available.</summary>
		internal bool AudioEnabled;

		/// <summary>Raised for every host message, for display in the UI.</summary>
		internal event Action<string> MessageReceived;

		public AndroidHost() : base(HostApplication.OpenBve)
		{
			Plugins = new ContentLoadingPlugin[0];
		}

		public override Dictionary<int, Track> Tracks
		{
			get => CurrentRoute?.Tracks;
			set
			{
				if (CurrentRoute != null)
				{
					CurrentRoute.Tracks = value;
				}
			}
		}

		public override AbstractTrain ParseTrackFollowingObject(string objectPath, string tfoFile)
		{
			AddMessage(MessageType.Error, false, "Track following objects are not yet supported on Android.");
			return null;
		}

		public override void AddMessage(MessageType type, bool fileNotFound, string text)
		{
			Log.Warn(Tag, "[" + type + "] " + text);
			MessageReceived?.Invoke(text);
		}

		public override void ReportProblem(ProblemType type, string text)
		{
			Log.Warn(Tag, "[Problem:" + type + "] " + text);
		}

		// --- textures ---

		public override bool QueryTextureDimensions(string path, out int width, out int height)
		{
			for (int i = 0; i < Plugins.Length; i++)
			{
				if (Plugins[i].Texture == null)
				{
					continue;
				}
				try
				{
					if (Plugins[i].Texture.CanLoadTexture(path) && Plugins[i].Texture.QueryTextureDimensions(path, out width, out height))
					{
						return true;
					}
				}
				catch (Exception ex)
				{
					AddMessage(MessageType.Error, false, "Plugin " + Plugins[i].Title + " raised an exception at QueryTextureDimensions: " + ex.Message);
				}
			}
			width = 0;
			height = 0;
			return false;
		}

		public override bool LoadTexture(string path, TextureParameters parameters, out Texture texture)
		{
			if (File.Exists(path) || Directory.Exists(path))
			{
				for (int i = 0; i < Plugins.Length; i++)
				{
					if (Plugins[i].Texture == null)
					{
						continue;
					}
					try
					{
						if (Plugins[i].Texture.CanLoadTexture(path) && Plugins[i].Texture.LoadTexture(path, out texture))
						{
							texture = texture.ApplyParameters(parameters);
							return true;
						}
					}
					catch (Exception ex)
					{
						AddMessage(MessageType.Error, false, "Plugin " + Plugins[i].Title + " raised an exception at LoadTexture: " + ex.Message);
					}
				}
				AddMessage(MessageType.Error, false, "No plugin found that is capable of loading texture " + path);
			}
			else
			{
				ReportProblem(ProblemType.PathNotFound, path);
			}
			texture = null;
			return false;
		}

		public override bool LoadTexture(ref Texture texture, OpenGlTextureWrapMode wrapMode)
		{
			return Renderer.TextureManager.LoadTexture(ref texture, wrapMode, 0, InterpolationMode.Nearest, 1);
		}

		public override bool RegisterTexture(string path, TextureParameters parameters, out Texture handle, bool loadTexture = false, int timeout = 1000)
		{
			if (Renderer.TextureManager.RegisterTexture(path, parameters, out handle))
			{
				if (loadTexture)
				{
					Texture local = handle;
					LoadTexture(ref local, OpenGlTextureWrapMode.ClampClamp);
				}
				return true;
			}
			handle = null;
			return false;
		}

		public override bool RegisterTexture(Texture texture, TextureParameters parameters, out Texture handle)
		{
			texture = texture.ApplyParameters(parameters);
			handle = Renderer.TextureManager.RegisterTexture(texture);
			return true;
		}

		// --- sounds ---

		public override bool LoadSound(string path, out Sound sound)
		{
			if (File.Exists(path) || Directory.Exists(path))
			{
				for (int i = 0; i < Plugins.Length; i++)
				{
					if (Plugins[i].Sound == null)
					{
						continue;
					}
					try
					{
						if (Plugins[i].Sound.CanLoadSound(path) && Plugins[i].Sound.LoadSound(path, out sound))
						{
							return true;
						}
					}
					catch (Exception ex)
					{
						AddMessage(MessageType.Error, false, "Plugin " + Plugins[i].Title + " raised an exception at LoadSound: " + ex.Message);
					}
				}
				AddMessage(MessageType.Error, false, "No plugin found that is capable of loading sound " + path);
			}
			else
			{
				ReportProblem(ProblemType.PathNotFound, path);
			}
			sound = null;
			return false;
		}

		public override bool RegisterSound(string path, out SoundHandle handle)
		{
			return RegisterSound(path, 0.0, out handle);
		}

		public override bool RegisterSound(string path, double radius, out SoundHandle handle)
		{
			if (!AudioEnabled)
			{
				handle = null;
				return false;
			}
			if (File.Exists(path) || Directory.Exists(path))
			{
				handle = Sounds.RegisterBuffer(path, radius);
				return true;
			}
			ReportProblem(ProblemType.PathNotFound, path);
			handle = null;
			return false;
		}

		public override bool RegisterSound(Sound sound, out SoundHandle handle)
		{
			if (!AudioEnabled)
			{
				handle = null;
				return false;
			}
			handle = Sounds.RegisterBuffer(sound, 0.0);
			return true;
		}

		public override bool SoundIsPlaying(object soundSource)
		{
			return AudioEnabled && Sounds.IsPlaying(soundSource);
		}

		public override object PlaySound(SoundHandle buffer, double pitch, double volume, Vector3 position, object parent, bool looped)
		{
			return AudioEnabled ? Sounds.PlaySound(buffer, pitch, volume, position, parent, looped) : null;
		}

		public override void PlayMicSound(Vector3 position, double backwardTolerance, double forwardTolerance)
		{
			// Microphone input is not available through OpenAL Soft on Android.
		}

		public override void StopSound(object soundSource)
		{
			if (AudioEnabled)
			{
				Sounds.StopSound(soundSource as SoundSource);
			}
		}

		public override void StopAllSounds(object parent)
		{
			if (AudioEnabled)
			{
				Sounds.StopAllSounds(parent);
			}
		}

		// --- objects ---

		public override bool LoadStaticObject(string path, System.Text.Encoding encoding, bool preserveVertices, out StaticObject staticObject)
		{
			if (base.LoadStaticObject(path, encoding, preserveVertices, out staticObject))
			{
				return true;
			}
			if (File.Exists(path) || Directory.Exists(path))
			{
				for (int i = 0; i < Plugins.Length; i++)
				{
					if (Plugins[i].Object == null)
					{
						continue;
					}
					try
					{
						if (Plugins[i].Object.CanLoadObject(path) && Plugins[i].Object.LoadObject(path, encoding, out UnifiedObject unifiedObject) && unifiedObject is StaticObject loaded)
						{
							staticObject = loaded;
							return true;
						}
					}
					catch (Exception ex)
					{
						AddMessage(MessageType.Error, false, "Plugin " + Plugins[i].Title + " raised an exception at LoadObject: " + ex.Message);
					}
				}
				AddMessage(MessageType.Error, false, "No plugin found that is capable of loading object " + path);
			}
			else
			{
				ReportProblem(ProblemType.PathNotFound, path);
			}
			staticObject = null;
			return false;
		}

		public override bool LoadObject(string path, System.Text.Encoding encoding, out UnifiedObject unifiedObject)
		{
			if (base.LoadObject(path, encoding, out unifiedObject))
			{
				return true;
			}
			if (File.Exists(path) || Directory.Exists(path))
			{
				for (int i = 0; i < Plugins.Length; i++)
				{
					if (Plugins[i].Object == null)
					{
						continue;
					}
					try
					{
						if (Plugins[i].Object.CanLoadObject(path) && Plugins[i].Object.LoadObject(path, encoding, out unifiedObject))
						{
							return true;
						}
					}
					catch (Exception ex)
					{
						AddMessage(MessageType.Error, false, "Plugin " + Plugins[i].Title + " raised an exception at LoadObject: " + ex.Message);
					}
				}
				AddMessage(MessageType.Error, false, "No plugin found that is capable of loading object " + path);
			}
			else
			{
				ReportProblem(ProblemType.PathNotFound, path);
			}
			unifiedObject = null;
			return false;
		}

		public override int CreateStaticObject(StaticObject prototype, Vector3 position, ObjectCreationParameters parameters, Transformation worldTransformation, Transformation localTransformation = null)
		{
			return Renderer.CreateStaticObject(prototype, position, worldTransformation, localTransformation, CurrentRoute.AccurateObjectDisposal, parameters, CurrentRoute.BlockLength);
		}

		public override int CreateStaticObject(StaticObject prototype, Vector3 position, Transformation localTransformation, Matrix4D rotate, Matrix4D translate, ObjectCreationParameters parameters)
		{
			return Renderer.CreateStaticObject(position, prototype, localTransformation, rotate, translate, CurrentRoute.AccurateObjectDisposal, parameters, CurrentRoute.BlockLength);
		}

		public override void CreateDynamicObject(ref ObjectState internalObject)
		{
			Renderer.CreateDynamicObject(ref internalObject);
		}

		public override void ShowObject(ObjectState objectToShow, ObjectType objectType)
		{
			Renderer.VisibleObjects.ShowObject(objectToShow, objectType);
		}

		public override void HideObject(ObjectState objectToHide)
		{
			Renderer.VisibleObjects.HideObject(objectToHide);
		}

		// --- misc ---

		public override SimulationState SimulationState => SimulationState.Running;

		public override double InGameTime => CurrentRoute?.SecondsSinceMidnight ?? 0.0;
	}

	/// <summary>Options stub; settings persistence is TODO.</summary>
	internal class AndroidOptions : BaseOptions
	{
		public override void Save(string fileName)
		{
		}
	}

	/// <summary>Train manager with no desktop extras.</summary>
	internal class AndroidTrainManager : TrainManagerBase
	{
		public AndroidTrainManager(HostInterface host, BaseRenderer renderer, BaseOptions options, FileSystem fileSystem) : base(host, renderer, options, fileSystem)
		{
		}
	}
}