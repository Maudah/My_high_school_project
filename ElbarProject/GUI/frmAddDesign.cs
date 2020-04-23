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
    public partial class frmAddDesign : Form
    {
        Design curentDesign = new Design();
        DesignTable curentTable = new DesignTable();
        public frmAddDesign()
        {
          
            InitializeComponent();
            ManufacturerTable ma = new ManufacturerTable();
            GroupTable gr = new GroupTable();
            Suport.FillCombox(cmbGroup, gr.GetTable(), "describeGroup", "coudeGroup");
            Suport.FillCombox(cmbManufactore , ma.GetTable(), "nameManufacturer", "coudeManufacturer");
            
            
            
        }
        private bool FillClass()
        {
            errorProvider1.Clear();
            bool f = true;
            //מעיה עם המספור האוטומטי
            curentDesign.CoudDesign =curentTable.GetNewKey(); 
            try {
                curentDesign.NameDesign = txtNameCoude.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNameCoude, ex.Message);
                f = false;
            }
            curentDesign.Manufacturer = Convert.ToInt32(cmbManufactore.SelectedValue);
            try {
                curentDesign.NumPlaces = Convert.ToInt32(txtNumPlaces.Text);
            }
            catch(Exception ex)
            {
                errorProvider1.SetError(txtNumPlaces, ex.Message);
                f = false;
            }
            curentDesign.Group = Convert.ToInt32(cmbGroup.SelectedValue);
            try {
                curentDesign.ManufacturYear = Convert.ToInt32(txtYeay.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtYeay, ex.Message);
                f = false;
            }
            try {
                curentDesign.VolumeMotor = Convert.ToInt32(txtAngine.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtAngine, ex.Message);
                f = false;
            }
            return f;
        }

        private void lblCode_Click(object sender, EventArgs e)
        {

        }

        private void frmAddDesign_Load(object sender, EventArgs e)
        {

        }
        
        private void btnOk_Click(object sender, EventArgs e)
         {
            if (FillClass())
            {
                curentTable.AddToAccess(curentDesign);
                MessageBox.Show("דגם התווסף בהצלחה");
                txtAngine.Text = "";
                txtNameCoude.Text = "";
                txtNumPlaces.Text = "";
                txtYeay.Text = "";
               
                
            }
        }

        private void cmbManufactore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
