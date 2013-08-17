namespace BeamerMeister
{
    partial class BeamerMeister
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
            this.buttonHDMI1 = new System.Windows.Forms.Button();
            this.buttonHDMI2 = new System.Windows.Forms.Button();
            this.buttonSVideo = new System.Windows.Forms.Button();
            this.buttonComponent = new System.Windows.Forms.Button();
            this.buttonVGA = new System.Windows.Forms.Button();
            this.numericUpDownBrightness = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownContrast = new System.Windows.Forms.NumericUpDown();
            this.labelContrast = new System.Windows.Forms.Label();
            this.labelBrightness = new System.Windows.Forms.Label();
            this.buttonPowerOff = new System.Windows.Forms.Button();
            this.buttonTurnOn = new System.Windows.Forms.Button();
            this.buttonComposite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContrast)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHDMI1
            // 
            this.buttonHDMI1.Location = new System.Drawing.Point(12, 12);
            this.buttonHDMI1.Name = "buttonHDMI1";
            this.buttonHDMI1.Size = new System.Drawing.Size(75, 23);
            this.buttonHDMI1.TabIndex = 2;
            this.buttonHDMI1.Text = "HDMI1";
            this.buttonHDMI1.UseVisualStyleBackColor = true;
            this.buttonHDMI1.Click += new System.EventHandler(this.buttonHDMI1_Click);
            // 
            // buttonHDMI2
            // 
            this.buttonHDMI2.Location = new System.Drawing.Point(12, 41);
            this.buttonHDMI2.Name = "buttonHDMI2";
            this.buttonHDMI2.Size = new System.Drawing.Size(75, 23);
            this.buttonHDMI2.TabIndex = 3;
            this.buttonHDMI2.Text = "HDMI2";
            this.buttonHDMI2.UseVisualStyleBackColor = true;
            // 
            // buttonSVideo
            // 
            this.buttonSVideo.Location = new System.Drawing.Point(12, 70);
            this.buttonSVideo.Name = "buttonSVideo";
            this.buttonSVideo.Size = new System.Drawing.Size(75, 23);
            this.buttonSVideo.TabIndex = 4;
            this.buttonSVideo.Text = "S-Video";
            this.buttonSVideo.UseVisualStyleBackColor = true;
            // 
            // buttonComponent
            // 
            this.buttonComponent.Location = new System.Drawing.Point(12, 128);
            this.buttonComponent.Name = "buttonComponent";
            this.buttonComponent.Size = new System.Drawing.Size(75, 23);
            this.buttonComponent.TabIndex = 5;
            this.buttonComponent.Text = "Component";
            this.buttonComponent.UseVisualStyleBackColor = true;
            // 
            // buttonVGA
            // 
            this.buttonVGA.Location = new System.Drawing.Point(12, 157);
            this.buttonVGA.Name = "buttonVGA";
            this.buttonVGA.Size = new System.Drawing.Size(75, 23);
            this.buttonVGA.TabIndex = 6;
            this.buttonVGA.Text = "VGA";
            this.buttonVGA.UseVisualStyleBackColor = true;
            // 
            // numericUpDownBrightness
            // 
            this.numericUpDownBrightness.Location = new System.Drawing.Point(201, 109);
            this.numericUpDownBrightness.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBrightness.Name = "numericUpDownBrightness";
            this.numericUpDownBrightness.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownBrightness.TabIndex = 7;
            // 
            // numericUpDownContrast
            // 
            this.numericUpDownContrast.Location = new System.Drawing.Point(201, 135);
            this.numericUpDownContrast.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownContrast.Name = "numericUpDownContrast";
            this.numericUpDownContrast.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownContrast.TabIndex = 8;
            // 
            // labelContrast
            // 
            this.labelContrast.AutoSize = true;
            this.labelContrast.Location = new System.Drawing.Point(149, 112);
            this.labelContrast.Name = "labelContrast";
            this.labelContrast.Size = new System.Drawing.Size(46, 13);
            this.labelContrast.TabIndex = 9;
            this.labelContrast.Text = "Contrast";
            // 
            // labelBrightness
            // 
            this.labelBrightness.AutoSize = true;
            this.labelBrightness.Location = new System.Drawing.Point(139, 137);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(56, 13);
            this.labelBrightness.TabIndex = 10;
            this.labelBrightness.Text = "Brightness";
            // 
            // buttonPowerOff
            // 
            this.buttonPowerOff.Location = new System.Drawing.Point(197, 41);
            this.buttonPowerOff.Name = "buttonPowerOff";
            this.buttonPowerOff.Size = new System.Drawing.Size(75, 23);
            this.buttonPowerOff.TabIndex = 11;
            this.buttonPowerOff.Text = "Power Off";
            this.buttonPowerOff.UseVisualStyleBackColor = true;
            // 
            // buttonTurnOn
            // 
            this.buttonTurnOn.Location = new System.Drawing.Point(197, 12);
            this.buttonTurnOn.Name = "buttonTurnOn";
            this.buttonTurnOn.Size = new System.Drawing.Size(75, 23);
            this.buttonTurnOn.TabIndex = 12;
            this.buttonTurnOn.Text = "Power On";
            this.buttonTurnOn.UseVisualStyleBackColor = true;
            // 
            // buttonComposite
            // 
            this.buttonComposite.Location = new System.Drawing.Point(12, 99);
            this.buttonComposite.Name = "buttonComposite";
            this.buttonComposite.Size = new System.Drawing.Size(75, 23);
            this.buttonComposite.TabIndex = 13;
            this.buttonComposite.Text = "Composite";
            this.buttonComposite.UseVisualStyleBackColor = true;
            // 
            // BeamerMeister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 209);
            this.Controls.Add(this.buttonComposite);
            this.Controls.Add(this.buttonTurnOn);
            this.Controls.Add(this.buttonPowerOff);
            this.Controls.Add(this.labelBrightness);
            this.Controls.Add(this.labelContrast);
            this.Controls.Add(this.numericUpDownContrast);
            this.Controls.Add(this.numericUpDownBrightness);
            this.Controls.Add(this.buttonVGA);
            this.Controls.Add(this.buttonComponent);
            this.Controls.Add(this.buttonSVideo);
            this.Controls.Add(this.buttonHDMI2);
            this.Controls.Add(this.buttonHDMI1);
            this.Name = "BeamerMeister";
            this.Text = "BeamerMeister";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContrast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHDMI1;
        private System.Windows.Forms.Button buttonHDMI2;
        private System.Windows.Forms.Button buttonSVideo;
        private System.Windows.Forms.Button buttonComponent;
        private System.Windows.Forms.Button buttonVGA;
        private System.Windows.Forms.NumericUpDown numericUpDownBrightness;
        private System.Windows.Forms.NumericUpDown numericUpDownContrast;
        private System.Windows.Forms.Label labelContrast;
        private System.Windows.Forms.Label labelBrightness;
        private System.Windows.Forms.Button buttonPowerOff;
        private System.Windows.Forms.Button buttonTurnOn;
        private System.Windows.Forms.Button buttonComposite;
    }
}

