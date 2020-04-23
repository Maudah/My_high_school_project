namespace ElbarProject.GUI
{
    partial class frmShowCars
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
            this.lblNum = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.chfound = new System.Windows.Forms.CheckBox();
            this.chbFix = new System.Windows.Forms.CheckBox();
            this.dtpB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.dtpT = new System.Windows.Forms.DateTimePicker();
            this.cmbPlace = new System.Windows.Forms.ComboBox();
            this.cmbDesign = new System.Windows.Forms.ComboBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.pcbPicture = new System.Windows.Forms.PictureBox();
            this.lblAddCar = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch = new ElbarProject.Resources.MyButton();
            this.btnPicture = new ElbarProject.Resources.MyButton();
            this.btnDel = new ElbarProject.Resources.MyButton();
            this.btnUpdate = new ElbarProject.Resources.MyButton();
            this.btnAdd = new ElbarProject.Resources.MyButton();
            this.txtNumForSerch = new ElbarProject.NumberTextBox();
            this.txtnum = new ElbarProject.NumberTextBox();
            this.txtKm = new ElbarProject.NumberAndPointTextBox();
            this.txtAmount = new ElbarProject.NumberAndPointTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.SteelBlue;
            this.lblMessage.Font = new System.Drawing.Font("Ahla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMessage.Location = new System.Drawing.Point(684, 44);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(213, 31);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "עדכון רכב";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNum.Location = new System.Drawing.Point(688, 106);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(69, 19);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "מס\' רכב";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblColor.Location = new System.Drawing.Point(688, 139);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(74, 19);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "צבע רכב";
            // 
            // chfound
            // 
            this.chfound.AutoSize = true;
            this.chfound.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chfound.Location = new System.Drawing.Point(688, 172);
            this.chfound.Name = "chfound";
            this.chfound.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chfound.Size = new System.Drawing.Size(73, 23);
            this.chfound.TabIndex = 2;
            this.chfound.Text = "נמצא?";
            this.chfound.UseVisualStyleBackColor = true;
            this.chfound.CheckedChanged += new System.EventHandler(this.chfound_CheckedChanged);
            // 
            // chbFix
            // 
            this.chbFix.AutoSize = true;
            this.chbFix.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chbFix.Location = new System.Drawing.Point(693, 201);
            this.chbFix.Name = "chbFix";
            this.chbFix.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbFix.Size = new System.Drawing.Size(67, 23);
            this.chbFix.TabIndex = 2;
            this.chbFix.Text = "תקין?";
            this.chbFix.UseVisualStyleBackColor = true;
            // 
            // dtpB
            // 
            this.dtpB.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpB.Location = new System.Drawing.Point(510, 233);
            this.dtpB.Name = "dtpB";
            this.dtpB.Size = new System.Drawing.Size(157, 26);
            this.dtpB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(688, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ת. לחידוש הביטוח";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(688, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ת. לחידוש טסט";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(688, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "מספר קמ שנסע";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(688, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "מיקום";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(688, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "דגם";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(688, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "כמות דלק במיכל";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(688, 544);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "תמונה";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(688, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "סניף";
            // 
            // cmbColor
            // 
            this.cmbColor.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "",
            "אדום",
            "כתום",
            "צהוב",
            "ירוק בהיר",
            "ירוק כהה",
            "כחול",
            "תכלת",
            "סגול",
            "ורוד",
            "אפור",
            "חום",
            "שחור",
            "לבן",
            "כסף",
            "זהב"});
            this.cmbColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbColor.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(386, 139);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(280, 24);
            this.cmbColor.TabIndex = 5;
            // 
            // dtpT
            // 
            this.dtpT.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpT.Location = new System.Drawing.Point(510, 277);
            this.dtpT.Name = "dtpT";
            this.dtpT.Size = new System.Drawing.Size(157, 26);
            this.dtpT.TabIndex = 3;
            // 
            // cmbPlace
            // 
            this.cmbPlace.Enabled = false;
            this.cmbPlace.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbPlace.FormattingEnabled = true;
            this.cmbPlace.Location = new System.Drawing.Point(443, 472);
            this.cmbPlace.Name = "cmbPlace";
            this.cmbPlace.Size = new System.Drawing.Size(223, 24);
            this.cmbPlace.TabIndex = 7;
            this.cmbPlace.SelectedIndexChanged += new System.EventHandler(this.cmbPlace_SelectedIndexChanged);
            // 
            // cmbDesign
            // 
            this.cmbDesign.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbDesign.FormattingEnabled = true;
            this.cmbDesign.Location = new System.Drawing.Point(443, 398);
            this.cmbDesign.Name = "cmbDesign";
            this.cmbDesign.Size = new System.Drawing.Size(223, 24);
            this.cmbDesign.TabIndex = 7;
            // 
            // cmbBranch
            // 
            this.cmbBranch.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(443, 358);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(223, 24);
            this.cmbBranch.TabIndex = 9;
            this.cmbBranch.SelectedIndexChanged += new System.EventHandler(this.cmbBranch_SelectedIndexChanged);
            this.cmbBranch.ValueMemberChanged += new System.EventHandler(this.cmbBranch_ValueMemberChanged);
            this.cmbBranch.SelectedValueChanged += new System.EventHandler(this.cmbBranch_SelectedValueChanged);
            this.cmbBranch.TabIndexChanged += new System.EventHandler(this.cmbBranch_TabIndexChanged);
            this.cmbBranch.TextChanged += new System.EventHandler(this.cmbBranch_TextChanged);
            this.cmbBranch.Click += new System.EventHandler(this.cmbBranch_Click);
            this.cmbBranch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbBranch_MouseClick);
            // 
            // pcbPicture
            // 
            this.pcbPicture.Location = new System.Drawing.Point(328, 601);
            this.pcbPicture.Name = "pcbPicture";
            this.pcbPicture.Size = new System.Drawing.Size(339, 166);
            this.pcbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPicture.TabIndex = 10;
            this.pcbPicture.TabStop = false;
            this.pcbPicture.Click += new System.EventHandler(this.pcbPicture_Click);
            // 
            // lblAddCar
            // 
            this.lblAddCar.BackColor = System.Drawing.Color.SteelBlue;
            this.lblAddCar.Font = new System.Drawing.Font("Ahla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAddCar.Location = new System.Drawing.Point(701, 44);
            this.lblAddCar.Name = "lblAddCar";
            this.lblAddCar.Size = new System.Drawing.Size(213, 31);
            this.lblAddCar.TabIndex = 0;
            this.lblAddCar.Text = "הוספת רכב";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(443, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "הקש מס רכב לחיפוש";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSearch.Location = new System.Drawing.Point(192, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(169, 34);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "חיפוש";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPicture.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPicture.Location = new System.Drawing.Point(328, 544);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(339, 51);
            this.btnPicture.TabIndex = 11;
            this.btnPicture.Text = "לחץ להוספת תמונה";
            this.btnPicture.UseVisualStyleBackColor = false;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDel.Enabled = false;
            this.btnDel.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDel.Location = new System.Drawing.Point(478, 779);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(152, 34);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "מחיקה";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdate.Location = new System.Drawing.Point(554, 779);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 34);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "עדכון";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdd.Location = new System.Drawing.Point(650, 779);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 34);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "הוספה";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNumForSerch
            // 
            this.txtNumForSerch.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNumForSerch.Location = new System.Drawing.Point(150, 48);
            this.txtNumForSerch.Name = "txtNumForSerch";
            this.txtNumForSerch.Size = new System.Drawing.Size(280, 23);
            this.txtNumForSerch.TabIndex = 4;
            this.txtNumForSerch.TextChanged += new System.EventHandler(this.txtNumForSerch_TextChanged);
            // 
            // txtnum
            // 
            this.txtnum.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtnum.Location = new System.Drawing.Point(386, 106);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(280, 23);
            this.txtnum.TabIndex = 4;
            // 
            // txtKm
            // 
            this.txtKm.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtKm.Location = new System.Drawing.Point(442, 318);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(224, 23);
            this.txtKm.TabIndex = 13;
            this.txtKm.Text = "0";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtAmount.Location = new System.Drawing.Point(443, 434);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(224, 23);
            this.txtAmount.TabIndex = 13;
            this.txtAmount.Text = "0";
            // 
            // frmShowCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(924, 823);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pcbPicture);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.cmbDesign);
            this.Controls.Add(this.cmbPlace);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.txtNumForSerch);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.dtpT);
            this.Controls.Add(this.dtpB);
            this.Controls.Add(this.chbFix);
            this.Controls.Add(this.chfound);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblAddCar);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Ahla", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "frmShowCars";
            this.Text = "frmShowCars";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmShowCars_FormClosed);
            this.Load += new System.EventHandler(this.frmShowCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.CheckBox chfound;
        private System.Windows.Forms.CheckBox chbFix;
        private System.Windows.Forms.DateTimePicker dtpB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private NumberTextBox txtnum;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.DateTimePicker dtpT;
        private System.Windows.Forms.ComboBox cmbPlace;
        private System.Windows.Forms.ComboBox cmbDesign;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.PictureBox pcbPicture;
        private System.Windows.Forms.Label lblAddCar;
        private Resources.MyButton btnAdd;
        private Resources.MyButton btnUpdate;
        private Resources.MyButton btnDel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Resources.MyButton btnPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private NumberTextBox txtNumForSerch;
        private System.Windows.Forms.Label label9;
        private Resources.MyButton btnSearch;
        private NumberAndPointTextBox txtAmount;
        private NumberAndPointTextBox txtKm;
    }
}