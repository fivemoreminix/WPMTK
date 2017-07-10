using System;
using System.Timers;
using System.Windows.Forms;
using System.Drawing;
using WOTK;

namespace Test
{
    public partial class OverlaySettings : Form
    {
        Random rand;
        WPMTK.Process process; // process
        Overlay overlay; // overlay object

        // constructor
        public OverlaySettings(WPMTK.Process process)
        {
            InitializeComponent();
            rand = new Random(DateTime.Now.Second * DateTime.Now.Millisecond);
            posShapeOne.Text = "";
            posShapeTwo.Text = "";
            posShapeThree.Text = "";
            posShapeFour.Text = "";

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
            Text = Text + " for " + process.WindowTitle;
        }

        // show
        private void showBox_CheckedChanged(object sender, EventArgs e)
        {
            overlay.IsOverlayShown(showBox.Checked);
            timer1.Enabled = showBox.Checked;
            if (!showBox.Checked)
                coordinatesStatus.Text = "Overlay not active - check \"show\" box, and select some shapes to enable it.";
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
            Rectangle bounds = overlay.FormOverlay.DesktopBounds;
            string coord = "Coordinates(X: " + bounds.X + ", Y: " + bounds.Y +
                ", W: "+ bounds.Width + ", H: " + bounds.Height + ")";
            coordinatesStatus.Text = coord;
        }

        // outlined box
        private void outlinedBoxCheck_CheckedChanged(object sender, EventArgs e)
        {
            RectangleF rect = new RectangleF(
                rand.Next(0, overlay.FormOverlay.Right),
                rand.Next(0, overlay.FormOverlay.Bottom),
                100,
                100);
            overlay.AddShape(Shapes.Rectangle, rect);
            posShapeOne.Text = "X: " + rect.X + ", Y: " + rect.Y +
                ", W: " + rect.Width + ", H: " + rect.Height;
        }

        private void filledBoxCheck_CheckedChanged(object sender, EventArgs e)
        {
            Brush b = new SolidBrush(Color.Red);
            Pen p = new Pen(b);
            overlay.FormOverlay.MyPen = p;
            RectangleF rect = new RectangleF(
                rand.Next(0, overlay.FormOverlay.Right),
                rand.Next(0, overlay.FormOverlay.Bottom),
                100,
                100);
            overlay.AddShape(Shapes.Rectangle, rect);
            posShapeOne.Text = "X: " + rect.X + ", Y: " + rect.Y +
                ", W: " + rect.Width + ", H: " + rect.Height;
        }
    }
}
