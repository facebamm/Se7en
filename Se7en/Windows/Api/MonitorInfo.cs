﻿#if Windows
using Se7en.Mathematic;
using System.Runtime.InteropServices;

namespace Se7en.Windows.Api
{
    /// <summary>
    /// The MONITORINFO structure contains information about a display monitor.
    /// The GetMonitorInfo function stores information into a MONITORINFOEX structure or a MONITORINFO structure.
    /// The MONITORINFOEX structure is a superset of the MONITORINFO structure. 
    /// The MONITORINFOEX structure adds a string member to contain a name for the display monitor.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MonitorInfo
    {
        /// <summary>
        /// The size, in bytes, of the structure. Set this member to sizeof(MONITORINFOEX) (72) before calling the GetMonitorInfo function.
        /// Doing so lets the function determine the type of structure you are passing to it.
        /// </summary>
        public int Size;
        /// <summary>
        /// A RECT structure that specifies the display monitor rectangle, expressed in virtual-screen coordinates.
        /// Note that if the monitor is not the primary display monitor, some of the rectangle's coordinates may be negative values.
        /// </summary>
        public Rect Monitor;
        /// <summary>
        /// A RECT structure that specifies the work area rectangle of the display monitor that can be used by applications,
        /// expressed in virtual-screen coordinates. Windows uses this rectangle to maximize an application on the monitor.
        /// The rest of the area in rcMonitor contains system windows such as the task bar and side bars.
        /// Note that if the monitor is not the primary display monitor, some of the rectangle's coordinates may be negative values.
        /// </summary>
        public Rect WorkArea;
        /// <summary>
        /// The attributes of the display monitor.
        ///
        /// This member can be the following value:
        ///   1 : MONITORINFOF_PRIMARY
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool IsPrimary;

        public unsafe void Init() 
            => Size = sizeof(MonitorInfo);
    }
}
#endif