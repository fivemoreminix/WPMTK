using System;
using System.Windows.Forms;
using WOTK;

namespace Test
{
    public partial class OverlaySettings : Form
    {
        WPMTK.Process process; // process
        Overlay overlay; // overlay object

        // constructor
        public OverlaySettings(WPMTK.Process process)
        {
            InitializeComponent();

            try
            {
                overlay = new Overlay(process);
            }
            catch
            {
                MessageBox.Show("Could not create an overlay for the process targeted. Maybe the process changed it\'s window title.");
                Close();
            }
            this.process = process;
            Text = Text+" for "+process.GetWindowTitle();
        }

        // show
        private void showBox_CheckedChanged(object sender, EventArgs e)
        {
            overlay.IsOverlayShown(showBox.Checked);
            timer1.Enabled = showBox.Checked;
            if (!showBox.Checked)
                coordinatesStatus.Text = "Overlay not active - check \"show\" box to enable it.";
        }

        // borderless
        private void borderlessBox_CheckedChanged(object sender, EventArgs e)
        {
            if (borderlessBox.Checked)
                overlay.FormOverlay.FormBorderStyle = FormBorderStyle.None;
            else
                overlay.FormOverlay.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // overlay coordinates
            System.Drawing.Rectangle bounds = overlay.FormOverlay.DesktopBounds;
            string coord = "Coordinates(X: " + bounds.X + ", Y: " + bounds.Y +
                ", W: "+ bounds.Width + ", H: " + bounds.Height + ")";
            coordinatesStatus.Text = coord;
        }
    }
}
