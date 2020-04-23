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
    public partial class frmAddBranch : Form
    {
        Branch curentBranch = new Branch();
        BranchTable curentTablt = new BranchTable();
        
        public frmAddBranch()
        {
            InitializeComponent();
            CityTable ctt = new CityTable();
            Suport.FillCombox(cmbCity, ctt.GetTable (), "nameCity", "coudeCity");
            WorkerTable CurentWorker = new WorkerTable();
            Suport.FillCombox(cmbMenager, CurentWorker.GetMenager(), "fullName", "idWorker");        }

        private void frmAddBranch_Load(object sender, EventArgs e)
        {

        }
        private bool  FillClass()
        {
            bool fla=true;
            curentBranch.BranchCoude = curentTablt.GetNewKey();
            curentBranch.Manager = Convert.ToInt32(cmbMenager.SelectedValue);
            curentBranch.City =Convert.ToInt32 ( cmbCity.SelectedValue);
            try
            {
                curentBranch.BranchName = txtName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtName , ex.Message);
                fla = false;
            }
            try
            {
                curentBranch.Address = txtAddress.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtAddress, ex.Message);
                fla = false;
            }
            return fla;
        }
        private   void  AddParking(int x,int y)
        {
            string names;
            ParkingInBranch curentp = new ParkingInBranch();
            ParkingInBranchTable curentPTable = new ParkingInBranchTable();
            for (int i = 0; i < x;i++)
            {
                for (int j=0;j<=y;j++)
                {
                    names = Convert.ToString(j);
                    curentp.CoudParking = curentPTable.GetNewKey();
                    curentp.CoudeBranch = curentBranch.BranchCoude;
                    curentp.Fullparking = false;
                    if (i == 0 && j == 0)
                        curentp.NumParking = "";
                    else
                    {
                        if (i == 0)
                        {
                            curentp.NumParking = "A/" + names;
                        }
                        if (i == 1)
                        {
                            curentp.NumParking = "B/" + names;
                        }
                        if (i == 2)
                        {
                            curentp.NumParking = "C/" + names;
                        }
                    }
                    curentPTable.AddToAccess(curentp);
                }
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (FillClass())
            {
                curentTablt.AddToAccess(curentBranch);
                AddParking(Convert.ToInt32 (txtNumT.Text ),Convert.ToInt32 (txtNumL.Text ));
                MessageBox.Show("הסניף התווסף בהצלחה");
                this.Close();
            }
        }
    }
}
