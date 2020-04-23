using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;

namespace ElbarProject.BLL
{
   public  class Car :GeneralRow 
    {
        private string carNumber;//מס רכב
        private int colorCar;//צבע רכב
        private bool  finds;//נמצא?
        private bool  fix;//תקין?
        private DateTime   dateTest;//תאריך לחידוש טסט
        private DateTime   dateInsurance;//תאריך לחידוש ביטוח
        private double  droveKM;//מס קמ שנסע
        private int coudeParking;//קוד חניה
        private int coudDesign;//קוד דגם
        private int coudBranch;//קוד סניף
        private double  amountGasIn;//כמות גז במיכל
        private bool  active;//פעיל?
        private string picture;//תמונה
        public Car() { }
        
        public Car (string carNumber)
        {
            CarTable cr = new CarTable();
            this.dRow = cr.Find(carNumber);
            if (this.dRow != null)
                this.FillFields();
            else throw new Exception("לא נמצאו תוצאות");

        }
        public override void FillDataRow()
        {
            dRow["CarNumber"] = this.carNumber;
            dRow["ColorCar"] = this.colorCar;
            dRow["finds"] = this.finds;
            dRow["Fix"] = this.fix;
            dRow["DateTest"] = this.dateTest;
            dRow["DateInsurance"] = this.dateInsurance;
            dRow["DroveKM"] = this.droveKM;
            dRow["CoudeParking"] = this.coudeParking;
            dRow["CoudDesign"] = this.coudDesign;
            dRow["CoudBranch"] = this.coudBranch;
            dRow["AmountGasIn"] = this.amountGasIn;
            dRow["Active"] = this.active;
            dRow["Picture"] = this.picture;
        }
        //מילוי הנתונים מהעצם לדטהראוו
        public override void FillFields()
        {
            this.carNumber = Convert.ToString (dRow["carNumber"]);
            this.colorCar = Convert.ToInt32 (dRow["ColorCar"]);
            this.finds = Convert.ToBoolean(dRow["Finds"]);
            this.fix = Convert.ToBoolean(dRow["Fix"]);
            this.dateTest = Convert.ToDateTime (dRow["DateTest"]);
            this.dateInsurance = Convert.ToDateTime (dRow["DateInsurance"]);
            this.droveKM = Convert.ToDouble (dRow["DroveKM"]);
            this.coudeParking = Convert.ToInt32 (dRow["CoudeParking"]);
            this.coudDesign = Convert.ToInt32 (dRow["CoudDesign"]);
            this.coudBranch = Convert.ToInt32 (dRow["CoudBranch"]);
            this.amountGasIn = Convert.ToDouble  (dRow["AmountGasIn"]);
            this.active = Convert.ToBoolean (dRow["Active"]);
            this.picture = Convert.ToString(dRow["Picture"]);
            
        }
         public string  CarNumber
        {
            get { return carNumber; }
            set {
                if (Validation.CarNumberCheck(value )&&value !="")
                    this.carNumber = value;
                else throw new Exception("הקש מס רכב חוקי");
             }
        }
        public int ColorCar
        {
            get { return colorCar; }
            set { this.colorCar = value; }
        }
        public bool Finds
        {
            get { return finds; }
            set { this.finds = value; }
        }
        public bool Fix
        {
            get { return fix; }
            set { this.fix = value; }
        }
        public DateTime  DateTest
        {
            get { return dateTest; }
            set {
                if (value > DateTime.Now)
                    this.dateTest = value;
                else throw new Exception("הקש תאריך עתידי בלבד");
            }
        }
        public DateTime   DateInsurance
        {
            get { return dateInsurance; }
            set {
                if (value > DateTime.Now)
                    this.dateInsurance = value;
                else throw new Exception("הקש תאריך עתידי בלבד");
                }
        }
        public double  DroveKM
        {
            get { return droveKM; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value )) )
                    this.droveKM = value;
                else throw new Exception(" הקש מספרים בלבד");
            }
        }
        public int CoudeParking
        {
            get { return coudeParking; }
            set { this.coudeParking = value; }
        }
        public int CoudDesign
        {
            get { return coudDesign; }
            set { this.coudDesign = value; }
        }
        public int CoudBranch
        {
            get { return coudBranch; }
            set { this.coudBranch = value; }
        }
        public double  AmountGasIn
        {
            get { return amountGasIn; }
            set { this.amountGasIn = value ; }
        }
        public bool Active
        {
            get { return active; }
            set { this.active = value; }
        }
        public string Picture
        {
            get { return picture; }
            set { this.picture = value; }
        }
    }

}
