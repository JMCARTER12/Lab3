namespace LAB_3
{
    partial class LAB3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LAB3));
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.RadiusOutput = new System.Windows.Forms.TextBox();
            this.DiameterLabel = new System.Windows.Forms.Label();
            this.DiameterOutput = new System.Windows.Forms.Label();
            this.SurfaceAreaLabel = new System.Windows.Forms.Label();
            this.SurfaceAreaOutput = new System.Windows.Forms.Label();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.VolumeOutput = new System.Windows.Forms.Label();
            this.Sphere2 = new System.Windows.Forms.PictureBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.Sphere1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Sphere2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sphere1)).BeginInit();
            this.SuspendLayout();
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(146, 26);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(90, 13);
            this.RadiusLabel.TabIndex = 0;
            this.RadiusLabel.Text = "Radius of sphere:";
            this.RadiusLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RadiusOutput
            // 
            this.RadiusOutput.Location = new System.Drawing.Point(248, 23);
            this.RadiusOutput.Name = "RadiusOutput";
            this.RadiusOutput.Size = new System.Drawing.Size(100, 20);
            this.RadiusOutput.TabIndex = 1;
            // 
            // DiameterLabel
            // 
            this.DiameterLabel.AutoSize = true;
            this.DiameterLabel.Location = new System.Drawing.Point(12, 174);
            this.DiameterLabel.Name = "DiameterLabel";
            this.DiameterLabel.Size = new System.Drawing.Size(49, 13);
            this.DiameterLabel.TabIndex = 2;
            this.DiameterLabel.Text = "Diameter";
            // 
            // DiameterOutput
            // 
            this.DiameterOutput.BackColor = System.Drawing.SystemColors.Menu;
            this.DiameterOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DiameterOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DiameterOutput.Location = new System.Drawing.Point(99, 173);
            this.DiameterOutput.Name = "DiameterOutput";
            this.DiameterOutput.Size = new System.Drawing.Size(86, 23);
            this.DiameterOutput.TabIndex = 3;
            this.DiameterOutput.Click += new System.EventHandler(this.DiameterOutput_Click);
            // 
            // SurfaceAreaLabel
            // 
            this.SurfaceAreaLabel.AutoSize = true;
            this.SurfaceAreaLabel.Location = new System.Drawing.Point(12, 226);
            this.SurfaceAreaLabel.Name = "SurfaceAreaLabel";
            this.SurfaceAreaLabel.Size = new System.Drawing.Size(69, 13);
            this.SurfaceAreaLabel.TabIndex = 4;
            this.SurfaceAreaLabel.Text = "Surface Area";
            // 
            // SurfaceAreaOutput
            // 
            this.SurfaceAreaOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SurfaceAreaOutput.Location = new System.Drawing.Point(99, 225);
            this.SurfaceAreaOutput.Name = "SurfaceAreaOutput";
            this.SurfaceAreaOutput.Size = new System.Drawing.Size(86, 23);
            this.SurfaceAreaOutput.TabIndex = 5;
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(12, 277);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(42, 13);
            this.VolumeLabel.TabIndex = 6;
            this.VolumeLabel.Text = "Volume";
            // 
            // VolumeOutput
            // 
            this.VolumeOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VolumeOutput.Location = new System.Drawing.Point(99, 276);
            this.VolumeOutput.Name = "VolumeOutput";
            this.VolumeOutput.Size = new System.Drawing.Size(86, 24);
            this.VolumeOutput.TabIndex = 7;
            // 
            // Sphere2
            // 
            this.Sphere2.BackColor = System.Drawing.SystemColors.Menu;
            this.Sphere2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sphere2.BackgroundImage")));
            this.Sphere2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sphere2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sphere2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Sphere2.ErrorImage")));
            this.Sphere2.Location = new System.Drawing.Point(231, 173);
            this.Sphere2.Name = "Sphere2";
            this.Sphere2.Size = new System.Drawing.Size(141, 139);
            this.Sphere2.TabIndex = 8;
            this.Sphere2.TabStop = false;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(248, 70);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(100, 24);
            this.CalcButton.TabIndex = 9;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // Sphere1
            // 
            this.Sphere1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sphere1.BackgroundImage")));
            this.Sphere1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sphere1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sphere1.Location = new System.Drawing.Point(15, 23);
            this.Sphere1.Name = "Sphere1";
            this.Sphere1.Size = new System.Drawing.Size(131, 126);
            this.Sphere1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Sphere1.TabIndex = 10;
            this.Sphere1.TabStop = false;
            // 
            // LAB3
            // 
            this.AcceptButton = this.CalcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.Sphere1);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.Sphere2);
            this.Controls.Add(this.VolumeOutput);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.SurfaceAreaOutput);
            this.Controls.Add(this.SurfaceAreaLabel);
            this.Controls.Add(this.DiameterOutput);
            this.Controls.Add(this.DiameterLabel);
            this.Controls.Add(this.RadiusOutput);
            this.Controls.Add(this.RadiusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LAB3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LAB3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sphere2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sphere1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.TextBox RadiusOutput;
        private System.Windows.Forms.Label DiameterLabel;
        private System.Windows.Forms.Label DiameterOutput;
        private System.Windows.Forms.Label SurfaceAreaLabel;
        private System.Windows.Forms.Label SurfaceAreaOutput;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Label VolumeOutput;
        private System.Windows.Forms.PictureBox Sphere2;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.PictureBox Sphere1;
    }
}

