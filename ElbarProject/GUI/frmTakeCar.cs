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
    public partial class frmTakeCar : Form
    {
        ParkingInBranch curentParking = new ParkingInBranch();
        ParkingInBranchTable curentParkingTable = new ParkingInBranchTable();
        Takes curentTake = new Takes();
        public frmTakeCar()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            try {
                 curentTake = new Takes(Convert.ToInt32(txtnumTake.Text));
                Car curentCar = new Car(curentTake.NumCar);
                curentCar.Finds = false;
                CarTable curentCarTable = new CarTable();
                curentCarTable.UpdateToAccess(curentCar);
                MessageBox.Show("תודה שהשכרתם באלבר");
                //עדכון שהחניה פנויה
                curentParking = new ParkingInBranch(curentCar.CoudeParking);
                curentParking.Fullparking = false;
                curentParkingTable.UpdateToAccess(curentParking);
            }
            catch
            {
                MessageBox.Show("לא נמצא לקוח במאגר וודא שהקלדת נכון את ת.ז");
            }
            frmReportTakeCar f1 = new frmReportTakeCar(curentTake.NumTakes);
            f1.Show();
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try {
                Client curentClient = new Client(txtId.Text);
                txtName.Text = curentClient.FirstName;
                txtFName.Text = curentClient.LastName;
            }
            catch
            {
                MessageBox.Show("לא נמצא לקוח במאגר וודא שהקלדת נכון את ת.ז");
            }

        }
    }
}
