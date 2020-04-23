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
    public partial class frmSearchTake : Form
    {
        int branchc;
        string searhUpdate;
        public frmSearchTake(int branchC,string su)
        {
            InitializeComponent();
            branchc = branchC;
            searhUpdate = su;
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dtt = TakesTable.GetTableForSearch(txtId.Text);
            DataView dtv = new DataView(dtt);
            dgvTakes.DataSource = dtv;

        }

        private void dgvTakes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (searhUpdate == "search" || searhUpdate == "update")
            {
                int number = Convert.ToInt32(dgvTakes.SelectedRows[0].Cells[0].Value);
                frmTakeForLong  f1 = new frmTakeForLong (branchc,number ,searhUpdate );
                f1.Show();
            }
            else
            {
                frmCarReturn.codeTake= Convert.ToInt32(dgvTakes.SelectedRows[0].Cells[0].Value);
               
            }
            this.Close();

        }

        private void frmSearchTake_Load(object sender, EventArgs e)
        {

        }
    }
}
