using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ElbarProject.DAL
{
     class Dal
    {
        DataSet ds;
        OleDbConnection con;
        //פעולה בונה לאיתחול לאובייקט שיכיל את כל הנתונים מהדטהסט ולקישור לדטהסט
        public Dal()
        {
            ds = new DataSet();
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\ElbarProjec.accdb");

        }
        // מוסיפה את הטבלה לדטהסט
        public void AddTable(string tableName)
        {
            if (ds.Tables.Contains(tableName)==false)
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from " + tableName, con);
                adapter.Fill(ds, tableName);
            }

        }
        //מחזירה  טבלה מהדטהסט
        public DataTable GetTable(string tableName)
        {
            return ds.Tables[tableName];
        }
        //המקבלת שאילתה ומחזירה את הטבלה
        public   DataTable GetQuery(string SQLquery)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(SQLquery, con);            
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public void SaveToAccess(string tableName)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from " + tableName, con);
            //עצם שעוזר בבנית משפטי הוספה עדכון ומחיקה
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            try {
                adapter.Update(ds, tableName);
            }
            catch
            {
                MessageBox.Show("try again later");
            }
        }
    }
}
