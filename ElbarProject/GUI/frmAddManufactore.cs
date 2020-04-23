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
    public partial class frmAddManufactore : Form
    {
        Manufacturer man=new Manufacturer ();
        ManufacturerTable mant=new ManufacturerTable();
        public frmAddManufactore()
        {
            InitializeComponent();
        }
        private void FillClass()
        {
            man.CoudeManufacturer = Convert.ToInt32(txtc.Text);
            man.NameManufacturer = txtn.Text;
        }
   
        private void btnok_Click(object sender, EventArgs e)
        {
            FillClass();
            mant.AddToAccess(man);
            txtn.Text = "";
            txtc.Text = "";
        }
    }
}
