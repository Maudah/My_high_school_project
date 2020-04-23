using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using ElbarProject.DAL;

namespace ElbarProject.BLL
{
  public   class Job:GeneralRow 
    {
        private int doudeJob;//קוד תפקיד
        private string  nameJob;//שם תפקיד
        private int salary;//שכר לשעה
        public Job() { }
        public Job(int doudeJob,string nameJob,int salary)
        {
            this.doudeJob = doudeJob;
            this.nameJob = nameJob;
            this.salary = salary;
        }
        public Job(int coudeJob)
        {
            JobTable   jo = new JobTable   ();
            this.dRow = jo.Find(coudeJob);
            if (this.dRow != null)
                this.FillFields();
            else
                throw new Exception("לא נמצאו שדות");
        }
        public override void FillDataRow()
        {
            dRow["doudeJob"] = this.doudeJob;
            dRow["NameJob"] = this.nameJob;
            dRow["Salary"] = this.salary;
        }
        public override void FillFields()
        {
            this.doudeJob = Convert.ToInt32(dRow["doudeJob"]);
            this.nameJob = Convert.ToString(dRow["NameJob"]);
            this.salary = Convert.ToInt32(dRow["Salary"]);
        }
        public int DoudeJob
        {
            get
            {
                return doudeJob;
            }
            set { this.doudeJob = value; }
        }
        public string NameJob
        {
            get { return nameJob; }
            set
            {
                if (Validation.IsHebrew(value))
                    this.nameJob = value;
                else throw new Exception("הקש תפקיד מעברית");
            }
        }
        public int Salary
        {
            get { return salary; }
            set { this .salary = value; }
        }
    }
}
