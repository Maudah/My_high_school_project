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
    public partial class frmAddWorker : Form
    {
        string tsr;
        Worker curentWorker;
        WorkerTable curentTable = new WorkerTable();
        public frmAddWorker(String st)
        {
            tsr = st;
            InitializeComponent();            
            JobTable jt = new JobTable();            
            CityTable ct = new CityTable();
            Suport.FillCombox(cmbCity, ct.GetTable(), "nameCity", "coudeCity");
            WorkerTable wo = new WorkerTable();
            Suport.FillCombox(cmbBranch, wo.GetTable(), "branchName", "branchCoude");
            Suport.FillCombox(cmbJob, jt.GetTable(), "nameJob", "doudeJob");
           
            BranchTable curentb = new BranchTable();
            Suport.FillCombox(cmbBranch, curentb.GetTable(), "branchName", "branchCoude");
            if (st=="Add")
            {
                curentWorker = new Worker();
                lblAdd.Visible = true;
                lblUpdate.Visible = false;
                lblSearch.Visible = false;
                txtSearch.Visible = false;
                btnSearch.Visible = false;
                lblDel.Visible = false;
                txtSearch.Visible = false;
            }
            if (st == "Update")
            {
                lblAdd.Visible = false ;
                lblUpdate.Visible = true ;
                lblDel.Visible = false;
                txtSearch.Visible = true;
                txtID.Enabled = false;
            }
            if(st=="Del")
            {
                lblAdd.Visible = false;
                lblUpdate.Visible = false;
                lblDel.Visible = true;
                txtSearch.Visible = true;
            }
        }
        private bool  FillClass()
        {
            bool flag = true;
            try
            {
                curentWorker.IDWorker = txtID.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtID , ex.Message);
                flag = false;
            }
            try
            {
                curentWorker.FirstName = txtFirstName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtFirstName, ex.Message);
                flag = false;

            }
            try
            {
                curentWorker.LastName = txtLastName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtLastName, ex.Message);
                flag = false;

            }
            try
            {
                curentWorker.Address = txtAddress.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtAddress, ex.Message);
                flag = false;

            }
            try
            {
                curentWorker.HomeNum = Convert.ToInt32(txtNumHouse.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNumHouse, ex.Message);
                flag = false;

            }            
            curentWorker.JobCoude =Convert.ToInt32 (cmbJob.SelectedValue);            
            curentWorker.City =Convert.ToInt32 ( cmbCity.SelectedValue);
            try
            {
                curentWorker.Telephone = txtTel.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtTel , ex.Message);
                flag = false;
            }
            try { 
            curentWorker.Phone = txtPhone.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPhone, ex.Message);
                flag = false;
            }
            curentWorker.BranchCoude = Convert.ToInt32(cmbBranch.SelectedValue);
            curentWorker.Active = true;
            return flag;
        }
        
        private void cmbJob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAddWorker_Load(object sender, EventArgs e)
        {
            

        }
        private void FillTXT()
        {
            txtID.Text = curentWorker.IDWorker;
            txtFirstName.Text = curentWorker.FirstName;
            txtLastName.Text = curentWorker.LastName;
            txtAddress.Text = curentWorker.Address;
            txtNumHouse.Text = curentWorker.HomeNum.ToString();
            txtPhone.Text = curentWorker.Phone;
            txtTel.Text = curentWorker.Telephone;
            cmbBranch.SelectedValue = curentWorker.BranchCoude;
            cmbCity.SelectedValue = curentWorker.City;
            cmbJob.SelectedValue = curentWorker.JobCoude;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                curentWorker = new Worker(txtID.Text);
                if (FillClass() == true&& (tsr != "Del"))
                {

                    curentTable.UpdateToAccess(curentWorker);
                    MessageBox.Show("!עובד התעדכן בהצלחה");
                }
            }
            catch
            {
                if (FillClass() == true && tsr == "Add")
                {
                    curentTable.AddToAccess(curentWorker);
                    MessageBox.Show("!עובד התווסף בהצלחה");
                    txtAddress.Text = "";
                    txtFirstName.Text = "";
                    txtID.Text = "";
                    txtLastName.Text = "";
                    txtNumHouse.Text = "";
                    txtPhone.Text = "";
                    txtTel.Text = "";
                    txtTel.Text = "";
                    cmbBranch.Text = "";
                    cmbCity.Text = "";
                    cmbJob.Text = "";
                }
            }
            
            if(tsr=="Del")
            {
               
                if (WorkerTable.GetIfDelId(curentWorker.IDWorker))
                {
                    DialogResult dres = MessageBox.Show("האם למחוק", "אזהרת מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    if (dres == DialogResult.Yes)
                    {
                        curentTable.DeleteToAccess(curentWorker);
                        MessageBox.Show("עובד הוסר בהצלחה");
                    }
                }
                else
                    MessageBox.Show("לא ניתן למחוק את העובד המבוקש");


                    
            }
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
             
             try
             {
                 curentWorker = new Worker(txtSearch.Text);
                FillTXT();
             }
             catch (Exception ex)
             {
                 MessageBox.Show (ex.Message );
             }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
