using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;

namespace ElbarProject.BLL
{
     class ParkingInBranchTable:GeneralTable 
    {
        public ParkingInBranchTable ():base("tblParkingInBranch", "coudParking") { }
      
        public  DataTable FillConbo(int x)
        {
            return d.GetQuery("select tblParkingInBranch.coudParking, tblParkingInBranch.numParking&'  '&tblParkingInBranch.fullparking as[fullName], tblParkingInBranch.coudeBranch   from tblParkingInBranch where tblParkingInBranch.coudeBranch=" + x);
         
        }

    }

}
