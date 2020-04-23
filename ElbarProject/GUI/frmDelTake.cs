using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElbarProject.BLL;

namespace ElbarProject.GUI
{
    public partial class frmDelTake : Form
    {
        Takes curentTake = new Takes();
        TakesTable curentTakesTable = new TakesTable();
        Car curentCar = new Car();

        public frmDelTake()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmDelTake_Load(object sender, EventArgs e)
        {

        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            try
            {
                curentTake = new Takes(Convert.ToInt32(txtCpde.Text));
                txtCodeTake.Text = curentTake.NumTakes.ToString();
                txtCarNum.Text = curentTake.NumCar;
                txtId.Text = curentTake.IDclient;
                dtpFrom.Value =Convert.ToDateTime( curentTake.DateTake);
                dtpTo.Value = Convert.ToDateTime(curentTake.DateReturn);

                FillTXT();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "לא נמצאו פרטים תואמים נסו שוב / נסו באמצעות הקשת ת.ז של הלקוח המבוקש");
            }
        }
        private void FillTXT()
        {
            
        }

        private void btnId_Click(object sender, EventArgs e)
        {
           
            DataTable curntTable=curentTakesTable.GetDataTakes(txtIdClient.Text );
            DataView dgv = new DataView(curntTable);
            dgvTakes.DataSource = dgv;

        }

        private void dgvTakes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtCodeTake.Text == "")
                MessageBox.Show("בחר הזמנה למחיקה");
            else
            {

                DialogResult dres = MessageBox.Show("האם למחוק", "אזהרת מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (dres == DialogResult.Yes)
                {
                    curentTakesTable.DeleteToAccess(curentTake);
                    MessageBox.Show("הזמנה בוטלה בהצלחה");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int num = Convert.ToInt32(dgvTakes.SelectedRows[0].Cells[0].Value);
            curentTake = new Takes(num);
            txtCodeTake.Text = curentTake.NumTakes.ToString();
            txtCarNum.Text = curentTake.NumCar;
            txtId.Text = curentTake.IDclient;
            dtpFrom.Text = curentTake.DateTake;
            dtpTo.Text = curentTake.DateReturn;

        }
    }
}