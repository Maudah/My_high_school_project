using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;
namespace ElbarProject.BLL
{
public     class KindLicense:GeneralRow 
    {
        private int coudeLicense;//קוש רשיון
        private string nameLicense;//שם רשיון
        public KindLicense (int coudeLicense,string nameLicense)
        {
            this.coudeLicense = coudeLicense;
            this.nameLicense = nameLicense;
        }
        public KindLicense() { }
        public KindLicense(int coudeLicense)
        {
            KindLicenseTable ki = new KindLicenseTable();
            this.dRow = ki.Find(coudeLicense);
            if (this.dRow != null)
                this.FillFields();
            else
                throw new Exception("לא נמצאו שדות");
        }
        public override void FillDataRow()
        {
            dRow["CoudeLicense"] = this.coudeLicense;
            dRow["NameLicense"] = this.nameLicense;
        }
        public override void FillFields()
        {
            this.coudeLicense = Convert.ToInt32(dRow["CoudeLicense"]);
            this.nameLicense = Convert.ToString(dRow["NameLicense"]);
        }
        public int CoudeLicense
        {
            get { return coudeLicense; }

            set
            {
                if (value.ToString() != "")
                    this.coudeLicense = value;
                else throw new Exception("מלא נתונים");
               
            }
        }
        public string NameLicense
        {
            get { return nameLicense; }
            set {
                if (value.ToString() != "")
                      this.nameLicense = value; 
                else throw new Exception("מלא נתונים");
              }
        }
    }
}
