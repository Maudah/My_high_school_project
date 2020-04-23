using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;

namespace ElbarProject.BLL
{
  public   class Client:GeneralRow 
    {
        private string iDclient;
        private string firstName;
        private string lastName;
        private string address;
        private int numHome;
        private int city;
        private DateTime  birthDate;
        private string telephne;
        private string phone;
        private int numLicense;
        private DateTime  dateGetLisence;
        private DateTime  valibityLicense;
        private int kindLicense;
        public Client() { }
        public Client (string iDclient)
        {
            ClientTable cl=new ClientTable ();
            this.dRow =cl.Find(iDclient);
            if (dRow != null)
                this.FillFields();
            else
                throw new Exception("לא נמצאו שדות");

        }
        public override void FillDataRow()
        {
            dRow["IDclient"] = this.iDclient;
            dRow["FirstName"] = this.firstName;
            dRow["LastName"] = this.lastName;
            dRow["Address"] = this.address;
            dRow["NumHome"] = this.numHome;
            dRow["City"] = this.city;
            dRow["BirthDate"] = this.birthDate;
            dRow["Telephne"] = this.telephne;
            dRow["Phone"] = this.phone;
            dRow["NumLicense"] = this.numLicense;
            dRow["DateGetLisence"] = this.dateGetLisence;
            dRow["valibityLicense"] = this.valibityLicense;
            dRow["KindLicense"] = this.kindLicense;
            
        }
        public override void FillFields()
        {
            this.iDclient = Convert.ToString(dRow["IDclient"]);
            this.firstName = Convert.ToString(dRow["FirstName"]);
            this.lastName = Convert.ToString(dRow["LastName"]);
            this.address = Convert.ToString(dRow["Address"]);
            this.numHome = Convert.ToInt32 (dRow["NumHome"]);
            this.city = Convert.ToInt32 (dRow["City"]);
            this.birthDate = Convert.ToDateTime (dRow["BirthDate"]);
            this.telephne = Convert.ToString(dRow["Telephne"]);
            this.phone = Convert.ToString(dRow["Phone"]);
            this.numLicense = Convert.ToInt32 (dRow["NumLicense"]);
            this.dateGetLisence = Convert.ToDateTime (dRow["DateGetLisence"]);
            this.valibityLicense = Convert.ToDateTime (dRow["ValibityLicense"]);
            this.kindLicense = Convert.ToInt32 (dRow["KindLicense"]);
           
        }
        public string IDclient
        {
            get { return iDclient; }
            set
            {
                if (Validation.IsID(value )&&value!="")
                    this.iDclient = value;
                else throw new Exception("הקש תז חוקית");
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
               if(value !="")
                    this.firstName = value;
               else
                throw new Exception("מלא נתונים בשדות");
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {

                if (value != "")
                    this.lastName = value;
                else
                throw new Exception("מלא נתונים בשדות");
               
                
            }
        }
        public string Address
        {
            get { return address; }
            set {
                if (value != "")
                    this.address = value;
                else
                throw new Exception("מלא נתונים בשדות");
                
            }
        }
        public int NumHome
        {
            get { return numHome; }
            set {if (value != 0)
                    this.numHome = value;
                else throw new Exception("מלא נתונים בשדות");
            }
        }
         public    int City
        {
            get { return city; }
            set { this.city = value; }
        }
        public DateTime  BirthDate
        {
            get { return birthDate; }
            set
            {
                if (DateTime.Now > value)
                    this.birthDate = value;
                else throw new Exception("הקש תאריך חוקי");
            }
        }
        public string Telephne
        {
            get { return telephne; }
            set
            {
                if (Validation.Phone(value )&&value!="")
                    this.telephne = value;
                else throw new Exception("הקש טלפון חוקי");
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (Validation.IsPhone(value ) && value != "")
                    this.phone = value;
                else throw new Exception("הקש פלאפון חוקי");
            }
        }
        public int NumLicense
        {
            get { return numLicense; }
            set
            {
                if ( value.ToString () != "" )
                    this.numLicense = value;
                else throw new Exception("מלא נתונים בשדות");
            }
        }
        public DateTime  DateGetLisence
        {
            get { return dateGetLisence; }
            set {
                if (DateTime.Now > value)
                    this.dateGetLisence = value;
                else
                    throw new Exception("הקש תאריך חוקי"); 
            }
        }
        public DateTime  ValibityLicense
        {
            get { return valibityLicense; }
            set {
                if (DateTime.Now < value)
                    this.valibityLicense = value;
                else throw new Exception("הקש תאריך חוקי");
            }
        }
        public int KindLicense
        {
            get { return kindLicense; }
            set { this.kindLicense = value; }
        }
        
    }
}
