using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_HrHammoud;

namespace DataBuisnessLayerHrHammoud
{
    public class ClsStatements
    {
        public int StatementID { get; set; }
        public int ApplicationID { get; set; }

        public string KindStatement { get; set; }
        public DateTime DateEntry { get; set; }
        public string Explination { get; set; }
        public byte[] Image { get; set; }
        public byte CreatedByUserID { get; set; }
        public string extension { get; set; }
        public ClsStatements()
        {
            StatementID = -1;
            ApplicationID = -1;
            KindStatement = "";
            DateEntry = DateTime.Now ;
                Explination="";
            Image = new byte[0];
            extension = "";
            CreatedByUserID = 0;
        }



        public bool AddStatement()
        {

            this.StatementID= Statements._AddStatement(this.ApplicationID, this.KindStatement, this.DateEntry, this.Explination, this.Image, this.extension,this.CreatedByUserID);
            if(this.StatementID!=-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UploadImage(int statementID, byte[] image,string ext)
        {
           return Statements._UploadImage(statementID, image, ext);

        }


       static public  byte[] ShowImage(int id)
        {

           return Statements.ShowImage(id);
        }

          static public DataTable getAllStatementsByAppID(int appid,short pagenumber)
        {
            return Statements.GetStatementsByAPPid(appid, pagenumber);



        }

        static public int GetNumberOfRecordsStatements()
        {
            return Statements._GetNumberOfecords();
        }


    }
}
