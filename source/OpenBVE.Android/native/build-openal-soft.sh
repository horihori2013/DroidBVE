#!/usr/bin/env bash
# Builds OpenAL Soft (https://github.com/kcat/openal-soft) for Android and
# stages the shared libraries for the DroidBVE APK.
#
# Requirements:
#   - Android NDK (r25+), e.g. installed via Android Studio's SDK manager
#   - cmake 3.16+
#
# Usage:
#   ANDROID_NDK=/path/to/ndk ./build-openal-soft.sh [openal-soft-src-dir]
#
# Output: jniLibs/<abi>/libopenal32.so (picked up by OpenBVE.Android.csproj).
set -euo pipefail

NDK="${ANDROID_NDK:?Set ANDROID_NDK to the Android NDK root}"
SRC="${1:-openal-soft-src}"
HERE="$(cd "$(dirname "$0")" && pwd)"

if [ ! -f "$SRC/CMakeLists.txt" ]; then
    echo "OpenAL Soft source not found at '$SRC'."
    echo "Clone it first:  git clone https://github.com/kcat/openal-soft $SRC"
    exit 1
fi

# arm64-v8a is the priority target; add others as needed.
ABIS="${ABIS:-arm64-v8a}"

for ABI in $ABIS; do
    case "$ABI" in
        arm64-v8a)  TRIPLE=aarch64-linux-android;  API=24 ;;
        armeabi-v7a) TRIPLE=armv7a-linux-androideabi; API=24 ;;
        x86_64)     TRIPLE=x86_64-linux-android;   API=24 ;;
        x86)        TRIPLE=i686-linux-android;     API=24 ;;
        *) echo "Unknown ABI: $ABI"; exit 1 ;;
    esac

    BUILD="$HERE/build/$ABI"
    echo "== Building OpenAL Soft for $ABI ($TRIPLE, API $API)"
    cmake -S "$SRC" -B "$BUILD" \
        -DCMAKE_TOOLCHAIN_FILE="$NDK/build/cmake/android.toolchain.cmake" \
        -DANDROID_ABI="$ABI" \
        -DANDROID_PLATFORM="android-$API" \
        -DCMAKE_BUILD_TYPE=Release \
        -DALSOFT_EXAMPLES=OFF \
        -DALSOFT_TESTS=OFF \
        -DALSOFT_UTILS=OFF \
        -DCMAKE_INSTALL_PREFIX="$BUILD/install"
    cmake --build "$BUILD" --parallel
    cmake --install "$BUILD"

    OUT="$HERE/jniLibs/$ABI"
    mkdir -p "$OUT"
    # Normalise the library name to libopenal32.so so it matches the
    # DllImportResolver mapping in AndroidAudioBootstrap.cs.
    cp "$BUILD"/libopenal.so* "$OUT/libopenal32.so" 2>/dev/null \
        || cp "$BUILD"/libopenal-soft.so* "$OUT/libopenal32.so"
    echo "-> $OUT/libopenal32.so"
done

echo "Done. Rebuild the Android app to pick the libraries up."