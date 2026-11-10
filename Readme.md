# DroidBVE

**OpenBVE をスマートフォン（Android）へ移植するプロジェクトです。**

DroidBVE is a project to port the train simulator
[OpenBVE](https://github.com/leezer3/OpenBVE) to smartphones (Android).
The simulation core is now built for .NET 8 / .NET for Android and is
verified running without any desktop UI, GDI or OpenGL.

## Status

| Component | State |
|---|---|
| Portable simulation core (`source/Mobile`, net8.0) | ✅ Working - route + train loading and physics verified by the headless smoke test |
| Headless smoke test (`source/Mobile/OpenBve.Headless`) | ✅ Passing on .NET 8 (usable in CI) |
| OpenTK 3.3.3 built from source (`externals/OpenTK3`) | ✅ Vendored; net8.0 build verified, `net8.0-android` build project ready (`AndroidGameView` + OpenGL ES bindings) |
| Android app skeleton (`source/OpenBVE.Android`) | 🚧 Boots the sim with touch throttle/brake; needs `dotnet workload install android` |
| OpenGL ES renderer / audio / menus on Android | 🚧 Roadmap, see [BuildingAndroid.md](BuildingAndroid.md) |

## Quick start (headless smoke test)

Only the .NET 8 SDK is required:

```bash
cd source/Mobile
dotnet build DroidBVE.Mobile.sln
dotnet run --project OpenBve.Headless
```

Expected output ends with `HEADLESS SMOKE TEST PASSED` after loading a test
CSV route and `train.dat` and accelerating the train for 20 simulated seconds.

## Building the Android app

See **[BuildingAndroid.md](BuildingAndroid.md)** for instructions
(`dotnet workload install android`), the architecture notes and the roadmap.

## Relationship to upstream OpenBVE

This repository started as a fork of
[leezer3/OpenBVE](https://github.com/leezer3/OpenBVE) and keeps the upstream
history in `master`. The desktop simulator is unchanged upstream OpenBVE -
all porting work lives on the `android-port` branch and in `source/Mobile`,
`source/OpenBVE.Android` and `externals`.

Many thanks to the openBVE project and all its contributors.
OpenBVE is © the openBVE Project - see [licenses/](licenses/) for licensing
of the individual components.
