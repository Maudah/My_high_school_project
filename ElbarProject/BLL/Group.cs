using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;

namespace ElbarProject.BLL
{
 public    class Group:GeneralRow 
    {
        private int coudeGroup;//קוד קבוצה
        private string describeGroup;//תיאור קבוצה
        private string nameGroup;//שם קבוצה
        private int  dayTariff;//תעריף יומי
        private int weekTarif;//תעריף שבועי
        private int monthTariff;//תעריף חודשי
        private int addKM;//מחיר לק'מ נוסף
        private int addHour;//מחיר לשעה נוספת
  
        private int carInsurance;//דמי ביטוח
        public Group() { }
        public Group(int  coudeGroup,string describeGroup,string nameGroup,int dayTariff,int weekTarif,int monthTariff,int addKM,int addHour,int carInsurance)
        {
            this.coudeGroup = coudeGroup;
            this.describeGroup = describeGroup;
            this.nameGroup = nameGroup;
            this.dayTariff = dayTariff;
            this.weekTarif = weekTarif;
            this.monthTariff = monthTariff;
            this.addKM = addKM;
            this.addHour = addHour;
            
            this.carInsurance = carInsurance;
        }
        public Group(int coudeGroup)
        {
            GroupTable   gr = new GroupTable  ();
            this.dRow = gr.Find(coudeGroup);
            if (this.dRow != null)
                this.FillFields();
            else
                throw new Exception("לא נמצאו שדות");
        }
        public override void FillDataRow()
        {
            dRow["coudeGroup"] = this.coudeGroup;
            dRow["describeGroup"] = this.describeGroup;
            dRow["nameGroup"] = this.nameGroup;
            dRow["dayTariff"] = this.dayTariff;
            dRow["weekTarif"] = this.weekTarif;
            dRow["monthTariff"] = this.monthTariff;
            dRow["addKM"] = this.addKM;
            dRow["addHour"] = this.addHour;
        
            dRow["carInsurance"] = this.carInsurance;

        }
        public override void FillFields()
        {
            this.coudeGroup = Convert.ToInt32(dRow["CoudeGroup"]);
            this.describeGroup = Convert.ToString (dRow["DescribeGroup"]);
            this.nameGroup = Convert.ToString (dRow["NameGroup"]);
            this.dayTariff = Convert.ToInt32(dRow["DayTariff"]);
            this.weekTarif = Convert.ToInt32(dRow["WeekTarif"]);
            this.monthTariff = Convert.ToInt32(dRow["MonthTariff"]);
            this.addKM = Convert.ToInt32(dRow["AddKM"]);
            this.addHour = Convert.ToInt32(dRow["AddHour"]);
  
            this.carInsurance = Convert.ToInt32(dRow["CarInsurance"]);
        }
        public int CoudeGroup
        {
            get { return coudeGroup; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value)))
                    this.coudeGroup = value;
                else throw new Exception("הקש מספרים בלבד");
            }
        }
        public string DescribeGroup
        {
            get { return describeGroup; }
            set
            {
                if (Validation.IsHebrew(value))
                    this.describeGroup = value;
                else throw new Exception("הקש תיאור בעברית בלבד");
            }
        }
        public string NameGroup
        {
            get { return nameGroup; }
            set { this.nameGroup = value; }
        }
        public int DayTariff
        {
            get { return dayTariff; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value)))
                    this.dayTariff = value;
                else throw new Exception("הקש מספרים בלבד");
            }
        }
        public int WeekTarif
        {
            get { return weekTarif; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value)))
                    this.weekTarif = value;
                else throw new Exception("הקש מספרים בלבד");
            }
        }
        public int MonthTariff
        {
            get { return monthTariff; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value)))
                    this.monthTariff = value;
                else throw new Exception("הקש מספרים בלבד");
            }
        }
        public int AddKM
        {
            get { return addKM; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value)))
                    this.addKM = value;
                else throw new Exception("הקש מספרים בלבד");
            }
        }
        public int AddHour
        {
            get { return addHour; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value)))
                    this.addHour = value;
                else throw new Exception("הקש מספרים בלבד");
            }
        }
        public int CarInsurance
        {
            get { return carInsurance; }
            set
            {
                if (Validation.IsNumbers(Convert.ToString(value)))
                    this.carInsurance = value;
                else throw new Exception("הקש מספרים בלבד");
            }
        }
    }
}
