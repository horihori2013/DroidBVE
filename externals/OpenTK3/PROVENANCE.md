# Vendored: OpenTK 3.3.3

* Source: https://github.com/opentk/opentk (tag `3.3.3`, the version the
  `OpenTK-OpenBVE` desktop package is based on)
* Scope: `src/OpenTK/`, `src/Generator.Rewrite/` plus `License.txt` (MIT).
  The generator tools, tests and GLControl are otherwise not vendored - the
  generated GL/ES binding files are checked in here instead (see below).
* Why: the desktop build consumes the `OpenTK-OpenBVE` NuGet package
  (net20 only). For the mobile port we need the same OpenTK 3.x API built for
  net8.0 and for Android - including `OpenTK.Platform.Android.AndroidGameView`,
  the EGL platform layer and the OpenGL ES 1.0/1.1/2.0/3.0/3.1 bindings, which
  the original Xamarin.Android project (`OpenTK.Android.csproj`) contained.

## Generated binding files

Upstream OpenTK 3.3.3 does not check in the big generated files
(`Graphics/OpenGL/GL.cs`, `GLEnums.cs`, `Graphics/ES*/ES*.cs`, ...); they are
produced by `src/Generator.Bind` at build time. The generated files in this
tree were produced with the 3.3.3 generator (rebuilt for net8.0 with two small
fixes: `Settings.Clone` no longer uses `BinaryFormatter`, and the
`Debug.Listeners` trace setup was removed) and are checked in so the Android
build works without running the generator.

The generated method bodies throw `BindingsNotRewrittenException` until the
**IL rewriter** (`Generator.Rewrite`, vendored in `Generator.Rewrite/`) has
run over the compiled assembly. This happens automatically via the
`RewriteBindings` MSBuild target in the build projects below - do not skip it
for assemblies that will run (opt out with `-p:SkipBindingRewrite=true`).

## Build projects (added by the DroidBVE port)

* `OpenTK3.Desktop.csproj` - net8.0, mirrors the original `OpenTK.csproj`
  file list and defines (`WIN32;CARBON;X11;SDL2;OPENGL;OPENGLES`). The full
  desktop OpenGL surface.
* `OpenTK3.Mobile.csproj` - net8.0, mirrors `OpenTK.Android.csproj` minus the
  Mono.Android-dependent `Platform/Android` glue, plus the GLESCompat shim.
  This is the API surface the mobile core compiles against, so the code path
  matches the Android build exactly (verified by the headless smoke test).
* `OpenTK3.Android.csproj` - net8.0-android, mirrors the original
  `OpenTK.Android.csproj` file list and defines
  (`ANDROID;OPENGLES;OPENTK_1_1`). Contains `AndroidGameView` etc.
* `desktop-items.txt` / `android-items.txt` - the extracted `<Compile>` lists
  the projects were generated from (kept for maintainability).

## GLESCompat (DroidBVE glue, not upstream OpenTK)

`GLESCompat/` re-provides the desktop `OpenTK.Graphics.OpenGL` API surface
that LibRender2 uses on top of the ES 3.0 bindings:

* `GLCompat.cs` - static class `GL`: shader/buffer/texture/FBO calls map ~1:1
  to ES 3.0; `ProgramUniform*` (DSA) is emulated with `UseProgram`+`Uniform*`;
  the fixed-function UI overlay pieces (Begin/Vertex*/End, matrix stack) are
  emulated with a small immediate-mode shader and CPU matrix stacks; GLSL
  sources are preprocessed into GLSL ES 1.00 form.
* `GLEnumsCompat.cs` - the desktop GL enums LibRender2 uses, with their
  original values (extracted from the generated `GLEnums.cs`).

## Local changes to the vendored sources

* `Platform/X11/XI2MouseKeyboard.cs`: explicit `(EventMask)` cast at an
  `XSendEvent` call site. On modern .NET `nint` makes the literal `0`
  ambiguous between the two overloads; the cast keeps the historical
  (EventMask) overload resolution.
* `DisplayDevice.cs`: added a `ScaleFactor` property (HiDPI scaling) for API
  compatibility with the `OpenTK-OpenBVE` fork used by the desktop build. It
  currently reports 1.0; platform detection (e.g. Android display density) is
  TODO.
* `Configuration.cs`: `DetectSdl2()` call is now guarded with `#if SDL2`
  (mobile builds do not compile the SDL2 backend).
* `Platform/Egl/EglContext.cs`, `Platform/Factory.cs`: the ANGLE support is
  excluded for `__MOBILE__` builds (it depends on Win32 window types);
  mobile/Android use their own context creation.
* `Platform/Dummy/DummyDisplayDeviceDriver.cs`: new file - a display driver
  that reports a single generic display so headless/mobile builds do not throw
  from the `DisplayDevice` static constructor (Android uses
  `AndroidDisplayDeviceDriver`).
* `Generator.Rewrite/`: rebuilt for net8.0 (`Generator.Rewrite.NetCore.csproj`
  with `Mono.Cecil` + `CommandLineParser` packages) and its assembly resolver
  now also probes the target directory and the .NET shared runtime so it can
  rewrite net8.0 assemblies.
