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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showBox = new System.Windows.Forms.CheckBox();
            this.borderlessBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.borderlessBox);
            this.groupBox1.Controls.Add(this.showBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
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
            // OverlaySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 149);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "OverlaySettings";
            this.Text = "Overlay Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox borderlessBox;
        private System.Windows.Forms.CheckBox showBox;
    }
}