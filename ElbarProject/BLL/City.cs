using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;

namespace ElbarProject.BLL
{
   public  class City:GeneralRow 
    {
        private int coudeCity;
        private string nameCity;
        public City() { }
        public City(int coudeCity, string nameCity)
        {
            this.coudeCity = coudeCity;
            this.nameCity = nameCity;
        }
        public City (int coudeCity)
        {
            CarTable ct = new CarTable();
            this.dRow = ct.Find(coudeCity);
            if (this.dRow != null)
                this.FillFields();
            else
                throw new Exception("לא נמצאו שדות");


        }
        public override void FillDataRow()
        {
            dRow["CoudeCity"] = this.coudeCity;
            dRow["NameCity"] = this.nameCity;
        }
        public override void FillFields()
        {
            this.coudeCity = Convert.ToInt32 (dRow["CoudeCity"]);
            this.nameCity = Convert.ToString (dRow["NameCity"]);
        }
        public int CoudeCity
        {
            get { return coudeCity; }
            set
            {
                this.coudeCity = value;
            }
        }
        public string NameCity
        {
            get { return nameCity; }
            set
            {
                if (Validation.IsHebrew(nameCity))
                    this.nameCity = value;
                else throw new Exception("הקש שם בעברית");
            }
        }
    }
}
