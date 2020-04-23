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
using System.IO;
namespace ElbarProject.GUI
{
    public partial class frmShowCars : Form
    {
        //שם תמונה
        string fileName=" ";
        //למילוי הקומבו של החניה
        int countForBranch = 0;
        string str,path;
        Car curentCar = new Car();
        CarTable curentTable = new CarTable();
        ParkingInBranchTable curentt = new ParkingInBranchTable();
        public frmShowCars(string st)
        {
            str = st;
            InitializeComponent();
            ColorsTable curentColor = new ColorsTable();
            Suport.FillCombox(cmbColor, curentColor .GetTable(), "nameColor", "coudeColor");

            
            //Suport.FillCombox(cmbPlace , curentp .FillConbo(), "numParking", "coudParking");

            DesignTable curentd = new DesignTable();
            Suport.FillCombox(cmbDesign, curentd.GetTable(), "nameDesign", "coudDesign");

            BranchTable curentb = new BranchTable();
            Suport.FillCombox(cmbBranch, curentb.GetTable(), "branchName", "branchCoude");

            if (st == "add") 
            {
                lblAddCar.Visible = true;
                lblMessage.Visible = false;
                btnAdd.Visible = true;
                
                label9.Visible = false;
                txtNumForSerch.Visible = false;
                btnSearch.Visible = false;
            }
            if(st=="update")
            {
                lblAddCar.Visible = false ;
                lblMessage.Visible = true ;              
                btnUpdate.Visible = true ;
                pcbPicture.Visible = true;
                pcbPicture.Visible = true;
            }
            if(st=="del")
            {
                lblAddCar.Visible = false;
                lblMessage.Visible = true;
                
                btnDel.Visible = true;
                
                
                pcbPicture.Visible = true;
            }
            
        }
        
        private void frmShowCars_Load(object sender, EventArgs e)
        {

        }
        private void FillTXT()
        {
            txtnum.Text = curentCar.CarNumber;
            cmbColor.SelectedValue = curentCar.ColorCar;
            chfound.Checked = curentCar.Finds;
            chbFix.Checked = curentCar.Fix;
            dtpT.Value = curentCar.DateTest;
            dtpB.Value = curentCar.DateTest;
            txtKm.Text = curentCar.DroveKM.ToString();
            cmbBranch.SelectedValue = curentCar.CoudBranch;
            ParkingInBranchTable curentp = new ParkingInBranchTable();
            int com = Convert.ToInt32(cmbBranch.SelectedValue);
            Suport.FillCombox(cmbPlace, curentp.FillConbo(com), "fullName", "coudParking");
            cmbPlace.SelectedValue = curentCar.CoudeParking;
            cmbDesign.SelectedValue = curentCar.CoudDesign;
            
            txtAmount.Text = curentCar.AmountGasIn.ToString();
            try
            {
                pcbPicture.Image = Image.FromFile(Application.StartupPath + @"\carsForTheProject\" + curentCar.Picture);
            }
            catch { }
            cmbPlace.Enabled = true;
        }
        private bool  FillClass()
        {
            bool flag = true;
            try
            {
                curentCar.CarNumber = txtnum.Text;
            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError (txtnum , ex.Message);
                
            }
            curentCar.ColorCar = Convert.ToInt32(cmbColor.SelectedValue);
            curentCar.Finds = chfound.Checked;
            curentCar.DateTest = dtpT.Value;
            curentCar.DateInsurance = dtpB.Value;
            try
            {
                curentCar.DroveKM = Convert.ToInt32(txtKm.Text);
            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(txtKm, ex.Message);

            }
            try
            {
                curentCar.AmountGasIn = Convert.ToInt32(txtAmount.Text);
            }
            catch (Exception ex)
            {
                flag = false;
                errorProvider1.SetError(txtAmount, ex.Message);

            }
       
            curentCar.CoudeParking=Convert.ToInt32( cmbPlace.SelectedValue );
            curentCar.CoudDesign = Convert.ToInt32(cmbDesign.SelectedValue);
            curentCar.CoudBranch = Convert.ToInt32(cmbBranch.SelectedValue);
          
            curentCar.Active = true;
            curentCar.Fix = true;
            try
            {
                curentCar.Picture =fileName;
                
            }
            catch
            {
                errorProvider1.SetError(label7, "בעיה בעת הוספת תמונה");
                flag = false;
            }
            return flag;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                curentCar = new Car(txtNumForSerch.Text);
                int p = Convert.ToInt32(cmbPlace.SelectedValue);
                ParkingInBranch curentp = new ParkingInBranch(p);
                curentp.Fullparking = true;
                curentt.UpdateToAccess(curentp);
                if (FillClass())
                {

                    curentTable.UpdateToAccess(curentCar);
                    MessageBox.Show("רכב התעדכן בהצלחה");
                }
            }
            catch
            {
                int p = Convert.ToInt32(cmbPlace.SelectedValue);
                errorProvider1.Clear();
                if (FillClass())
                {
                    curentTable.AddToAccess(curentCar);
                    MessageBox.Show("רכב התווסף למאגר בהצלחה");
                }
                ParkingInBranch curentp = new ParkingInBranch(p);
                curentp.Fullparking = true;
                curentt.UpdateToAccess(curentp);

            }
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //שמירת שם התמונה
                fileName = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf("\\"));
                //העתקה לתיקיה
                try
                {
                    File.Copy(openFileDialog1.FileName, Application.StartupPath + @"\carsForTheProject\" + fileName);
                }
                catch { }
                //הצגה בטופס
                pcbPicture.Image = Image.FromFile(Application.StartupPath + @"\carsForTheProject\" + fileName );
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
           
            int p =Convert.ToInt32 ( cmbPlace.SelectedValue);
            if (CarTable .GetIfDelId(curentCar .CarNumber))
            {
                DialogResult dres = MessageBox.Show("האם למחוק", "אזהרת מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (dres == DialogResult.Yes)
                {
                    curentTable.DeleteToAccess(curentCar );
                    MessageBox.Show("רכב הוסר בהצלחה");
                    ParkingInBranch curentp = new ParkingInBranch(p);
                    curentp.Fullparking = false;
                    curentt.UpdateToAccess(curentp);
                }
            }
            else
                MessageBox.Show("לא ניתן למחוק את הרכב המבוקש");
              
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                curentCar = new Car(txtNumForSerch.Text);
                FillTXT();
               int p = Convert.ToInt32(cmbPlace.SelectedValue);
                ParkingInBranch curentp = new ParkingInBranch(p);
                curentp.Fullparking = false;
                curentt.UpdateToAccess(curentp);
                btnUpdate.Enabled = true;
                btnDel.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //קוד חניה
            int p = Convert.ToInt32(cmbPlace.SelectedValue);            
            ParkingInBranch curentp = new ParkingInBranch(p);
            curentp.Fullparking = true;
            curentt.UpdateToAccess(curentp);
            if (FillClass())
            {
               
                curentTable.UpdateToAccess(curentCar);
                MessageBox.Show("רכב התעדכן בהצלחה");
            }
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                countForBranch++;
                ParkingInBranchTable curentp = new ParkingInBranchTable();
                int com = Convert.ToInt32(cmbBranch.SelectedValue);
                Suport.FillCombox(cmbPlace, curentp.FillConbo(com), "fullName", "coudParking");
                if (countForBranch != 0)
                    cmbPlace.Enabled = true;
                countForBranch++;
            }
            catch { }
        }

        private void cmbPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(str!= "del")
            try
            {
                int placeCode = Convert.ToInt32(cmbPlace.SelectedValue);
                ParkingInBranch curentp = new ParkingInBranch(placeCode);
                if (curentp.Fullparking == true)
                    MessageBox.Show("החניה שבחרת תפוסה בחר חניה אחרת");
            }
            catch { }
        }

        private void cmbBranch_SelectedValueChanged(object sender, EventArgs e)
        {
        //    cmbPlace.Enabled = true;
        //    ParkingInBranchTable curentp = new ParkingInBranchTable();
        //    string com = cmbBranch.SelectedValue.ToString();
        //    Suport.FillCombox(cmbPlace, curentp.FillConbo(com), "numParking", "coudParking");
        }

        private void cmbBranch_TabIndexChanged(object sender, EventArgs e)
        {
            //cmbPlace.Enabled = true;
            //ParkingInBranchTable curentp = new ParkingInBranchTable();
            //Suport.FillCombox(cmbPlace, curentp.FillConbo(cmbBranch.ValueMember), "numParking", "coudParking");
        }

        private void cmbBranch_TextChanged(object sender, EventArgs e)
           {
            //cmbPlace.Enabled = true;
            //ParkingInBranchTable curentp = new ParkingInBranchTable();
            //Suport.FillCombox(cmbPlace, curentp.FillConbo(cmbBranch.ValueMember), "numParking", "coudParking");
        
    }

        private void cmbBranch_Click(object sender, EventArgs e)
        {
            //cmbPlace.Enabled = true;
            //ParkingInBranchTable curentp = new ParkingInBranchTable();
            //Suport.FillCombox(cmbPlace, curentp.FillConbo(cmbBranch.ValueMember), "numParking", "coudParking");

        }

        private void cmbBranch_ValueMemberChanged(object sender, EventArgs e)
        {
            //cmbPlace.Enabled = true;
            //ParkingInBranchTable curentp = new ParkingInBranchTable();
            //string com = cmbBranch.SelectedValue.ToString();
            //Suport.FillCombox(cmbPlace, curentp.FillConbo(com), "numParking", "coudParking");
        }

        private void cmbBranch_MouseClick(object sender, MouseEventArgs e)
        {
            //cmbPlace.Enabled = true;
            //ParkingInBranchTable curentp = new ParkingInBranchTable();
            //Suport.FillCombox(cmbPlace, curentp.FillConbo(cmbBranch.ValueMember), "numParking", "coudParking");

        }

        private void btnTry_Click(object sender, EventArgs e)
        {
            

        }

        private void chfound_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pcbPicture_Click(object sender, EventArgs e)
        {

        }

        private void txtNumForSerch_TextChanged(object sender, EventArgs e)
        {

        }
        //בסגירת הטופס החניה תתעדכן
        private void frmShowCars_FormClosed(object sender, FormClosedEventArgs e)
        {
            int p = Convert.ToInt32(cmbPlace.SelectedValue);
            ParkingInBranch curentp = new ParkingInBranch(p);
            curentp.Fullparking = true;
            curentt.UpdateToAccess(curentp);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var source = sender as OpenFileDialog;
            path = source.FileName;
        }
    }
}
