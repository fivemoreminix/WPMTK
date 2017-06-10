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

namespace OverlayLib {
    public partial class Form1 : Form {
        WOTK.FormOverlay frm;
        public Form1() {
            WPMTK.Process process = new WPMTK.Process("Snipping Tool");
            process.Attach();
            frm = new WOTK.FormOverlay(process);
            InitializeComponent();
        }

        private void overlayCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (overlayCheckBox.Checked) {
                frm.Show();
            } else {
                frm.Hide();
            }

        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
