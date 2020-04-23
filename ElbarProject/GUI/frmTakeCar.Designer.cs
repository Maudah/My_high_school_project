namespace ElbarProject.GUI
{
    partial class frmTakeCar
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtnumTake = new ElbarProject.NumberTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFName = new ElbarProject.HebrewTextBox();
            this.txtName = new ElbarProject.HebrewTextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.btnok = new ElbarProject.Resources.MyButton();
            this.btnEnter = new ElbarProject.Resources.MyButton();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblMessage.Font = new System.Drawing.Font("Ahla", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMessage.Location = new System.Drawing.Point(253, 69);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMessage.Size = new System.Drawing.Size(217, 32);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "         לקיחת רכב";
            // 
            // txtnumTake
            // 
            this.txtnumTake.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtnumTake.Location = new System.Drawing.Point(149, 142);
            this.txtnumTake.Name = "txtnumTake";
            this.txtnumTake.Size = new System.Drawing.Size(160, 26);
            this.txtnumTake.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(316, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "מס\' השכרה";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(149, 244);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(160, 26);
            this.txtFName.TabIndex = 35;
            this.txtFName.Text = " ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 212);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 26);
            this.txtName.TabIndex = 34;
            this.txtName.Text = " ";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(316, 243);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(93, 19);
            this.label33.TabIndex = 33;
            this.label33.Text = "שם משפחה";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(316, 211);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(72, 19);
            this.label34.TabIndex = 32;
            this.label34.Text = "שם פרטי";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(149, 178);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(161, 26);
            this.txtId.TabIndex = 31;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(316, 182);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(75, 19);
            this.label35.TabIndex = 30;
            this.label35.Text = "ת.ז לקוח";
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnok.Location = new System.Drawing.Point(209, 308);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(140, 41);
            this.btnok.TabIndex = 36;
            this.btnok.Text = "אישור";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEnter.Location = new System.Drawing.Point(77, 176);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(66, 31);
            this.btnEnter.TabIndex = 37;
            this.btnEnter.Text = "הכנס";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // frmTakeCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(467, 512);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.txtnumTake);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmTakeCar";
            this.Text = "frmTakeCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private NumberTextBox txtnumTake;
        private System.Windows.Forms.Label label7;
        private HebrewTextBox txtFName;
        private HebrewTextBox txtName;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label35;
        private Resources.MyButton btnok;
        private Resources.MyButton btnEnter;
    }
}