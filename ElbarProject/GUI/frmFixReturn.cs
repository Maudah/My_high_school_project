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
    public partial class frmFixReturn : Form
    {
        Fixs curentFix = new Fixs();
        FixsTable curentFixTable = new FixsTable();
        Client curentClient = new Client();
        bool flag = true;
        public frmFixReturn()
        {
            InitializeComponent();
        }

        private void btnSearsh_Click(object sender, EventArgs e)
        {
            try
            {
                curentFix = new Fixs(Convert.ToInt32(txtSearch.Text));
                FillTXT();
            }
            catch
            {
                MessageBox.Show("לא נמצאו תיקונים מתאימים");
            }
        }
        private void FillTXT()
        {
            txtCar.Text = curentFix.CarNumber;
            txtClient.Text = curentFix.IDClient;
            txtFix.Text = curentFix.DescribeFix;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                curentFix = new Fixs(Convert.ToInt32(txtSearch.Text));
                if (FillClass() == true)
                {
                    curentFixTable.UpdateToAccess (curentFix);
                    MessageBox.Show("תיקון התעדכן בהצלחה");
                    Car curentCar = new Car(curentFix.CarNumber);
                    curentCar.Fix = true;
                    CarTable curentTable = new CarTable();
                    curentTable.UpdateToAccess(curentCar);
                }

            }
            catch
            {
                MessageBox.Show("לא נמצאו תיקונים מתאימים");
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
            try
            {
                 curentClient = new Client(txtClient.Text);
                curentFix.IDClient = txtClient.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtClient, ex.Message);
                flag = false;
            }
            try
            {
                curentFix.DescribeFix = txtFix.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtFix, ex.Message);
                flag = false;
            }
            try
            {
                curentFix.DescribeDamage = txtDamage.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtDamage, ex.Message);
                flag = false;
            }
            try
            {
                curentFix.ToPay = Convert.ToInt32(txtToPay.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtToPay, ex.Message);
                flag = false;
            }
            curentFix.IsFix = true ;
            try
            {
                curentClient = new Client(txtClient.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtClient, ex.Message);
                flag = false;
            }
        
            lblMesage.Text = "תשלום התיקון יגבה מ " + curentClient.FirstName + " " + curentClient.LastName + " ";
            return flag;
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            frmAddCreditCard f1 = new frmAddCreditCard();
            f1.ShowDialog();
            CreditCardTable curentT = new CreditCardTable();
            Suport.FillCombox(cmbCardForPay, curentT.GetCards(txtClient.Text), "numCard", "coudcCeditCard");
        }

        private void txtClient_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CreditCardTable curentT = new CreditCardTable();
                Suport.FillCombox(cmbCardForPay, curentT.GetCards(txtClient.Text), "numCard", "coudcCeditCard");
            }
            catch { }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            frmAddShowClient f1 = new frmAddShowClient(txtClient.Text );
            f1.Show();

        }
    }
}
