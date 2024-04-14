using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_HrHammoud;

namespace DataBuisnessLayerHrHammoud
{
    public class ClsArchive
    {
        public int LogID { get; set; }
        public int ApplicationID { get; set; }
        public string FullName { get; set; }
        public byte ByUser { get; set; }
        public string KindOperation { get; set; }
        public DateTime DateAt { get; set; }



        public ClsArchive()
        {
            LogID = -1;
            ApplicationID = -1;
            FullName = "";
            ByUser = 0;
            KindOperation = "";
            DateAt = DateTime.Now;

        }



        static public DataTable GetAllRecordsArchive(short pageNumber)
        {
            return Archive.GetAllRecordsArchive(pageNumber);
        }


        static public int GetNumberOfRecords()
        {
            return Archive._GetNumberOfecords();
        }

        static public int GetNumberOfRecords(int appid)
        {
            return Archive._GetNumberOfecords(appid);
        }

        static public DataTable GetAllRecordsArchive()
        {

            return Archive.GetAllRecordsArchive();



        }

        static public DataTable GetAllRecordsArchiveByAppid(int appid,int pagenumber)
        {

            return Archive.GetAllRecordsArchiveByAppid(appid, pagenumber);



        }

        static public DataTable SearchBetweenTwoDates(string startdate, string enddate)
        {

            return Archive._SearchBetweenTwoDates( startdate,  enddate);



        }

    }
}
