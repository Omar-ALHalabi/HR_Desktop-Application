using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_HrHammoud
{
    public class Statements
    {

        static public int _AddStatement(int appid, string KindStatement, DateTime DateEntry, string Explination, byte[] Image,string extenstion,byte createByUserID)
        {
            int id = -1;
            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec SP_AddStatement @ApplicationID,@KindStatement,@DateEntry,@Explination,@Image,@extenstion,@createdByUserID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ApplicationID", appid);
                        cmd.Parameters.AddWithValue("@KindStatement", KindStatement);
                        cmd.Parameters.AddWithValue("@DateEntry", DateEntry);
                        cmd.Parameters.AddWithValue("@Explination", Explination);
                        cmd.Parameters.AddWithValue("@Image", Image);
                        cmd.Parameters.AddWithValue("@extenstion", extenstion);
                        cmd.Parameters.AddWithValue("@createdByUserID", createByUserID);
                        connection.Open();
                        object I = cmd.ExecuteScalar();
                        if (I != null && int.TryParse(I.ToString(), out int insertedID))
                        {

                            id = insertedID;
                        }

                    }
                }

            }
            catch
            {
                id = -1;



            }

            return id;

        }

        static public bool _UploadImage(int StatementID, byte[] image, string ext)
        {

            int rowaffacted = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "  exec SP_UploadFileStatemnt @ID,@Image,@extenstion";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", StatementID);
                        cmd.Parameters.AddWithValue("@Image", image);
                        cmd.Parameters.AddWithValue("@extenstion", ext);

                        connection.Open();
                        rowaffacted = cmd.ExecuteNonQuery();


                    }
                }


            }
            catch
            {
                rowaffacted = 0;


            }



            return rowaffacted > 0;



        }

        static public byte[] ShowImage(int StatementID)
        {
            byte[] image = new byte[0];
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "exec SP_ShowImageByStatementID @id";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", StatementID);

                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            image = (byte[])reader["Image"];
                        }
                        else { image = null; }

                    }



                }








            }
            catch
            {
                image = null;


            }


            return image;







        }

        static public DataTable GetStatementsByAPPid(int appid,short pagenumber)
        {


            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec sp_getAllStatementsByAppID @AppId,@pagenumber";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@AppId", appid);
                        cmd.Parameters.AddWithValue("@pagenumber", pagenumber);
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }
                        else
                        {
                            dt = null;
                        }


                    }

                }




            }
            catch
            {



            }
            return dt;

        }

        static public int _GetNumberOfecords()
        {
            int NumberOfRecords = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec numberOfRecordsInStatements ";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {



                        connection.Open();
                        object Num = cmd.ExecuteScalar();
                        if (Num != null && int.TryParse(Num.ToString(), out int nummer))
                        {
                            NumberOfRecords = nummer;
                        }


                    }

                }




            }
            catch
            {
                NumberOfRecords = 0;


            }
            return NumberOfRecords;


        }

    }
}
