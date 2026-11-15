// Audio bootstrap for Android.
//
// SoundManager (and the whole simulation core) speaks OpenAL through the
// OpenTK bindings, which DllImport "openal32.dll" - the Windows library name.
// On Android the OpenAL implementation is OpenAL Soft, shipped as
// libopenal32.so in the APK (see native/build-openal-soft.sh), so the import
// name is remapped here before any audio call is made.

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace DroidBVE
{
	internal static class AndroidAudioBootstrap
	{
		private static bool initialized;

		/// <summary>
		/// Maps the OpenTK OpenAL binding's "openal32.dll" import to the
		/// OpenAL Soft shared library shipped with the app. Must be called
		/// before any audio code runs (idempotent).
		/// </summary>
		internal static void Initialize()
		{
			if (initialized)
			{
				return;
			}
			initialized = true;

			Assembly openTkAssembly = typeof(OpenTK.Audio.OpenAL.AL).Assembly;
			NativeLibrary.SetDllImportResolver(openTkAssembly, ResolveOpenAl);
		}

		private static IntPtr ResolveOpenAl(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
		{
			switch (libraryName)
			{
				case "openal32.dll":
				case "openal32":
				case "openal":
					// libopenal32.so is bundled via AndroidNativeLibrary in the csproj
					return NativeLibrary.Load("openal32");
				default:
					return IntPtr.Zero;
			}
		}
	}
}