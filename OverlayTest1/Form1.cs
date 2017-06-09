using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverlayTest1 {
    public partial class Form1 : Form {
        FormOverlay frm;
        public Form1() {
            frm = new FormOverlay();
            InitializeComponent();
        }

        private void overlayCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (overlayCheckBox.Checked) {
                frm.Show();
            } else {
                frm.Hide();
            }

        }
    }
}
