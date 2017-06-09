using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPMTK;

namespace Test
{
    public partial class Form1 : Form
    {
        private IntPtr address;
        private string process_title;
        private Process proc;

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        // set address's value (int/string)
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == comboBox1.Items[0]) // int
            {
                int value = (int)numericUpDown1.Value;
                proc.memory.WriteInt32(address, value);
            }
            else if (comboBox1.SelectedItem == comboBox1.Items[1]) // string
            {
                proc.memory.WriteStringASCII(address, textBox3.Text);
            }
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
            if (button1.Enabled != true)
                button1.Enabled = true;
            if (button2.Enabled != true)
                button2.Enabled = true;
        }

        // set process title
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                proc.changeprocess(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Could not attach to that process. The title does not seem to meet any matches.", "Failed changing processes.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == comboBox1.Items[0]) // int
            {
                textBox3.Visible = false;
                numericUpDown1.Visible = true;
            }
            else if (comboBox1.SelectedItem == comboBox1.Items[1]) // string
            {
                numericUpDown1.Visible = false;
                textBox3.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked) // sync on
            {
                if (comboBox1.SelectedItem == comboBox1.Items[0]) // int
                    numericUpDown2.Value = proc.memory.ReadInt32(address);
                else if (comboBox1.SelectedItem == comboBox1.Items[1]) // string
                    textBox3.Text = proc.memory.ReadStringASCII(address, 0);
            }
        }
    }
}
