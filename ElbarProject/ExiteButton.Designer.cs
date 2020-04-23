namespace ElbarProject
{
    partial class ExiteButton
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
            this.btnExite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExite
            // 
            this.btnExite.BackgroundImage = global::ElbarProject.Properties.Resources.M1tmban0;
            this.btnExite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExite.Font = new System.Drawing.Font("Ahla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnExite.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExite.Location = new System.Drawing.Point(0, 0);
            this.btnExite.Name = "btnExite";
            this.btnExite.Size = new System.Drawing.Size(152, 56);
            this.btnExite.TabIndex = 0;
            this.btnExite.Text = "יציאה";
            this.btnExite.UseVisualStyleBackColor = true;
            this.btnExite.Click += new System.EventHandler(this.btnExite_Click);
            // 
            // ExiteButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExite);
            this.Name = "ExiteButton";
            this.Size = new System.Drawing.Size(153, 57);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExite;
    }
}
