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
    public partial class frmAddFix : Form
    {
        
        bool flag = true;
        Fixs curentFix = new Fixs();
        FixsTable curentFixTable = new FixsTable();
        string addUpdate;
        public frmAddFix(string au)
        {
            InitializeComponent();
            addUpdate = au;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (addUpdate == "add")
            {
                if (FillClass() == true)
                {
                    curentFixTable.AddToAccess(curentFix);
                    MessageBox.Show("תיקון התווסף בהצלחה");
                    Car curentCar = new Car(curentFix.CarNumber);
                    curentCar.Fix = false ;
                    CarTable curentTable = new CarTable();
                    curentTable.UpdateToAccess(curentCar);
                    lblSearch.Visible = false;
                    txtSearch.Visible = false;
                    btnSearsh.Visible = false;
                }
            }
            if(addUpdate=="update")
            {
                try
                {
                    curentFix = new Fixs(Convert.ToInt32(txtSearch.Text));
                    if (FillClass() == true)
                    {
                        curentFixTable.AddToAccess(curentFix);
                        MessageBox.Show("תיקון התעדכן בהצלחה");
                    }

                }
                catch
                {
                    MessageBox.Show("לא נמצאו תיקונים מתאימים");
                }
            }



        }
        private bool FillClass()
        {
            try
            {
                Car curentCar = new Car(txtCar.Text);
                curentFix.CarNumber = txtCar.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCar, ex.Message);
                flag = false;
            }
            if (txtClient.Text == "חברה")
            {
                Client curentClient = new Client("22529473");
                curentFix.IDClient = txtClient.Text;
            }
            else
            {
                try
                {

                    Client curentClient = new Client(txtClient.Text);
                    curentFix.IDClient = txtClient.Text;
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(txtClient, ex.Message);
                    flag = false;
                }
            }
            try {
                curentFix.DescribeFix = txtFix.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtFix, ex.Message);
                flag = false;
            }
            
            curentFix.DescribeDamage = " ";         
            curentFix.FixCoude = curentFixTable.GetNewKey();
            curentFix.IsFix = false;
            curentFix.ToPay = 0;
            return flag;
        }

        private void btnSearsh_Click(object sender, EventArgs e)
        {
            

        }
        private void FillTXT()
        {
            txtCar.Text = curentFix.CarNumber;
            txtClient.Text = curentFix.IDClient;
            txtFix.Text = curentFix.DescribeFix;
        }

        private void frmAddFix_Load(object sender, EventArgs e)
        {

        }

        private void myButton1_Click(object sender, EventArgs e)
        {
           
            txtClient.Text = "חברה";

        }
    }
}
