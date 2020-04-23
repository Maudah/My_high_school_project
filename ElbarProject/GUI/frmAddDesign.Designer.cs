namespace ElbarProject.GUI
{
    partial class frmAddDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddDesign));
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblDesign = new System.Windows.Forms.Label();
            this.lblMenufactore = new System.Windows.Forms.Label();
            this.lblNumP = new System.Windows.Forms.Label();
            this.lblGroupe = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblEngine = new System.Windows.Forms.Label();
            this.txtNameCoude = new System.Windows.Forms.TextBox();
            this.cmbManufactore = new System.Windows.Forms.ComboBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.btnOk = new ElbarProject.Resources.MyButton();
            this.txtAngine = new ElbarProject.NumberTextBox();
            this.txtYeay = new ElbarProject.NumberTextBox();
            this.txtNumPlaces = new ElbarProject.NumberTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblMessage.Font = new System.Drawing.Font("Ahla", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblMessage.Image")));
            this.lblMessage.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblMessage.Location = new System.Drawing.Point(466, 60);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(227, 37);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "הוספת דגם";
            // 
            // lblDesign
            // 
            this.lblDesign.AutoSize = true;
            this.lblDesign.Font = new System.Drawing.Font("Ahla", 14.25F);
            this.lblDesign.Location = new System.Drawing.Point(531, 206);
            this.lblDesign.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(64, 19);
            this.lblDesign.TabIndex = 3;
            this.lblDesign.Text = "שם דגם";
            this.lblDesign.Click += new System.EventHandler(this.lblCode_Click);
            // 
            // lblMenufactore
            // 
            this.lblMenufactore.AutoSize = true;
            this.lblMenufactore.Font = new System.Drawing.Font("Ahla", 14.25F);
            this.lblMenufactore.Location = new System.Drawing.Point(531, 238);
            this.lblMenufactore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMenufactore.Name = "lblMenufactore";
            this.lblMenufactore.Size = new System.Drawing.Size(37, 19);
            this.lblMenufactore.TabIndex = 3;
            this.lblMenufactore.Text = "יצרן";
            this.lblMenufactore.Click += new System.EventHandler(this.lblCode_Click);
            // 
            // lblNumP
            // 
            this.lblNumP.AutoSize = true;
            this.lblNumP.Font = new System.Drawing.Font("Ahla", 14.25F);
            this.lblNumP.Location = new System.Drawing.Point(531, 270);
            this.lblNumP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumP.Name = "lblNumP";
            this.lblNumP.Size = new System.Drawing.Size(108, 19);
            this.lblNumP.TabIndex = 3;
            this.lblNumP.Text = "מספר מקומות";
            this.lblNumP.Click += new System.EventHandler(this.lblCode_Click);
            // 
            // lblGroupe
            // 
            this.lblGroupe.AutoSize = true;
            this.lblGroupe.Font = new System.Drawing.Font("Ahla", 14.25F);
            this.lblGroupe.Location = new System.Drawing.Point(531, 302);
            this.lblGroupe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGroupe.Name = "lblGroupe";
            this.lblGroupe.Size = new System.Drawing.Size(55, 19);
            this.lblGroupe.TabIndex = 3;
            this.lblGroupe.Text = "קבוצה";
            this.lblGroupe.Click += new System.EventHandler(this.lblCode_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Ahla", 14.25F);
            this.lblYear.Location = new System.Drawing.Point(531, 334);
            this.lblYear.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(73, 19);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "שנת ייצור";
            this.lblYear.Click += new System.EventHandler(this.lblCode_Click);
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Font = new System.Drawing.Font("Ahla", 14.25F);
            this.lblEngine.Location = new System.Drawing.Point(531, 366);
            this.lblEngine.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(70, 19);
            this.lblEngine.TabIndex = 3;
            this.lblEngine.Text = "נפח מנוע";
            this.lblEngine.Click += new System.EventHandler(this.lblCode_Click);
            // 
            // txtNameCoude
            // 
            this.txtNameCoude.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNameCoude.Location = new System.Drawing.Point(365, 205);
            this.txtNameCoude.Name = "txtNameCoude";
            this.txtNameCoude.Size = new System.Drawing.Size(141, 23);
            this.txtNameCoude.TabIndex = 5;
            // 
            // cmbManufactore
            // 
            this.cmbManufactore.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "ב מ וו",
            "הונדה",
            "טויוטה",
            "יונדאי",
            "מזדה",
            "מיצובישי",
            "מרצדס",
            "ניסן",
            "סאנגויינג",
            "סוברו",
            "סוזוקי",
            "סיאט",
            "סיטרואן",
            "סייק מוטורס",
            "פולקסווגן",
            "פורד",
            "פיאט",
            "קאיה",
            "קדילק",
            "קרייזלר",
            "רנו",
            "שברולט"});
            this.cmbManufactore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbManufactore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbManufactore.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbManufactore.FormattingEnabled = true;
            this.cmbManufactore.Location = new System.Drawing.Point(365, 241);
            this.cmbManufactore.Name = "cmbManufactore";
            this.cmbManufactore.Size = new System.Drawing.Size(141, 24);
            this.cmbManufactore.TabIndex = 6;
            this.cmbManufactore.SelectedIndexChanged += new System.EventHandler(this.cmbManufactore_SelectedIndexChanged);
            // 
            // cmbGroup
            // 
            this.cmbGroup.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "\t",
            "נפח 1100\tB",
            "נפח 1600\tE",
            "נפח 1800\tF",
            "נפח 2000\tI",
            "נפח 2400\tM",
            "נפח 3000\tU"});
            this.cmbGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGroup.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(365, 305);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(141, 24);
            this.cmbGroup.TabIndex = 8;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOk.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOk.Location = new System.Drawing.Point(408, 419);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(160, 42);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "אישור";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtAngine
            // 
            this.txtAngine.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtAngine.Location = new System.Drawing.Point(365, 366);
            this.txtAngine.Name = "txtAngine";
            this.txtAngine.Size = new System.Drawing.Size(140, 23);
            this.txtAngine.TabIndex = 10;
            // 
            // txtYeay
            // 
            this.txtYeay.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtYeay.Location = new System.Drawing.Point(365, 336);
            this.txtYeay.Name = "txtYeay";
            this.txtYeay.Size = new System.Drawing.Size(141, 23);
            this.txtYeay.TabIndex = 9;
            // 
            // txtNumPlaces
            // 
            this.txtNumPlaces.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNumPlaces.Location = new System.Drawing.Point(365, 275);
            this.txtNumPlaces.Name = "txtNumPlaces";
            this.txtNumPlaces.Size = new System.Drawing.Size(141, 23);
            this.txtNumPlaces.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(708, 657);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtAngine);
            this.Controls.Add(this.txtYeay);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.txtNumPlaces);
            this.Controls.Add(this.cmbManufactore);
            this.Controls.Add(this.txtNameCoude);
            this.Controls.Add(this.lblEngine);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblGroupe);
            this.Controls.Add(this.lblNumP);
            this.Controls.Add(this.lblMenufactore);
            this.Controls.Add(this.lblDesign);
            this.Controls.Add(this.lblMessage);
            this.Name = "frmAddDesign";
            this.Text = "frmAddDesign";
            this.Load += new System.EventHandler(this.frmAddDesign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.Label lblMenufactore;
        private System.Windows.Forms.Label lblNumP;
        private System.Windows.Forms.Label lblGroupe;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.TextBox txtNameCoude;
        private System.Windows.Forms.ComboBox cmbManufactore;
        private NumberTextBox txtNumPlaces;
        private System.Windows.Forms.ComboBox cmbGroup;
        private NumberTextBox txtYeay;
        private NumberTextBox txtAngine;
        private Resources.MyButton btnOk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}