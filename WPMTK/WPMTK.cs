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
        private IntPtr hWnd;
        private string window_title;

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

        private bool sethwnd(string title)
        {
            try
            {
                hWnd = Windows.FindWindow(null, title);
                if (hWnd == null)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Get the HWND that belongs to this process.
        /// </summary>
        /// <returns>IntPtr (HWND)</returns>
        public IntPtr gethwnd()
        {
            return hWnd;
        }

        /// <summary>
        /// Changes this object to attach to an entirely different process.
        /// </summary>
        /// <param name="proc_title">Name of process to attach to.</param>
        /// <returns>True if no errors, false if failed to locate new process: returns to same process.</returns>
        public bool changeprocess(string proc_title)
        {
            try
            {
                if (sethwnd(proc_title)) // if false, failed
                {
                    memory = new VAMemory(proc_title);
                    window_title = proc_title;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
