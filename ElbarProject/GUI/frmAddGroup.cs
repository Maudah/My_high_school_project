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
    public partial class frmAddGroup : Form
    {
        bool flag = true;
        Group curentGroup = new Group();
        GroupTable curentTable = new GroupTable();
        
        public frmAddGroup()
        {
            InitializeComponent();
        }
        private bool  FillClass()
        {
            curentGroup.CoudeGroup = curentTable.GetNewKey();
            try
            {
                curentGroup.DescribeGroup = txtDiscribe.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtDiscribe, ex.Message);
                flag = false;
            }
            try
            {
                curentGroup.NameGroup = txtName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtName, ex.Message);
                flag = false;
            }
            try
            {
                curentGroup.DayTariff = Convert.ToInt32(txtDay.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtDay, ex.Message);
                flag = false;
            }
            try
            {
                curentGroup.MonthTariff = Convert.ToInt32(txtMonth.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtMonth, ex.Message);
                flag = false;
            }
            try
            {
                curentGroup.WeekTarif = Convert.ToInt32(txtWeek.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtWeek, ex.Message);
                flag = false;
            }
            try
            {
                curentGroup.AddKM = Convert.ToInt32(txtKm.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtKm, ex.Message);
                flag = false;
            }
            try
            {
                curentGroup.AddKM = Convert.ToInt32(txtKm.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtKm, ex.Message);
                flag = false;
            }
            try
            {
                curentGroup.AddHour = Convert.ToInt32(txtHour.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtHour, ex.Message);
                flag = false;
            }
            try
            {
                curentGroup.CarInsurance = Convert.ToInt32(txtInsurance.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtInsurance, ex.Message);
                flag = false;
            }

            return flag;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (FillClass())
            {
                curentTable.AddToAccess(curentGroup);
                MessageBox.Show("קבוצה התווספה בהצלחה");
                txtDay.Text = "";
                txtDiscribe.Text = "";
                txtHour.Text = "";
                txtInsurance.Text = "";
                txtKm.Text = "";
                txtMonth.Text = "";
                txtName.Text = "";
                txtSelf.Text = "";
                txtWeek.Text = "";
            }
        }
            
        

        private void frmAddGroup_Load(object sender, EventArgs e)
        {

        }
    }
}
