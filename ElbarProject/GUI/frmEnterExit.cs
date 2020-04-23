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
    public partial class frmEnterExit : Form
    {
        Salary curentSalary = new Salary();
        SalaryTable curentSalaryTable = new SalaryTable();
        bool isnew;
        public frmEnterExit()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            try
            {
                Worker curentWorker = new Worker(txtId.Text);
                btnEnter.Enabled = true;
                btnExite.Enabled = true;

            }
            catch
            {
                MessageBox.Show("וודא שהקלדת נכון את הת.ז שלך");
            }
            
            FillClass();
            if (isnew == true)
                curentSalaryTable.AddToAccess(curentSalary);
            else
                curentSalaryTable.UpdateToAccess(curentSalary);
        }
        public void  FillClass()
        {
            string x = txtId.Text;
            string d = DateTime.Now.Day.ToString();
            string m = DateTime.Now.Month.ToString();
            string y = DateTime.Now.Year.ToString();
            string code = x + d + m + y;
            try
            {
                curentSalary = new Salary(code);
                isnew = false;
            }
            catch
            {
                curentSalary.SalaryCoud = code;
                isnew = true;
                curentSalary.CodeWorker = txtId.Text;
                curentSalary.TimeEnter = "0000";
                curentSalary.TimeLeave = "0000";
                curentSalary.DateToday = DateTime.Now.Day.ToString ()+"/"+ DateTime.Now.Month.ToString() ;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string hours = DateTime.Now.Hour.ToString();
            string minutes= DateTime.Now.Minute.ToString(); ;
            curentSalary.TimeEnter = hours + ":" + minutes;
            curentSalaryTable.UpdateToAccess(curentSalary);
            MessageBox.Show("עבודה נעימה");
        }

        private void btnExite_Click(object sender, EventArgs e)
        {
            string hours = DateTime.Now.Hour.ToString();
            string minutes = DateTime.Now.Minute.ToString(); ;
            curentSalary.TimeLeave = DateTime.Now.Hour.ToString() +":"+ DateTime.Now.Minute.ToString();
            curentSalaryTable.UpdateToAccess(curentSalary);
            MessageBox.Show("יום טוב");
        }
    }
}
