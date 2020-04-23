using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;

namespace ElbarProject.BLL
{
     class JobTable:GeneralTable 
    {
        public JobTable ():base("tblJob", "coudeJob") { }
    }
}
