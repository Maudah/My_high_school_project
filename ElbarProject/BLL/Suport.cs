using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using ElbarProject.DAL;
namespace ElbarProject.BLL
{
   public  class Suport
    {
        public static void FillCombox(ComboBox cmb, DataTable table, string display, string valMember)
        {
            //מקור הנתונים של הקומבובוקס 
            cmb.DataSource = table;
            //הערך שיהיה מוצג
            cmb.DisplayMember = display;
            //הערך החבוי של השדה
            cmb.ValueMember = valMember;
        }
    }
}
