namespace ElbarProject.GUI
{
    partial class frmAddShowClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddShowClient));
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLicenseNum = new System.Windows.Forms.Label();
            this.lblLicenseD1 = new System.Windows.Forms.Label();
            this.lblLicenseD2 = new System.Windows.Forms.Label();
            this.lblKindLicense = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbLicenseKind = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtLicenseD1 = new System.Windows.Forms.DateTimePicker();
            this.txtLicenseD2 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblmessageupdate = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnUpdate = new ElbarProject.Resources.MyButton();
            this.btnSearch = new ElbarProject.Resources.MyButton();
            this.btnOK = new ElbarProject.Resources.MyButton();
            this.txtAddress = new ElbarProject.HebrewTextBox();
            this.txtLName = new ElbarProject.HebrewTextBox();
            this.txtFName = new ElbarProject.HebrewTextBox();
            this.txtNum = new ElbarProject.NumberTextBox();
            this.numberTextBox2 = new ElbarProject.NumberTextBox();
            this.txtLicenseNum = new ElbarProject.NumberTextBox();
            this.txtPhone = new ElbarProject.NumberTextBox();
            this.txtTel = new ElbarProject.NumberTextBox();
            this.txtSearch = new ElbarProject.NumberTextBox();
            this.txtID = new ElbarProject.NumberTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblMessage.Font = new System.Drawing.Font("Ahla", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblMessage.Image")));
            this.lblMessage.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblMessage.Location = new System.Drawing.Point(467, 80);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(243, 36);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "     הוספת לקוח";
            this.lblMessage.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(561, 157);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(93, 19);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "תעודת זהות";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(561, 190);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(71, 19);
            this.lblFName.TabIndex = 2;
            this.lblFName.Text = "שם פרטי";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(561, 222);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(91, 19);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "שם משפחה";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(561, 254);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 19);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "כתובת";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(561, 286);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(63, 19);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "מס\' בית";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(558, 319);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(33, 19);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "עיר";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(561, 351);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(65, 19);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "ת. לידה";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(561, 383);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 19);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "טלפון";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(561, 415);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(33, 19);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "נייד";
            // 
            // lblLicenseNum
            // 
            this.lblLicenseNum.AutoSize = true;
            this.lblLicenseNum.Location = new System.Drawing.Point(561, 447);
            this.lblLicenseNum.Name = "lblLicenseNum";
            this.lblLicenseNum.Size = new System.Drawing.Size(72, 19);
            this.lblLicenseNum.TabIndex = 2;
            this.lblLicenseNum.Text = "מס\' רשיון";
            // 
            // lblLicenseD1
            // 
            this.lblLicenseD1.AutoSize = true;
            this.lblLicenseD1.Location = new System.Drawing.Point(561, 479);
            this.lblLicenseD1.Name = "lblLicenseD1";
            this.lblLicenseD1.Size = new System.Drawing.Size(109, 19);
            this.lblLicenseD1.TabIndex = 2;
            this.lblLicenseD1.Text = "ת. קבלת רשיון";
            // 
            // lblLicenseD2
            // 
            this.lblLicenseD2.AutoSize = true;
            this.lblLicenseD2.Location = new System.Drawing.Point(561, 510);
            this.lblLicenseD2.Name = "lblLicenseD2";
            this.lblLicenseD2.Size = new System.Drawing.Size(83, 19);
            this.lblLicenseD2.TabIndex = 2;
            this.lblLicenseD2.Text = "תוקף רשיון";
            // 
            // lblKindLicense
            // 
            this.lblKindLicense.AutoSize = true;
            this.lblKindLicense.Location = new System.Drawing.Point(561, 542);
            this.lblKindLicense.Name = "lblKindLicense";
            this.lblKindLicense.Size = new System.Drawing.Size(70, 19);
            this.lblKindLicense.TabIndex = 2;
            this.lblKindLicense.Text = "סוג רשיון";
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
            this.cmbCity.Location = new System.Drawing.Point(411, 319);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(143, 27);
            this.cmbCity.TabIndex = 5;
            // 
            // cmbLicenseKind
            // 
            this.cmbLicenseKind.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "A",
            "A1",
            "A2",
            "B",
            "C",
            "C1",
            "D",
            "D1",
            "D2",
            "D3",
            "E"});
            this.cmbLicenseKind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLicenseKind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLicenseKind.FormattingEnabled = true;
            this.cmbLicenseKind.Location = new System.Drawing.Point(411, 543);
            this.cmbLicenseKind.Name = "cmbLicenseKind";
            this.cmbLicenseKind.Size = new System.Drawing.Size(143, 27);
            this.cmbLicenseKind.TabIndex = 5;
            // 
            // txtDate
            // 
            this.txtDate.CustomFormat = "dd/MM/yyyy";
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDate.Location = new System.Drawing.Point(413, 352);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(141, 26);
            this.txtDate.TabIndex = 7;
            // 
            // txtLicenseD1
            // 
            this.txtLicenseD1.CustomFormat = "dd/MM/yyyy";
            this.txtLicenseD1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtLicenseD1.Location = new System.Drawing.Point(413, 480);
            this.txtLicenseD1.Name = "txtLicenseD1";
            this.txtLicenseD1.Size = new System.Drawing.Size(141, 26);
            this.txtLicenseD1.TabIndex = 7;
            // 
            // txtLicenseD2
            // 
            this.txtLicenseD2.CustomFormat = "dd/MM/yyyy";
            this.txtLicenseD2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtLicenseD2.Location = new System.Drawing.Point(414, 512);
            this.txtLicenseD2.Name = "txtLicenseD2";
            this.txtLicenseD2.Size = new System.Drawing.Size(141, 26);
            this.txtLicenseD2.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblmessageupdate
            // 
            this.lblmessageupdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblmessageupdate.Font = new System.Drawing.Font("Ahla", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblmessageupdate.Image = ((System.Drawing.Image)(resources.GetObject("lblmessageupdate.Image")));
            this.lblmessageupdate.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblmessageupdate.Location = new System.Drawing.Point(467, 80);
            this.lblmessageupdate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblmessageupdate.Name = "lblmessageupdate";
            this.lblmessageupdate.Size = new System.Drawing.Size(243, 36);
            this.lblmessageupdate.TabIndex = 1;
            this.lblmessageupdate.Text = "     עדכון לקוח";
            this.lblmessageupdate.Visible = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(256, 70);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(187, 19);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "הקש תעודת זהות לחיפוש";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblSearch.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdate.Location = new System.Drawing.Point(502, 600);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 50);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "עדכון";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.Location = new System.Drawing.Point(187, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 50);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "חיפוש";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOK.Location = new System.Drawing.Point(420, 600);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(159, 50);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "אישור";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(413, 255);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(141, 26);
            this.txtAddress.TabIndex = 4;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(413, 223);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(141, 26);
            this.txtLName.TabIndex = 4;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(413, 191);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(141, 26);
            this.txtFName.TabIndex = 4;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(412, 287);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(142, 26);
            this.txtNum.TabIndex = 3;
            this.txtNum.Text = "0";
            this.txtNum.TextChanged += new System.EventHandler(this.numberTextBox1_TextChanged);
            // 
            // numberTextBox2
            // 
            this.numberTextBox2.Location = new System.Drawing.Point(412, 287);
            this.numberTextBox2.Name = "numberTextBox2";
            this.numberTextBox2.Size = new System.Drawing.Size(142, 26);
            this.numberTextBox2.TabIndex = 3;
            this.numberTextBox2.TextChanged += new System.EventHandler(this.numberTextBox1_TextChanged);
            // 
            // txtLicenseNum
            // 
            this.txtLicenseNum.Location = new System.Drawing.Point(412, 448);
            this.txtLicenseNum.Name = "txtLicenseNum";
            this.txtLicenseNum.Size = new System.Drawing.Size(142, 26);
            this.txtLicenseNum.TabIndex = 3;
            this.txtLicenseNum.TextChanged += new System.EventHandler(this.numberTextBox1_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(412, 416);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(142, 26);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.TextChanged += new System.EventHandler(this.numberTextBox1_TextChanged);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(412, 384);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(142, 26);
            this.txtTel.TabIndex = 3;
            this.txtTel.TextChanged += new System.EventHandler(this.numberTextBox1_TextChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(108, 67);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(142, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.numberTextBox1_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(412, 158);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(142, 26);
            this.txtID.TabIndex = 3;
            this.txtID.TextChanged += new System.EventHandler(this.numberTextBox1_TextChanged);
            // 
            // frmAddShowClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(708, 662);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLicenseD2);
            this.Controls.Add(this.txtLicenseD1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbLicenseKind);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.numberTextBox2);
            this.Controls.Add(this.txtLicenseNum);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblKindLicense);
            this.Controls.Add(this.lblLicenseD2);
            this.Controls.Add(this.lblLicenseD1);
            this.Controls.Add(this.lblLicenseNum);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblmessageupdate);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Ahla", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmAddShowClient";
            this.Text = "frmAddShowClient";
            this.Load += new System.EventHandler(this.frmAddShowClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLicenseNum;
        private System.Windows.Forms.Label lblLicenseD1;
        private System.Windows.Forms.Label lblLicenseD2;
        private System.Windows.Forms.Label lblKindLicense;
        private NumberTextBox txtID;
        private HebrewTextBox txtFName;
        private HebrewTextBox txtLName;
        private HebrewTextBox txtAddress;
        private NumberTextBox numberTextBox2;
        private NumberTextBox txtNum;
        private System.Windows.Forms.ComboBox cmbCity;
        private NumberTextBox txtTel;
        private NumberTextBox txtPhone;
        private NumberTextBox txtLicenseNum;
        private System.Windows.Forms.ComboBox cmbLicenseKind;
        private Resources.MyButton btnOK;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.DateTimePicker txtLicenseD1;
        private System.Windows.Forms.DateTimePicker txtLicenseD2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblmessageupdate;
        private Resources.MyButton btnUpdate;
        private Resources.MyButton btnSearch;
        private NumberTextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}