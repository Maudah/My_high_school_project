using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;
namespace ElbarProject.BLL
{
  public   class Manufacturer:GeneralRow 
    {
        private int coudeManufacturer;//קוד יצרן
        private string nameManufacturer;//שם יצרן
        public Manufacturer(int coudeManufacturer, string nameManufacturer)
        {
            this.coudeManufacturer = coudeManufacturer;
            this.nameManufacturer = nameManufacturer;
        }
        public Manufacturer() { }
        public Manufacturer(int coudeManufacturer)
        {
            ManufacturerTable ma = new ManufacturerTable ();
            this.dRow = ma.Find(coudeManufacturer);
            if (this.dRow != null)
                this.FillFields();
            else
                throw new Exception("לא נמצאו שדות");
        }
        public override void FillDataRow()
        {
            dRow["CoudeManufacturer"] = this.coudeManufacturer;
            dRow["NameManufacturer"] = this.nameManufacturer;
        }
        public override void FillFields()
        {
            this.coudeManufacturer = Convert.ToInt32(dRow["CoudeManufacturer"]);
            this.nameManufacturer = Convert.ToString(dRow["NameManufacturer"]);
        }
        public int CoudeManufacturer
        {
            get { return coudeManufacturer; }
            set { this.coudeManufacturer = value; }
        }
        public string NameManufacturer
        {
            get { return nameManufacturer; }
            set {
                if (value.ToString() != "")
                    this.nameManufacturer = value;
                else throw new Exception("מלא נתונים");
                
            }
        }
    }
}
