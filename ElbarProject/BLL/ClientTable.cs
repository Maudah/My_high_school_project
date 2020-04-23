using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;

namespace ElbarProject.BLL
{
     class ClientTable:GeneralTable 
    {
        public ClientTable():base ("tblClient", "iDclient") { }
    }
}
