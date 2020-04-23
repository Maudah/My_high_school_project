using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;

namespace ElbarProject.BLL
{
  public   class CreditCard:GeneralRow 
    {
        private int coudcCeditCard;//קוד כרטיס
        private int numCard;//מס כרטיס
        private string iDclient;//ת.ז לקוח
        private DateTime  valibity;//תוקף
        public CreditCard() { }
       
        public CreditCard(int coudcCeditCard)
        {
            CreditCardTable  ca = new CreditCardTable ();
            this.dRow = ca.Find(coudcCeditCard);
            if (this.dRow != null)
                this.FillFields();
            else
                throw new Exception("לא נמצאו שדות");
        }
        public override void FillDataRow()
        {
            dRow["CoudcCeditCard"] = this.coudcCeditCard;
            dRow["NumCard"] = this.numCard;
            dRow["IDclient"] = this.iDclient;
            dRow["Valibity"] = this.valibity;
        }
        public override void FillFields()
        {
            this.coudcCeditCard = Convert.ToInt32(dRow["CoudcCeditCard"]);
            this.numCard = Convert.ToInt32 (dRow["NumCard"]);
            this.iDclient = Convert.ToString(dRow["IDclient"]);
            this.valibity = Convert.ToDateTime (dRow["Valibity"]);
        }
        public int CoudcCeditCard
        {
            get { return coudcCeditCard; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value))&& value.ToString() != "")
                    this.coudcCeditCard = value;
                else throw new Exception("הקש מספרים בלבד");
            }
        }
        public int NumCard
        {
            get { return numCard; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value))&&value.ToString() != "" )
                    this.numCard = value;
                else throw new Exception("מלא נתונים בשדות");
            }
        }
        public string IDclient
        {
            get { return iDclient; }
            set
            {
                if (Validation.IsID(value)&&value !="")
                    this.iDclient = value;
                else throw new Exception("הקש ת.ז חוקית");
            }
        }
        public DateTime  Valibity
        {
            get { return valibity; }
            set
            {
                if (value > DateTime.Now)
                    this.valibity = value;
                else throw new Exception("הכרטיס אינו בתוקף אין אפשרות להוסיף כרטיס זה");
            }
        }
    }
}
