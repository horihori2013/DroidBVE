// LibRender2 renderer hosted on an Android GLES context (via AndroidGameView).
//
// The first on-device rendering path: clear the screen, set up the camera and
// draw all visible object faces through LibRender2. Everything here mirrors
// the world-layer of the desktop renderer (source/OpenBVE/Graphics/
// NewRenderer.cs); the background, motion blur, particles and cab overlays are
// follow-up work (see ../../../BuildingAndroid.md).

using System.Collections.Generic;
using System.Linq;
using LibRender2;
using LibRender2.Objects;
using OpenBveApi;
using OpenBveApi.FileSystem;
using OpenBveApi.Graphics;
using OpenBveApi.Hosts;
using OpenBveApi.Math;
using OpenTK.Graphics.OpenGL;

namespace DroidBVE
{
	internal class AndroidRenderer : BaseRenderer
	{
		public AndroidRenderer(HostInterface host, BaseOptions options, FileSystem fileSystem) : base(host, options, fileSystem)
		{
		}

		/// <summary>Renders one frame. Called from SimGameView's render loop.</summary>
		internal void RenderScene(double timeElapsed)
		{
			ReleaseResources();
			ResetOpenGlState();

			// Sky colour until the background (skybox) renderer is wired up
			GL.ClearColor(0.45f, 0.65f, 0.9f, 1.0f);
			GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

			// Camera: same conventions as the desktop renderer
			CurrentViewMatrix = Matrix4D.LookAt(Vector3.Zero,
				new Vector3(Camera.AbsoluteDirection.X, Camera.AbsoluteDirection.Y, -Camera.AbsoluteDirection.Z),
				new Vector3(Camera.AbsoluteUp.X, Camera.AbsoluteUp.Y, -Camera.AbsoluteUp.Z));
			UpdateViewport(ViewportChangeMode.ChangeToScenery);

			// World objects
			DefaultShader.Activate();
			DefaultShader.SetShadowEnabled(false); // CSM shadow pass not wired up yet
			DefaultShader.SetIsLight(true);
			DefaultShader.SetTexture(0);
			DefaultShader.SetCurrentProjectionMatrix(CurrentProjectionMatrix);

			List<FaceState> opaqueFaces, alphaFaces, overlayOpaqueFaces, overlayAlphaFaces;
			lock (VisibleObjects.LockObject)
			{
				opaqueFaces = VisibleObjects.OpaqueFaces.ToList();
				alphaFaces = VisibleObjects.GetSortedPolygons();
				overlayOpaqueFaces = VisibleObjects.OverlayOpaqueFaces.ToList();
				overlayAlphaFaces = VisibleObjects.GetSortedPolygons(true);
			}

			foreach (FaceState face in opaqueFaces)
			{
				face.Draw();
			}

			// Alpha faces: performance transparency (the desktop option's simple mode)
			ResetOpenGlState();
			SetBlendFunc();
			SetAlphaFunc(AlphaFunction.Greater, 0.0f);
			GL.DepthMask(false);
			foreach (FaceState face in alphaFaces)
			{
				face.Draw();
			}

			// Overlay layer (cab, markers)
			ResetOpenGlState();
			SetBlendFunc();
			SetAlphaFunc(AlphaFunction.Greater, 0.0f);
			foreach (FaceState face in overlayOpaqueFaces)
			{
				face.Draw();
			}
			foreach (FaceState face in overlayAlphaFaces)
			{
				face.Draw();
			}

			GL.DepthMask(true);
			ResetOpenGlState();
		}
	}
}