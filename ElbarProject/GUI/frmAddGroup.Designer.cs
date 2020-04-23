namespace ElbarProject.GUI
{
    partial class frmAddGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddGroup));
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblDiscribe = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblWeek = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblSelf = new System.Windows.Forms.Label();
            this.lblInsurance = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOk = new ElbarProject.Resources.MyButton();
            this.txtInsurance = new ElbarProject.NumberTextBox();
            this.txtSelf = new ElbarProject.NumberTextBox();
            this.txtHour = new ElbarProject.NumberTextBox();
            this.txtKm = new ElbarProject.NumberTextBox();
            this.txtMonth = new ElbarProject.NumberTextBox();
            this.txtWeek = new ElbarProject.NumberTextBox();
            this.txtDay = new ElbarProject.NumberTextBox();
            this.txtDiscribe = new ElbarProject.HebrewTextBox();
            this.txtName = new ElbarProject.LetterTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblMessage.Font = new System.Drawing.Font("Ahla", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblMessage.Image")));
            this.lblMessage.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblMessage.Location = new System.Drawing.Point(487, 67);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(209, 43);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "הוספת קבוצה      ";
            // 
            // lblDiscribe
            // 
            this.lblDiscribe.AutoSize = true;
            this.lblDiscribe.Location = new System.Drawing.Point(488, 160);
            this.lblDiscribe.Name = "lblDiscribe";
            this.lblDiscribe.Size = new System.Drawing.Size(98, 19);
            this.lblDiscribe.TabIndex = 1;
            this.lblDiscribe.Text = "תיאור קבוצה";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(488, 188);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "שם קבוצה";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(488, 217);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(81, 19);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "תעריף יומי";
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Location = new System.Drawing.Point(488, 246);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(98, 19);
            this.lblWeek.TabIndex = 1;
            this.lblWeek.Text = "תעריף שבועי";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(488, 277);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(100, 19);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "תעריף חודשי";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(488, 306);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(118, 19);
            this.lblKm.TabIndex = 1;
            this.lblKm.Text = "מחיר לק\'מ נוסף";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(488, 337);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(138, 19);
            this.lblHour.TabIndex = 1;
            this.lblHour.Text = "מחיר לשעה נוספת";
            // 
            // lblSelf
            // 
            this.lblSelf.AutoSize = true;
            this.lblSelf.Location = new System.Drawing.Point(488, 367);
            this.lblSelf.Name = "lblSelf";
            this.lblSelf.Size = new System.Drawing.Size(130, 19);
            this.lblSelf.TabIndex = 1;
            this.lblSelf.Text = "השתתפות עצמית";
            // 
            // lblInsurance
            // 
            this.lblInsurance.AutoSize = true;
            this.lblInsurance.Location = new System.Drawing.Point(488, 398);
            this.lblInsurance.Name = "lblInsurance";
            this.lblInsurance.Size = new System.Drawing.Size(94, 19);
            this.lblInsurance.TabIndex = 1;
            this.lblInsurance.Text = "ביטוח לרכב";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOk.Location = new System.Drawing.Point(375, 466);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(213, 55);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "אישור";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtInsurance
            // 
            this.txtInsurance.Location = new System.Drawing.Point(309, 393);
            this.txtInsurance.Name = "txtInsurance";
            this.txtInsurance.Size = new System.Drawing.Size(155, 26);
            this.txtInsurance.TabIndex = 4;
            // 
            // txtSelf
            // 
            this.txtSelf.Location = new System.Drawing.Point(309, 363);
            this.txtSelf.Name = "txtSelf";
            this.txtSelf.Size = new System.Drawing.Size(155, 26);
            this.txtSelf.TabIndex = 4;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(309, 333);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(155, 26);
            this.txtHour.TabIndex = 4;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(309, 303);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(155, 26);
            this.txtKm.TabIndex = 4;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(309, 273);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(155, 26);
            this.txtMonth.TabIndex = 4;
            // 
            // txtWeek
            // 
            this.txtWeek.Location = new System.Drawing.Point(309, 243);
            this.txtWeek.Name = "txtWeek";
            this.txtWeek.Size = new System.Drawing.Size(155, 26);
            this.txtWeek.TabIndex = 4;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(309, 213);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(155, 26);
            this.txtDay.TabIndex = 4;
            // 
            // txtDiscribe
            // 
            this.txtDiscribe.Location = new System.Drawing.Point(309, 153);
            this.txtDiscribe.Name = "txtDiscribe";
            this.txtDiscribe.Size = new System.Drawing.Size(156, 26);
            this.txtDiscribe.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(310, 183);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 26);
            this.txtName.TabIndex = 6;
            // 
            // frmAddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(708, 657);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtInsurance);
            this.Controls.Add(this.txtSelf);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtWeek);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtDiscribe);
            this.Controls.Add(this.lblInsurance);
            this.Controls.Add(this.lblSelf);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblWeek);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDiscribe);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmAddGroup";
            this.Text = "הוספת קבוצה";
            this.Load += new System.EventHandler(this.frmAddGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblDiscribe;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblSelf;
        private System.Windows.Forms.Label lblInsurance;
        private HebrewTextBox txtDiscribe;
        private NumberTextBox txtDay;
        private NumberTextBox txtWeek;
        private NumberTextBox txtMonth;
        private NumberTextBox txtKm;
        private NumberTextBox txtHour;
        private NumberTextBox txtSelf;
        private NumberTextBox txtInsurance;
        private Resources.MyButton btnOk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private LetterTextBox txtName;
    }
}