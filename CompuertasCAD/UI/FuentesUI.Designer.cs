namespace AutoCADAPI.Lab3.UI
{
    partial class FuentesUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuentesUI));
            this.VCC = new System.Windows.Forms.Button();
            this.GND = new System.Windows.Forms.Button();
            this.Random = new System.Windows.Forms.Button();
            this.FalseStart = new System.Windows.Forms.Button();
            this.TrueStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VCC
            // 
            this.VCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VCC.Image = ((System.Drawing.Image)(resources.GetObject("VCC.Image")));
            this.VCC.Location = new System.Drawing.Point(12, 23);
            this.VCC.Name = "VCC";
            this.VCC.Size = new System.Drawing.Size(101, 171);
            this.VCC.TabIndex = 0;
            this.VCC.UseVisualStyleBackColor = true;
            // 
            // GND
            // 
            this.GND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GND.Image = ((System.Drawing.Image)(resources.GetObject("GND.Image")));
            this.GND.Location = new System.Drawing.Point(119, 23);
            this.GND.Name = "GND";
            this.GND.Size = new System.Drawing.Size(100, 171);
            this.GND.TabIndex = 1;
            this.GND.UseVisualStyleBackColor = true;
            // 
            // Random
            // 
            this.Random.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Random.Image = ((System.Drawing.Image)(resources.GetObject("Random.Image")));
            this.Random.Location = new System.Drawing.Point(12, 200);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(207, 72);
            this.Random.TabIndex = 2;
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Pulso_Click);
            // 
            // FalseStart
            // 
            this.FalseStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FalseStart.Image = ((System.Drawing.Image)(resources.GetObject("FalseStart.Image")));
            this.FalseStart.Location = new System.Drawing.Point(12, 278);
            this.FalseStart.Name = "FalseStart";
            this.FalseStart.Size = new System.Drawing.Size(207, 72);
            this.FalseStart.TabIndex = 3;
            this.FalseStart.UseVisualStyleBackColor = true;
            this.FalseStart.Click += new System.EventHandler(this.Pulso_Click);
            // 
            // TrueStart
            // 
            this.TrueStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TrueStart.Image = ((System.Drawing.Image)(resources.GetObject("TrueStart.Image")));
            this.TrueStart.Location = new System.Drawing.Point(12, 356);
            this.TrueStart.Name = "TrueStart";
            this.TrueStart.Size = new System.Drawing.Size(207, 72);
            this.TrueStart.TabIndex = 4;
            this.TrueStart.UseVisualStyleBackColor = true;
            this.TrueStart.Click += new System.EventHandler(this.Pulso_Click);
            // 
            // FuentesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TrueStart);
            this.Controls.Add(this.FalseStart);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.GND);
            this.Controls.Add(this.VCC);
            this.Name = "FuentesUI";
            this.Size = new System.Drawing.Size(263, 488);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VCC;
        private System.Windows.Forms.Button GND;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.Button FalseStart;
        private System.Windows.Forms.Button TrueStart;
    }
}
