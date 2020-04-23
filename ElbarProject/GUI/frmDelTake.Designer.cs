namespace ElbarProject.GUI
{
    partial class frmDelTake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelTake));
            this.label1 = new System.Windows.Forms.Label();
            this.lblmessageupdate = new System.Windows.Forms.Label();
            this.txtCpde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.btnCode = new ElbarProject.Resources.MyButton();
            this.btnId = new ElbarProject.Resources.MyButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCarNum = new ElbarProject.NumberTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtId = new ElbarProject.NumberTextBox();
            this.grbTake = new System.Windows.Forms.GroupBox();
            this.txtCodeTake = new ElbarProject.NumberTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDel = new ElbarProject.Resources.MyButton();
            this.dgvTakes = new System.Windows.Forms.DataGridView();
            this.grbTake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(257, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(401, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "הקש קוד השכרה למחיקה (מופיע בראש דוח ההשכרה)";
            // 
            // lblmessageupdate
            // 
            this.lblmessageupdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblmessageupdate.Font = new System.Drawing.Font("Ahla", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblmessageupdate.Image = ((System.Drawing.Image)(resources.GetObject("lblmessageupdate.Image")));
            this.lblmessageupdate.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblmessageupdate.Location = new System.Drawing.Point(447, 33);
            this.lblmessageupdate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblmessageupdate.Name = "lblmessageupdate";
            this.lblmessageupdate.Size = new System.Drawing.Size(221, 36);
            this.lblmessageupdate.TabIndex = 2;
            this.lblmessageupdate.Text = "     ביטול הזמנה";
            this.lblmessageupdate.Visible = false;
            // 
            // txtCpde
            // 
            this.txtCpde.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtCpde.Location = new System.Drawing.Point(413, 110);
            this.txtCpde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCpde.Name = "txtCpde";
            this.txtCpde.Size = new System.Drawing.Size(150, 26);
            this.txtCpde.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(351, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(286, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "הקש ת.ז  לקוח לבחירת הזמנה לביטול";
            // 
            // txtIdClient
            // 
            this.txtIdClient.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtIdClient.Location = new System.Drawing.Point(413, 175);
            this.txtIdClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(150, 26);
            this.txtIdClient.TabIndex = 3;
            // 
            // btnCode
            // 
            this.btnCode.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCode.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCode.Location = new System.Drawing.Point(351, 110);
            this.btnCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(48, 26);
            this.btnCode.TabIndex = 4;
            this.btnCode.Text = "ok";
            this.btnCode.UseVisualStyleBackColor = false;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // btnId
            // 
            this.btnId.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnId.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnId.Location = new System.Drawing.Point(351, 174);
            this.btnId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(48, 27);
            this.btnId.TabIndex = 4;
            this.btnId.Text = "ok";
            this.btnId.UseVisualStyleBackColor = false;
            this.btnId.Click += new System.EventHandler(this.btnId_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ahla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(558, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "בחר שורה ";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarFont = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpFrom.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(289, 151);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(110, 26);
            this.dtpFrom.TabIndex = 6;
            // 
            // dtpTo
            // 
            this.dtpTo.CalendarFont = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(92, 151);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(110, 26);
            this.dtpTo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(369, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "מס\' רכב";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(369, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "טווח תאריכים";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(398, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "מתאריך";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(206, 157);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "עד תאריך";
            // 
            // txtCarNum
            // 
            this.txtCarNum.Location = new System.Drawing.Point(240, 55);
            this.txtCarNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCarNum.Name = "txtCarNum";
            this.txtCarNum.Size = new System.Drawing.Size(117, 22);
            this.txtCarNum.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(369, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "ת.ז לקוח";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(240, 83);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(117, 22);
            this.txtId.TabIndex = 7;
            // 
            // grbTake
            // 
            this.grbTake.Controls.Add(this.txtCodeTake);
            this.grbTake.Controls.Add(this.txtCarNum);
            this.grbTake.Controls.Add(this.txtId);
            this.grbTake.Controls.Add(this.label10);
            this.grbTake.Controls.Add(this.label5);
            this.grbTake.Controls.Add(this.label9);
            this.grbTake.Controls.Add(this.dtpTo);
            this.grbTake.Controls.Add(this.label6);
            this.grbTake.Controls.Add(this.dtpFrom);
            this.grbTake.Controls.Add(this.label7);
            this.grbTake.Controls.Add(this.label8);
            this.grbTake.Location = new System.Drawing.Point(101, 340);
            this.grbTake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTake.Name = "grbTake";
            this.grbTake.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTake.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbTake.Size = new System.Drawing.Size(532, 218);
            this.grbTake.TabIndex = 8;
            this.grbTake.TabStop = false;
            this.grbTake.Text = "פרטי השכרה";
            // 
            // txtCodeTake
            // 
            this.txtCodeTake.Location = new System.Drawing.Point(240, 22);
            this.txtCodeTake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodeTake.Name = "txtCodeTake";
            this.txtCodeTake.Size = new System.Drawing.Size(117, 22);
            this.txtCodeTake.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(369, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(94, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "קוד השכרה";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDel.Location = new System.Drawing.Point(52, 602);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(143, 49);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "מחיקה";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dgvTakes
            // 
            this.dgvTakes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTakes.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgvTakes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakes.Location = new System.Drawing.Point(10, 238);
            this.dgvTakes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTakes.MultiSelect = false;
            this.dgvTakes.Name = "dgvTakes";
            this.dgvTakes.ReadOnly = true;
            this.dgvTakes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTakes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTakes.Size = new System.Drawing.Size(644, 85);
            this.dgvTakes.TabIndex = 10;
            this.dgvTakes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmDelTake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(665, 739);
            this.Controls.Add(this.dgvTakes);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.grbTake);
            this.Controls.Add(this.btnId);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.txtIdClient);
            this.Controls.Add(this.txtCpde);
            this.Controls.Add(this.lblmessageupdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Ahla", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "frmDelTake";
            this.Text = "frmDelTake";
            this.Load += new System.EventHandler(this.frmDelTake_Load);
            this.grbTake.ResumeLayout(false);
            this.grbTake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmessageupdate;
        private System.Windows.Forms.TextBox txtCpde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdClient;
        private Resources.MyButton btnCode;
        private Resources.MyButton btnId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private NumberTextBox txtCarNum;
        private System.Windows.Forms.Label label9;
        private NumberTextBox txtId;
        private System.Windows.Forms.GroupBox grbTake;
        private NumberTextBox txtCodeTake;
        private System.Windows.Forms.Label label10;
        private Resources.MyButton btnDel;
        private System.Windows.Forms.DataGridView dgvTakes;
    }
}