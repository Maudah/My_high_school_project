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
    public partial class frmCarReturn : Form
    {
        ParkingInBranchTable curentParkingTable = new ParkingInBranchTable();
        ParkingInBranch curentParking = new ParkingInBranch();
        Car curentCar = new Car();
        CarTable curentCarTable = new CarTable();
        CreditCard curentCard = new CreditCard();
        Takes curentTake = new Takes();
        TakesTable curentTakeTable = new TakesTable();
        Client curentClient = new Client();
        Branch curentBranch = new Branch();
        public  static int codeTake = 0;
        int branchCode;
        public frmCarReturn(int br)
        {
            InitializeComponent();
            branchCode = br;
            lblDate.Text = DateTime.Now.ToString();
            curentBranch = new Branch(br);
            cmbBranch .DisplayMember  = Convert.ToString(curentBranch.BranchName);
            CityTable ct = new CityTable();
            Suport.FillCombox(cmbCity, ct.GetTable(), "nameCity", "coudeCity");
            KindLicenseTable k = new KindLicenseTable();
            Suport.FillCombox(cmbLicenseKind, k.GetTable(), "nameLicense", "coudeLicense");
            BranchTable bra = new BranchTable();
            Suport.FillCombox(cmbBranch, bra.GetTable(), "branchName", "branchCoude");
            int com = Convert.ToInt32(cmbBranch.SelectedValue);
            Suport.FillCombox(cmbBranchBack , curentParkingTable.FillConbo(com), "fullName", "coudParking");
            chbFix.Checked = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try {
                curentTake = new Takes(Convert.ToInt32(txtCode.Text));
                curentClient = new Client(curentTake.IDclient);
                
                FillTxtClient();
                
            }
            catch
            {
                MessageBox.Show("לא נמצאו השכרות מתאימות!");
            }
            grpReturn.Enabled = true;
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            frmSearchTake f1 = new frmSearchTake(branchCode, "return");
            f1.ShowDialog();

            try
            {
                curentTake = new Takes(codeTake );
                curentClient = new Client(curentTake.IDclient);
                FillTxtClient();
            }
            catch
            {
                MessageBox.Show("לא נמצאו השכרות מתאימות!");
            }
            grpReturn.Enabled = true;

        }
        private void FillTxtClient()
        {
            CreditCardTable curentT = new CreditCardTable();
            Suport.FillCombox(cmbCardList, curentT.GetCards(curentTake.IDclient), "numCard", "coudcCeditCard");
            Suport.FillCombox(cmbCardForPay , curentT.GetCards(curentTake.IDclient), "numCard", "coudcCeditCard");
            txtId.Text = curentClient.IDclient;
            txtAddress.Text = curentClient.Address;
            txtDate.Text = curentClient.BirthDate.ToString();
            txtFName.Text = curentClient.FirstName;
            txtLicenseD1.Text = curentClient.DateGetLisence.ToString();
            txtLicenseD2.Text = curentClient.ValibityLicense.ToString();
            txtLicenseNum.Text = curentClient.NumLicense.ToString();
            txtLName.Text = curentClient.LastName;
            txtNum.Text = curentClient.NumHome.ToString();
            txtPhone.Text = curentClient.Phone;
            txtTel.Text = curentClient.Telephne;
            cmbCity.SelectedValue = curentClient.City;
            cmbLicenseKind.SelectedValue = curentClient.KindLicense;
            int count = 0;
            DateTime dt = txtDate.Value;
            while (DateTime.Now > dt.AddMonths(count))
            {

                count++;
            }
            txtAge.Text = (count / 12) + "." + (count % 12);
            txtToPay.Text = curentTake.ToPay.ToString();
            cmbCardList.SelectedValue = curentTake.CodeCraditCard;
            chkB.Checked = curentTake.CarInsurance;
            CreditCardTable curentc = new CreditCardTable();
            Suport.FillCombox(cmbCardForPay, curentc.GetCards(txtId.Text), "numCard", "coudcCeditCard");           
            dtpFrom.Value = Convert.ToDateTime(curentTake.DateTake);
            dtpTo.Value = Convert.ToDateTime(curentTake.DateReturn);
            //חישוב מס ימים
            int countDays = 0;
            DateTime dti = dtpFrom.Value;
            while (dtpTo.Value > dti.AddDays(countDays))
            {
                countDays++;
            }
            lblDays.Text = countDays.ToString();
            //חישוב מס' ימים בפועל
            countDays = 0;
            while (DateTime.Now  > dti.AddDays(countDays))
            {
                countDays++;
            }
            lblDaysNow.Text = countDays.ToString();
            if (dtpTo.Value<DateTime.Now )
            {
                dtpTo.CalendarForeColor = Color.Red;
            }

        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            frmAddCreditCard f1 = new frmAddCreditCard();
            f1.ShowDialog();
            CreditCardTable curentT = new CreditCardTable();
            Suport.FillCombox(cmbCardForPay, curentT.GetCards(txtId.Text), "numCard", "coudcCeditCard");
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            curentCar = new Car(curentTake.NumCar);
            curentTake.TimeReturn = DateTime.Now.Hour.ToString();
            curentTake.CoudBranchReturn = Convert.ToInt32(cmbBranch.SelectedValue);
            curentTake.AmountGasReturn= Convert.ToInt32(txtGas.Text);
            curentTake.NumKMreturn = Convert.ToInt32(txtKm.Text);
            //עדכון שהחניה תפוסה
            curentParking = new ParkingInBranch(Convert.ToInt32(cmbBranchBack.SelectedValue));
            curentParking.Fullparking = true;
            curentParkingTable.UpdateToAccess(curentParking);
           
            //עדכון שינוים ברכב המושכר
            curentCar.Finds = true;
            curentCar.Fix = chbFix.Checked;
            curentCar.AmountGasIn = Convert.ToInt32(txtGas.Text);
            curentCar.DroveKM = Convert.ToInt32(txtKm.Text);
            curentCar.CoudeParking = Convert.ToInt32(cmbBranchBack.SelectedValue);
            //להמשיך ביצוע החזרה
            curentCarTable.UpdateToAccess(curentCar);
            
            curentTakeTable.UpdateToAccess(curentTake);
            //לטפל בכמות הדלק ומס' קמ שיהיה דאבל ולא ינט
            if (chbFix.Checked == false&&curentTake.CarInsurance==false )
                MessageBox.Show("התשלום בגין נזק הרכב יגבה בהמשך מכרטיס האשראי האחרון");
            MessageBox.Show("הרכב הוחזר למלאי ההשכרות תןדה שהשכרת באלבר");
            frmReportCarReturn f1 = new frmReportCarReturn(curentTake.NumTakes);
            f1.Show();
        }

        private void frmCarReturn_Load(object sender, EventArgs e)
        {

        }

        private void cmbCardForPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                curentCard = new CreditCard(Convert.ToInt32(cmbCardList.ValueMember));
                if (curentCard.Valibity < DateTime.Now)
                {
                    MessageBox.Show("לא ניתן לבחור בכרטיס זה תוגפו פג");
                }
            }
            catch { }
        }

        private void txtKm_TextChanged(object sender, EventArgs e)
        {
            curentCar = new Car(curentTake.NumCar);
            double x = Convert.ToDouble(txtKm.Text) - curentCar.DroveKM;
            txtKmNo.Text = x.ToString();
        }

        private void txtKmNo_TextChanged(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtKmNo.Text) / Convert.ToDouble(lblDaysNow .Text);
            txtKmForDay.Text = x.ToString();
           
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int com = Convert.ToInt32(cmbBranch.SelectedValue);
            Suport.FillCombox(cmbBranchBack , curentParkingTable.FillConbo(com), "fullName", "coudParking");
            
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnToPay_Click(object sender, EventArgs e)
        {
            Design curentd = new Design(curentCar.CoudDesign);
            Group curentg = new Group(curentd.Group);
            int mun = curentg.AddKM;
            double price = 0;
            if (curentCar.AmountGasIn > Convert.ToDouble(txtGas.Text))
                price += (Convert.ToDouble(txtGas.Text) - curentCar.AmountGasIn) * 8;
            if (Convert.ToDouble(txtKmForDay.Text) > 10)
                price += Convert.ToInt32(lblDaysNow.Text) * Convert.ToDouble(txtKmForDay.Text) * mun;

            lblAddPaying.Text = price.ToString();
        }

        private void chbFix_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void myButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
