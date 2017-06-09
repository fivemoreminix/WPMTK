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
        private IntPtr address;

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
            
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        // set the address
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                address = (IntPtr)int.Parse(textBox1.Text);
                button2.Enabled = false;
            }
            catch
            {
                MessageBox.Show("\"" + textBox1.Text + "\" is not recognized as a valid memory address.", "Address Error!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (button2.Enabled != true)
                button2.Enabled = true;
        }
    }
}
