using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ElbarProject.DAL;

namespace ElbarProject.BLL
{
     class CarTable:GeneralTable 
    {
        public CarTable():base ("tblCar", "carNumber") { }
        //מציג את כל הרכבים
        public static DataTable GetDisplayTable()
        {
            return d.GetQuery("select tblCar.carNumber, tblCar.finds, tblCar.fix, tblDesign.numPlaces, tblDesign.nameDesign,tblDesign.volumeMotor, tblColor.nameColor, tblManufacturer.nameManufacturer from tblColor inner join(tblManufacturer inner join(tblDesign inner join tblCar on tblDesign.coudDesign = tblCar.coudDesign) on tblManufacturer.coudeManufacturer = tblDesign.manufacturer) on tblColor.coudeColor = tblCar.colorCar where(((tblCar.active) = True))");

        }
        public override void DeleteToAccess(GeneralRow currentObj)
        {
            ((Car)currentObj).Active = false;
            currentObj.FillDataRow();
            d.SaveToAccess(this.tableName );
           
        }
        public static bool GetIfDelId(string id)
        {
            DataTable dt = d.GetQuery("select *  from tblCar  inner join  tblFixs  on tblCar.carNumber=tblFixs.carNumber where tblCar.carNumber='" + id + "'");
            DataTable dt2 = d.GetQuery("select *  from tblCar ca inner join  tblTakes ta on ca.carNumber=ta.numCar where ca.carNumber='" + id + "'");
            if (dt.Rows.Count != 0 && dt2.Rows.Count!=0)
                return false;
            return true;
        }
        //להצגת הרכבים מבסניף הזה
        
        // בכל הסניפים מחזירה את כל הרכבים הפנויים בטווח התאריכים
        public static DataTable GetTimesCars(int branch, bool f, DateTime fromH, DateTime toH)
        {
            string fh = fromH.Month + "/" + fromH.Day + "/" + fromH.Year;
            string th = toH.Month + "/" + toH.Day + "/" + toH.Year;
            if (f == false)
            
                return d.GetQuery("select tblCar.carNumber, tblCar.coudBranch, tblCar.finds, tblCar.fix, tblColor.nameColor, tblDesign.nameDesign, tblDesign.numPlaces,tblDesign.volumeMotor, tblManufacturer.nameManufacturer from (tblManufacturer inner join (tblDesign inner join (tblColor inner join tblCar on tblColor.coudeColor = tblCar.colorCar) on tblDesign.coudDesign = tblCar.coudDesign) on tblManufacturer.coudeManufacturer = tblDesign.manufacturer) left join  tblTakes on tblCar.carNumber = tblTakes.numCar where (((tblCar.active) = True) and ((tblCar.coudBranch)=" + branch + ") and (((tblTakes.dateTake)>#" + th + "#) or ((tblTakes.dateReturn)<#" + fh + "#) or (tblTakes.dateTake is null))) ");
            else 
                return d.GetQuery("select tblCar.carNumber, tblCar.coudBranch, tblCar.finds, tblCar.fix, tblColor.nameColor, tblDesign.nameDesign, tblDesign.numPlaces,tblDesign.volumeMotor, tblManufacturer.nameManufacturer from (tblManufacturer inner join (tblDesign inner join (tblColor inner join tblCar on tblColor.coudeColor = tblCar.colorCar) on tblDesign.coudDesign = tblCar.coudDesign) on tblManufacturer.coudeManufacturer = tblDesign.manufacturer) left join  tblTakes on tblCar.carNumber = tblTakes.numCar where (((tblCar.active) = True) and ((tblTakes.dateTake)>#" + th + "#) or ((tblTakes.dateReturn)<#" + fh + "#)) or tblTakes.dateTake is null ");
        }
        }
    }
