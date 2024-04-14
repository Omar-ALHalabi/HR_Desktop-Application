using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_HrHammoud;

namespace DataBuisnessLayerHrHammoud
{
    public class ClsWarnings
    {
      public  int WarningID { get; set; }
        public int ApplicationID { get; set; }

        public string KindWarning { get; set; }
        public string DateWarning { get; set; }
        public string ReasonForWarning { get; set; }
        public byte[] image { get; set; }
        public string ext { get; set; }
        public byte CreatedByUserID { set; get; }

        public ClsWarnings()
        {
            WarningID = -1;
            ApplicationID = -1;
              KindWarning = "";
            DateWarning = "";
            ReasonForWarning = "";
            ext = "";
            CreatedByUserID = 0;
        }


        public bool AddWarning()
        {

            this.WarningID= Warnings._AddWarning(this.ApplicationID, this.KindWarning, this.DateWarning, this.ReasonForWarning, this.image,this.ext,this.CreatedByUserID) ;
            if(this.WarningID!=-1)
            {
                return true;
            }else
            {
                return false;
            }

        }


        public bool UploadImage(int id, byte[] image,string ext)
        {

            return Warnings._UploadImage(id, image,ext);


        }

       public DataTable getWarningsByAppID( int page)
        {
            return Warnings.GetWarningsByAPPid(this.ApplicationID,page);

        }

        static public byte[] ShowImage(int warningID)
        {

            return Warnings.ShowImage(warningID);
        }


        static public int _NumberOfRecordsInWarning()
        {

            return Warnings._GetNumberOfecords();
        }
        public DataTable geAlltWarnings(int page)
        {
            return Warnings.GetAllWarnings( page);

        }


    }
}
