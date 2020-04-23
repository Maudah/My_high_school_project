using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElbarProject.DAL;
using System.Data;


namespace ElbarProject.BLL
{
   public abstract  class GeneralRow
    {
        public DataRow dRow { get; set; }
        public abstract void FillFields();
        public abstract void FillDataRow();
    }
}
