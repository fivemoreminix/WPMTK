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
            addressNewSet.Enabled = false;
            timer1.Enabled = true;
        }

        // set address's value (int/string)
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataTypeBox.SelectedItem == dataTypeBox.Items[0]) // int
            {
                int value = (int)numericUpDown1.Value;
                proc.memory.WriteInt32(address, value);
            }
            else if (dataTypeBox.SelectedItem == dataTypeBox.Items[1]) // string
            {
                proc.memory.WriteStringASCII(address, addressNewBox.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        // set the address
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int str_int = (int)new Int32Converter().ConvertFromString(addressBox.Text);
                address = (IntPtr)str_int;
                addressSet.Enabled = false;
            }
            catch
            {
                MessageBox.Show("\"" + addressBox.Text + "\" is not recognized as a valid memory address.", "Address Error!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (addressNewSet.Enabled != true)
                addressNewSet.Enabled = true;
            if (addressSet.Enabled != true)
                addressSet.Enabled = true;
        }

        // set process title
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (proc != null)
                    proc.ChangeProcess(processTitleBox.Text);
                else
                    proc = new Process(processTitleBox.Text); // Process initializer
                process_title = processTitleBox.Text;
                processTitleInfo.Visible = false; // hide the info label
            }
            catch
            {
                MessageBox.Show("Could not attach to that process. The title does not seem to meet any matches.", "Failed changing processes.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataTypeBox.SelectedItem == dataTypeBox.Items[0]) // int
            {
                label1.Visible = true;
                addressNewBox.Visible = false;
                numericUpDown1.Visible = true;
            }
            else if (dataTypeBox.SelectedItem == dataTypeBox.Items[1]) // string
            {
                label1.Visible = true;
                numericUpDown1.Visible = false;
                addressNewBox.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (address != null && process_title != null) // sync is available
            {
                if (dataTypeBox.SelectedItem == dataTypeBox.Items[0]) // int
                    addressCurrentNum.Value = proc.memory.ReadInt32(address);
                else if (dataTypeBox.SelectedItem == dataTypeBox.Items[1]) // string
                    addressNewBox.Text = proc.memory.ReadStringASCII(address, 0);
            }
        }

        // Address -> Attach
        private void attachMenuItem_Click(object sender, EventArgs e)
        {
            if (proc != null)
                proc.Attach();
            else
                MessageBox.Show("No process specified for attaching to.");
        }
    }
}
