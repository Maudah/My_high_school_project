using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;
namespace ElbarProject.BLL
{
  public   class Worker:GeneralRow 
    {
        
        private string iDWorker;
        private string firstName;
        private string lastName;
        private int jobCoude;
        private string address;
        private int homeNum;
        private int city;
        private string telephone;
        private string phone;
        private int branchCoude;
        private bool active;      
        public Worker() { }
        public Worker(string  iDWorker)
        {
            WorkerTable wo = new WorkerTable();
            this.dRow = wo.Find(iDWorker);
            if (this.dRow != null)
                this.FillFields();
            else
                throw new Exception("לא נמצאו שדות");
        }
        public override void FillDataRow()
        {
            dRow["iDWorker"] = this.iDWorker;
            dRow["firstName"] = this.firstName;
            dRow["lastName"] = this.lastName;
            dRow["jobCoude"] = this.jobCoude;
            dRow["address"] = this.address;
            dRow["homeNum"] = this.homeNum;
            dRow["city"] = this.city;
            dRow["telephone"] = this.telephone;
            dRow["phone"] = this.phone;
            dRow["branchCoude"] = this.branchCoude;
            dRow["active"] = this.active;
        }
        public override void FillFields()
        {
            this.iDWorker = Convert.ToString(dRow["iDWorker"]);
            this.firstName = Convert.ToString(dRow["firstName"]);
            this.lastName = Convert.ToString(dRow["lastName"]);
            this.jobCoude = Convert.ToInt32 (dRow["jobCoude"]);
            this.address = Convert.ToString(dRow["address"]);
            this.homeNum = Convert.ToInt32 (dRow["homeNum"]);
            this.city = Convert.ToInt32 (dRow["city"]);
            this.telephone = Convert.ToString(dRow["telephone"]);
            this.phone = Convert.ToString(dRow["phone"]);
            this.branchCoude = Convert.ToInt32 (dRow["branchCoude"]);
            this.active = Convert.ToBoolean (dRow["active"]);
        }
        public string IDWorker
        {
            get { return iDWorker; }
            set
            {
                if (Validation.IsID(value))
                    this.iDWorker = value;
                else throw new Exception("הקש תז חוקית");
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (Validation.IsHebrew (value) && value.ToString() != "")
                    this.firstName  = value;
                else throw new Exception(" הקש שם בעברית בלבד");
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (Validation.IsHebrew(value) && value.ToString() != "")
                    this.lastName = value;
                else throw new Exception("הקש שם בעברית בלבד");
            }
        }
        public int JobCoude
        {
            get { return jobCoude; }
            set { jobCoude = value; }
        }
        public string Address
        {
            get { return address; }
            set
            {
                if (Validation.IsHebrew(value) && value.ToString() != "")
                    this.address = value;
                else throw new Exception("הקש כתובת בעברית בלבד");
            }
        }
        public int HomeNum
        {
            get { return homeNum; }
            set {
                if ( value.ToString() != "")
                    homeNum = value;
                else throw new Exception("מלא נתונים");  }
        }
        public int City
        {
            get { return city; }
            set { city = value; }
        }
        public string Telephone
        {
            get { return telephone; }
            set
            {
                if (Validation.Phone(value) && value.ToString() != "")
                    this.telephone = value;
                else throw new Exception("מספר הטלפון שהקשת אינו חוקי");
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (Validation.IsPhone(value) && value.ToString() != "")
                    this.phone = value;
                else throw new Exception("מספר הטלפון שהקשת אינו חוקי");
            }
        }
        public int BranchCoude
        {
            get { return branchCoude; }
            set { branchCoude = value; }
        }
        public bool Active
        {
            get { return active; }
            set { active = value; }
        }
    }
}
