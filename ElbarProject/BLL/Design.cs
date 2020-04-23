using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using ElbarProject.DAL;

namespace ElbarProject.BLL
{
  public   class Design:GeneralRow 
    {
        private int coudDesign;//קוד דגם
        private string nameDesign;//שם דגם
        private int manufacturer;//יצרן
        private int numPlaces;//מס מקומות
        private int group;//קבוצה
        private int   manufacturYear;//שנת ייצור
        private int volumeMotor;//נפח מנוע
        public Design() { }
        public Design(int coudDesign,string nameDesign,int manufacturer,int numPlaces,int group,int   manufacturYear,int volumeMotor)
        {
            this.coudDesign = coudDesign;
            this.nameDesign = nameDesign;
            this.manufacturer = manufacturer;
            this.numPlaces = numPlaces;
            this.group = group;
            this.manufacturYear = manufacturYear;
            this.volumeMotor = volumeMotor;
        }
        public Design(int coudDesign)
        {
            DesignTable  ca = new DesignTable ();
            this.dRow = ca.Find(coudDesign);
            if (this.dRow != null)
                this.FillFields();
            else
                throw new Exception("לא נמצאו שדות");
        }
        public override void FillDataRow()
        {
            dRow["CoudDesign"] = this.coudDesign;
            dRow["NameDesign"] = this.nameDesign;
            dRow["Manufacturer"] = this.manufacturer;
            dRow["NumPlaces"] = this.numPlaces;
            dRow["Groupss"] = this.group;
            dRow["ManufacturYear"] = this.manufacturYear;
            dRow["VolumeMotor"] = this.volumeMotor;
        }
        public override void FillFields()
        {
            this.coudDesign = Convert.ToInt32(dRow["CoudDesign"]);
            this.nameDesign = Convert.ToString (dRow["NameDesign"]);
            this.manufacturer = Convert.ToInt32(dRow["Manufacturer"]);
            this.numPlaces = Convert.ToInt32(dRow["NumPlaces"]);
            this.group = Convert.ToInt32(dRow["Groupss"]);
            this.manufacturYear = Convert.ToInt32  (dRow["ManufacturYear"]);
            this.volumeMotor = Convert.ToInt32(dRow["VolumeMotor"]);

        }
        public int CoudDesign
        {
            get { return coudDesign; }
            set
            {
                
                    this.coudDesign = value;
               
            }
        }
        public string NameDesign
        {
            get { return nameDesign; }
            set
            {
                if (Validation.IsEnglish(value) && value != "")
                    this.nameDesign = value;
                else throw new Exception("הקש דגם באנגלית");
            }
        }
        public int Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value)))
                    this.manufacturer = value;
                else throw new Exception("הקש מספרים בלבד");
            }
       }
        public int NumPlaces
        {
            get { return numPlaces; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value))&&value<10 && value.ToString () != "")
                    this.numPlaces = value;
                else throw new Exception("הקש מספר מקומות הגיוני");
            }
        }
        public int Group
        {
            get { return group; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value)))
                    this.group = value;
                else throw new Exception("הקש מספרים בלבד");
            }
        }
        public int  ManufacturYear
        {
            get { return manufacturYear; }
            set
            {        
                if(value.ToString() != "")       
                    this.manufacturYear = value;
                else throw new Exception("מלא נתונים בשדות");
            }       
        }
        public int VolumeMotor
        {
            get { return volumeMotor; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value))&&value.ToString() != "")
                    this.volumeMotor = value;
                else throw new Exception("מלא נתונים");
            }
        }
    }
}
