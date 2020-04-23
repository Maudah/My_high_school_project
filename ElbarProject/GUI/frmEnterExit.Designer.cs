namespace ElbarProject.GUI
{
    partial class frmEnterExit
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
            this.txtId = new ElbarProject.NumberTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new ElbarProject.Resources.MyButton();
            this.btnEnter = new ElbarProject.Resources.MyButton();
            this.btnExite = new ElbarProject.Resources.MyButton();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(157, 149);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(185, 26);
            this.txtId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "הקש ת.ז ";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOk.Location = new System.Drawing.Point(177, 201);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(271, 52);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "אישור";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEnter.Enabled = false;
            this.btnEnter.Location = new System.Drawing.Point(391, 308);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(129, 95);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "כניסה";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnExite
            // 
            this.btnExite.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExite.Enabled = false;
            this.btnExite.Location = new System.Drawing.Point(135, 308);
            this.btnExite.Name = "btnExite";
            this.btnExite.Size = new System.Drawing.Size(129, 95);
            this.btnExite.TabIndex = 3;
            this.btnExite.Text = "יציאה";
            this.btnExite.UseVisualStyleBackColor = false;
            this.btnExite.Click += new System.EventHandler(this.btnExite_Click);
            // 
            // frmEnterExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(618, 597);
            this.Controls.Add(this.btnExite);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmEnterExit";
            this.Text = "frmEnterExit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumberTextBox txtId;
        private System.Windows.Forms.Label label1;
        private Resources.MyButton btnOk;
        private Resources.MyButton btnEnter;
        private Resources.MyButton btnExite;
    }
}