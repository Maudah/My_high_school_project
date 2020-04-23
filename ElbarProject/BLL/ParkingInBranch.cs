using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;
namespace ElbarProject.BLL
{
 public    class ParkingInBranch:GeneralRow 
    {
        private int coudParking;//קוד חניה
        private string numParking;//מס חניה
        private int coudeBranch;//קוד סניף
        private bool fullparking;
        public ParkingInBranch (int coudParking,string numParking,int coudeBranch )
        {
            this.coudParking = coudParking;
            this.numParking = numParking;
            this.coudeBranch = coudeBranch;

        }
        public ParkingInBranch()
        { }
        public ParkingInBranch(int coudParking)
        {
            ParkingInBranchTable  pa = new ParkingInBranchTable  ();
            this.dRow = pa.Find(coudParking);
            if (this.dRow != null)
                this.FillFields();
            else
                throw new Exception("לא נמצאו שדות");
        }
        public override void FillDataRow()
        {
            dRow["CoudParking"] = this.coudParking;
            dRow["NumParking"] = this.numParking;
            dRow["CoudeBranch"] = this.coudeBranch;
            dRow["fullparking"] = this.fullparking;
        }
        public override void FillFields()
        {
            this.coudParking = Convert.ToInt32(dRow["CoudParking"]);
            this.numParking = Convert.ToString(dRow["NumParking"]);
            this.coudeBranch = Convert.ToInt32(dRow["CoudeBranch"]);
            this.fullparking = Convert.ToBoolean(dRow["fullparking"]);
           
        }
        public int CoudParking
        {
            get { return coudParking; }
            set { this.coudParking = value; }
        }
        public string NumParking
        {
            get { return numParking; }
            set { this.numParking = value; }
        }
        public int CoudeBranch
        {
            get { return coudeBranch; }
            set { this.coudeBranch = value; }
        }
        public bool Fullparking
        {
            get { return fullparking; }
            set { this.fullparking = value; }
        }
    }
}
