using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;
namespace ElbarProject.BLL
{
   public  class Salary:GeneralRow 
    {
        private string  salaryCoud;
        private string codeWorker;
        private string timeEnter;
        private string timeLeave;
        private string  dateToday;  
        public Salary() { }
        
        public Salary(string  salaryCoud)
        {
            SalaryTable   sa = new SalaryTable   ();
            this.dRow = sa.Find(salaryCoud);
            if (this.dRow != null)
                this.FillFields();
            else
                throw new Exception("לא נמצאו שדות");
        }
        public override void FillDataRow()
        {
            dRow["SalaryCoud"] = this.salaryCoud;
            dRow["codeWorker"] = this.codeWorker;
            dRow["TimeEnter"] = this.timeEnter;
            dRow["TimeLeave"] = this.timeLeave;
            dRow["dateToday"] = this.dateToday;
        }
        public override void FillFields()
        {
            this.salaryCoud = Convert.ToString  (dRow["SalaryCoud"]);
            this.codeWorker = Convert.ToString(dRow["codeWorker"]);
            this.timeEnter = Convert.ToString(dRow["TimeEnter"]);
            this.timeLeave = Convert.ToString(dRow["TimeLeave"]);
            this.dateToday = Convert.ToString  (dRow["dateToday"]);
        }
        
        public string  SalaryCoud
        {
            get { return salaryCoud; }
            set {
                if (Validation.IsNumbers(Convert.ToString(value)))
                    salaryCoud = value;
                else throw new Exception("הקש מספרים בלבד");
                }
        }
        public string   DateToday
        {
            get { return dateToday; }
            set { dateToday = value ; }
        }
        public string CodeWorker
        {
            get { return codeWorker; }
            set {
                if (Validation.IsID(value ))
                    this.codeWorker = value;
                else throw new Exception("הקש תז חוקית");
            }
        }
        public string TimeEnter
        {
            get { return timeEnter; }
            set {

                timeEnter = value;
            }
        }
        public string TimeLeave
        {
            get { return timeLeave; }
            set {

                timeLeave = value;
            
            }
        }
    }
}
