﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;

namespace ElbarProject.BLL
{
     class GroupTable:GeneralTable 
    {
        public GroupTable ():base("tblGroup", "coudeGroup") { }
    }
}
