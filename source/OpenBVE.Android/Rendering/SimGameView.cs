// AndroidGameView hosting the simulation renderer.
//
// The GL context is created by OpenTK's AndroidGameView (vendored OpenTK 3.x,
// externals/OpenTK3); the renderer (LibRender2 over the GLES compat shim)
// draws one frame per RenderFrame and swaps. The simulation is updated on the
// same thread via UpdateFrame (matching the desktop architecture), and content
// loading runs on the GL thread through ContextReady.

using System;
using Android.Content;
using Android.Util;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Platform.Android;

namespace DroidBVE
{
	internal class SimGameView : AndroidGameView
	{
		private const string Tag = "DroidBVE";

		private readonly AndroidRenderer renderer;

		/// <summary>
		/// Invoked on the render thread right after the renderer is initialized -
		/// the place to load simulation content (it creates GL resources).
		/// </summary>
		public Action ContextReady;

		public SimGameView(Context context, AndroidRenderer renderer) : base(context)
		{
			this.renderer = renderer;
			AutoSetContextOnRenderFrame = true;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			try
			{
				MakeCurrent();
				renderer.Initialize();
				renderer.Screen.Width = Width;
				renderer.Screen.Height = Height;
				Log.Info(Tag, "Renderer initialized on GLES context: " + GL.GetString(StringName.Version));
				ContextReady?.Invoke();
			}
			catch (Exception ex)
			{
				Log.Error(Tag, "Renderer/content initialization failed: " + ex);
			}
		}

		protected override void OnRenderFrame(FrameEventArgs e)
		{
			base.OnRenderFrame(e);
			renderer.RenderScene(e.Time);
			SwapBuffers();
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			renderer.Screen.Width = Width;
			renderer.Screen.Height = Height;
		}
	}
}