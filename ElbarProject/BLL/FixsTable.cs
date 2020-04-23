using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;


namespace ElbarProject.BLL
{
     class FixsTable:GeneralTable 
    {
        public FixsTable ():base("tblFixs", "fixCoude") { }
        public override void DeleteToAccess(GeneralRow currentObj)
        {
            ((Fixs)currentObj).IsFix = true;
            currentObj.FillDataRow();
            d.SaveToAccess(this.tableName);
           
        }
         public DataTable GetFixisTable()
        {
             // where (((tblTakes.dateTake)>#" + th + "#) or ((tblTakes.dateReturn)<#" + fh + "#))");
            DateTime dt = DateTime.Now;
            return d.GetQuery("select tblFixs.fixCoude as fixCoude, tblFixs.carNumber as carNumber, tblFixs.iDClient as iDClient, tblClient.firstName as firstName, tblClient.lastName as lastName, tblFixs.describeFix as describeFix, tblFixs.describeDamage as describeDamage, tblFixs.toPay as toPay, tblCar.dateTest as dateTest, tblCar.dateInsurance as dateInsurance, tblCar.droveKM as droveKM,  tblFixs.isFix as isFix from tblClient inner join  (tblCar inner join  tblFixs on tblCar.carNumber = tblFixs.carNumber) on tblClient.IDclient = tblFixs.iDClient where (((dateTest)>=#" + dt + "#) or ((dateInsurance)>=#" + dt + "#) and ((isFix)=true))");
        }
        
    }
   
   
   
}
