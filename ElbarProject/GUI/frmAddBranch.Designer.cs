namespace ElbarProject.GUI
{
    partial class frmAddBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBranch));
            this.lblMessage = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnOK = new ElbarProject.Resources.MyButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new ElbarProject.HebrewTextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMenager = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumT = new ElbarProject.NumberTextBox();
            this.txtNumL = new ElbarProject.NumberTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblMessage.Font = new System.Drawing.Font("Ahla", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblMessage.Image")));
            this.lblMessage.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblMessage.Location = new System.Drawing.Point(466, 73);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(227, 42);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "הוספת סניף      ";
            // 
            // cmbCity
            // 
            this.cmbCity.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "",
            "תל אביב",
            "פתח תקווה",
            "ראשון לציון",
            "אלעד",
            "חולון",
            "בת ים",
            "בני ברק",
            "ראש העין",
            "נתניה",
            "אשדוד",
            "חדרה",
            "יבנה",
            "רחובות",
            "קרית אונו",
            "קרית אתא",
            "שדרות",
            "צפת",
            "רכסים",
            "ירושלים",
            "טבריה"});
            this.cmbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(349, 195);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(185, 27);
            this.cmbCity.TabIndex = 2;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(554, 198);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(59, 19);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "שם עיר";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOK.Location = new System.Drawing.Point(417, 478);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(117, 35);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "להוספה";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "כתובת";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "שם סניף";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(350, 268);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 26);
            this.txtName.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(348, 230);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(186, 26);
            this.txtAddress.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "מנהל";
            // 
            // cmbMenager
            // 
            this.cmbMenager.FormattingEnabled = true;
            this.cmbMenager.Location = new System.Drawing.Point(348, 306);
            this.cmbMenager.Name = "cmbMenager";
            this.cmbMenager.Size = new System.Drawing.Size(185, 27);
            this.cmbMenager.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(554, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "גודל חניון";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "מס\' טורים";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "מס\' שורות";
            // 
            // txtNumT
            // 
            this.txtNumT.Location = new System.Drawing.Point(401, 346);
            this.txtNumT.Name = "txtNumT";
            this.txtNumT.Size = new System.Drawing.Size(56, 26);
            this.txtNumT.TabIndex = 8;
            this.txtNumT.Text = "0";
            // 
            // txtNumL
            // 
            this.txtNumL.Location = new System.Drawing.Point(270, 346);
            this.txtNumL.Name = "txtNumL";
            this.txtNumL.Size = new System.Drawing.Size(56, 26);
            this.txtNumL.TabIndex = 8;
            this.txtNumL.Text = "0";
            // 
            // frmAddBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(708, 657);
            this.Controls.Add(this.txtNumL);
            this.Controls.Add(this.txtNumT);
            this.Controls.Add(this.cmbMenager);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Ahla", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmAddBranch";
            this.Text = "frmAddBranch";
            this.Load += new System.EventHandler(this.frmAddBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label lblCity;
        private Resources.MyButton btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private HebrewTextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbMenager;
        private System.Windows.Forms.Label label3;
        private NumberTextBox txtNumL;
        private NumberTextBox txtNumT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}