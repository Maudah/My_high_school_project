using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using ElbarProject.DAL;
namespace ElbarProject.BLL
{
     class WorkerTable:GeneralTable 
    {
        public WorkerTable() : base("tblWorker", "iDWorker") { }
        public override void DeleteToAccess(GeneralRow currentObj)
        {
            ((Worker)currentObj).Active = false;
            currentObj.FillDataRow();
            d.SaveToAccess(this.tableName);
            
        }
        public static bool GetIfDelId(string id)
        {
            DataTable dt = d.GetQuery("select *  from tblWorker  inner join tblSalary  on tblWorker.idWorker=tblSalary.codeWorker where tblSalary.codeWorker='" + id + "'");
            if (dt.Rows.Count != 0)
                return false;
            return true;
        }
        public  DataTable GetMenager()
        {
            return d.GetQuery("select tblWorker.idWorker, tblWorker.firstName&' '&tblWorker.lastName as [fullName], tblWorker.jobCoude from tblWorker where(((tblWorker.jobCoude) = 2))");
        }
    }
    
}
