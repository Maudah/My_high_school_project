namespace ElbarProject.GUI
{
    partial class frmAddCreditCard
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
            this.components = new System.ComponentModel.Container();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtDateCard = new System.Windows.Forms.DateTimePicker();
            this.txtNumCard = new ElbarProject.NumberTextBox();
            this.txtCodeCard = new ElbarProject.NumberTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new ElbarProject.NumberTextBox();
            this.myButton1 = new ElbarProject.Resources.MyButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblMessage.Font = new System.Drawing.Font("Ahla", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMessage.Location = new System.Drawing.Point(360, 61);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMessage.Size = new System.Drawing.Size(318, 32);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "          הוספת כרטיס חדש";
            // 
            // txtDateCard
            // 
            this.txtDateCard.CustomFormat = "dd/MM/yyyy";
            this.txtDateCard.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtDateCard.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateCard.Location = new System.Drawing.Point(361, 270);
            this.txtDateCard.Name = "txtDateCard";
            this.txtDateCard.Size = new System.Drawing.Size(160, 26);
            this.txtDateCard.TabIndex = 37;
            // 
            // txtNumCard
            // 
            this.txtNumCard.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNumCard.Location = new System.Drawing.Point(408, 241);
            this.txtNumCard.Name = "txtNumCard";
            this.txtNumCard.Size = new System.Drawing.Size(113, 26);
            this.txtNumCard.TabIndex = 35;
            // 
            // txtCodeCard
            // 
            this.txtCodeCard.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtCodeCard.Location = new System.Drawing.Point(407, 212);
            this.txtCodeCard.Name = "txtCodeCard";
            this.txtCodeCard.Size = new System.Drawing.Size(113, 26);
            this.txtCodeCard.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.Location = new System.Drawing.Point(527, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 19);
            this.label14.TabIndex = 32;
            this.label14.Text = "תוקף";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(527, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 19);
            this.label13.TabIndex = 33;
            this.label13.Text = "מס\' כרטיס";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(527, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 19);
            this.label12.TabIndex = 34;
            this.label12.Text = "קוד כרטיס";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(526, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "ת.ז לקוח";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtId.Location = new System.Drawing.Point(406, 183);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(113, 26);
            this.txtId.TabIndex = 36;
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.myButton1.Location = new System.Drawing.Point(387, 318);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(168, 58);
            this.myButton1.TabIndex = 38;
            this.myButton1.Text = "הוסף כרטיס ";
            this.myButton1.UseVisualStyleBackColor = false;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(678, 653);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.txtDateCard);
            this.Controls.Add(this.txtNumCard);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtCodeCard);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmAddCreditCard";
            this.Text = "frmAddCreditCard";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DateTimePicker txtDateCard;
        private NumberTextBox txtNumCard;
        private NumberTextBox txtCodeCard;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private NumberTextBox txtId;
        private Resources.MyButton myButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}