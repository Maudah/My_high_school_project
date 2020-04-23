namespace ElbarProject.GUI
{
    partial class frmSearchTake
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
            this.dgvTakes = new System.Windows.Forms.DataGridView();
            this.btnSearch = new ElbarProject.Resources.MyButton();
            this.txtId = new ElbarProject.NumberTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblMessage.Font = new System.Drawing.Font("Ahla", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMessage.Location = new System.Drawing.Point(488, 58);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMessage.Size = new System.Drawing.Size(256, 32);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "          חיפוש השכרה";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "הקש ת.ז לחיפוש כל ההשכרות שלך";
            // 
            // dgvTakes
            // 
            this.dgvTakes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTakes.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgvTakes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakes.Location = new System.Drawing.Point(12, 242);
            this.dgvTakes.MultiSelect = false;
            this.dgvTakes.Name = "dgvTakes";
            this.dgvTakes.ReadOnly = true;
            this.dgvTakes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTakes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTakes.Size = new System.Drawing.Size(738, 349);
            this.dgvTakes.TabIndex = 6;
            this.dgvTakes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTakes_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.Location = new System.Drawing.Point(455, 150);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 35);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "חיפוש";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(537, 150);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(179, 26);
            this.txtId.TabIndex = 3;
            // 
            // frmSearchTake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(756, 710);
            this.Controls.Add(this.dgvTakes);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Ahla", 14.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmSearchTake";
            this.Text = "frmSearchTake";
            this.Load += new System.EventHandler(this.frmSearchTake_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private NumberTextBox txtId;
        private System.Windows.Forms.Label label1;
        private Resources.MyButton btnSearch;
        private System.Windows.Forms.DataGridView dgvTakes;
    }
}