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
    public class BlackList
    {
        static public bool _addToBlackList(int BlackListID, string REASON,byte createdByUserID,DateTime date)
        {
            int rowaffacted = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = " exec sp_addToBlackList @BlackListID,@reason,@CreatedByUser,@date";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@BlackListID", BlackListID);
                        cmd.Parameters.AddWithValue("@reason", REASON);
                        cmd.Parameters.AddWithValue("@CreatedByUser", createdByUserID);
                        cmd.Parameters.AddWithValue("@date", date);
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


        static public bool _deleteFromBlackList(int blacklistID)
        {

            int rowaffacted = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = " exec sp_DeleteFromBlackList @blacklistID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@blacklistID", blacklistID);

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
        static public DataTable _IsFoundOnBlackList(int blacklistID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = " exec spIsFoundOnBlackList @BlackListID";


                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@BlackListID", blacklistID);

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

        static public DataTable _GetBlackListRecords(short pagenumber)
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString)) 
                {
                    string query = "exec sp_GetBlackListRecords @PageNumber";

                    using(SqlCommand cmd=new SqlCommand(query,connection))
                    {
                        cmd.Parameters.AddWithValue("@PageNumber",pagenumber);
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

        static public short _NumberOfRecords()
        {
            int NumberOfRecords = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec NumberOfRecordsInbLackList ";

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
            return Convert.ToInt16(NumberOfRecords);







        }


        static public DataTable _GetAllBlackListRecords()
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "exec sp_GetAllBlackListRecords ";

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
                dt = null;

            }

            return dt;








        }

    }

}
            

