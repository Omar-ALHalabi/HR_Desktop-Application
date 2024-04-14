using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_HrHammoud;

namespace DataBuisnessLayerHrHammoud
{
    public class ClsBlackList
    {
        public int BlackListID {get;set;}
    //    public int AppID { get; set; }
        public string reason { get; set; }

        public byte CreatedByUserID { get; set; }
       public DateTime dateEnter { get; set; }

        public ClsBlackList()
        {
            BlackListID = -1;
           // AppID = -1;
            reason = "";
            CreatedByUserID = 0;
            dateEnter = DateTime.Parse(DateTime.Now.ToString());
        }


        public bool AddToBlackList()
        {
            return BlackList._addToBlackList(this.BlackListID,this.reason,this.CreatedByUserID,this.dateEnter);


        }

        static public bool DeleteFromBlackList(int blackListID)
        {
            return BlackList._deleteFromBlackList(blackListID);


        }

        static public DataTable IsFoundOnBlackList(int blackListID)
        {
            return BlackList._IsFoundOnBlackList(blackListID);


        }

        static public DataTable GetBlackListRecords(short pagenumber)
        {
            return BlackList._GetBlackListRecords(pagenumber);


        }


        static public DataTable GetAllBlackListRecords()
        {
            return BlackList._GetAllBlackListRecords();

        }
        static public short getNumberOfRecords()
        {
            return BlackList._NumberOfRecords();
        }
    }
}
