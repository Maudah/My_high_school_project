namespace ElbarProject.GUI
{
    partial class frmAddFix
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCar = new ElbarProject.NumberTextBox();
            this.txtClient = new ElbarProject.NumberTextBox();
            this.txtFix = new ElbarProject.HebrewTextBox();
            this.btnOk = new ElbarProject.Resources.MyButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSearch = new ElbarProject.NumberTextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearsh = new ElbarProject.Resources.MyButton();
            this.myButton1 = new ElbarProject.Resources.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblMessage.Font = new System.Drawing.Font("Ahla", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMessage.Location = new System.Drawing.Point(510, 61);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMessage.Size = new System.Drawing.Size(224, 32);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "         הוספת תיקון";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "מס\' רכב";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "ת.ז לקוח";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "תיאור תיקון";
            // 
            // txtCar
            // 
            this.txtCar.Location = new System.Drawing.Point(338, 178);
            this.txtCar.Name = "txtCar";
            this.txtCar.Size = new System.Drawing.Size(168, 26);
            this.txtCar.TabIndex = 4;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(338, 218);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(168, 26);
            this.txtClient.TabIndex = 4;
            this.txtClient.Text = "חברה";
            // 
            // txtFix
            // 
            this.txtFix.Location = new System.Drawing.Point(338, 257);
            this.txtFix.Name = "txtFix";
            this.txtFix.Size = new System.Drawing.Size(172, 26);
            this.txtFix.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOk.Location = new System.Drawing.Point(362, 420);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(222, 30);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "הוספה/עדכון";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(178, 107);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(116, 26);
            this.txtSearch.TabIndex = 7;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(300, 107);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(115, 19);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "הקש קוד תיקון";
            // 
            // btnSearsh
            // 
            this.btnSearsh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearsh.Location = new System.Drawing.Point(117, 106);
            this.btnSearsh.Name = "btnSearsh";
            this.btnSearsh.Size = new System.Drawing.Size(43, 26);
            this.btnSearsh.TabIndex = 9;
            this.btnSearsh.Text = "ok";
            this.btnSearsh.UseVisualStyleBackColor = false;
            this.btnSearsh.Click += new System.EventHandler(this.btnSearsh_Click);
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.myButton1.Location = new System.Drawing.Point(212, 222);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(110, 26);
            this.myButton1.TabIndex = 10;
            this.myButton1.Text = "אתחול";
            this.myButton1.UseVisualStyleBackColor = false;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // frmAddFix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(731, 681);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.btnSearsh);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtFix);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.txtCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmAddFix";
            this.Text = "frmAddFix";
            this.Load += new System.EventHandler(this.frmAddFix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private NumberTextBox txtCar;
        private NumberTextBox txtClient;
        private HebrewTextBox txtFix;
        private Resources.MyButton btnOk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Resources.MyButton btnSearsh;
        private System.Windows.Forms.Label lblSearch;
        private NumberTextBox txtSearch;
        private Resources.MyButton myButton1;
    }
}