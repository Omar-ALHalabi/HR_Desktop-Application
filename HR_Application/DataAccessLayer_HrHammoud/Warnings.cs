using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Data;
using System.Configuration;

namespace DataAccessLayer_HrHammoud
{
    public class Warnings
    {
        static public int _AddWarning(int appid,string kindWarning,string date,string reason, byte[] image,string ext,byte createdByUserID)
        {
            int id = -1;
            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec SP_AddWarning @ApplicationID,@KindWarning,@DateWarning,@ReasonForWarning,@image,@ext,@CreatedByUserID ; select SCOPE_IDENTITY()";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ApplicationID", appid);
                        cmd.Parameters.AddWithValue("@KindWarning", kindWarning);
                        cmd.Parameters.AddWithValue("@DateWarning", date);
                        cmd.Parameters.AddWithValue("@ReasonForWarning", reason);
                        cmd.Parameters.AddWithValue("@image", image);
                        cmd.Parameters.AddWithValue("@ext", ext);
                        cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                        connection.Open();
                        object I = cmd.ExecuteScalar();
                        if(I!=null && int.TryParse(I.ToString(),out int insertedID))
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

            return id ;

        }

        static public bool _UploadImage(int id, byte[] image,string ext)
        {

            int rowaffacted = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "  exec sp_UploadWarningFile @ID,@image,@ext";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID",id);
                        cmd.Parameters.AddWithValue("@image", image);
                        cmd.Parameters.AddWithValue("@ext", ext);

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

        static public DataTable GetWarningsByAPPid(int appid,int pagenumber)
        {


            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec SP_GetWarningsByAPPid @AppId,@PageNumber";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@AppId", appid);
                        cmd.Parameters.AddWithValue("@PageNumber", pagenumber);
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

        static public byte[] ShowImage(int warningID)
        {
            byte[] image = new byte[0];
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "exec spGetWarningFileByWarningID @id";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", warningID);

                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            image = (byte[])reader["image"];
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

        static public int _GetNumberOfecords()
        {
            int NumberOfRecords = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec NumberRecordsInWarning ";

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


        static public DataTable GetAllWarnings(int pagenumber)
        {


            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec SP_GetAllWarnings @PageNumber";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PageNumber", pagenumber);
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

    }
}
