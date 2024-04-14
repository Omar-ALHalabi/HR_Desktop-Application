using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Data;
using System.Configuration;

namespace DataAccessLayer_HrHammoud
{
    public  class OfficialDocuments
    {
       static public bool _AddNewDocument( int AppId, string Name, DateTime DateEntry, byte[] image,string filetype,byte createdByUserID)
        {
            int rowaffacted = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec Sp_AddDocument @appid,@name,@dateEntry,@image,@filetype,@createdByUserID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@appid", AppId);
                        cmd.Parameters.AddWithValue("@name", Name);
                        cmd.Parameters.AddWithValue("@dateEntry", DateEntry);
                        cmd.Parameters.AddWithValue("@image", image);
                        cmd.Parameters.AddWithValue("@filetype", filetype);
                        cmd.Parameters.AddWithValue("@createdByUserID", createdByUserID);

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


        static public bool _UpdateDocument(int documentID, string Name, DateTime DateEntry, byte[] image, string filetype,byte creadByUserID)
        {
            int rowaffacted = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "  exec sp_UpdateDocumen @DocumentID,@name,@dateEntry,@image,@fileType,@createdByUserID";

                    using (SqlCommand cmd = new SqlCommand(query,connection))
                    {
                        cmd.Parameters.AddWithValue("@DocumentID", documentID);
                        cmd.Parameters.AddWithValue("@name", Name);
                        cmd.Parameters.AddWithValue("@dateEntry", DateEntry);
                        cmd.Parameters.AddWithValue("@image", image);
                        cmd.Parameters.AddWithValue("@fileType", filetype);
                        cmd.Parameters.AddWithValue("@createdByUserID", creadByUserID);
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


        static public DataTable _GetAllDocumentsByAppID(int AppId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec SP_GetAllDocumentsByID @AppId";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@AppId", AppId);

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




        static public byte[] _GetImageByID(int documentID)
        {
            byte[] image= null;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = " EXEC sp_GetDocumentByID @ID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", documentID);

                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            image = (byte[])reader["DocumentImage"];
                        }
                        else
                        {
                            image = null;
                        }


                    }

                }




            }
            catch
            {

                image = null;

            }
            return image;

        }


        static public bool _deleteDocument(int documentID)
        {

            int rowaffacted = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec sp_deleteDocument @id";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", documentID);
                     

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


        static public DataTable _GetAllDocumentsBydocumentID(int DocumentID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec  sp_GetAllByDocumentID @DocumentID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@DocumentID", DocumentID);

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

