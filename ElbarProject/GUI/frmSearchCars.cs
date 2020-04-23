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
    public partial class frmSearchCars : Form
    {
        Form f1;
        DataTable dtt;
        DataView dgv;
        GroupTable br = new GroupTable();
        int branchs;
        Car curentcar = new Car();
        Design curentd = new Design();
        Group curentGoup = new Group();
        Branch curentBranch = new Branch();
        string status = "";
        string lisenceC;
        double  ageC;
        public frmSearchCars(Form f2,string st,int  ob,string user)
        {
            InitializeComponent();
            branchs = ob;          
            f1 = f2;
            f1.Enabled  = false;
          //להצגת רכבים בסניף זה
            if(st=="one"&&user =="worker")
            {
                lblWorker.Visible = true;
                lblClient.Visible = false;
                chbBranch.Visible = true;
                lblb.Visible = true;
                txtBranch.Visible  = true;
                chbBranch.Checked = true;
               
            }
            //להצגת רכבים שנמצאים כרגע בסניף
            if (st == "one" && user == "client")
            {
                lblWorker.Visible = false ;
                lblClient.Visible = true ;
                chbBranch.Visible = false ;
                lblb.Visible = false ;
                txtBranch.Visible = false ;
                dtt = CarTable.GetTimesCars(ob , true, dtpFrom.Value, dtpTo.Value);
                //המשתנה מלמעלה
                dgv = new DataView(dtt);
                //המשתנה מהטופס
                dgvTableCar.DataSource = dgv;
                chbBranch.Checked = false;
            }
         //להצגת כל הרכבים
            if (user != "client")
            {
                dtt = CarTable.GetDisplayTable();
                //המשתנה מלמעלה
                dgv = new DataView(dtt);
                //המשתנה מהטופס
                dgvTableCar.DataSource = dgv;
            }
            curentBranch  = new Branch ( ob);
            txtBranch.Text = Convert.ToString(curentBranch .BranchName);
        }
        //פעולה בונה להזמנה 
        public frmSearchCars(Form f2, DateTime  fromd, int ob, DateTime  tod,string longShort,double  age,string lisence)
        {
            InitializeComponent();
            status = "invite";
            lisenceC = lisence;
            ageC = age;
            f1 = f2;
            f1.Enabled = false;
            curentBranch = new Branch(ob);
            txtBranch.Text = Convert.ToString(curentBranch.BranchName);
            btnReturn.Visible = true;
            lblWorker.Visible = true;
            lblClient.Visible = false;
            if (longShort == "long"|| longShort == "short")
            {
                chbBranch.Checked = true;
            }
            else
                chbBranch.Checked = false;
            //מאפשר הצגת רכבים מכל הסניפים
            chbBranch.Visible = true;
            lblb.Visible = true;
            txtBranch.Visible = true;
            //מילוי ה data table
            dtt = CarTable.GetTimesCars(branchs ,true,dtpFrom.Value, dtpTo.Value);
            //המשתנה מלמעלה
            dgv = new DataView(dtt);
            //המשתנה מהטופס
            dgvTableCar.DataSource = dgv;
            dtpFrom.Value = fromd.Date;
            dtpTo.Value = tod.Date;
            
        }


        private void frmSearchCars_Load(object sender, EventArgs e)
        {

        }
       
        private void frmSearchCars_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dgv.RowFilter = "numPlaces like '" +Convert.ToInt32 ( txtNumPlaces.Text )+"%'";
            //  dvCust.RowFilter = "שם like '" + txtName.Text + "%'";
        }

        private void dgvTableCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void chbBranch_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBranch.Checked == true)
            {
              //  dgv.RowFilter = "coudBranch="+ true ;
                dtt = CarTable.GetTimesCars( branchs, true, dtpFrom.Value, dtpTo.Value);
                //המשתנה מלמעלה
                dgv = new DataView(dtt);
                //המשתנה מהטופס
                dgvTableCar.DataSource = dgv;
            }
            if (chbBranch.Checked == false )
            {
               // dgv.RowFilter = "coudBranch="+ false  ;
                dtt = CarTable.GetTimesCars(branchs , false, dtpFrom.Value, dtpTo.Value);
                //המשתנה מלמעלה
                dgv = new DataView(dtt);
                //המשתנה מהטופס
                dgvTableCar.DataSource = dgv;
            }
        }

        private void txtNumPlaces_TextChanged(object sender, EventArgs e)
        {
            if (txtNumPlaces.Text == "")
                dgv.RowFilter = "";
            else
                dgv.RowFilter = "numPlaces = " + Convert.ToInt32(txtNumPlaces.Text);
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void cmbDesign_SelectedIndexChanged(object sender, EventArgs e)
        {
           // dgv.RowFilter = "nameDesign=" + cmbDesign.SelectedValue;
        }

        private void txtBranch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchG_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearchd_Click(object sender, EventArgs e)
        {
            
         
        }

        private void dgvTableCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNotice.Visible = false;
            string number = dgvTableCar.SelectedRows[0].Cells[0].Value.ToString();
            try {
                 curentcar = new Car(number);
                 curentd = new Design(curentcar.CoudDesign);
                 curentGoup = new Group(curentd.Group);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            txtDay.Text  = curentGoup.DayTariff.ToString ();
            txtHoure.Text = curentGoup.AddHour.ToString();
            txtKm.Text = curentGoup.AddKM.ToString();
            txtMonth.Text = curentGoup.MonthTariff.ToString();
            txtWeek.Text = curentGoup.WeekTarif.ToString();
            if(status=="invite")
            {
                if (ageC <= 21 && curentd.VolumeMotor > 1600)
                    lblNotice.Visible = true;
                if (ageC <= 24 && curentd.VolumeMotor > 2000)
                    lblNotice.Visible = true;
                if (Convert.ToInt32(lisenceC) < 6 && curentGoup.CoudeGroup < 5)
                    lblNotice.Visible = true;
            }
        }

        private void dgvTableCar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string number = dgvTableCar.SelectedRows[0].Cells[0].Value.ToString();
            frmCarsFromDGV fr = new frmCarsFromDGV (number);
            fr.Show();
        }

        private void txtttt_TextChanged(object sender, EventArgs e)
        {
            dgv.RowFilter = "nameDesign like '" + txtttt.Text + "%'";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value > dtpTo.Value|| dtpTo.Value<=DateTime.Now  )
                MessageBox.Show("הקש תאריכים חוקיים");
            dtt = CarTable.GetTimesCars(branchs,chbBranch.Checked, dtpFrom.Value, dtpTo.Value);
            //המשתנה מלמעלה
            dgv = new DataView(dtt);
            //המשתנה מהטופס
            dgvTableCar.DataSource = dgv;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblNotice.Visible == true)
                    MessageBox.Show("לא ניתן להשכיר את הרכב שנבחר");
                else
                {

                    frmTakeForLong.st = dgvTableCar.SelectedRows[0].Cells[0].Value.ToString();
                    this.Close();
                    f1.Enabled = true;
                }
            }
            catch { }
           
           
          
        
        }

        private void txtCarNum_TextChanged(object sender, EventArgs e)
        {
            if (txtCarNum .Text == "")
                dgv.RowFilter = "";
            else
                dgv.RowFilter = "carNumber = " + Convert.ToInt32(txtCarNum .Text);
        }

        private void txtValueMotor_TextChanged(object sender, EventArgs e)
        {
            if (txtValueMotor .Text == "")
                dgv.RowFilter = "";
            else
                dgv.RowFilter = "volumeMotor = " + Convert.ToInt32(txtValueMotor .Text);
        }
    }
}
