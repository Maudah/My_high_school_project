using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;
namespace ElbarProject.BLL
{
     class TakesTable:GeneralTable 
    {
        public TakesTable() : base("tblTakes", "numTakes") { }
        public  DataTable GetDataTakes(string id)
        {
            return d.GetQuery("select tblTakes.numTakes, tblTakes.numCar, tblTakes.IDclient, tblDesign.nameDesign, tblDesign.manufacturer from tblDesign inner join(tblCar inner join  tblTakes on tblCar.carNumber = tblTakes.numCar) on tblDesign.coudDesign = tblCar.coudDesign where tblTakes.IDclient='" + id + "'");
        }
        public static  DataTable GetTableForSearch(string id)
        {
            return d.GetQuery("select tblTakes.numTakes, tblTakes.numCar, tblTakes.IDclient, tblTakes.dateTake, tblDesign.nameDesign, tblManufacturer.nameManufacturer from tblManufacturer inner join(tblDesign inner join(tblCar inner join tblTakes on tblCar.carNumber = tblTakes.numCar) on tblDesign.coudDesign = tblCar.coudDesign) on tblManufacturer.coudeManufacturer = tblDesign.manufacturer where tblTakes.IDclient= '" + id + "'");
        }
         public  DataTable GetTableForReportInviting(int numinviting)
        {
            return d.GetQuery("select tblTakes.numTakes as numTakes, tblTakes.numCar as numCar, tblDesign.nameDesign as nameDesign, tblManufacturer.nameManufacturer as nameManufacturer, tblTakes.dateTake AS dateTake, tblTakes.dateReturn AS dateReturn, tblTakes.toPay AS toPay, tblClient.IDclient AS IDclient, tblClient.firstName as firstName, tblClient.lastName as lastName, tblClient.address as address, tblClient.numHome as numHome, tblClient.telephne as telephne, tblClient.phone as phone, tblClient.numLicense as numLicense, tblKindLicense.nameLicense as nameLicense, tblCity.nameCity as nameCity from tblCity inner join  (tblKindLicense inner join (tblManufacturer inner join (tblDesign inner join (tblClient inner join (tblCar inner join tblTakes on tblCar.carNumber = tblTakes.numCar) on tblClient.IDclient = tblTakes.IDclient) on tblDesign.coudDesign = tblCar.coudDesign) on tblManufacturer.coudeManufacturer = tblDesign.manufacturer) on tblKindLicense.coudeLicense = tblClient.kindLicense) on tblCity.coudeCity = tblClient.city where numTakes="+numinviting );
        }
         public DataTable GetTableForReportReturn(int numReturn)
         {
             return d.GetQuery("select tblTakes.numTakes as numTakes, tblTakes.numCar as numCar, tblTakes.IDclient as IDclient, tblClient.firstName as firstName, tblClient.lastName as lastName, tblTakes.dateTake as dateTake, tblTakes.timeTake as timeTake, tblTakes.dateReturn as dateReturn, tblTakes.timeReturn as timeReturn, tblBranch.branchName as branchName, tblTakes.amountGasReturn as amountGasReturn, tblTakes.numKMreturn as numKMreturn, tblTakes.toPay as toPay, tblTakes.carInsurance as carInsurance, tblTakes.codeCraditCard as codeCraditCard from tblBranch inner join (tblClient inner join tblTakes on tblClient.IDclient = tblTakes.IDclient) on tblBranch.branchCoude = tblTakes.coudBranchReturn where numTakes=" + numReturn); 
         }
         public DataTable GetTableForReportTakes(int numTake)
         {
             return d.GetQuery("SELECT tblTakes.numTakes as numTakes, tblTakes.numCar as numCar, tblDesign.nameDesign as nameDesign, tblManufacturer.nameManufacturer as nameManufacturer, tblTakes.IDclient as IDclient, tblClient.firstName as firstName, tblClient.lastName as lastName, tblTakes.dateTake as dateTake, tblTakes.timeTake as timeTake, tblBranch.branchName as branchName, tblCar.amountGasIn as amountGasIn, tblCar.droveKM as droveKM, tblTakes.carInsurance as carInsurance, tblTakes.codeCraditCard as codeCraditCard from tblBranch inner join (tblManufacturer inner join (tblDesign inner join (tblClient inner join (tblCar inner join tblTakes on tblCar.carNumber = tblTakes.numCar) on tblClient.IDclient = tblTakes.IDclient) on tblDesign.coudDesign = tblCar.coudDesign) on tblManufacturer.coudeManufacturer = tblDesign.manufacturer) on (tblBranch.branchCoude = tblTakes.coudBranchReturn) and (tblBranch.branchCoude = tblCar.coudBranch) where numTakes=" + numTake );
         }
    }
}
