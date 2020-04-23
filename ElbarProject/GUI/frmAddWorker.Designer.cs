namespace ElbarProject.GUI
{
    partial class frmAddWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddWorker));
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblDiscribe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbJob = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNumHouse = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUpdate = new System.Windows.Forms.Label();
            this.txtAddress = new ElbarProject.HebrewTextBox();
            this.txtLastName = new ElbarProject.HebrewTextBox();
            this.txtFirstName = new ElbarProject.HebrewTextBox();
            this.btnOK = new ElbarProject.Resources.MyButton();
            this.txtPhone = new ElbarProject.NumberTextBox();
            this.txtTel = new ElbarProject.NumberTextBox();
            this.txtNumHouse = new ElbarProject.NumberTextBox();
            this.txtID = new ElbarProject.NumberTextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new ElbarProject.NumberTextBox();
            this.btnSearch = new ElbarProject.Resources.MyButton();
            this.lblDel = new System.Windows.Forms.Label();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblAdd.Font = new System.Drawing.Font("Ahla", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAdd.Image = ((System.Drawing.Image)(resources.GetObject("lblAdd.Image")));
            this.lblAdd.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblAdd.Location = new System.Drawing.Point(466, 76);
            this.lblAdd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(227, 37);
            this.lblAdd.TabIndex = 1;
            this.lblAdd.Text = "הוספת עובד";
            // 
            // lblDiscribe
            // 
            this.lblDiscribe.AutoSize = true;
            this.lblDiscribe.Location = new System.Drawing.Point(518, 147);
            this.lblDiscribe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDiscribe.Name = "lblDiscribe";
            this.lblDiscribe.Size = new System.Drawing.Size(71, 19);
            this.lblDiscribe.TabIndex = 2;
            this.lblDiscribe.Text = "ת.ז עובד";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "שם פרטי";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "שם משפחה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "תפקיד";
            // 
            // cmbJob
            // 
            this.cmbJob.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "",
            "מנהל ראשי",
            "מנהל סניף",
            "מזכירה",
            "פקיד",
            "מנקה"});
            this.cmbJob.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbJob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbJob.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbJob.FormattingEnabled = true;
            this.cmbJob.Location = new System.Drawing.Point(356, 234);
            this.cmbJob.Name = "cmbJob";
            this.cmbJob.Size = new System.Drawing.Size(153, 27);
            this.cmbJob.TabIndex = 5;
            this.cmbJob.SelectedIndexChanged += new System.EventHandler(this.cmbJob_SelectedIndexChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(518, 270);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 19);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "כתובת";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNumHouse
            // 
            this.lblNumHouse.AutoSize = true;
            this.lblNumHouse.Location = new System.Drawing.Point(518, 300);
            this.lblNumHouse.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumHouse.Name = "lblNumHouse";
            this.lblNumHouse.Size = new System.Drawing.Size(63, 19);
            this.lblNumHouse.TabIndex = 2;
            this.lblNumHouse.Text = "מס\' בית";
            this.lblNumHouse.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(518, 331);
            this.lblCity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(33, 19);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "עיר";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.cmbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCity.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(356, 328);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(153, 27);
            this.cmbCity.TabIndex = 7;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(518, 362);
            this.lblTel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(49, 19);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "טלפון";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(518, 395);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 19);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "פלאפון";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 427);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "סניף";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblUpdate
            // 
            this.lblUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblUpdate.Font = new System.Drawing.Font("Ahla", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblUpdate.Image = ((System.Drawing.Image)(resources.GetObject("lblUpdate.Image")));
            this.lblUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblUpdate.Location = new System.Drawing.Point(466, 88);
            this.lblUpdate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(227, 37);
            this.lblUpdate.TabIndex = 1;
            this.lblUpdate.Text = "עדכון עובד";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtAddress.Location = new System.Drawing.Point(356, 265);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(153, 26);
            this.txtAddress.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtLastName.Location = new System.Drawing.Point(356, 205);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(153, 26);
            this.txtLastName.TabIndex = 10;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFirstName.Location = new System.Drawing.Point(356, 173);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(153, 26);
            this.txtFirstName.TabIndex = 10;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOK.Location = new System.Drawing.Point(415, 497);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(137, 32);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "שמירה";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPhone.Location = new System.Drawing.Point(356, 391);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(153, 26);
            this.txtPhone.TabIndex = 6;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtTel.Location = new System.Drawing.Point(356, 360);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(153, 26);
            this.txtTel.TabIndex = 6;
            // 
            // txtNumHouse
            // 
            this.txtNumHouse.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNumHouse.Location = new System.Drawing.Point(356, 297);
            this.txtNumHouse.Name = "txtNumHouse";
            this.txtNumHouse.Size = new System.Drawing.Size(153, 26);
            this.txtNumHouse.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtID.Location = new System.Drawing.Point(356, 141);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(153, 26);
            this.txtID.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(298, 106);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(126, 19);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "הקש ת.ז לחיפוש";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(117, 103);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(175, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.Location = new System.Drawing.Point(152, 141);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 31);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "חיפוש";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDel
            // 
            this.lblDel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblDel.Font = new System.Drawing.Font("Ahla", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDel.Image = ((System.Drawing.Image)(resources.GetObject("lblDel.Image")));
            this.lblDel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblDel.Location = new System.Drawing.Point(466, 100);
            this.lblDel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDel.Name = "lblDel";
            this.lblDel.Size = new System.Drawing.Size(227, 37);
            this.lblDel.TabIndex = 1;
            this.lblDel.Text = "מחיקת עובד";
            // 
            // cmbBranch
            // 
            this.cmbBranch.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(356, 427);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(153, 27);
            this.cmbBranch.TabIndex = 13;
            // 
            // frmAddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(708, 657);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtNumHouse);
            this.Controls.Add(this.cmbJob);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblNumHouse);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDiscribe);
            this.Controls.Add(this.lblDel);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblAdd);
            this.Font = new System.Drawing.Font("Ahla", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmAddWorker";
            this.Text = "frmAddWorker";
            this.Load += new System.EventHandler(this.frmAddWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblDiscribe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private NumberTextBox txtID;
        private System.Windows.Forms.ComboBox cmbJob;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNumHouse;
        private System.Windows.Forms.Label lblCity;
        private NumberTextBox txtNumHouse;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label6;
        private NumberTextBox txtTel;
        private NumberTextBox txtPhone;
        private Resources.MyButton btnOK;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private HebrewTextBox txtAddress;
        private HebrewTextBox txtLastName;
        private HebrewTextBox txtFirstName;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblSearch;
        private NumberTextBox txtSearch;
        private Resources.MyButton btnSearch;
        private System.Windows.Forms.Label lblDel;
        private System.Windows.Forms.ComboBox cmbBranch;
    }
}