using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer_HrHammoud
{
    public class Vaccations
    {

        static public bool _AddNewVaccation(int appID,string Name,DateTime dateofapp, byte[] Image,string ext,byte CreatedByUserID)
        {
            int rowaffacted = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = " exec SP_AddVaccation @appid,@name,@dateApplication,@image,@Ext,@CreatedByUserID";

                    using(SqlCommand cmd=new SqlCommand(query,connection))
                    {
                        cmd.Parameters.AddWithValue("@appid", appID);
                        cmd.Parameters.AddWithValue("@name", Name);
                        cmd.Parameters.AddWithValue("@dateApplication", dateofapp);
                        cmd.Parameters.AddWithValue("@image", Image);
                        cmd.Parameters.AddWithValue("@Ext", ext);
                        cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
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


        static public byte[] ShowImage(int VaccationID)
        {
            byte[] image = new byte[0];
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "exec spGetVaccationFile @id";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", VaccationID);
                 
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if(reader.Read())
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

        static public DataTable _GetAllVaccationsByVaccID(int AppID,short pagenumber)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "exec SP_GetAllVaccByApplicationID @appid,@pagenumber";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@appid", AppID);

                        cmd.Parameters.AddWithValue("@pagenumber", pagenumber);

                        connection.Open();
                        SqlDataReader reader  = cmd.ExecuteReader();
                        if(reader.HasRows)
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
                dt = null;

            }

            return dt;

        }
        static public DataTable LogVaccations(int pagenumber)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "exec SP_LogVaccations @PageNumber";
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
                dt = null;

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

                    string query = "exec sp_NumberOfRecordsVaccations ";

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

        static public short _GetNumberOfecordsByAppid(int appid)
        {
            int NumberOfRecords = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec numberofrecordsByAppidInVaccations @appid ";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@appid", appid);


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
            return Convert.ToInt16(NumberOfRecords);


        }
    }
}
