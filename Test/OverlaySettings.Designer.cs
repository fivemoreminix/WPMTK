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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverlaySettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.borderlessBox = new System.Windows.Forms.CheckBox();
            this.showBox = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.coordinatesStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.posShapeFour = new System.Windows.Forms.Label();
            this.posShapeThree = new System.Windows.Forms.Label();
            this.posShapeTwo = new System.Windows.Forms.Label();
            this.posShapeOne = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.filledCircleCheck = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.outlinedCircleCheck = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.filledBoxCheck = new System.Windows.Forms.CheckBox();
            this.outlinedBoxCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.borderlessBox);
            this.groupBox1.Controls.Add(this.showBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // borderlessBox
            // 
            this.borderlessBox.AutoSize = true;
            this.borderlessBox.Enabled = false;
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coordinatesStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 194);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(384, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // coordinatesStatus
            // 
            this.coordinatesStatus.Name = "coordinatesStatus";
            this.coordinatesStatus.Size = new System.Drawing.Size(402, 15);
            this.coordinatesStatus.Text = "Overlay not active - check \"show\" box, and select some shapes to enable it.";
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.posShapeFour);
            this.groupBox2.Controls.Add(this.posShapeThree);
            this.groupBox2.Controls.Add(this.posShapeTwo);
            this.groupBox2.Controls.Add(this.posShapeOne);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.filledCircleCheck);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.outlinedCircleCheck);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.filledBoxCheck);
            this.groupBox2.Controls.Add(this.outlinedBoxCheck);
            this.groupBox2.Location = new System.Drawing.Point(159, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 178);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Draw Random Shapes";
            // 
            // posShapeFour
            // 
            this.posShapeFour.AutoSize = true;
            this.posShapeFour.Location = new System.Drawing.Point(67, 133);
            this.posShapeFour.Name = "posShapeFour";
            this.posShapeFour.Size = new System.Drawing.Size(29, 13);
            this.posShapeFour.TabIndex = 12;
            this.posShapeFour.Text = "POS";
            // 
            // posShapeThree
            // 
            this.posShapeThree.AutoSize = true;
            this.posShapeThree.Location = new System.Drawing.Point(67, 95);
            this.posShapeThree.Name = "posShapeThree";
            this.posShapeThree.Size = new System.Drawing.Size(29, 13);
            this.posShapeThree.TabIndex = 11;
            this.posShapeThree.Text = "POS";
            // 
            // posShapeTwo
            // 
            this.posShapeTwo.AutoSize = true;
            this.posShapeTwo.Location = new System.Drawing.Point(67, 57);
            this.posShapeTwo.Name = "posShapeTwo";
            this.posShapeTwo.Size = new System.Drawing.Size(29, 13);
            this.posShapeTwo.TabIndex = 10;
            this.posShapeTwo.Text = "POS";
            // 
            // posShapeOne
            // 
            this.posShapeOne.AutoSize = true;
            this.posShapeOne.Location = new System.Drawing.Point(67, 19);
            this.posShapeOne.Name = "posShapeOne";
            this.posShapeOne.Size = new System.Drawing.Size(29, 13);
            this.posShapeOne.TabIndex = 9;
            this.posShapeOne.Text = "POS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Test.Properties.Resources.RedCircleFilled;
            this.pictureBox4.Location = new System.Drawing.Point(28, 133);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // filledCircleCheck
            // 
            this.filledCircleCheck.AutoSize = true;
            this.filledCircleCheck.Location = new System.Drawing.Point(7, 141);
            this.filledCircleCheck.Name = "filledCircleCheck";
            this.filledCircleCheck.Size = new System.Drawing.Size(15, 14);
            this.filledCircleCheck.TabIndex = 6;
            this.filledCircleCheck.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Test.Properties.Resources.RedCircleOutlined;
            this.pictureBox3.Location = new System.Drawing.Point(28, 95);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // outlinedCircleCheck
            // 
            this.outlinedCircleCheck.AutoSize = true;
            this.outlinedCircleCheck.Location = new System.Drawing.Point(7, 103);
            this.outlinedCircleCheck.Name = "outlinedCircleCheck";
            this.outlinedCircleCheck.Size = new System.Drawing.Size(15, 14);
            this.outlinedCircleCheck.TabIndex = 4;
            this.outlinedCircleCheck.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Test.Properties.Resources.RedBoxFilled;
            this.pictureBox2.Location = new System.Drawing.Point(28, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // filledBoxCheck
            // 
            this.filledBoxCheck.AutoSize = true;
            this.filledBoxCheck.Location = new System.Drawing.Point(7, 65);
            this.filledBoxCheck.Name = "filledBoxCheck";
            this.filledBoxCheck.Size = new System.Drawing.Size(15, 14);
            this.filledBoxCheck.TabIndex = 2;
            this.filledBoxCheck.UseVisualStyleBackColor = true;
            this.filledBoxCheck.CheckedChanged += new System.EventHandler(this.filledBoxCheck_CheckedChanged);
            // 
            // outlinedBoxCheck
            // 
            this.outlinedBoxCheck.AutoSize = true;
            this.outlinedBoxCheck.Location = new System.Drawing.Point(7, 27);
            this.outlinedBoxCheck.Name = "outlinedBoxCheck";
            this.outlinedBoxCheck.Size = new System.Drawing.Size(15, 14);
            this.outlinedBoxCheck.TabIndex = 0;
            this.outlinedBoxCheck.UseVisualStyleBackColor = true;
            this.outlinedBoxCheck.CheckedChanged += new System.EventHandler(this.outlinedBoxCheck_CheckedChanged);
            // 
            // OverlaySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 216);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "OverlaySettings";
            this.Text = "Overlay Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox borderlessBox;
        private System.Windows.Forms.CheckBox showBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel coordinatesStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox outlinedBoxCheck;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox filledCircleCheck;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox outlinedCircleCheck;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox filledBoxCheck;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label posShapeFour;
        private System.Windows.Forms.Label posShapeThree;
        private System.Windows.Forms.Label posShapeTwo;
        private System.Windows.Forms.Label posShapeOne;
    }
}