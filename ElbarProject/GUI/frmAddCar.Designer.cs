namespace ElbarProject.GUI
{
    partial class frmAddCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCar));
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblKM = new System.Windows.Forms.Label();
            this.lblAmountGaz = new System.Windows.Forms.Label();
            this.lblPicture = new System.Windows.Forms.Label();
            this.rdbFix = new System.Windows.Forms.RadioButton();
            this.rdbFind = new System.Windows.Forms.RadioButton();
            this.lblDateTest = new System.Windows.Forms.Label();
            this.lblDateB = new System.Windows.Forms.Label();
            this.lblDesign = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblParking = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblMessage.Font = new System.Drawing.Font("Ahla", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblMessage.Image")));
            this.lblMessage.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblMessage.Location = new System.Drawing.Point(514, 43);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(227, 37);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "הוספת רכב";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNum.Location = new System.Drawing.Point(617, 123);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(69, 19);
            this.lblNum.TabIndex = 4;
            this.lblNum.Text = "מס\' רכב";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblColor.Location = new System.Drawing.Point(617, 180);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(39, 19);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "צבע";
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblKM.Location = new System.Drawing.Point(617, 142);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(76, 19);
            this.lblKM.TabIndex = 4;
            this.lblKM.Text = "ק\'מ שנסע";
            // 
            // lblAmountGaz
            // 
            this.lblAmountGaz.AutoSize = true;
            this.lblAmountGaz.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAmountGaz.Location = new System.Drawing.Point(617, 161);
            this.lblAmountGaz.Name = "lblAmountGaz";
            this.lblAmountGaz.Size = new System.Drawing.Size(96, 19);
            this.lblAmountGaz.TabIndex = 4;
            this.lblAmountGaz.Text = "כמות במיכל";
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPicture.Location = new System.Drawing.Point(617, 351);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(51, 19);
            this.lblPicture.TabIndex = 4;
            this.lblPicture.Text = "תמונה";
            // 
            // rdbFix
            // 
            this.rdbFix.AutoSize = true;
            this.rdbFix.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rdbFix.Location = new System.Drawing.Point(617, 202);
            this.rdbFix.Name = "rdbFix";
            this.rdbFix.Size = new System.Drawing.Size(66, 23);
            this.rdbFix.TabIndex = 5;
            this.rdbFix.TabStop = true;
            this.rdbFix.Text = "תקין?";
            this.rdbFix.UseVisualStyleBackColor = true;
            // 
            // rdbFind
            // 
            this.rdbFind.AutoSize = true;
            this.rdbFind.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rdbFind.Location = new System.Drawing.Point(617, 225);
            this.rdbFind.Name = "rdbFind";
            this.rdbFind.Size = new System.Drawing.Size(72, 23);
            this.rdbFind.TabIndex = 5;
            this.rdbFind.TabStop = true;
            this.rdbFind.Text = "נמצא?";
            this.rdbFind.UseVisualStyleBackColor = true;
            // 
            // lblDateTest
            // 
            this.lblDateTest.AutoSize = true;
            this.lblDateTest.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDateTest.Location = new System.Drawing.Point(617, 251);
            this.lblDateTest.Name = "lblDateTest";
            this.lblDateTest.Size = new System.Drawing.Size(118, 19);
            this.lblDateTest.TabIndex = 4;
            this.lblDateTest.Text = "ת. לחידוש טסט";
            // 
            // lblDateB
            // 
            this.lblDateB.AutoSize = true;
            this.lblDateB.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDateB.Location = new System.Drawing.Point(617, 270);
            this.lblDateB.Name = "lblDateB";
            this.lblDateB.Size = new System.Drawing.Size(125, 19);
            this.lblDateB.TabIndex = 4;
            this.lblDateB.Text = "ת. לחידוש ביטוח";
            // 
            // lblDesign
            // 
            this.lblDesign.AutoSize = true;
            this.lblDesign.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDesign.Location = new System.Drawing.Point(615, 308);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(38, 19);
            this.lblDesign.TabIndex = 4;
            this.lblDesign.Text = "דגם";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBranch.Location = new System.Drawing.Point(615, 327);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(39, 19);
            this.lblBranch.TabIndex = 4;
            this.lblBranch.Text = "סניף";
            // 
            // lblParking
            // 
            this.lblParking.AutoSize = true;
            this.lblParking.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblParking.Location = new System.Drawing.Point(617, 289);
            this.lblParking.Name = "lblParking";
            this.lblParking.Size = new System.Drawing.Size(40, 19);
            this.lblParking.TabIndex = 4;
            this.lblParking.Text = "חניה";
            // 
            // frmAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(743, 700);
            this.Controls.Add(this.rdbFind);
            this.Controls.Add(this.rdbFix);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.lblDesign);
            this.Controls.Add(this.lblParking);
            this.Controls.Add(this.lblDateB);
            this.Controls.Add(this.lblDateTest);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.lblAmountGaz);
            this.Controls.Add(this.lblKM);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblMessage);
            this.Name = "frmAddCar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmAddCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label lblAmountGaz;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.RadioButton rdbFix;
        private System.Windows.Forms.RadioButton rdbFind;
        private System.Windows.Forms.Label lblDateTest;
        private System.Windows.Forms.Label lblDateB;
        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblParking;
    }
}