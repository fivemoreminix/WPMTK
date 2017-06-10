using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WOTK;

namespace OverlayLib {
    public partial class Form1 : Form {
        WOTK.Overlay frm;
        public Form1() {
            WPMTK.Process process = new WPMTK.Process("Snipping Tool");
            process.Attach();
            frm = new WOTK.Overlay(process);
            InitializeComponent();
        }

        private void overlayCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (overlayCheckBox.Checked) {
                frm.IsOverlayShown(true);
                frm.AddShape(Shapes.Rectangle, new RectangleF(10, 10, 100, 100));
                frm.AddShape(Shapes.Arc, new Arc(110, 110, 100, 100, 10, 30));
                frm.AddShape(Shapes.Ellipse, new RectangleF(10, 210, 100, 100));
                frm.AddShape(Shapes.Pie, new Pie(new RectangleF(210, 210, 100, 100), 30, 90));
                frm.AddShape(Shapes.String, new StringStruct("Hello World!",
                    new Font("Arial", 16), new SolidBrush(Color.White), new PointF(300, 300),
                    new StringFormat()));
            } else {
                frm.IsOverlayShown(false);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
