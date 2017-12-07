namespace AutoCADAPI.Lab3.UI
{
    partial class CompuertasUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompuertasUI));
            this.OR = new System.Windows.Forms.Button();
            this.AND = new System.Windows.Forms.Button();
            this.NOR = new System.Windows.Forms.Button();
            this.NAND = new System.Windows.Forms.Button();
            this.XOR = new System.Windows.Forms.Button();
            this.XNOR = new System.Windows.Forms.Button();
            this.NOT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OR
            // 
            this.OR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OR.Image = ((System.Drawing.Image)(resources.GetObject("OR.Image")));
            this.OR.Location = new System.Drawing.Point(19, 27);
            this.OR.Name = "OR";
            this.OR.Size = new System.Drawing.Size(172, 105);
            this.OR.TabIndex = 0;
            this.OR.UseVisualStyleBackColor = true;
            this.OR.Click += new System.EventHandler(this.button1_Click);
            // 
            // AND
            // 
            this.AND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AND.Image = ((System.Drawing.Image)(resources.GetObject("AND.Image")));
            this.AND.Location = new System.Drawing.Point(19, 138);
            this.AND.Name = "AND";
            this.AND.Size = new System.Drawing.Size(172, 105);
            this.AND.TabIndex = 1;
            this.AND.UseVisualStyleBackColor = true;
            this.AND.Click += new System.EventHandler(this.button1_Click);
            // 
            // NOR
            // 
            this.NOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NOR.Image = ((System.Drawing.Image)(resources.GetObject("NOR.Image")));
            this.NOR.Location = new System.Drawing.Point(19, 249);
            this.NOR.Name = "NOR";
            this.NOR.Size = new System.Drawing.Size(172, 105);
            this.NOR.TabIndex = 2;
            this.NOR.UseVisualStyleBackColor = true;
            this.NOR.Click += new System.EventHandler(this.button1_Click);
            // 
            // NAND
            // 
            this.NAND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAND.Image = ((System.Drawing.Image)(resources.GetObject("NAND.Image")));
            this.NAND.Location = new System.Drawing.Point(19, 360);
            this.NAND.Name = "NAND";
            this.NAND.Size = new System.Drawing.Size(172, 105);
            this.NAND.TabIndex = 3;
            this.NAND.UseVisualStyleBackColor = true;
            this.NAND.Click += new System.EventHandler(this.button1_Click);
            // 
            // XOR
            // 
            this.XOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.XOR.Image = ((System.Drawing.Image)(resources.GetObject("XOR.Image")));
            this.XOR.Location = new System.Drawing.Point(19, 471);
            this.XOR.Name = "XOR";
            this.XOR.Size = new System.Drawing.Size(172, 105);
            this.XOR.TabIndex = 4;
            this.XOR.UseVisualStyleBackColor = true;
            this.XOR.Click += new System.EventHandler(this.button1_Click);
            // 
            // XNOR
            // 
            this.XNOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.XNOR.Image = ((System.Drawing.Image)(resources.GetObject("XNOR.Image")));
            this.XNOR.Location = new System.Drawing.Point(19, 693);
            this.XNOR.Name = "XNOR";
            this.XNOR.Size = new System.Drawing.Size(172, 105);
            this.XNOR.TabIndex = 5;
            this.XNOR.UseVisualStyleBackColor = true;
            this.XNOR.Click += new System.EventHandler(this.button1_Click);
            // 
            // NOT
            // 
            this.NOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NOT.Image = ((System.Drawing.Image)(resources.GetObject("NOT.Image")));
            this.NOT.Location = new System.Drawing.Point(19, 582);
            this.NOT.Name = "NOT";
            this.NOT.Size = new System.Drawing.Size(172, 105);
            this.NOT.TabIndex = 6;
            this.NOT.UseVisualStyleBackColor = true;
            this.NOT.Click += new System.EventHandler(this.button1_Click);
            // 
            // CompuertasUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NOT);
            this.Controls.Add(this.XNOR);
            this.Controls.Add(this.XOR);
            this.Controls.Add(this.NAND);
            this.Controls.Add(this.NOR);
            this.Controls.Add(this.AND);
            this.Controls.Add(this.OR);
            this.Name = "CompuertasUI";
            this.Size = new System.Drawing.Size(275, 750);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OR;
        private System.Windows.Forms.Button AND;
        private System.Windows.Forms.Button NOR;
        private System.Windows.Forms.Button NAND;
        private System.Windows.Forms.Button XOR;
        private System.Windows.Forms.Button XNOR;
        private System.Windows.Forms.Button NOT;
    }
}
