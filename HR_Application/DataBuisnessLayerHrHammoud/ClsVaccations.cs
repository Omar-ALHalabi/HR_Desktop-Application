using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_HrHammoud;

namespace DataBuisnessLayerHrHammoud
{
    public class ClsVaccations
    {

        public int VaccationID { get; set; }
        public int AppID { get; set; }
        public string EmploymentName { get; set; }

        public DateTime dateOfVaccation { get; set; }
        public string extension { get; set; }
        public byte[] Image { get; set; }
        public byte CreatesByUserID { get; set; }



        public ClsVaccations()
        {
            VaccationID = -1;
            AppID = -1;
            EmploymentName = "";
            dateOfVaccation = DateTime.Now;
            extension = "";
            Image = new byte[0];
            CreatesByUserID = 0;
        }

        public bool AddNewVaccation()
        {

            return Vaccations._AddNewVaccation(this.AppID, this.EmploymentName, this.dateOfVaccation, this.Image,this.extension,this.CreatesByUserID);

        }

       

         public DataTable _getAllVaccByAppID(short pagenumber)
        {
            return Vaccations._GetAllVaccationsByVaccID(this.AppID, pagenumber);
        }

        static public byte[] _ShowImage(int vaccID)
        {

            return Vaccations.ShowImage(vaccID);
        }

        static public DataTable _logVaccations(int pagenumber)
        {
            return Vaccations.LogVaccations(pagenumber);


        }

        static public int _NumberOfRecords()
        {
          return Vaccations._GetNumberOfecords();
        }

        static public short _NumberOfRecordsByAppid(int appid)
        {
            return Vaccations._GetNumberOfecordsByAppid(appid);
        }
    }
}
