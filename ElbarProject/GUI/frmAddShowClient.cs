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
    public partial class frmAddShowClient : Form
    {
        string str;
        Client curentClient = new Client();
        ClientTable curentTable = new ClientTable();
        public frmAddShowClient(string st)
        {
            InitializeComponent();
            CityTable ct = new CityTable();
            Suport.FillCombox(cmbCity, ct.GetTable(), "nameCity", "coudeCity");
            KindLicenseTable k = new KindLicenseTable();
            Suport.FillCombox(cmbLicenseKind, k.GetTable(), "nameLicense", "coudeLicense");
            str = st;
            if (st == "add")
            {
                lblMessage.Visible = true;
                btnOK.Visible = true;
                
            }
            if(st=="update")
            {
                lblmessageupdate.Visible = true;
                btnUpdate.Visible = true;
                lblSearch.Visible = true;
                txtSearch.Visible = true;
                btnSearch.Visible = true;
            }
            if (st == "search")
            {
                txtAddress.Enabled = false;
                txtDate .Enabled = false;
                txtFName .Enabled = false;
                txtID .Enabled = false;
                txtLicenseD1 .Enabled = false;
                txtLicenseD2 .Enabled = false;
                txtLicenseNum .Enabled = false;
                txtLName .Enabled = false;
                txtNum .Enabled = false;
                txtPhone .Enabled = false;
                txtTel.Enabled = false;
                lblSearch.Visible = true;
                txtSearch.Visible = true;
                btnSearch.Visible = true;
                lblSearch.Enabled  = true  ;
                txtSearch.Enabled = true;
                btnSearch.Enabled = true;
                cmbCity.Enabled = false;
                cmbLicenseKind.Enabled = false;
            }
            //else
            //{
            //   // txtSearch.Text = st;
            //    txtSearch.Enabled = false;
            //    txtAddress.Enabled = false;
            //    txtDate.Enabled = false;
            //    txtFName.Enabled = false;
            //    txtID.Enabled = false;
            //    txtLicenseD1.Enabled = false;
            //    txtLicenseD2.Enabled = false;
            //    txtLicenseNum.Enabled = false;
            //    txtLName.Enabled = false;
            //    txtNum.Enabled = false;
            //    txtPhone.Enabled = false;
            //    txtTel.Enabled = false;
            //    lblSearch.Visible = true;
            //    txtSearch.Visible = true;
            //    btnSearch.Visible = true;
            //    lblSearch.Enabled = true;
            //    txtSearch.Enabled = true;
            //    btnSearch.Enabled = true;
            //    cmbCity.Enabled = false;
            //    cmbLicenseKind.Enabled = false;
            //}
        }
        private bool  FillClass()
        { 
            bool flag =true;
            try
            {
                curentClient.IDclient = txtID.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtID, ex.Message);
                flag = false;
            }
            try
            {
                curentClient.FirstName = txtFName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtFName, ex.Message);
                flag = false;
            }
            try
            {
                curentClient.LastName = txtLName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtLName, ex.Message);
                flag = false;
            }
            try
            {
                curentClient.Address = txtAddress.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtAddress, ex.Message);
                flag = false;
            }          
            try
            {
                curentClient.NumHome = Convert.ToInt32(txtNum.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNum, ex.Message);
                flag = false ;
            }
            curentClient.City = Convert.ToInt32(cmbCity.SelectedValue);
            try
            {
                curentClient.BirthDate = Convert.ToDateTime(txtDate.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtDate, ex.Message);
                flag = false;
            }
            try
            {
                curentClient.Telephne = txtTel.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtTel , ex.Message);
                flag = false;
            }
            try
            {
                curentClient.Phone = txtPhone.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPhone , ex.Message);
                flag = false;
            }
            try
            {
                curentClient.NumLicense = Convert.ToInt32(txtLicenseNum.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtLicenseNum, ex.Message);
                flag = false;
            }
            
            try
            {
                curentClient.DateGetLisence = Convert.ToDateTime(txtLicenseD1.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtLicenseD1 , ex.Message);
                flag = false;
            }
            try
            {
                curentClient.ValibityLicense = Convert.ToDateTime(txtLicenseD2.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtLicenseD2 , ex.Message);
                flag = false;
            }
            curentClient.KindLicense = Convert.ToInt32(cmbLicenseKind.SelectedValue);
            return flag;
        }
        private void FillTXT()
        {
            txtID.Text = curentClient.IDclient;
            txtFName.Text = curentClient.FirstName;
            txtAddress.Text = curentClient.Address;
            txtDate.Value = curentClient.BirthDate;
            txtLicenseD1.Value = curentClient.DateGetLisence;
            txtLicenseD2.Value = curentClient.ValibityLicense;
            txtLicenseNum.Text = curentClient.NumLicense.ToString ();
            txtNum.Text = curentClient.NumHome.ToString();
            txtPhone.Text = curentClient.Phone;
            txtTel.Text = curentClient.Telephne;
            txtLName.Text = curentClient.LastName;
            cmbCity.SelectedValue = curentClient.City;
            cmbLicenseKind.SelectedValue = curentClient.KindLicense;

        }
            
        private void numberTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                curentClient = new Client(txtID.Text);
                if (FillClass() == true)
                {
                    curentTable.UpdateToAccess (curentClient);
                    MessageBox.Show("לקוח עודכן בהצלחה");
                }

            }
            catch
            {
                if (FillClass() == true)
                {
                    curentTable.AddToAccess(curentClient);
                    MessageBox.Show("לקוח התווסף בהצלחה");
                    txtAddress.Text = "";
                }
            }
        }

        private void frmAddShowClient_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                curentClient = new Client(txtSearch.Text);
                FillTXT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (FillClass() == true)
            {
                curentClient = new Client(txtSearch.Text);
                curentTable.UpdateToAccess (curentClient);
                MessageBox.Show("לקוח עודכן בהצלחה");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            curentClient = new Client(txtSearch.Text);
            if (FillClass() == true)
            {
               
                curentTable.UpdateToAccess(curentClient);
                MessageBox.Show("לקוח עודכן בהצלחה");
            }
        }
    }
}
