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
    public partial class frmTakeForLong : Form
    {
        CreditCard curentCard = new CreditCard();
        CreditCardTable  curentCardTable = new CreditCardTable();
        Takes curentTake = new Takes();
        TakesTable curentTakeTable = new TakesTable(); 
        Car curentCar = new Car();
        Design curentd = new Design();
        Group curentGoup = new Group();
        Client curentClient = new Client();
        ClientTable curentClientTable = new ClientTable();
        Branch curentBranch = new Branch();
        CityTable ct = new CityTable();
        KindLicenseTable curentL = new KindLicenseTable();
        ColorsTable curentColorTable = new ColorsTable();
        DesignTable curentDesignTable = new DesignTable();
        BranchTable curentBranchTable = new BranchTable();
        ParkingInBranchTable curentParkingTable = new ParkingInBranchTable();

        int newClient=2;
        int bra;
        public static   string st="";
        int countD;
     
        string shortLong;
        int takeCode;
        public frmTakeForLong(int br,string sl)
        {
            shortLong = sl;
            bra = br;//סניף
            InitializeComponent();            
            curentCardTable = new CreditCardTable();
            Suport.FillCombox(cmbCity, ct.GetTable(), "nameCity", "coudeCity");            
            Suport.FillCombox(cmbLicenseKind, curentL.GetTable(), "nameLicense", "coudeLicense");
            curentBranch = new Branch(br);
            txtBranch.Text= Convert.ToString(curentBranch.BranchName);
            btnOk.Visible = true;
           
        }

        //להצגת רכב מרשימת השכרות
        public frmTakeForLong(int br,int TakeCode,string searchUpdate)
        {
            InitializeComponent();
            Suport.FillCombox(cmbCity, ct.GetTable(), "nameCity", "coudeCity");
            Suport.FillCombox(cmbLicenseKind, curentL.GetTable(), "nameLicense", "coudeLicense");
            bra = br;//סניף
            curentBranch = new Branch(br);
            txtBranch.Text = Convert.ToString(curentBranch.BranchName);
            curentTake = new Takes(TakeCode);
            //מילוי נתונים לפי הת.ז שבהשכרה
            curentClient = new Client(curentTake.IDclient );
            FillTxtClient();
            //מילוי פרטי רכב
            st = curentTake.NumCar;
            FillTXT();
            btnUpdate.Visible = true;
            if (searchUpdate == "search")
                this.Enabled = false;
            else
            {
                btnCar.Enabled = true;
                grpCar.Enabled = false ;
            }
            //קוד השכרה
            this.takeCode = TakeCode;
        }
       
        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                curentClient = new Client(txtId.Text);
                FillTxtClient();
                newClient = 0;
            }
            catch
            {
                MessageBox.Show("לא נמצא לקוח במאגר הוסף לקוח חדש");
                newClient = 1;
            }
        }
        private void FillTxtClient()
        {
            txtId.Text = curentClient.IDclient;
            txtAddress.Text  = curentClient.Address;
            txtDate.Text = curentClient.BirthDate.ToString();
            txtFName.Text = curentClient.FirstName;
            txtLicenseD1.Text = curentClient.DateGetLisence.ToString();
            txtLicenseD2.Text = curentClient.ValibityLicense.ToString();
            txtLicenseNum.Text = curentClient.NumLicense.ToString();
            txtLName.Text = curentClient.LastName;
            txtNum.Text = curentClient.NumHome.ToString();
            txtPhone.Text = curentClient.Phone;
            txtTel.Text = curentClient.Telephne;
            cmbCity.SelectedValue  = curentClient.City;
            cmbLicenseKind.SelectedValue = curentClient.KindLicense;
            int count = 0;
            DateTime dt = txtDate.Value;
            while (DateTime.Now > dt.AddMonths(count))
            {

                count++;
            }
            txtAge.Text = (count / 12) + "." + (count % 12);


        }

        private void btmCar_Click(object sender, EventArgs e)
        {
            if (shortLong!="short")
            {
                frmSearchCars f2 = new frmSearchCars(this, dtpFrom.Value, bra, dtpTo.Value, "long",Convert.ToDouble (txtAge.Text  ),cmbLicenseKind.SelectedValue.ToString ()  );
                f2.ShowDialog();
            }
            else
            {
                frmSearchCars f2 = new frmSearchCars(this, dtpFrom.Value, bra, dtpTo.Value, "short", Convert.ToDouble   (txtAge), cmbLicenseKind.Text .ToString());
                f2.ShowDialog();
            }
            if (st == "")
            {
                MessageBox.Show("לא נמצאו תוצאות בחר רכב להשכרה");
            }
            else
            {
                FillTXT();
            }

        }
        
        private  void FillTXT()
        {
            Suport.FillCombox(cmbColor, curentColorTable .GetTable(), "nameColor", "coudeColor");
            Suport.FillCombox(cmbDesign, curentDesignTable .GetTable(), "nameDesign", "coudDesign");
            Suport.FillCombox(cmbBranch, curentBranchTable .GetTable(), "branchName", "branchCoude");
            int com = Convert.ToInt32(cmbBranch.SelectedValue);
            Suport.FillCombox(cmbPlace, curentParkingTable .FillConbo(com), "fullName", "coudParking");
            curentCar = new Car(st);
            curentd = new Design(curentCar.CoudDesign);
            curentGoup = new Group(curentd.Group);
            txtDay.Text = curentGoup.DayTariff.ToString();
            txtHoure.Text = curentGoup.AddHour.ToString();
            txtKm.Text = curentGoup.AddKM.ToString();
            txtMonth.Text = curentGoup.MonthTariff.ToString();
            txtWeek.Text = curentGoup.WeekTarif.ToString();
            txtB.Text = curentGoup.CarInsurance.ToString();
            txtnumCar.Text = curentCar.CarNumber;
            cmbColor.SelectedValue = curentCar.ColorCar.ToString();        
            txtKMd .Text = curentCar.DroveKM.ToString();
            cmbPlace.SelectedValue = curentCar.CoudeParking.ToString();
            cmbDesign.SelectedValue = curentCar.CoudDesign.ToString();
            cmbBranch.SelectedValue = curentCar.CoudBranch.ToString();
            txtAmount.Text = curentCar.AmountGasIn.ToString();
            pcbPicture .Image = Image.FromFile(Application.StartupPath + @"\carsForTheProject\" + curentCar.Picture);
            cmbCardList.SelectedValue = curentTake.CodeCraditCard.ToString();
           
        }
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Suport.FillCombox(cmbCardList, curentCardTable .GetCards(txtId.Text), "numCard", "coudcCeditCard");
            if (txtId.Text == "")
                MessageBox.Show("מלא פרטים בשדות");
            else
            {
                errorProvider1.Clear();
                if (newClient == 1)
                {
                    if (FillClass() == true)
                    {
                        curentClientTable.AddToAccess(curentClient);
                        MessageBox.Show("לקוח התווסף בהצלחה! המשך בתהליך ההשכרה");
                        btnCar.Enabled = true;
                        grpClient.Enabled = false;
                        btnCheck.Enabled = true;
                    }
                }
                if (newClient == 0)
                {
                    if (FillClass() == true)
                    {
                       // curentClient = new Client(txtId.Text);
                        curentClientTable.UpdateToAccess(curentClient);
                        MessageBox.Show("לקוח התעדכן בהצלחה במאגר! המשך בתהליך ההשכרה");
                        btnCheck.Enabled = true;
                        grpClient.Enabled = false;
                    }
                }
                if(newClient==2)
                {
                    try
                    {
                        curentClient = new Client(txtId.Text);
                        FillTxtClient();
                        newClient = 0;
                    }
                    catch
                    {
                        
                        newClient = 1;
                    }
                }
                DateTime dt = new DateTime();
                dt = txtLicenseD1.Value;
                if (dt.AddDays(730) < DateTime.Now ) 
                    lblDriver.Text = "הלקוח הינו נהג חדש";
                if(Convert.ToDouble  ( txtAge.Text)<23)
                {
                    lblAgeD.Text = "הלקוח הינו נהג צעיר";
                }
               // txtAge.Text = (txtDate.Value ) -( DateTime.Now).ToString();
            }
        }
        private bool FillClass()
        {
            bool flag = true;
            try
            {
                curentClient.IDclient = txtId.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtId, ex.Message);
                flag = false;
            }

            try
            {
                curentClient.FirstName = txtFName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtFName, ex.Message);
                flag = false;

            }
            try
            {
                curentClient.LastName = txtLName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtLName, ex.Message);
                flag = false;

            }
            try
            {
                curentClient.Address = txtAddress.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtAddress, ex.Message);
                flag = false;

            }



           
            try {
                curentClient.NumHome = Convert.ToInt32(txtNum.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNum, ex.Message);
            }
            curentClient.City = Convert.ToInt32(cmbCity.SelectedValue);
            try
            {
                curentClient.BirthDate = Convert.ToDateTime(txtDate.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtDate, ex.Message);
                flag = false;
            }
            try
            {
                curentClient.Telephne = txtTel.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtTel, ex.Message);
                flag = false;
            }
            try
            {
                curentClient.Phone = txtPhone.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPhone, ex.Message);
                flag = false;
            }
            try
            {
                curentClient.NumLicense = Convert.ToInt32(txtLicenseNum.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtLicenseNum, ex.Message);
                flag = false;
            }
            try
            {
                curentClient.DateGetLisence = Convert.ToDateTime(txtLicenseD1.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtLicenseD1, ex.Message);
                flag = false;
            }
            try
            {
                curentClient.ValibityLicense = Convert.ToDateTime(txtLicenseD2.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtLicenseD2, ex.Message);
                flag = false;
            }
            curentClient.KindLicense = Convert.ToInt32(cmbLicenseKind.SelectedValue);
            return flag;
        }

        private void frmTakeForLong_Load(object sender, EventArgs e)
        {

        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {
            int count = 0;
            DateTime dt = txtDate.Value;
            while (DateTime.Now > dt.AddMonths(count ) )
            {
                
                count++;
            }
            txtAge.Text =(count/12)+"."+(count % 12);           
        }

        private void myButton1_Click(object sender, EventArgs e)
        {

            frmAddCreditCard f1 = new frmAddCreditCard();
            f1.ShowDialog();
            CreditCardTable curentT = new CreditCardTable();
            Suport.FillCombox(cmbCardList , curentT.GetCards(txtId.Text), "numCard", "coudcCeditCard");
        }
         

        private void btnListCard_Click(object sender, EventArgs e)
        {
            CreditCardTable curentT = new CreditCardTable();         
            Suport.FillCombox(cmbCardList, curentT.GetCards(txtId.Text) , "numCard", "coudcCeditCard");
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
           
        }
        
        private void btnToPay_Click(object sender, EventArgs e)
        {
            int days = 0;
            int weeks = 0;
            int months =0;;
            int years =0;
             days = countD % 7 ;
             weeks = countD / 7 % 4;
             months = countD/7 /4;
             years = countD / 7 / 4 / 12;

            int price = 0;
            
            curentCar = new Car(st);
            curentd = new Design(curentCar.CoudDesign);
            curentGoup = new Group(curentd.Group);
            if (chkB.Checked == true)
                price = curentGoup.DayTariff * days + curentGoup.MonthTariff * months + curentGoup.WeekTarif * weeks + curentGoup.CarInsurance;
            else
                price = curentGoup.DayTariff * days + curentGoup.MonthTariff * months + curentGoup.WeekTarif * weeks;
            txtToPay.Text = price.ToString();
            btnOk.Enabled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            FillTakeClass();
            curentTakeTable.AddToAccess(curentTake);
            MessageBox.Show("ההזמנה התבצעה בהצלחה");
            frmReportInviting f1 = new frmReportInviting(curentTake.NumTakes);
            f1.Show();

        }
        private void FillTakeClass()
        {

            curentTake.NumTakes = curentTakeTable.GetNewKey();
            
            curentTake.NumCar = txtnumCar.Text;
            curentTake.IDclient = txtId.Text;
            curentTake.DateInitation = DateTime.Now.ToString();
            curentTake.DateTake = dtpFrom.Value.ToString();
            curentTake.TimeTake = " ";
            curentTake.DateReturn = dtpTo.Value.ToString();
            curentTake.TimeReturn = " ";
            curentTake.CoudBranchReturn = 0;           
            curentTake.AmountGasReturn = 0;
            curentTake.NumKMreturn = 0;
            curentTake.ToPay =Convert.ToInt32( txtToPay.Text);
            curentTake.CarInsurance = chkB.Checked;
            curentTake.CodeCraditCard = Convert.ToInt32(cmbCardList.SelectedValue);
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                curentTake = new Takes(takeCode);
            }
            catch
            {
                MessageBox.Show("לא נמצאו שדות מתאימים");
            }
            FillTakeClass();
            curentTakeTable.UpdateToAccess(curentTake);
        }

        private void cmbCardList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                curentCard = new CreditCard(Convert.ToInt32(cmbCardList.ValueMember));
                if (curentCard.Valibity <= dtpFrom.Value)
                {
                    MessageBox.Show("לא ניתן לבחור בכרטיס זה משום שתוקפו יופג עד גבית התשלום");
                }
            }
            catch { }
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnCar.Enabled = true;
            if ((dtpFrom.Value.Date ) < (DateTime.Now.Date) ||(dtpTo.Value  <= DateTime.Now)|| (dtpTo.Value)<=(dtpFrom.Value.Date))
                MessageBox.Show("הקש תאריך חוקי"); 
            int countDays = 0;
            DateTime dt = dtpFrom.Value;
            while (dtpTo.Value >= dt.AddDays(countDays))
            {
                countDays++;
            }
            lblDays.Text = countDays.ToString();
            lblEndDays.Text = "  נבחרו" + " " + countDays + " " + "  ימים להשכרה";
            countD = countDays;
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
