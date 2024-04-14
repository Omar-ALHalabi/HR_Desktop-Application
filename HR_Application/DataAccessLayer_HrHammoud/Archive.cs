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
    public  class Archive
    {

        static public DataTable GetAllRecordsArchive(short PageNumber)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec GetAllRecordsArchive @PageNumber";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PageNumber", PageNumber);


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

                    string query = "exec NumberRecordsInArchive ";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                    


                        connection.Open();
                        object Num= cmd.ExecuteScalar();
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

        static public int _GetNumberOfecords(int appid)
        {
            int NumberOfRecords = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec sp_numberRecordsByAppid @appid";

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
            return NumberOfRecords;


        }

        static public DataTable GetAllRecordsArchive()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.connectionstring))
                {

                    string query = "exec sp_getAllRecordsInfo ";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        


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



        static public DataTable GetAllRecordsArchiveByAppid(int appid,int pagenumber)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec sp_getAllRecordsInfoByAppID @ApplicationID,@PageNumber ";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@ApplicationID", appid);
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

        static public DataTable _SearchBetweenTwoDates(string startdate, string enddate)
        {
             DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec sp_SearchDatesInArchiveLog @startDate,@enddate ";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@startDate", startdate);
                        cmd.Parameters.AddWithValue("@enddate", enddate);

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
