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
    public partial class frmAddCreditCard : Form
    {
        CreditCard curentCard = new CreditCard();
        CreditCardTable curentTable = new CreditCardTable();
        public frmAddCreditCard()
        {
            InitializeComponent();
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                curentCard = new CreditCard(Convert.ToInt32(txtCodeCard.Text));
                if(FillClass())
                {
                    curentTable.UpdateToAccess(curentCard);
                    MessageBox.Show("כרטיס התעדכן בהצלחה");
                }
            }
            catch
            {
                if (FillClass())
                {
                    curentTable.AddToAccess(curentCard);
                    MessageBox.Show("כרטיס התווסף בהצלחה");
                }
            }
            
        }
        private bool FillClass()
        {
            bool flag = true;
            try
            {
                curentCard.CoudcCeditCard = Convert.ToInt32(txtCodeCard.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCodeCard, ex.Message);
                flag = false;
            }
            try {
                curentCard.NumCard = Convert.ToInt32(txtNumCard.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNumCard, ex.Message);
                flag = false;
            }
            try
            {
                curentCard.Valibity = Convert.ToDateTime(txtDateCard.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            try
            {
                curentCard.IDclient = txtId.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtId, ex.Message);
                flag = false;
            }
            return flag;
        }
    }
    
}
