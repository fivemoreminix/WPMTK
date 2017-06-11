namespace Test
{
    partial class OverlaySettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.borderlessBox = new System.Windows.Forms.CheckBox();
            this.showBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.coordinatesStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.borderlessBox);
            this.groupBox1.Controls.Add(this.showBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // borderlessBox
            // 
            this.borderlessBox.AutoSize = true;
            this.borderlessBox.Location = new System.Drawing.Point(7, 43);
            this.borderlessBox.Name = "borderlessBox";
            this.borderlessBox.Size = new System.Drawing.Size(74, 17);
            this.borderlessBox.TabIndex = 1;
            this.borderlessBox.Text = "borderless";
            this.borderlessBox.UseVisualStyleBackColor = true;
            this.borderlessBox.CheckedChanged += new System.EventHandler(this.borderlessBox_CheckedChanged);
            // 
            // showBox
            // 
            this.showBox.AutoSize = true;
            this.showBox.Location = new System.Drawing.Point(7, 20);
            this.showBox.Name = "showBox";
            this.showBox.Size = new System.Drawing.Size(51, 17);
            this.showBox.TabIndex = 0;
            this.showBox.Text = "show";
            this.showBox.UseVisualStyleBackColor = true;
            this.showBox.CheckedChanged += new System.EventHandler(this.showBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(158, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shape Test";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coordinatesStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 153);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(340, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // coordinatesStatus
            // 
            this.coordinatesStatus.Name = "coordinatesStatus";
            this.coordinatesStatus.Size = new System.Drawing.Size(272, 17);
            this.coordinatesStatus.Text = "Overlay not active - check \"show\" box to enable it.";
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OverlaySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 175);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "OverlaySettings";
            this.Text = "Overlay Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox borderlessBox;
        private System.Windows.Forms.CheckBox showBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel coordinatesStatus;
        private System.Windows.Forms.Timer timer1;
    }
}