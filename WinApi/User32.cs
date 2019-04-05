﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Se7en.WinApi
{
    public class User32
    {
        public const string ImportKey = "user32.dll";

        [DllImport(ImportKey)]
        [return: MarshalAs(UnmanagedType.Bool)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static extern bool ShowWindow(IntPtr hwnd, ShowWindowCommands command);

        [DllImport(ImportKey)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static extern IntPtr FindWindow(string className, string lpWindowName);

        [DllImport(ImportKey)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);

        [DllImport(ImportKey)]
        [return: MarshalAs(UnmanagedType.Bool)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport(ImportKey)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndParent);

        [DllImport(ImportKey)]
        [return: MarshalAs(UnmanagedType.Bool)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport(ImportKey)]
        [return: MarshalAs(UnmanagedType.Bool)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static extern bool GetWindowRect(IntPtr hWnd, ref Rect lpRect);

        [DllImport(ImportKey)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport(ImportKey)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static extern bool ReleaseCapture();

        [DllImport(ImportKey)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport(ImportKey)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDC);

        /// <summary>
        /// Retrieves a handle to a window that has the specified relationship (Z-Order or owner) to the specified window.
        /// </summary>
        /// <remarks>The EnumChildWindows function is more reliable than calling GetWindow in a loop. An application that
        /// calls GetWindow to perform this task risks being caught in an infinite loop or referencing a handle to a window
        /// that has been destroyed.</remarks>
        /// <param name="hWnd">A handle to a window. The window handle retrieved is relative to this window, based on the
        /// value of the uCmd parameter.</param>
        /// <param name="uCmd">The relationship between the specified window and the window whose handle is to be
        /// retrieved.</param>
        /// <returns>
        /// If the function succeeds, the return value is a window handle. If no window exists with the specified relationship
        /// to the specified window, the return value is NULL. To get extended error information, call GetLastError.
        /// </returns>
        [DllImport(ImportKey)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static extern IntPtr GetWindow(IntPtr hWnd, GetWindowType wCmd);
        [DllImport(ImportKey)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static extern IntPtr GetTopWindow(IntPtr hWnd);
        [DllImport(ImportKey, CharSet = CharSet.Auto, SetLastError = true)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport(ImportKey)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static extern int GetWindowTextLength(IntPtr hWnd);
    }
}
