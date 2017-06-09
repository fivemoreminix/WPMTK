using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace WPMTK
{
    public class Windows
    {
        public struct RECT
        {
            public int left, top, right, bottom;
        }

        [DllImport("User32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("User32.dll", SetLastError = true)]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("User32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("User32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);
    }

    public class Process
    {
        public VAMemory memory;
        public IntPtr hWnd { get; }
        public string window_title { get; }
        Process(string window_title)
        {
            hWnd = Windows.FindWindow(null, window_title);
            if (hWnd == null) // the window could not be found
            {
                Console.WriteLine("Process \"{0}\" could not be found.\nExiting with code 1...", window_title);
                Thread.Sleep(5000);
                Environment.Exit(1);
            }
            this.window_title = window_title;
            memory = new VAMemory(window_title);
        }
    }
}
