using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;

namespace ElbarProject.BLL
{
     class CreditCardTable:GeneralTable 
    {
        public CreditCardTable  ():base ("tblCreditCard", "coudcCeditCard") { }
        public DataTable GetCards(string id)
        {
            return d.GetQuery("select coudcCeditCard,numCard from tblCreditCard where IDclient='"+id+"'");
        }
    }
    
}
