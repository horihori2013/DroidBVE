using System;
using System.Collections.Generic;
using System.Drawing;

namespace OpenTK.Platform.Dummy
{
    /// <summary>
    /// Display device driver for headless and non-visual builds (the mobile
    /// core, headless simulation). Reports a single generic display instead of
    /// failing; real platforms provide their own drivers (e.g. Android).
    /// </summary>
    internal class DummyDisplayDeviceDriver : IDisplayDeviceDriver
    {
        private readonly DisplayDevice primary;

        public DummyDisplayDeviceDriver()
        {
            DisplayResolution resolution = new DisplayResolution(0, 0, 1024, 768, 32, 60.0f);
            primary = new DisplayDevice(resolution, true, new List<DisplayResolution> { resolution }, Rectangle.Empty, null);
        }

        public bool TryChangeResolution(DisplayDevice device, DisplayResolution resolution)
        {
            return false;
        }

        public bool TryRestoreResolution(DisplayDevice device)
        {
            return false;
        }

        public DisplayDevice GetDisplay(DisplayIndex displayIndex)
        {
            return displayIndex == DisplayIndex.Primary ? primary : null;
        }
    }
}