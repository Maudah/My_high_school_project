using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;

namespace ElbarProject.BLL
{
   public  class Fixs:GeneralRow 
    {
        private int fixCoude;//קוד תיקון
        private string carNumber;//מס רכב
        private string iDClient;//ת.ז לקוח
        private string describeFix;//תיאור תיקון
        private string describeDamage;//תיאור נזק
        private bool isFix;//תוקן?
        private int toPay;//לתשלום
        public Fixs() { }
        public Fixs(int fixCoude, string carNumber, string iDClient, string describeFix, string describeDamage, bool isFix, int toPay)
        {
            this.fixCoude = fixCoude;
            this.carNumber = carNumber;
            this.iDClient = iDClient;
            this.describeFix = describeFix;
            this.describeDamage = describeDamage;
            this.isFix = isFix;
            this.toPay = toPay;
        }
        public Fixs(int coudDesign)
        {
            FixsTable  fi = new FixsTable ();
            this.dRow = fi.Find(coudDesign);
            if (this.dRow != null)
                this.FillFields();
            else
                throw new Exception("לא נמצאו שדות");
        }
        public override void FillDataRow()
        {
            dRow["FixCoude"] = this.fixCoude;
            dRow["CarNumber"] = this.carNumber;
            dRow["IDClient"] = this.iDClient;
            dRow["DescribeFix"] = this.describeFix;
            dRow["describeDamage"] = this.describeDamage;
            dRow["IsFix"] = this.isFix;
            dRow["ToPay"] = this.toPay;
        }
        public override void FillFields()
        {
            this.fixCoude = Convert.ToInt32  (dRow["FixCoude"]);
            this.carNumber = Convert.ToString(dRow["CarNumber"]);
            this.iDClient = Convert.ToString (dRow["IDClient"]);
            this.describeFix = Convert.ToString (dRow["DescribeFix"]);
            this.describeDamage = Convert.ToString (dRow["DescribeDamage"]);
            this.isFix = Convert.ToBoolean (dRow["IsFix"]);
            this.toPay = Convert.ToInt32(dRow["ToPay"]);

        }
        public int FixCoude
        {
            get { return fixCoude; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value)))
                    this.fixCoude = value;
                else throw new Exception("הקש מספרים בלבד");
            }
        }
        public string CarNumber
        {
            get { return carNumber; }
            set
            {
                if (value.ToString() != "")
                    this.carNumber = value;
                else throw new Exception("מלא נתונים");
            }
        }
        public string IDClient
        {
            get { return iDClient; }
            set
            {
                if (Validation.IsID (value)&& value != "")
                    this.iDClient = value;
                else throw new Exception("הקש מספרים בלבד");
            }
        }
        public string DescribeFix
        {
            get { return describeFix; }
            set
            {
                if (Validation.IsHebrew (value)&&value != "")
                    this.describeFix = value;
                else throw new Exception("הקש תיאור בעברית בלבד");
            }
        }
        public string DescribeDamage
        {
            get { return describeDamage; }
            set
            {
                if (Validation.IsHebrew(value)&& value != "")
                    this.describeDamage = value;
                else throw new Exception("הקש תיאור בעברית בלבד");
            }
        }
        public bool IsFix
        {
            get { return isFix; }
            set { this.isFix = value; }
        }
        public int ToPay
        {
            get { return toPay; }
            set
            {
                if (Validation.IsNumbers(Convert .ToString ( value)))
                    this.toPay = value;
                else throw new Exception("הקש מספרים בלבד");
            }
        }
    }
    
}

