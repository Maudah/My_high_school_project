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
    public partial class frmCarsFromDGV : Form
    {
        public frmCarsFromDGV(string number)
        {
            InitializeComponent();
            Car curentcar = new Car(number );
            Design curentd = new Design(curentcar.CoudDesign);
            Group curentGoup = new Group(curentd.Group);
            Colors curentco = new Colors(curentcar.ColorCar);
            Branch curentbranch = new Branch(curentcar.CoudBranch);
            txtBranch.SelectedText = curentbranch.BranchName;
            txtColor.Text = curentco.NameColor.ToString();
            txtDay.Text = curentGoup.DayTariff.ToString();
            txtHoure.Text = curentGoup.AddHour.ToString();
            txtKm.Text = curentGoup.AddKM.ToString();
            txtMonth.Text = curentGoup.MonthTariff.ToString();
            txtWeek.Text = curentGoup.WeekTarif.ToString();
            txtADDkm.Text = curentGoup.AddKM.ToString();
            txtDesign.Text = curentd.NameDesign.ToString();
            txtGroup.Text = curentGoup.NameGroup+" "+curentGoup.DescribeGroup ;
            txtNum.Text = curentcar.CarNumber;
            chbFind.Checked  = curentcar.Finds;
            chbFix.Checked = curentcar.Fix;
            txtValumeMotore.Text = curentd.VolumeMotor.ToString();
            try
            {
                picture.Image = Image.FromFile(Application.StartupPath + @"\carsForTheProject\" + curentcar.Picture);
            }
            catch { }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCarsFromDGV_Load(object sender, EventArgs e)
        {

        }
    }
}
