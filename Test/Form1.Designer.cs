namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.addressNewSet = new System.Windows.Forms.Button();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addressSet = new System.Windows.Forms.Button();
            this.addressCurrentNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addressNewBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.processBox = new System.Windows.Forms.ComboBox();
            this.processTitleInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataTypeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolbarOverlayButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusPID = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusPName = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProcessMemory = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressCurrentNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(5, 116);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1215752191,
            23,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "value to set to";
            this.label1.Visible = false;
            // 
            // addressNewSet
            // 
            this.addressNewSet.Location = new System.Drawing.Point(131, 113);
            this.addressNewSet.Name = "addressNewSet";
            this.addressNewSet.Size = new System.Drawing.Size(37, 23);
            this.addressNewSet.TabIndex = 2;
            this.addressNewSet.Text = "set";
            this.addressNewSet.UseVisualStyleBackColor = true;
            this.addressNewSet.Click += new System.EventHandler(this.button1_Click);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(6, 35);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(120, 20);
            this.addressBox.TabIndex = 3;
            this.addressBox.Text = "0x00000000";
            this.addressBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addressBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "address for manipulation";
            // 
            // addressSet
            // 
            this.addressSet.Enabled = false;
            this.addressSet.Location = new System.Drawing.Point(132, 33);
            this.addressSet.Name = "addressSet";
            this.addressSet.Size = new System.Drawing.Size(35, 23);
            this.addressSet.TabIndex = 5;
            this.addressSet.Text = "set";
            this.addressSet.UseVisualStyleBackColor = true;
            this.addressSet.Click += new System.EventHandler(this.button2_Click);
            // 
            // addressCurrentNum
            // 
            this.addressCurrentNum.Location = new System.Drawing.Point(6, 74);
            this.addressCurrentNum.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.addressCurrentNum.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.addressCurrentNum.Name = "addressCurrentNum";
            this.addressCurrentNum.ReadOnly = true;
            this.addressCurrentNum.Size = new System.Drawing.Size(120, 20);
            this.addressCurrentNum.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "current value at address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addressNewBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addressNewSet);
            this.groupBox1.Controls.Add(this.addressBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.addressCurrentNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.addressSet);
            this.groupBox1.Location = new System.Drawing.Point(181, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 147);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // addressNewBox
            // 
            this.addressNewBox.Location = new System.Drawing.Point(5, 116);
            this.addressNewBox.Name = "addressNewBox";
            this.addressNewBox.Size = new System.Drawing.Size(120, 20);
            this.addressNewBox.TabIndex = 12;
            this.addressNewBox.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.processBox);
            this.groupBox2.Controls.Add(this.processTitleInfo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dataTypeBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 147);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuration";
            // 
            // processBox
            // 
            this.processBox.FormattingEnabled = true;
            this.processBox.Location = new System.Drawing.Point(6, 35);
            this.processBox.Name = "processBox";
            this.processBox.Size = new System.Drawing.Size(151, 21);
            this.processBox.TabIndex = 13;
            this.processBox.DropDown += new System.EventHandler(this.processBox_DropDown);
            this.processBox.SelectedIndexChanged += new System.EventHandler(this.processBox_SelectedIndexChanged);
            // 
            // processTitleInfo
            // 
            this.processTitleInfo.AutoSize = true;
            this.processTitleInfo.BackColor = System.Drawing.SystemColors.Control;
            this.processTitleInfo.ForeColor = System.Drawing.Color.Red;
            this.processTitleInfo.Location = new System.Drawing.Point(6, 59);
            this.processTitleInfo.Name = "processTitleInfo";
            this.processTitleInfo.Size = new System.Drawing.Size(128, 26);
            this.processTitleInfo.TabIndex = 12;
            this.processTitleInfo.Text = "Select the process before\r\ndoing anything.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "data type at address";
            // 
            // dataTypeBox
            // 
            this.dataTypeBox.FormattingEnabled = true;
            this.dataTypeBox.Items.AddRange(new object[] {
            "integer",
            "string"});
            this.dataTypeBox.Location = new System.Drawing.Point(6, 116);
            this.dataTypeBox.Name = "dataTypeBox";
            this.dataTypeBox.Size = new System.Drawing.Size(151, 21);
            this.dataTypeBox.TabIndex = 10;
            this.dataTypeBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "process";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarOverlayButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(369, 22);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolbarOverlayButton
            // 
            this.toolbarOverlayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbarOverlayButton.Image = ((System.Drawing.Image)(resources.GetObject("toolbarOverlayButton.Image")));
            this.toolbarOverlayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarOverlayButton.Name = "toolbarOverlayButton";
            this.toolbarOverlayButton.Size = new System.Drawing.Size(96, 19);
            this.toolbarOverlayButton.Text = "Overlay Settings";
            this.toolbarOverlayButton.Click += new System.EventHandler(this.toolbarOverlayButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusPID,
            this.statusPName,
            this.statusProcessMemory});
            this.statusStrip1.Location = new System.Drawing.Point(0, 184);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(369, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusPID
            // 
            this.statusPID.Name = "statusPID";
            this.statusPID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.statusPID.Size = new System.Drawing.Size(51, 17);
            this.statusPID.Text = "procId";
            // 
            // statusPName
            // 
            this.statusPName.Name = "statusPName";
            this.statusPName.Size = new System.Drawing.Size(227, 17);
            this.statusPName.Spring = true;
            this.statusPName.Text = "procName";
            // 
            // statusProcessMemory
            // 
            this.statusProcessMemory.Name = "statusProcessMemory";
            this.statusProcessMemory.Size = new System.Drawing.Size(76, 17);
            this.statusProcessMemory.Text = "procMemory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 206);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "WPMTK Test Trainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressCurrentNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addressNewSet;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addressSet;
        private System.Windows.Forms.NumericUpDown addressCurrentNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressNewBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox dataTypeBox;
        private System.Windows.Forms.Label processTitleInfo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolbarOverlayButton;
        private System.Windows.Forms.ComboBox processBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusPID;
        private System.Windows.Forms.ToolStripStatusLabel statusPName;
        private System.Windows.Forms.ToolStripStatusLabel statusProcessMemory;
    }
}

