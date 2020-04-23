namespace ElbarProject.GUI
{
    partial class frmSearchCars
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
            this.lblDesign = new System.Windows.Forms.Label();
            this.lblNumPlaces = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblWorker = new System.Windows.Forms.Label();
            this.dgvTableCar = new System.Windows.Forms.DataGridView();
            this.chbBranch = new System.Windows.Forms.CheckBox();
            this.lblRarif = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblWeek = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblHoure = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNotice = new System.Windows.Forms.Label();
            this.lblNumCar = new System.Windows.Forms.Label();
            this.lblValueMotor = new System.Windows.Forms.Label();
            this.txtCarNum = new ElbarProject.NumberTextBox();
            this.btnReturn = new ElbarProject.Resources.MyButton();
            this.btnSearch = new ElbarProject.Resources.MyButton();
            this.txtttt = new ElbarProject.LetterTextBox();
            this.txtNumPlaces = new ElbarProject.NumberTextBox();
            this.txtKm = new ElbarProject.NumberTextBox();
            this.txtHoure = new ElbarProject.NumberTextBox();
            this.txtMonth = new ElbarProject.NumberTextBox();
            this.txtWeek = new ElbarProject.NumberTextBox();
            this.txtDay = new ElbarProject.NumberTextBox();
            this.txtValueMotor = new ElbarProject.NumberTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblMessage.Font = new System.Drawing.Font("Ahla", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMessage.Location = new System.Drawing.Point(959, 33);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMessage.Size = new System.Drawing.Size(168, 32);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "חיפוש רכב:  ";
            // 
            // lblDesign
            // 
            this.lblDesign.AutoSize = true;
            this.lblDesign.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDesign.Location = new System.Drawing.Point(1068, 79);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(38, 19);
            this.lblDesign.TabIndex = 2;
            this.lblDesign.Text = "דגם";
            // 
            // lblNumPlaces
            // 
            this.lblNumPlaces.AutoSize = true;
            this.lblNumPlaces.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNumPlaces.Location = new System.Drawing.Point(1016, 114);
            this.lblNumPlaces.Name = "lblNumPlaces";
            this.lblNumPlaces.Size = new System.Drawing.Size(90, 19);
            this.lblNumPlaces.TabIndex = 2;
            this.lblNumPlaces.Text = "מס\' מקומות";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblClient.Location = new System.Drawing.Point(167, 33);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(85, 19);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "שלום לקוח";
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWorker.Location = new System.Drawing.Point(167, 33);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(84, 19);
            this.lblWorker.TabIndex = 2;
            this.lblWorker.Text = "שלום עובד";
            // 
            // dgvTableCar
            // 
            this.dgvTableCar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTableCar.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvTableCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableCar.Location = new System.Drawing.Point(234, 260);
            this.dgvTableCar.MultiSelect = false;
            this.dgvTableCar.Name = "dgvTableCar";
            this.dgvTableCar.ReadOnly = true;
            this.dgvTableCar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTableCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableCar.Size = new System.Drawing.Size(881, 481);
            this.dgvTableCar.TabIndex = 4;
            this.dgvTableCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableCar_CellClick);
            this.dgvTableCar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableCar_CellContentClick);
            this.dgvTableCar.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableCar_CellContentDoubleClick);
            // 
            // chbBranch
            // 
            this.chbBranch.AutoSize = true;
            this.chbBranch.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chbBranch.Location = new System.Drawing.Point(120, 113);
            this.chbBranch.Name = "chbBranch";
            this.chbBranch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbBranch.Size = new System.Drawing.Size(149, 20);
            this.chbBranch.TabIndex = 5;
            this.chbBranch.Text = "רכבים מכל הסניפים";
            this.chbBranch.UseVisualStyleBackColor = true;
            this.chbBranch.Visible = false;
            this.chbBranch.CheckedChanged += new System.EventHandler(this.chbBranch_CheckedChanged);
            // 
            // lblRarif
            // 
            this.lblRarif.AutoSize = true;
            this.lblRarif.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblRarif.Location = new System.Drawing.Point(53, 323);
            this.lblRarif.Name = "lblRarif";
            this.lblRarif.Size = new System.Drawing.Size(69, 19);
            this.lblRarif.TabIndex = 2;
            this.lblRarif.Text = "תעריפים";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblb.Location = new System.Drawing.Point(230, 77);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(39, 19);
            this.lblb.TabIndex = 2;
            this.lblb.Text = "סניף";
            // 
            // txtBranch
            // 
            this.txtBranch.Enabled = false;
            this.txtBranch.Location = new System.Drawing.Point(91, 78);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(133, 20);
            this.txtBranch.TabIndex = 6;
            this.txtBranch.TextChanged += new System.EventHandler(this.txtBranch_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ElbarProject.Properties.Resources.tring;
            this.pictureBox2.Location = new System.Drawing.Point(48, 644);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 97);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Ahla", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDay.Location = new System.Drawing.Point(143, 376);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(61, 15);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "מחיר ליום";
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Font = new System.Drawing.Font("Ahla", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWeek.Location = new System.Drawing.Point(128, 405);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(76, 15);
            this.lblWeek.TabIndex = 2;
            this.lblWeek.Text = "מחיר לשבוע";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Ahla", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMonth.Location = new System.Drawing.Point(127, 436);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(77, 15);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "מחיר לחודש";
            // 
            // lblHoure
            // 
            this.lblHoure.AutoSize = true;
            this.lblHoure.Font = new System.Drawing.Font("Ahla", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHoure.Location = new System.Drawing.Point(94, 464);
            this.lblHoure.Name = "lblHoure";
            this.lblHoure.Size = new System.Drawing.Size(110, 15);
            this.lblHoure.TabIndex = 2;
            this.lblHoure.Text = "מחיר לשעה נוספת";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Ahla", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblKm.Location = new System.Drawing.Point(109, 493);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(95, 15);
            this.lblKm.TabIndex = 2;
            this.lblKm.Text = "מחיר לק\'מ נוסף";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(575, 226);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpFrom.Size = new System.Drawing.Size(130, 26);
            this.dtpFrom.TabIndex = 14;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(399, 226);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpTo.Size = new System.Drawing.Size(130, 26);
            this.dtpTo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(706, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "טווח תאריכים להשכרה     מ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(535, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "עד ";
            // 
            // lblNotice
            // 
            this.lblNotice.Font = new System.Drawing.Font("Ahla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNotice.ForeColor = System.Drawing.Color.Red;
            this.lblNotice.Location = new System.Drawing.Point(308, 78);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNotice.Size = new System.Drawing.Size(275, 73);
            this.lblNotice.TabIndex = 17;
            this.lblNotice.Text = "הלקוח אינו יכול להשכיר רכב זה עקב גילו / סוג רישיונו";
            this.lblNotice.Visible = false;
            // 
            // lblNumCar
            // 
            this.lblNumCar.AutoSize = true;
            this.lblNumCar.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNumCar.Location = new System.Drawing.Point(1037, 154);
            this.lblNumCar.Name = "lblNumCar";
            this.lblNumCar.Size = new System.Drawing.Size(69, 19);
            this.lblNumCar.TabIndex = 18;
            this.lblNumCar.Text = "מס\' רכב";
            // 
            // lblValueMotor
            // 
            this.lblValueMotor.AutoSize = true;
            this.lblValueMotor.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblValueMotor.Location = new System.Drawing.Point(1032, 191);
            this.lblValueMotor.Name = "lblValueMotor";
            this.lblValueMotor.Size = new System.Drawing.Size(74, 19);
            this.lblValueMotor.TabIndex = 21;
            this.lblValueMotor.Text = "נפח מנוע ";
            // 
            // txtCarNum
            // 
            this.txtCarNum.Location = new System.Drawing.Point(897, 154);
            this.txtCarNum.Name = "txtCarNum";
            this.txtCarNum.Size = new System.Drawing.Size(113, 20);
            this.txtCarNum.TabIndex = 22;
            this.txtCarNum.TextChanged += new System.EventHandler(this.txtCarNum_TextChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReturn.Font = new System.Drawing.Font("Ahla", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnReturn.Location = new System.Drawing.Point(26, 579);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(156, 59);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "בחר שורה ולחץ כאן להמשך ההשכרה";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSearch.Location = new System.Drawing.Point(313, 221);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 33);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "חיפוש";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtttt
            // 
            this.txtttt.Location = new System.Drawing.Point(897, 80);
            this.txtttt.Name = "txtttt";
            this.txtttt.Size = new System.Drawing.Size(143, 20);
            this.txtttt.TabIndex = 13;
            this.txtttt.TextChanged += new System.EventHandler(this.txtttt_TextChanged);
            // 
            // txtNumPlaces
            // 
            this.txtNumPlaces.Location = new System.Drawing.Point(897, 115);
            this.txtNumPlaces.Name = "txtNumPlaces";
            this.txtNumPlaces.Size = new System.Drawing.Size(113, 20);
            this.txtNumPlaces.TabIndex = 11;
            this.txtNumPlaces.TextChanged += new System.EventHandler(this.txtNumPlaces_TextChanged);
            // 
            // txtKm
            // 
            this.txtKm.Enabled = false;
            this.txtKm.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtKm.Location = new System.Drawing.Point(19, 491);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(60, 26);
            this.txtKm.TabIndex = 3;
            // 
            // txtHoure
            // 
            this.txtHoure.Enabled = false;
            this.txtHoure.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtHoure.Location = new System.Drawing.Point(19, 462);
            this.txtHoure.Name = "txtHoure";
            this.txtHoure.Size = new System.Drawing.Size(60, 26);
            this.txtHoure.TabIndex = 3;
            // 
            // txtMonth
            // 
            this.txtMonth.Enabled = false;
            this.txtMonth.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMonth.Location = new System.Drawing.Point(19, 434);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(60, 26);
            this.txtMonth.TabIndex = 3;
            // 
            // txtWeek
            // 
            this.txtWeek.Enabled = false;
            this.txtWeek.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtWeek.Location = new System.Drawing.Point(19, 403);
            this.txtWeek.Name = "txtWeek";
            this.txtWeek.Size = new System.Drawing.Size(60, 26);
            this.txtWeek.TabIndex = 3;
            // 
            // txtDay
            // 
            this.txtDay.Enabled = false;
            this.txtDay.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtDay.Location = new System.Drawing.Point(19, 374);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(60, 26);
            this.txtDay.TabIndex = 3;
            // 
            // txtValueMotor
            // 
            this.txtValueMotor.Location = new System.Drawing.Point(897, 192);
            this.txtValueMotor.Name = "txtValueMotor";
            this.txtValueMotor.Size = new System.Drawing.Size(90, 20);
            this.txtValueMotor.TabIndex = 23;
            this.txtValueMotor.TextChanged += new System.EventHandler(this.txtValueMotor_TextChanged);
            // 
            // frmSearchCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1127, 758);
            this.Controls.Add(this.txtValueMotor);
            this.Controls.Add(this.txtCarNum);
            this.Controls.Add(this.lblValueMotor);
            this.Controls.Add(this.lblNumCar);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.txtttt);
            this.Controls.Add(this.txtNumPlaces);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.chbBranch);
            this.Controls.Add(this.dgvTableCar);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtHoure);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtWeek);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblHoure);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblWeek);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblRarif);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lblNumPlaces);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDesign);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Ahla", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "frmSearchCars";
            this.Text = "frmSearchCars";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSearchCars_FormClosing);
            this.Load += new System.EventHandler(this.frmSearchCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.Label lblNumPlaces;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.DataGridView dgvTableCar;
        private System.Windows.Forms.CheckBox chbBranch;
        private System.Windows.Forms.Label lblRarif;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private NumberTextBox txtNumPlaces;
        private LetterTextBox txtttt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private NumberTextBox txtKm;
        private NumberTextBox txtHoure;
        private NumberTextBox txtMonth;
        private NumberTextBox txtWeek;
        private NumberTextBox txtDay;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblHoure;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Resources.MyButton btnSearch;
        private Resources.MyButton btnReturn;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Label lblValueMotor;
        private System.Windows.Forms.Label lblNumCar;
        private NumberTextBox txtCarNum;
        private NumberTextBox txtValueMotor;
    }
}