namespace ElbarProject.GUI
{
    partial class frmCarReturn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.cmbCardList = new System.Windows.Forms.ComboBox();
            this.chkB = new System.Windows.Forms.CheckBox();
            this.txtNum = new ElbarProject.NumberTextBox();
            this.txtLicenseD2 = new System.Windows.Forms.DateTimePicker();
            this.txtToPay = new ElbarProject.NumberTextBox();
            this.txtLicenseD1 = new System.Windows.Forms.DateTimePicker();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.cmbLicenseKind = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.txtAddress = new ElbarProject.HebrewTextBox();
            this.txtLName = new ElbarProject.HebrewTextBox();
            this.txtFName = new ElbarProject.HebrewTextBox();
            this.txtLicenseNum = new ElbarProject.NumberTextBox();
            this.txtPhone = new ElbarProject.NumberTextBox();
            this.txtAge = new ElbarProject.NumberTextBox();
            this.txtTel = new ElbarProject.NumberTextBox();
            this.lblAgeD = new System.Windows.Forms.Label();
            this.lblDriver = new System.Windows.Forms.Label();
            this.lblKindLicense = new System.Windows.Forms.Label();
            this.lblLicenseD2 = new System.Windows.Forms.Label();
            this.lblLicenseD1 = new System.Windows.Forms.Label();
            this.lblLicenseNum = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.grpReturn = new System.Windows.Forms.GroupBox();
            this.txtKmForDay = new ElbarProject.NumberAndPointTextBox();
            this.txtKmNo = new ElbarProject.NumberAndPointTextBox();
            this.txtKm = new ElbarProject.NumberAndPointTextBox();
            this.txtGas = new ElbarProject.NumberAndPointTextBox();
            this.btnToPay = new ElbarProject.Resources.MyButton();
            this.lblAddPaying = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbBranchBack = new System.Windows.Forms.ComboBox();
            this.chbFix = new System.Windows.Forms.CheckBox();
            this.btnAddCard = new ElbarProject.Resources.MyButton();
            this.cmbCardForPay = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSearchById = new ElbarProject.Resources.MyButton();
            this.btnFinish = new ElbarProject.Resources.MyButton();
            this.btnSearch = new ElbarProject.Resources.MyButton();
            this.txtCode = new ElbarProject.NumberTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDaysNow = new System.Windows.Forms.Label();
            this.grpClient.SuspendLayout();
            this.grpReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblMessage.Font = new System.Drawing.Font("Ahla", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMessage.Location = new System.Drawing.Point(791, 51);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMessage.Size = new System.Drawing.Size(228, 32);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "          החזרת רכב";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(946, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "קוד השכרה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "סניף";
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(13, 31);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(185, 27);
            this.cmbBranch.TabIndex = 5;
            this.cmbBranch.SelectedIndexChanged += new System.EventHandler(this.cmbBranch_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 82);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "תאריך נוכחי:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(103, 82);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(0, 19);
            this.lblDate.TabIndex = 3;
            // 
            // grpClient
            // 
            this.grpClient.Controls.Add(this.cmbCardList);
            this.grpClient.Controls.Add(this.chkB);
            this.grpClient.Controls.Add(this.txtNum);
            this.grpClient.Controls.Add(this.txtLicenseD2);
            this.grpClient.Controls.Add(this.txtToPay);
            this.grpClient.Controls.Add(this.txtLicenseD1);
            this.grpClient.Controls.Add(this.txtDate);
            this.grpClient.Controls.Add(this.cmbLicenseKind);
            this.grpClient.Controls.Add(this.label11);
            this.grpClient.Controls.Add(this.label7);
            this.grpClient.Controls.Add(this.cmbCity);
            this.grpClient.Controls.Add(this.txtAddress);
            this.grpClient.Controls.Add(this.txtLName);
            this.grpClient.Controls.Add(this.txtFName);
            this.grpClient.Controls.Add(this.txtLicenseNum);
            this.grpClient.Controls.Add(this.txtPhone);
            this.grpClient.Controls.Add(this.txtAge);
            this.grpClient.Controls.Add(this.txtTel);
            this.grpClient.Controls.Add(this.lblAgeD);
            this.grpClient.Controls.Add(this.lblDriver);
            this.grpClient.Controls.Add(this.lblKindLicense);
            this.grpClient.Controls.Add(this.lblLicenseD2);
            this.grpClient.Controls.Add(this.lblLicenseD1);
            this.grpClient.Controls.Add(this.lblLicenseNum);
            this.grpClient.Controls.Add(this.lblPhone);
            this.grpClient.Controls.Add(this.lblTel);
            this.grpClient.Controls.Add(this.label4);
            this.grpClient.Controls.Add(this.label5);
            this.grpClient.Controls.Add(this.lblCity);
            this.grpClient.Controls.Add(this.lblNum);
            this.grpClient.Controls.Add(this.lblAddress);
            this.grpClient.Controls.Add(this.lblLName);
            this.grpClient.Controls.Add(this.lblFName);
            this.grpClient.Controls.Add(this.txtId);
            this.grpClient.Controls.Add(this.label6);
            this.grpClient.Enabled = false;
            this.grpClient.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grpClient.Location = new System.Drawing.Point(390, 184);
            this.grpClient.Name = "grpClient";
            this.grpClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpClient.Size = new System.Drawing.Size(651, 463);
            this.grpClient.TabIndex = 6;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "פרטי לקוח";
            // 
            // cmbCardList
            // 
            this.cmbCardList.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbCardList.FormattingEnabled = true;
            this.cmbCardList.Location = new System.Drawing.Point(324, 330);
            this.cmbCardList.Name = "cmbCardList";
            this.cmbCardList.Size = new System.Drawing.Size(168, 27);
            this.cmbCardList.TabIndex = 35;
            // 
            // chkB
            // 
            this.chkB.AutoSize = true;
            this.chkB.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chkB.Location = new System.Drawing.Point(177, 202);
            this.chkB.Name = "chkB";
            this.chkB.Size = new System.Drawing.Size(68, 23);
            this.chkB.TabIndex = 19;
            this.chkB.Text = "ביטוח";
            this.chkB.UseVisualStyleBackColor = true;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(366, 165);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(161, 26);
            this.txtNum.TabIndex = 34;
            this.txtNum.Text = "0";
            // 
            // txtLicenseD2
            // 
            this.txtLicenseD2.CustomFormat = "dd/MM/yyyy";
            this.txtLicenseD2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtLicenseD2.Location = new System.Drawing.Point(30, 135);
            this.txtLicenseD2.Name = "txtLicenseD2";
            this.txtLicenseD2.Size = new System.Drawing.Size(141, 26);
            this.txtLicenseD2.TabIndex = 32;
            // 
            // txtToPay
            // 
            this.txtToPay.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtToPay.Location = new System.Drawing.Point(85, 375);
            this.txtToPay.Name = "txtToPay";
            this.txtToPay.Size = new System.Drawing.Size(113, 26);
            this.txtToPay.TabIndex = 18;
            // 
            // txtLicenseD1
            // 
            this.txtLicenseD1.CustomFormat = "dd/MM/yyyy";
            this.txtLicenseD1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtLicenseD1.Location = new System.Drawing.Point(29, 103);
            this.txtLicenseD1.Name = "txtLicenseD1";
            this.txtLicenseD1.Size = new System.Drawing.Size(141, 26);
            this.txtLicenseD1.TabIndex = 31;
            // 
            // txtDate
            // 
            this.txtDate.CustomFormat = "dd/MM/yyyy";
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDate.Location = new System.Drawing.Point(366, 231);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(160, 26);
            this.txtDate.TabIndex = 30;
            // 
            // cmbLicenseKind
            // 
            this.cmbLicenseKind.FormattingEnabled = true;
            this.cmbLicenseKind.Location = new System.Drawing.Point(27, 166);
            this.cmbLicenseKind.Name = "cmbLicenseKind";
            this.cmbLicenseKind.Size = new System.Drawing.Size(143, 27);
            this.cmbLicenseKind.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(498, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "מס\' כרטיס אשראי";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(128, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "סה\"כ לתשלום:";
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
            this.cmbCity.Location = new System.Drawing.Point(364, 198);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(162, 27);
            this.cmbCity.TabIndex = 28;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(366, 134);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(160, 26);
            this.txtAddress.TabIndex = 27;
            this.txtAddress.Text = " ";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(366, 102);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(160, 26);
            this.txtLName.TabIndex = 26;
            this.txtLName.Text = " ";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(366, 70);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(160, 26);
            this.txtFName.TabIndex = 25;
            this.txtFName.Text = " ";
            // 
            // txtLicenseNum
            // 
            this.txtLicenseNum.Location = new System.Drawing.Point(28, 71);
            this.txtLicenseNum.Name = "txtLicenseNum";
            this.txtLicenseNum.Size = new System.Drawing.Size(142, 26);
            this.txtLicenseNum.TabIndex = 21;
            this.txtLicenseNum.Text = " ";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(365, 295);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(161, 26);
            this.txtPhone.TabIndex = 24;
            this.txtPhone.Text = " ";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(190, 235);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(132, 26);
            this.txtAge.TabIndex = 20;
            this.txtAge.Text = "0";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(365, 263);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(161, 26);
            this.txtTel.TabIndex = 20;
            this.txtTel.Text = " ";
            // 
            // lblAgeD
            // 
            this.lblAgeD.AutoSize = true;
            this.lblAgeD.ForeColor = System.Drawing.Color.Maroon;
            this.lblAgeD.Location = new System.Drawing.Point(6, 242);
            this.lblAgeD.Name = "lblAgeD";
            this.lblAgeD.Size = new System.Drawing.Size(0, 19);
            this.lblAgeD.TabIndex = 18;
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.ForeColor = System.Drawing.Color.Maroon;
            this.lblDriver.Location = new System.Drawing.Point(6, 218);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(0, 19);
            this.lblDriver.TabIndex = 18;
            // 
            // lblKindLicense
            // 
            this.lblKindLicense.AutoSize = true;
            this.lblKindLicense.Location = new System.Drawing.Point(177, 165);
            this.lblKindLicense.Name = "lblKindLicense";
            this.lblKindLicense.Size = new System.Drawing.Size(71, 19);
            this.lblKindLicense.TabIndex = 18;
            this.lblKindLicense.Text = "סוג רשיון";
            // 
            // lblLicenseD2
            // 
            this.lblLicenseD2.AutoSize = true;
            this.lblLicenseD2.Location = new System.Drawing.Point(177, 133);
            this.lblLicenseD2.Name = "lblLicenseD2";
            this.lblLicenseD2.Size = new System.Drawing.Size(85, 19);
            this.lblLicenseD2.TabIndex = 17;
            this.lblLicenseD2.Text = "תוקף רשיון";
            // 
            // lblLicenseD1
            // 
            this.lblLicenseD1.AutoSize = true;
            this.lblLicenseD1.Location = new System.Drawing.Point(177, 102);
            this.lblLicenseD1.Name = "lblLicenseD1";
            this.lblLicenseD1.Size = new System.Drawing.Size(113, 19);
            this.lblLicenseD1.TabIndex = 16;
            this.lblLicenseD1.Text = "ת. קבלת רשיון";
            // 
            // lblLicenseNum
            // 
            this.lblLicenseNum.AutoSize = true;
            this.lblLicenseNum.Location = new System.Drawing.Point(177, 70);
            this.lblLicenseNum.Name = "lblLicenseNum";
            this.lblLicenseNum.Size = new System.Drawing.Size(74, 19);
            this.lblLicenseNum.TabIndex = 15;
            this.lblLicenseNum.Text = "מס\' רשיון";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(533, 294);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(34, 19);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "נייד";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(533, 262);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(50, 19);
            this.lblTel.TabIndex = 13;
            this.lblTel.Text = "טלפון";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "גיל";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "ת. לידה";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(530, 198);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(33, 19);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "עיר";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(533, 165);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(66, 19);
            this.lblNum.TabIndex = 10;
            this.lblNum.Text = "מס\' בית";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(533, 133);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 19);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "כתובת";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(533, 101);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(93, 19);
            this.lblLName.TabIndex = 19;
            this.lblLName.Text = "שם משפחה";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(533, 69);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(72, 19);
            this.lblFName.TabIndex = 8;
            this.lblFName.Text = "שם פרטי";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(366, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(161, 26);
            this.txtId.TabIndex = 1;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "ת.ז לקוח";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(478, 673);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpTo.Size = new System.Drawing.Size(130, 26);
            this.dtpTo.TabIndex = 22;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(671, 672);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpFrom.Size = new System.Drawing.Size(130, 26);
            this.dtpFrom.TabIndex = 23;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label18.Location = new System.Drawing.Point(807, 678);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 19);
            this.label18.TabIndex = 19;
            this.label18.Text = "מ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label16.Location = new System.Drawing.Point(614, 679);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 19);
            this.label16.TabIndex = 20;
            this.label16.Text = "עד ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label17.Location = new System.Drawing.Point(866, 679);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(175, 19);
            this.label17.TabIndex = 21;
            this.label17.Text = "טווח תאריכים להשכרה";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDays.Location = new System.Drawing.Point(320, 678);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(18, 19);
            this.lblDays.TabIndex = 24;
            this.lblDays.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label19.Location = new System.Drawing.Point(361, 678);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label19.Size = new System.Drawing.Size(88, 19);
            this.label19.TabIndex = 25;
            this.label19.Text = "סה\"כ ימים:";
            // 
            // grpReturn
            // 
            this.grpReturn.Controls.Add(this.txtKmForDay);
            this.grpReturn.Controls.Add(this.txtKmNo);
            this.grpReturn.Controls.Add(this.txtKm);
            this.grpReturn.Controls.Add(this.txtGas);
            this.grpReturn.Controls.Add(this.btnToPay);
            this.grpReturn.Controls.Add(this.lblAddPaying);
            this.grpReturn.Controls.Add(this.label20);
            this.grpReturn.Controls.Add(this.cmbBranchBack);
            this.grpReturn.Controls.Add(this.chbFix);
            this.grpReturn.Controls.Add(this.btnAddCard);
            this.grpReturn.Controls.Add(this.cmbCardForPay);
            this.grpReturn.Controls.Add(this.label15);
            this.grpReturn.Controls.Add(this.label14);
            this.grpReturn.Controls.Add(this.label10);
            this.grpReturn.Controls.Add(this.label9);
            this.grpReturn.Controls.Add(this.label8);
            this.grpReturn.Controls.Add(this.label12);
            this.grpReturn.Enabled = false;
            this.grpReturn.Location = new System.Drawing.Point(44, 135);
            this.grpReturn.Name = "grpReturn";
            this.grpReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpReturn.Size = new System.Drawing.Size(282, 512);
            this.grpReturn.TabIndex = 26;
            this.grpReturn.TabStop = false;
            this.grpReturn.Text = "נתוני החזרה";
            // 
            // txtKmForDay
            // 
            this.txtKmForDay.Location = new System.Drawing.Point(134, 220);
            this.txtKmForDay.Name = "txtKmForDay";
            this.txtKmForDay.Size = new System.Drawing.Size(100, 26);
            this.txtKmForDay.TabIndex = 42;
            this.txtKmForDay.Text = "0";
            // 
            // txtKmNo
            // 
            this.txtKmNo.Location = new System.Drawing.Point(134, 159);
            this.txtKmNo.Name = "txtKmNo";
            this.txtKmNo.Size = new System.Drawing.Size(100, 26);
            this.txtKmNo.TabIndex = 42;
            this.txtKmNo.Text = "0";
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(66, 99);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(100, 26);
            this.txtKm.TabIndex = 42;
            this.txtKm.Text = "0";
            // 
            // txtGas
            // 
            this.txtGas.Location = new System.Drawing.Point(66, 66);
            this.txtGas.Name = "txtGas";
            this.txtGas.Size = new System.Drawing.Size(100, 26);
            this.txtGas.TabIndex = 42;
            this.txtGas.Text = "0";
            // 
            // btnToPay
            // 
            this.btnToPay.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnToPay.Location = new System.Drawing.Point(40, 330);
            this.btnToPay.Name = "btnToPay";
            this.btnToPay.Size = new System.Drawing.Size(209, 32);
            this.btnToPay.TabIndex = 41;
            this.btnToPay.Text = "תשלום";
            this.btnToPay.UseVisualStyleBackColor = false;
            this.btnToPay.Click += new System.EventHandler(this.btnToPay_Click);
            // 
            // lblAddPaying
            // 
            this.lblAddPaying.AutoSize = true;
            this.lblAddPaying.Location = new System.Drawing.Point(100, 379);
            this.lblAddPaying.Name = "lblAddPaying";
            this.lblAddPaying.Size = new System.Drawing.Size(18, 19);
            this.lblAddPaying.TabIndex = 40;
            this.lblAddPaying.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(148, 379);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 19);
            this.label20.TabIndex = 39;
            this.label20.Text = "תוספת תשלום";
            // 
            // cmbBranchBack
            // 
            this.cmbBranchBack.FormattingEnabled = true;
            this.cmbBranchBack.Location = new System.Drawing.Point(39, 291);
            this.cmbBranchBack.Name = "cmbBranchBack";
            this.cmbBranchBack.Size = new System.Drawing.Size(171, 27);
            this.cmbBranchBack.TabIndex = 38;
            // 
            // chbFix
            // 
            this.chbFix.AutoSize = true;
            this.chbFix.Location = new System.Drawing.Point(134, 263);
            this.chbFix.Name = "chbFix";
            this.chbFix.Size = new System.Drawing.Size(115, 23);
            this.chbFix.TabIndex = 37;
            this.chbFix.Text = "הרכב תקין?";
            this.chbFix.UseVisualStyleBackColor = true;
            this.chbFix.CheckedChanged += new System.EventHandler(this.chbFix_CheckedChanged);
            // 
            // btnAddCard
            // 
            this.btnAddCard.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddCard.Location = new System.Drawing.Point(90, 462);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(168, 31);
            this.btnAddCard.TabIndex = 36;
            this.btnAddCard.Text = "הוספת כרטיס חדש";
            this.btnAddCard.UseVisualStyleBackColor = false;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // cmbCardForPay
            // 
            this.cmbCardForPay.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbCardForPay.FormattingEnabled = true;
            this.cmbCardForPay.Location = new System.Drawing.Point(90, 429);
            this.cmbCardForPay.Name = "cmbCardForPay";
            this.cmbCardForPay.Size = new System.Drawing.Size(168, 27);
            this.cmbCardForPay.TabIndex = 35;
            this.cmbCardForPay.SelectedIndexChanged += new System.EventHandler(this.cmbCardForPay_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(221, 295);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 19);
            this.label15.TabIndex = 3;
            this.label15.Text = "חניה";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(124, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 19);
            this.label14.TabIndex = 3;
            this.label14.Text = "חישוב ק\'מ ליום";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "סה\"כ ק\'מ בהשכרה נוכחית";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "מס\' ק\'מ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "כמות גז";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(124, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 19);
            this.label12.TabIndex = 16;
            this.label12.Text = "מס\' כרטיס אשראי";
            // 
            // btnSearchById
            // 
            this.btnSearchById.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearchById.Location = new System.Drawing.Point(425, 126);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(234, 33);
            this.btnSearchById.TabIndex = 29;
            this.btnSearchById.Text = "חיפוש ע\"י ת.ז לקוח";
            this.btnSearchById.UseVisualStyleBackColor = false;
            this.btnSearchById.Click += new System.EventHandler(this.btnSearchById_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnFinish.Location = new System.Drawing.Point(22, 657);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(188, 63);
            this.btnFinish.TabIndex = 28;
            this.btnFinish.Text = "סיום";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.Location = new System.Drawing.Point(677, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 32);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "ok";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(737, 132);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(203, 26);
            this.txtCode.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(361, 701);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(142, 19);
            this.label13.TabIndex = 25;
            this.label13.Text = "סה\"כ ימים בפועל :";
            // 
            // lblDaysNow
            // 
            this.lblDaysNow.AutoSize = true;
            this.lblDaysNow.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDaysNow.Location = new System.Drawing.Point(320, 701);
            this.lblDaysNow.Name = "lblDaysNow";
            this.lblDaysNow.Size = new System.Drawing.Size(18, 19);
            this.lblDaysNow.TabIndex = 24;
            this.lblDaysNow.Text = "0";
            // 
            // frmCarReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1071, 741);
            this.Controls.Add(this.btnSearchById);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpReturn);
            this.Controls.Add(this.lblDaysNow);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.grpClient);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmCarReturn";
            this.Text = "frmCarReturn";
            this.Load += new System.EventHandler(this.frmCarReturn_Load);
            this.grpClient.ResumeLayout(false);
            this.grpClient.PerformLayout();
            this.grpReturn.ResumeLayout(false);
            this.grpReturn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label1;
        private NumberTextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpClient;
        private NumberTextBox txtNum;
        private System.Windows.Forms.DateTimePicker txtLicenseD2;
        private System.Windows.Forms.DateTimePicker txtLicenseD1;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.ComboBox cmbLicenseKind;
        private System.Windows.Forms.ComboBox cmbCity;
        private HebrewTextBox txtAddress;
        private HebrewTextBox txtLName;
        private HebrewTextBox txtFName;
        private NumberTextBox txtLicenseNum;
        private NumberTextBox txtPhone;
        private NumberTextBox txtAge;
        private NumberTextBox txtTel;
        private System.Windows.Forms.Label lblAgeD;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.Label lblKindLicense;
        private System.Windows.Forms.Label lblLicenseD2;
        private System.Windows.Forms.Label lblLicenseD1;
        private System.Windows.Forms.Label lblLicenseNum;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox chkB;
        private NumberTextBox txtToPay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpReturn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Resources.MyButton btnSearch;
        private Resources.MyButton btnFinish;
        private System.Windows.Forms.ComboBox cmbCardList;
        private Resources.MyButton btnSearchById;
        private System.Windows.Forms.ComboBox cmbCardForPay;
        private System.Windows.Forms.Label label12;
        private Resources.MyButton btnAddCard;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDaysNow;
        private System.Windows.Forms.CheckBox chbFix;
        private System.Windows.Forms.ComboBox cmbBranchBack;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblAddPaying;
        private System.Windows.Forms.Label label20;
        private Resources.MyButton btnToPay;
        private NumberAndPointTextBox txtKmForDay;
        private NumberAndPointTextBox txtKmNo;
        private NumberAndPointTextBox txtKm;
        private NumberAndPointTextBox txtGas;
    }
}