using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverlayLib {
    public partial class FormOverlay : Form {
        #region DllImport
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32")]
        static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);
        #endregion

        #region Fields
        RECT rect;
        private readonly string WINDOW_NAME;
        IntPtr handle;
        private readonly bool isBorderless;
        #endregion

        #region Structs
        public struct RECT {
            public int left, top, right, bottom;
        }
        #endregion

        Graphics g;
        Pen myPen = new Pen(Color.Red);

        public FormOverlay(string windowName, bool isBorderless = false) {
            InitializeComponent();
            WINDOW_NAME = windowName;
            handle = FindWindow(null, WINDOW_NAME);
            this.isBorderless = isBorderless;
        }

        private void FormOverlay_Load(object sender, EventArgs e) {
            this.BackColor = Color.Wheat;
            this.TransparencyKey = Color.Wheat;
            this.TopMost = true;
            if (isBorderless) {
                this.FormBorderStyle = FormBorderStyle.None;
            }

            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -29, initialStyle | 0x80000 | 0x20);

            GetWindowRect(handle, out rect);
            this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
            this.Top = rect.top;
            this.Left = rect.left;
        }

        private void FormOverlay_Paint(object sender, PaintEventArgs e) {
            
            g = e.Graphics;
            g.DrawRectangle(myPen, 100, 100, 200, 200);
        }


    }
}
