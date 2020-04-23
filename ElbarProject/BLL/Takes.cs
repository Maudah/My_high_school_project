using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;
namespace ElbarProject.BLL
{
public     class Takes:GeneralRow 
    {
        private int numTakes;
        private string numCar;
        private string iDclient;
        private string dateInitation;
        private string dateTake;
        private string timeTake;
        private string dateReturn;
        private string timeReturn;
        private int coudBranchReturn;    
        private int amountGasReturn;
        private int numKMreturn;
        private int toPay;      
        private bool carInsurance;
        private int codeCraditCard;
        public Takes() { }
        public Takes(int numTakes)
        {
            TakesTable    ta = new TakesTable    ();
            this.dRow = ta.Find(numTakes);
            if (this.dRow != null)
                this.FillFields();
            else
                throw new Exception("לא נמצאו שדות");
        }
        public override void FillDataRow()
        {
            dRow["NumTakes"] = this.numTakes;
            dRow["NumCar"] = this.numCar;
            dRow["IDclient"] = this.iDclient;
            dRow["DateInitation"] = this.dateInitation;
            dRow["DateTake"] = this.dateTake;
            dRow["TimeTake"] = this.timeTake;
            dRow["DateReturn"] = this.dateReturn;
            dRow["TimeReturn"] = this.timeReturn;
            dRow["CoudBranchReturn"] = this.coudBranchReturn;          
            dRow["AmountGasReturn"] = this.amountGasReturn;
            dRow["NumKMreturn"] = this.numKMreturn;
            dRow["ToPay"] = this.toPay;    
            dRow["carInsurance"] = this.carInsurance;
            dRow["codeCraditCard"] = this.codeCraditCard;
        }
        public override void FillFields()
        {
            this.numTakes = Convert.ToInt32 (dRow["NumTakes"]);
            this.numCar = Convert.ToString(dRow["NumCar"]);
            this.iDclient = Convert.ToString(dRow["IDclient"]);
            this.dateInitation = Convert.ToString(dRow["DateInitation"]);
            this.dateTake = Convert.ToString(dRow["DateTake"]);
            this.timeTake = Convert.ToString(dRow["TimeTake"]);
            this.dateReturn = Convert.ToString(dRow["DateReturn"]);
            this.timeReturn = Convert.ToString(dRow["TimeReturn"]);
            this.coudBranchReturn = Convert.ToInt32 (dRow["CoudBranchReturn"]);       
            this.amountGasReturn = Convert.ToInt32(dRow["AmountGasReturn"]);
            this.numKMreturn = Convert.ToInt32(dRow["NumKMreturn"]);
            this.toPay = Convert.ToInt32(dRow["ToPay"]); 
            this.carInsurance = Convert.ToBoolean(dRow["CarInsurance"]);
            this.codeCraditCard = Convert.ToInt32(dRow["codeCraditCard"]);
        }

        public int NumTakes
        {
            get { return numTakes; }
            set
            {
                //if (value.ToString() != "")
                //    this.nameLicense = value;
                //else throw new Exception("מלא נתונים");
                if (Validation.IsNumbers(Convert.ToString(value))&& value.ToString() != "")
                    numTakes = value;
                else throw new Exception("הקש מספרים בלבד");
            }
        }
        public string NumCar
        {
            get { return numCar; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value)) && value.ToString() != "")
                    numCar = value;
                else throw new Exception("הקש מספרים בלבד");
            }
        }
        public string IDclient
        {
            get { return iDclient; }
            set
            {
                if (Validation.IsID(value) && value.ToString() != "")
                    this.iDclient = value;
                else throw new Exception("הקש תז חוקית");
            }
        }
        public string DateInitation
        {
            get { return dateInitation; }
            set { dateInitation = value; }
        }
        public string DateTake
        {
            get { return dateTake; }
            set { dateTake = value; }
        }
        public string TimeTake
        {
            get { return timeTake; }
            set { timeTake = value; }
        }
        public string DateReturn
        {
            get { return dateReturn; }
            set { dateReturn = value; }
        }
        public string TimeReturn
        {
            get { return timeReturn; }
            set { timeReturn = value; }
        }
        public int CoudBranchReturn
        {
            get { return coudBranchReturn; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value)) && value.ToString() != "")
                    coudBranchReturn = value;
                else throw new Exception("הקש מספרים בלבד");
            }
        }
       
        public int AmountGasReturn
        {
            get { return amountGasReturn; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value)) && value.ToString() != "")
                    amountGasReturn = value;
                else throw new Exception("הקש מספרים בלבד");
            }
        }
        public int NumKMreturn
        {
            get { return numKMreturn; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value)) && value.ToString() != "")
                    numKMreturn = value;
                else throw new Exception("הקש מספרים בלבד");
            }
        }
        public int ToPay
        {
            get { return toPay; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value)) && value.ToString() != "")
                    toPay = value;
                else throw new Exception("הקש מספרים בלבד");
            }
        }
        
        public bool CarInsurance
        {
            get { return carInsurance; }
            set { carInsurance = value; }
        }
        public int  CodeCraditCard
        {
            get { return codeCraditCard; }
            set { codeCraditCard = value; }
        }
    }
}
