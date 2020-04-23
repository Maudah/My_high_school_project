using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;
using System.Windows.Forms;

namespace ElbarProject.BLL
{
    abstract   class GeneralTable
    {

        protected   static Dal d = new Dal();//מופע לכל הטבלאות
        protected   DataTable table;//הפניה לטבלה
        protected   string key;//מפתח ראשי
        protected   string tableName;//שם טבלה
        
        public GeneralTable (string tableName, string key)
        {
            this.tableName = tableName;//שפ טבלה
            this.key = key;//מפתח ראשי
            //להוסיף את הטבלה לדטהסט
            d.AddTable(tableName);
            //קישור ההפניה לטבלה בDAL
            table = d.GetTable(tableName);
        }
        public  DataTable GetTable()
        {
            return table;
        }
        public string GetKey ()
        {
            return key;
        }
        public string GetTableName()
        {
            return tableName;
        }
        //חיפוש עצם לפי נתון בכל השדות
        public DataRow Find(object value)
        {

            //item - שם משתנה מקומי לפריט אחד מתוך האוסף
            foreach (DataRow item in table.Rows)//עבור על פריט באוסף הרשומות של הטבלה תבצע...
            {
                if (item[key ].Equals(value))
                    return item;
            }
            return null;
        }
        //חיפוש עצם לפי נתון בשדה מסויים
        public DataRow Find(string columnName, object value)
        {

            //item - שם משתנה מקומי לפריט אחד מתוך האוסף
            foreach (DataRow item in table.Rows)//עבור על פריט באוסף הרשומות של הטבלה תבצע...
            {
                if (item[columnName].Equals(value))
                    return item;
            }
            return null;
        }
        public int GetNewKey()
        {
            DataTable dt = d.GetQuery("select max(" + key + ") from " + this .tableName);
            return Convert.ToInt32(dt.Rows[0][0]) + 1;
        }
        public void AddToAccess( GeneralRow currentObj)
        {
            currentObj.dRow = table.NewRow();
            currentObj.FillDataRow();
            table.Rows.Add(currentObj.dRow);
            d.SaveToAccess(tableName);
        }
        //פונ זו מקבלת את האובייק הנוכחי שאמור להתעדכן באקסס
        public void UpdateToAccess(GeneralRow currentObj)
        {
            //מילוי מהשדות לדרוי
            currentObj.FillDataRow();
            //עדכון מהדרוי לאקסס
            d.SaveToAccess(tableName);
        }
        public virtual void DeleteToAccess(GeneralRow currentObj)
        {
            //מסמן למחיקה
            currentObj.dRow.Delete();
            //עדכון מהדרוי לאקסס
            d.SaveToAccess(tableName);
        }
    }
}
