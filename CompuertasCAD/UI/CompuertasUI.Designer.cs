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
            this.SuspendLayout();
            // 
            // OR
            // 
            this.OR.Image = ((System.Drawing.Image)(resources.GetObject("OR.Image")));
            this.OR.Location = new System.Drawing.Point(19, 27);
            this.OR.Name = "OR";
            this.OR.Size = new System.Drawing.Size(222, 75);
            this.OR.TabIndex = 0;
            this.OR.Text = "button1";
            this.OR.UseVisualStyleBackColor = true;
            this.OR.Click += new System.EventHandler(this.button1_Click);
            // 
            // AND
            // 
            this.AND.Image = ((System.Drawing.Image)(resources.GetObject("AND.Image")));
            this.AND.Location = new System.Drawing.Point(19, 121);
            this.AND.Name = "AND";
            this.AND.Size = new System.Drawing.Size(222, 82);
            this.AND.TabIndex = 1;
            this.AND.Text = "button1";
            this.AND.UseVisualStyleBackColor = true;
            this.AND.Click += new System.EventHandler(this.button1_Click);
            // 
            // CompuertasUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AND);
            this.Controls.Add(this.OR);
            this.Name = "CompuertasUI";
            this.Size = new System.Drawing.Size(275, 438);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OR;
        private System.Windows.Forms.Button AND;
    }
}
