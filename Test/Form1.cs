using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addressParse(sender, e);
        }

        private unsafe void addressParse(object sender, EventArgs e) {
            int denars = (int)numericUpDown1.Value;
            int* addr = (int*) int.Parse(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
