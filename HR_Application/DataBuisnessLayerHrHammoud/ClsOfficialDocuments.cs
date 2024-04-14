using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_HrHammoud;
using static System.Net.Mime.MediaTypeNames;

namespace DataBuisnessLayerHrHammoud
{
    public class ClsOfficialDocuments
    {
        public int DocumentID { get; set; }

        public int ApplicationID { get; set; }

        public string DocumentName { get; set; }

        public DateTime DateOfEntry { get; set; }

        public byte[] DocumentImage { get; set; }
        public byte CreatedByUserID { get; set;}
        public string fileType { get; set; }

        public ClsOfficialDocuments()
        {
            DocumentID = 0;
            ApplicationID = 0;
             DocumentName = "";
             DateOfEntry = DateTime.Now;
            DocumentImage = new byte[0];
            fileType = "";
            CreatedByUserID = 0;

        }


        public ClsOfficialDocuments(int ID, int AppId, string Name, DateTime DateEntry, byte[] image,string type,byte createByUserID)
        {
            DocumentID = ID;
            ApplicationID = AppId;
            DocumentName = Name;
            DateOfEntry = DateEntry;
            DocumentImage = image;
            fileType=type;
            this.CreatedByUserID = createByUserID;
        }

        public bool AddNewDocument()
        {

            return OfficialDocuments._AddNewDocument(this.ApplicationID, this.DocumentName, this.DateOfEntry, this.DocumentImage,this.fileType,this.CreatedByUserID);



        }
        public bool UpdateDocument()
        {

            return OfficialDocuments._UpdateDocument(this.DocumentID, this.DocumentName, this.DateOfEntry, this.DocumentImage, this.fileType,this.CreatedByUserID);



        }




         public DataTable GetAllDocumentsByAppID()
        {

            return OfficialDocuments._GetAllDocumentsByAppID(this.ApplicationID);
        }


      static  public byte[] GetImageByID(int _DocumentID)
        {

            return OfficialDocuments._GetImageByID(_DocumentID);
        }


       static public bool DeleteDocument(int documentID)
        {
            return OfficialDocuments._deleteDocument(documentID);


        }

        static public DataTable GetAllDocumentsBydocumentID(int documentID)
        {

            return OfficialDocuments._GetAllDocumentsBydocumentID(documentID);
        }

    }

}

    

