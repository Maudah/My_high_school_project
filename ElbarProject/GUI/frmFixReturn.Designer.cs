namespace ElbarProject.GUI
{
    partial class frmFixReturn
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
            this.btnSearsh = new ElbarProject.Resources.MyButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new ElbarProject.NumberTextBox();
            this.txtFix = new ElbarProject.HebrewTextBox();
            this.txtClient = new ElbarProject.NumberTextBox();
            this.txtCar = new ElbarProject.NumberTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDamage = new ElbarProject.HebrewTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtToPay = new ElbarProject.NumberTextBox();
            this.btnOk = new ElbarProject.Resources.MyButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMesage = new System.Windows.Forms.Label();
            this.btnAddCard = new ElbarProject.Resources.MyButton();
            this.cmbCardForPay = new System.Windows.Forms.ComboBox();
            this.lblCard = new System.Windows.Forms.Label();
            this.btnClient = new ElbarProject.Resources.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblMessage.Font = new System.Drawing.Font("Ahla", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMessage.Location = new System.Drawing.Point(268, 58);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMessage.Size = new System.Drawing.Size(305, 32);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "         החזרת רכב מתיקון";
            // 
            // btnSearsh
            // 
            this.btnSearsh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearsh.Location = new System.Drawing.Point(241, 140);
            this.btnSearsh.Name = "btnSearsh";
            this.btnSearsh.Size = new System.Drawing.Size(43, 26);
            this.btnSearsh.TabIndex = 12;
            this.btnSearsh.Text = "ok";
            this.btnSearsh.UseVisualStyleBackColor = false;
            this.btnSearsh.Click += new System.EventHandler(this.btnSearsh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "הקש קוד תיקון";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(302, 141);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(116, 26);
            this.txtSearch.TabIndex = 10;
            // 
            // txtFix
            // 
            this.txtFix.Enabled = false;
            this.txtFix.Location = new System.Drawing.Point(89, 282);
            this.txtFix.Name = "txtFix";
            this.txtFix.Size = new System.Drawing.Size(336, 26);
            this.txtFix.TabIndex = 18;
            // 
            // txtClient
            // 
            this.txtClient.Enabled = false;
            this.txtClient.Location = new System.Drawing.Point(263, 238);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(158, 26);
            this.txtClient.TabIndex = 16;
            this.txtClient.TextChanged += new System.EventHandler(this.txtClient_TextChanged);
            // 
            // txtCar
            // 
            this.txtCar.Enabled = false;
            this.txtCar.Location = new System.Drawing.Point(263, 198);
            this.txtCar.Name = "txtCar";
            this.txtCar.Size = new System.Drawing.Size(158, 26);
            this.txtCar.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(445, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "תיאור תיקון";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(445, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "ת.ז לקוח";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(445, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "מס\' רכב";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(445, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "תיאור נזק";
            // 
            // txtDamage
            // 
            this.txtDamage.Location = new System.Drawing.Point(89, 328);
            this.txtDamage.Name = "txtDamage";
            this.txtDamage.Size = new System.Drawing.Size(336, 26);
            this.txtDamage.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(445, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "לתשלום";
            // 
            // txtToPay
            // 
            this.txtToPay.Location = new System.Drawing.Point(263, 413);
            this.txtToPay.Name = "txtToPay";
            this.txtToPay.Size = new System.Drawing.Size(149, 26);
            this.txtToPay.TabIndex = 16;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOk.Location = new System.Drawing.Point(168, 583);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(279, 46);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "אישור";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblMesage
            // 
            this.lblMesage.AutoSize = true;
            this.lblMesage.Location = new System.Drawing.Point(123, 451);
            this.lblMesage.Name = "lblMesage";
            this.lblMesage.Size = new System.Drawing.Size(0, 19);
            this.lblMesage.TabIndex = 20;
            // 
            // btnAddCard
            // 
            this.btnAddCard.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddCard.Location = new System.Drawing.Point(390, 546);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(168, 31);
            this.btnAddCard.TabIndex = 42;
            this.btnAddCard.Text = "הוספת כרטיס חדש";
            this.btnAddCard.UseVisualStyleBackColor = false;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // cmbCardForPay
            // 
            this.cmbCardForPay.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbCardForPay.FormattingEnabled = true;
            this.cmbCardForPay.Location = new System.Drawing.Point(228, 508);
            this.cmbCardForPay.Name = "cmbCardForPay";
            this.cmbCardForPay.Size = new System.Drawing.Size(168, 27);
            this.cmbCardForPay.TabIndex = 41;
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCard.Location = new System.Drawing.Point(420, 511);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(138, 19);
            this.lblCard.TabIndex = 40;
            this.lblCard.Text = "מס\' כרטיס אשראי";
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClient.Location = new System.Drawing.Point(149, 238);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(108, 36);
            this.btnClient.TabIndex = 43;
            this.btnClient.Text = "פרטי לקוח";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // frmFixReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(570, 663);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnAddCard);
            this.Controls.Add(this.cmbCardForPay);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.lblMesage);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtDamage);
            this.Controls.Add(this.txtFix);
            this.Controls.Add(this.txtToPay);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.txtCar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearsh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmFixReturn";
            this.Text = "frmFixReturn";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private Resources.MyButton btnSearsh;
        private System.Windows.Forms.Label label4;
        private NumberTextBox txtSearch;
        private HebrewTextBox txtFix;
        private NumberTextBox txtClient;
        private NumberTextBox txtCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private HebrewTextBox txtDamage;
        private System.Windows.Forms.Label label6;
        private NumberTextBox txtToPay;
        private Resources.MyButton btnOk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblMesage;
        private Resources.MyButton btnAddCard;
        private System.Windows.Forms.ComboBox cmbCardForPay;
        private System.Windows.Forms.Label lblCard;
        private Resources.MyButton btnClient;
    }
}