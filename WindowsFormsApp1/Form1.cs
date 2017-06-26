using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            process = new WPMTK.Process("GitHub");
            overlay = new WOTK.Overlay(process);
        }

        WPMTK.Process process;
        WOTK.Overlay overlay;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            label1.Text = process.WindowTitle;
            // overlay
            RectangleF rect = new RectangleF(10, 10, 100, 100);
            overlay.AddShape(WOTK.Shapes.Rectangle, rect);
            overlay.IsOverlayShown(true);
        }
    }
}
