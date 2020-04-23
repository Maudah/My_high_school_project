using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;
namespace ElbarProject.BLL
{
     class SalaryTable:GeneralTable 
    {
        public SalaryTable() : base("tblSalary", "salaryCoud") { }
        public static  DataTable GetDisplayTable(string id)
        {
          
            return d.GetQuery("select tblSalary.salaryCoud, tblSalary.IdWorker, tblSalary.timeEnter, tblSalary.timeLeave, tblSalary.dateToday from tblSalary where(tblSalary.IdWorker) ='"+id+"'");
        }
    }
}
