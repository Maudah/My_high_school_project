namespace ElbarProject.GUI
{
    partial class frmCarsFromDGV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chbFix = new System.Windows.Forms.CheckBox();
            this.chbFind = new System.Windows.Forms.CheckBox();
            this.lblAddCar = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtDesign = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.txtADDkm = new ElbarProject.NumberTextBox();
            this.txtHoure = new ElbarProject.NumberTextBox();
            this.txtMonth = new ElbarProject.NumberTextBox();
            this.txtWeek = new ElbarProject.NumberTextBox();
            this.txtDay = new ElbarProject.NumberTextBox();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblHoure = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblWeek = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValumeMotore = new ElbarProject.NumberTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(618, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "מספר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(618, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "דגם";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(618, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "צבע";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(618, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "קבוצה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(618, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "סניף";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(618, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "מס\' ק\'מ שנסע";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(618, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "תמונה";
            // 
            // chbFix
            // 
            this.chbFix.AutoSize = true;
            this.chbFix.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chbFix.Location = new System.Drawing.Point(618, 385);
            this.chbFix.Name = "chbFix";
            this.chbFix.Size = new System.Drawing.Size(67, 23);
            this.chbFix.TabIndex = 1;
            this.chbFix.Text = "תקין?";
            this.chbFix.UseVisualStyleBackColor = true;
            // 
            // chbFind
            // 
            this.chbFind.AutoSize = true;
            this.chbFind.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chbFind.Location = new System.Drawing.Point(618, 417);
            this.chbFind.Name = "chbFind";
            this.chbFind.Size = new System.Drawing.Size(77, 23);
            this.chbFind.TabIndex = 1;
            this.chbFind.Text = "נמצא? ";
            this.chbFind.UseVisualStyleBackColor = true;
            this.chbFind.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // lblAddCar
            // 
            this.lblAddCar.BackColor = System.Drawing.Color.SteelBlue;
            this.lblAddCar.Font = new System.Drawing.Font("Ahla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAddCar.Location = new System.Drawing.Point(540, 74);
            this.lblAddCar.Name = "lblAddCar";
            this.lblAddCar.Size = new System.Drawing.Size(183, 31);
            this.lblAddCar.TabIndex = 2;
            this.lblAddCar.Text = "הצגת רכב";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Ahla", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNum.Location = new System.Drawing.Point(435, 139);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(166, 22);
            this.txtNum.TabIndex = 3;
            // 
            // txtDesign
            // 
            this.txtDesign.Font = new System.Drawing.Font("Ahla", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtDesign.Location = new System.Drawing.Point(435, 172);
            this.txtDesign.Name = "txtDesign";
            this.txtDesign.Size = new System.Drawing.Size(166, 22);
            this.txtDesign.TabIndex = 3;
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Ahla", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtColor.Location = new System.Drawing.Point(435, 203);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(166, 22);
            this.txtColor.TabIndex = 3;
            // 
            // txtGroup
            // 
            this.txtGroup.Font = new System.Drawing.Font("Ahla", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtGroup.Location = new System.Drawing.Point(435, 236);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(166, 22);
            this.txtGroup.TabIndex = 3;
            // 
            // txtBranch
            // 
            this.txtBranch.Font = new System.Drawing.Font("Ahla", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtBranch.Location = new System.Drawing.Point(435, 270);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(166, 22);
            this.txtBranch.TabIndex = 3;
            // 
            // txtKm
            // 
            this.txtKm.Font = new System.Drawing.Font("Ahla", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtKm.Location = new System.Drawing.Point(435, 300);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(166, 22);
            this.txtKm.TabIndex = 3;
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(379, 465);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(290, 223);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 4;
            this.picture.TabStop = false;
            // 
            // txtADDkm
            // 
            this.txtADDkm.Enabled = false;
            this.txtADDkm.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtADDkm.Location = new System.Drawing.Point(166, 259);
            this.txtADDkm.Name = "txtADDkm";
            this.txtADDkm.Size = new System.Drawing.Size(60, 26);
            this.txtADDkm.TabIndex = 10;
            // 
            // txtHoure
            // 
            this.txtHoure.Enabled = false;
            this.txtHoure.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtHoure.Location = new System.Drawing.Point(166, 230);
            this.txtHoure.Name = "txtHoure";
            this.txtHoure.Size = new System.Drawing.Size(60, 26);
            this.txtHoure.TabIndex = 11;
            // 
            // txtMonth
            // 
            this.txtMonth.Enabled = false;
            this.txtMonth.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMonth.Location = new System.Drawing.Point(166, 202);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(60, 26);
            this.txtMonth.TabIndex = 12;
            // 
            // txtWeek
            // 
            this.txtWeek.Enabled = false;
            this.txtWeek.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtWeek.Location = new System.Drawing.Point(166, 171);
            this.txtWeek.Name = "txtWeek";
            this.txtWeek.Size = new System.Drawing.Size(60, 26);
            this.txtWeek.TabIndex = 13;
            // 
            // txtDay
            // 
            this.txtDay.Enabled = false;
            this.txtDay.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtDay.Location = new System.Drawing.Point(166, 142);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(60, 26);
            this.txtDay.TabIndex = 14;
            this.txtDay.TextChanged += new System.EventHandler(this.txtDay_TextChanged);
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblKm.Location = new System.Drawing.Point(256, 261);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(106, 16);
            this.lblKm.TabIndex = 5;
            this.lblKm.Text = "מחיר לק\'מ נוסף";
            // 
            // lblHoure
            // 
            this.lblHoure.AutoSize = true;
            this.lblHoure.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHoure.Location = new System.Drawing.Point(241, 232);
            this.lblHoure.Name = "lblHoure";
            this.lblHoure.Size = new System.Drawing.Size(122, 16);
            this.lblHoure.TabIndex = 6;
            this.lblHoure.Text = "מחיר לשעה נוספת";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMonth.Location = new System.Drawing.Point(274, 204);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(87, 16);
            this.lblMonth.TabIndex = 7;
            this.lblMonth.Text = "מחיר לחודש";
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWeek.Location = new System.Drawing.Point(275, 173);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(86, 16);
            this.lblWeek.TabIndex = 8;
            this.lblWeek.Text = "מחיר לשבוע";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDay.Location = new System.Drawing.Point(290, 144);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(70, 16);
            this.lblDay.TabIndex = 9;
            this.lblDay.Text = "מחיר ליום";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(618, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "נפח מנוע";
            // 
            // txtValumeMotore
            // 
            this.txtValumeMotore.Font = new System.Drawing.Font("Ahla", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtValumeMotore.Location = new System.Drawing.Point(435, 334);
            this.txtValumeMotore.Name = "txtValumeMotore";
            this.txtValumeMotore.Size = new System.Drawing.Size(165, 22);
            this.txtValumeMotore.TabIndex = 15;
            // 
            // frmCarsFromDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(729, 701);
            this.Controls.Add(this.txtValumeMotore);
            this.Controls.Add(this.txtADDkm);
            this.Controls.Add(this.txtHoure);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtWeek);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblHoure);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblWeek);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtDesign);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblAddCar);
            this.Controls.Add(this.chbFind);
            this.Controls.Add(this.chbFix);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Enabled = false;
            this.Name = "frmCarsFromDGV";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmCarsFromDGV";
            this.Load += new System.EventHandler(this.frmCarsFromDGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chbFix;
        private System.Windows.Forms.CheckBox chbFind;
        private System.Windows.Forms.Label lblAddCar;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtDesign;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.PictureBox picture;
        private NumberTextBox txtADDkm;
        private NumberTextBox txtHoure;
        private NumberTextBox txtMonth;
        private NumberTextBox txtWeek;
        private NumberTextBox txtDay;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblHoure;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label label8;
        private NumberTextBox txtValumeMotore;
    }
}