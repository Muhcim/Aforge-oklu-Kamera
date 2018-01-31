namespace AforgeÇokluCamera
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.sbGreenColor = new System.Windows.Forms.HScrollBar();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.sbRedColor = new System.Windows.Forms.HScrollBar();
            this.sbBlueColor = new System.Windows.Forms.HScrollBar();
            this.sbRadius = new System.Windows.Forms.HScrollBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sbThreshold = new System.Windows.Forms.HScrollBar();
            this.cbBlur = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CmbxCamera = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(12, 493);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 26);
            this.textBox1.TabIndex = 29;
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(5, 164);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(38, 17);
            this.rbGreen.TabIndex = 20;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Gri";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbGreen_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Yarı Çapı";
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(5, 125);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(48, 17);
            this.rbBlue.TabIndex = 20;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Mavi";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // sbGreenColor
            // 
            this.sbGreenColor.Location = new System.Drawing.Point(61, 157);
            this.sbGreenColor.Maximum = 255;
            this.sbGreenColor.Name = "sbGreenColor";
            this.sbGreenColor.Size = new System.Drawing.Size(125, 22);
            this.sbGreenColor.TabIndex = 17;
            this.sbGreenColor.Value = 30;
            this.sbGreenColor.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbGreenColor_Scroll);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Checked = true;
            this.rbRed.Location = new System.Drawing.Point(5, 88);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(54, 17);
            this.rbRed.TabIndex = 19;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Kırmızı";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // sbRedColor
            // 
            this.sbRedColor.Location = new System.Drawing.Point(61, 88);
            this.sbRedColor.Maximum = 255;
            this.sbRedColor.Name = "sbRedColor";
            this.sbRedColor.Size = new System.Drawing.Size(125, 22);
            this.sbRedColor.TabIndex = 17;
            this.sbRedColor.Value = 220;
            this.sbRedColor.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbRedColor_Scroll);
            // 
            // sbBlueColor
            // 
            this.sbBlueColor.Location = new System.Drawing.Point(61, 125);
            this.sbBlueColor.Maximum = 255;
            this.sbBlueColor.Name = "sbBlueColor";
            this.sbBlueColor.Size = new System.Drawing.Size(125, 22);
            this.sbBlueColor.TabIndex = 17;
            this.sbBlueColor.Value = 30;
            this.sbBlueColor.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbBlueColor_Scroll);
            // 
            // sbRadius
            // 
            this.sbRadius.Location = new System.Drawing.Point(61, 52);
            this.sbRadius.Maximum = 450;
            this.sbRadius.Name = "sbRadius";
            this.sbRadius.Size = new System.Drawing.Size(125, 22);
            this.sbRadius.TabIndex = 17;
            this.sbRadius.Value = 100;
            this.sbRadius.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbRadius_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGreen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbBlue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sbGreenColor);
            this.groupBox1.Controls.Add(this.rbRed);
            this.groupBox1.Controls.Add(this.sbRedColor);
            this.groupBox1.Controls.Add(this.sbBlueColor);
            this.groupBox1.Controls.Add(this.sbRadius);
            this.groupBox1.Controls.Add(this.sbThreshold);
            this.groupBox1.Location = new System.Drawing.Point(12, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 191);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayarlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Threshold";
            // 
            // sbThreshold
            // 
            this.sbThreshold.Location = new System.Drawing.Point(61, 18);
            this.sbThreshold.Maximum = 255;
            this.sbThreshold.Name = "sbThreshold";
            this.sbThreshold.Size = new System.Drawing.Size(125, 22);
            this.sbThreshold.TabIndex = 17;
            this.sbThreshold.Value = 40;
            this.sbThreshold.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbThreshold_Scroll);
            // 
            // cbBlur
            // 
            this.cbBlur.AutoSize = true;
            this.cbBlur.Location = new System.Drawing.Point(216, 5);
            this.cbBlur.Name = "cbBlur";
            this.cbBlur.Size = new System.Drawing.Size(59, 17);
            this.cbBlur.TabIndex = 27;
            this.cbBlur.Text = "Uygula";
            this.cbBlur.UseVisualStyleBackColor = true;
            this.cbBlur.CheckedChanged += new System.EventHandler(this.cbBlur_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(485, 296);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(275, 260);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(206, 296);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(275, 260);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(485, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 244);
            this.listBox1.TabIndex = 23;
            // 
            // CmbxCamera
            // 
            this.CmbxCamera.FormattingEnabled = true;
            this.CmbxCamera.Location = new System.Drawing.Point(12, 3);
            this.CmbxCamera.Name = "CmbxCamera";
            this.CmbxCamera.Size = new System.Drawing.Size(189, 21);
            this.CmbxCamera.TabIndex = 21;
            this.CmbxCamera.SelectedIndexChanged += new System.EventHandler(this.CmbxCamera_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(206, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 590);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbBlur);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CmbxCamera);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.HScrollBar sbGreenColor;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.HScrollBar sbRedColor;
        private System.Windows.Forms.HScrollBar sbBlueColor;
        private System.Windows.Forms.HScrollBar sbRadius;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar sbThreshold;
        private System.Windows.Forms.CheckBox cbBlur;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox CmbxCamera;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

