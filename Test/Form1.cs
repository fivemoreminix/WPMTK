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
            timer1.Enabled = true;
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
                int str_int = (int)new Int32Converter().ConvertFromString(textBox1.Text);
                address = (IntPtr)str_int;
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
                if (proc != null)
                    proc.ChangeProcess(textBox2.Text);
                else
                    proc = new Process(textBox2.Text); // Process initializer
                process_title = textBox2.Text;
                label6.Visible = false; // hide the info label
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
                label1.Visible = true;
                textBox3.Visible = false;
                numericUpDown1.Visible = true;
            }
            else if (comboBox1.SelectedItem == comboBox1.Items[1]) // string
            {
                label1.Visible = true;
                numericUpDown1.Visible = false;
                textBox3.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (address != null && process_title != null) // sync is available
            {
                if (comboBox1.SelectedItem == comboBox1.Items[0]) // int
                    numericUpDown2.Value = proc.memory.ReadInt32(address);
                else if (comboBox1.SelectedItem == comboBox1.Items[1]) // string
                    textBox3.Text = proc.memory.ReadStringASCII(address, 0);
            }
        }
    }
}
