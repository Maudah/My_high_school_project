using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using ElbarProject.DAL;

namespace ElbarProject.BLL
{
 public    class Branch:GeneralRow 
    {
        private int branchCoude;//קוד סניף
        private string  branchName;//שם סניף
        private string address;//כתובת
        private int city;//עיר
        private int manager;//מנהל
       
        public Branch()
        { }
        public Branch (int branchCoude)
        {
            BranchTable br= new BranchTable() ;
            this.dRow = br.Find(branchCoude);
            if (dRow != null)
                this.FillFields();
            else
                throw new Exception("לא נמצא לקוח עם תז זו");
        }
       
       
         public override  void FillDataRow()
        {
            dRow["BranchCoude"] = this.branchCoude;
            dRow["BranchName"] = this.branchName;
            dRow["Address"] = this.address;
            dRow["City"] = this.city;
            dRow["Manager"] = this.manager;
         }
         public override void FillFields()
         {
             this.branchCoude = Convert.ToInt32(dRow["BranchCoude"]);
             this.branchName = Convert.ToString(dRow["BranchName"]);
             this.address = Convert.ToString(dRow["Address"]);
             this.city = Convert.ToInt32(dRow["City"]);
             this.manager = Convert.ToInt32 (dRow["manager"]);
         }
        public int BranchCoude
        {
            get { return branchCoude; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value)) == true)
                    branchCoude = value;
                else
                    throw new Exception("הקש מספרים בלבד");
            }
        }
        public string BranchName
        {
            get { return branchName; }
            set
            {
                if  (value != "" && value != null)
                    branchName = value;
                else
                    throw new Exception("הקש שם סניף בעיברית בלבד");
            }
        }
        public string Address
        {
            get { return  address; }
            
            set
            {
                if (value != "" && value != null)
                    address = value;
                else
                    throw new Exception("מלא נתונים בשדות");          
            }
        }
        public int City
        {
            get { return city; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value)) == true)
                    city = value;
                else
                    throw new Exception("שם העיר שהקשת אינו חוקי");
            }
        }
        public int Manager
        {
            get { return manager; }
            set
            {                
                    manager = value;                
            }
        }
    }
}
