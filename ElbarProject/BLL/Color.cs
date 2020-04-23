using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;

namespace ElbarProject.BLL
{
  public   class Colors:GeneralRow 
    {
        private int coudeColor;//קוד צבע
        private string nameColor;//שם צבע
        public Colors() { }
        public Colors (int coudeColor, string nameColor )
        {
            this.coudeColor = coudeColor;
            this.nameColor = nameColor;
        }
        public Colors(int coudeColor)
        {
            ColorsTable  co = new ColorsTable ();
            this.dRow = co.Find(coudeColor);
            if (this.dRow != null)
                this.FillFields();
            else
                throw new Exception("לא נמצאו שדות");
        }
        public override void FillDataRow()
        {
            dRow["CoudeColor"] = this.coudeColor;
            dRow["NameColor"] = this.nameColor;
        }
        public override void FillFields()
        {
            this.coudeColor = Convert.ToInt32 (dRow["CoudeColor"]);
            this.nameColor = Convert.ToString(dRow["NameColor"]);
        }
        public int CoudeColor
        {
            get { return coudeColor; }
            set { this. coudeColor = value; }
        }
        public string NameColor
        {
            get { return nameColor; }
            set
            {
                if (Validation.IsHebrew(value))
                    this.nameColor = value;
                else throw new Exception("הקש צבע בעברית");

            }
        }
    }
}
