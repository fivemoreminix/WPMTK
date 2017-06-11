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
        private Process process;
        private OverlaySettings overlaySettings;

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
                process.memory.WriteInt32(address, value);
            }
            else if (dataTypeBox.SelectedItem == dataTypeBox.Items[1]) // string
            {
                process.memory.WriteStringASCII(address, addressNewBox.Text);
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
        }

        // set process title
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (process != null)
                    process.ChangeProcess(processTitleBox.Text);
                else
                    process = new Process(processTitleBox.Text); // Process initializer
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
            if (address != null && process != null) // sync is available
            {
                if (dataTypeBox.SelectedItem == dataTypeBox.Items[0]) // int
                    addressCurrentNum.Value = process.memory.ReadInt32(address);
                else if (dataTypeBox.SelectedItem == dataTypeBox.Items[1]) // string
                    addressNewBox.Text = process.memory.ReadStringASCII(address, 0);
            }
        }

        // Address -> Attach
        private void attachMenuItem_Click(object sender, EventArgs e)
        {
            if (process != null)
                process.Attach();
            else
                MessageBox.Show("No process specified for attaching to.");
        }

        // Overlay Settings
        private void toolbarOverlayButton_Click(object sender, EventArgs e)
        {
            if (overlaySettings != null && !overlaySettings.IsDisposed) // hasn't been closed yet, just unfocused
                overlaySettings.Show();
            else // the form had been closed, reopen it
            {
                if (process != null)
                {
                    overlaySettings = new OverlaySettings(process);
                    overlaySettings.Show();
                }
                else
                {
                    MessageBox.Show("You must specify a window title for the target process before you can draw an overlay.");
                }
            }
        }
    }
}
