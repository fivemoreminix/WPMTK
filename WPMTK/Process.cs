using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace WPMTK
{
    internal class UnsafeNativeMethods
    {
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
    }

    public class Process : IDisposable
    {
        public static Exception ProcessNotFoundException = new Exception(
            "Could not find the process specified. " +
            "Please reference the process by it's window title exactly as it appears. " +
            "E.x. \"Mount&Blade\".");
        public VAMemory memory;
        private IntPtr hWnd;
        private string window_title;

        public Process(string window_title)
        {
            if (!SethWnd(window_title)) // true if succeeded
            {
                throw ProcessNotFoundException;
            }
            this.window_title = window_title;
            memory = new VAMemory(window_title);
        }

        private bool SethWnd(string title)
        {
            try
            {
                hWnd = UnsafeNativeMethods.FindWindow(null, title);
                if (hWnd == null)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Get the HWND that belongs to this process.
        /// </summary>
        /// <returns>IntPtr (hWnd)</returns>
        public IntPtr GethWnd()
        {
            return hWnd;
        }

        /// <summary>
        /// Changes this object to attach to an entirely different process.
        /// </summary>
        /// <param name="window_title">Name of process to attach to.</param>
        /// <returns>True if no errors, false if failed to locate new process: returns to same process.</returns>
        public void ChangeProcess(string window_title)
        {
            if (SethWnd(window_title)) // if false, failed
            {
                memory = new VAMemory(window_title);
                this.window_title = window_title;
            }
            else
            {
                throw ProcessNotFoundException;
            }
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
