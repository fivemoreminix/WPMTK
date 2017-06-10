using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WOTK;

namespace Test
{
    public partial class OverlaySettings : Form
    {
        WPMTK.Process process; // process
        Overlay overlay; // overlay object

        public OverlaySettings(WPMTK.Process process)
        {
            InitializeComponent();

            overlay = new Overlay(process);
            this.process = process;
        }

        // show
        private void showBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showBox.Checked)
                overlay.IsOverlayShown(true);
            else
                overlay.IsOverlayShown(false);
        }

        // borderless
        private void borderlessBox_CheckedChanged(object sender, EventArgs e)
        {
            if (borderlessBox.Checked)
                overlay.FormOverlay.FormBorderStyle = FormBorderStyle.None;
            else
                overlay.FormOverlay.FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
