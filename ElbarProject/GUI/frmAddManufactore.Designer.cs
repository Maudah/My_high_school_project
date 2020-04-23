namespace ElbarProject.GUI
{
    partial class frmAddManufactore
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
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(158, 85);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(126, 20);
            this.txtc.TabIndex = 0;
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(158, 133);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(126, 20);
            this.txtn.TabIndex = 0;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(192, 200);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(72, 49);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "button1";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // frmAddManufactore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 413);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.txtc);
            this.Name = "frmAddManufactore";
            this.Text = "frmAddManufactore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Button btnok;
    }
}