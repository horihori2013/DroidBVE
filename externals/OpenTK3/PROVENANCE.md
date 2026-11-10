# Vendored: OpenTK 3.3.3

* Source: https://github.com/opentk/opentk (tag `3.3.3`, the version the
  `OpenTK-OpenBVE` desktop package is based on)
* Scope: `src/OpenTK/` plus `License.txt` (MIT). Generator tools, tests and
  GLControl are not vendored - the generated GL/ES binding files are checked
  in here instead (see below).
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

## Build projects (added by the DroidBVE port)

* `OpenTK3.Desktop.csproj` - net8.0, mirrors the original `OpenTK.csproj`
  file list and defines (`WIN32;CARBON;X11;SDL2;OPENGL;OPENGLES`).
* `OpenTK3.Android.csproj` - net8.0-android, mirrors the original
  `OpenTK.Android.csproj` file list and defines (`ANDROID;OPENGLES;OPENTK_1_1`).
* `desktop-items.txt` / `android-items.txt` - the extracted `<Compile>` lists
  the two projects were generated from (kept for maintainability).

## Local changes to the vendored sources

* `Platform/X11/XI2MouseKeyboard.cs`: explicit `(EventMask)` cast at an
  `XSendEvent` call site. On modern .NET `nint` makes the literal `0`
  ambiguous between the two overloads; the cast keeps the historical
  (EventMask) overload resolution.
* `DisplayDevice.cs`: added a `ScaleFactor` property (HiDPI scaling) for API
  compatibility with the `OpenTK-OpenBVE` fork used by the desktop build. It
  currently reports 1.0; platform detection (e.g. Android display density) is
  TODO.
