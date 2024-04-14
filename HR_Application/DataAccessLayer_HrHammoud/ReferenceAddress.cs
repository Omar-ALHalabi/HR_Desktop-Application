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
    public class ReferenceAddress
    {


        static public bool _AddReferenceAddress( int ApplicationID, string Name
            , string KindKnowiedge, string phone, string address)
        {

            int rowaffacted = 0;
            try
            {
                using (SqlConnection connection=new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec SP_AddReferenceAddress @AppID,@Name,@KindOfKnowledge,@phone,@address ";

                    using (SqlCommand cmd=new SqlCommand(query,connection))
                    {
                        cmd.Parameters.AddWithValue("@AppID", ApplicationID);
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@KindOfKnowledge", KindKnowiedge);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@address", address);

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


        static public bool _UpdateReferenceAddress(int AddressID, string Name
            , string KindKnowiedge, string phone, string address)
        {



            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = " exec SP_UpdateReferenceAdress @AddressID,@name,@kindOfKnowledge, @phone, @address";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@AddressID", AddressID);
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@kindOfKnowledge", KindKnowiedge);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address);

                    connection.Open();
                    rowsAffected = cmd.ExecuteNonQuery();

                }
            }
            catch
            {

                rowsAffected = 0;

            }
            return rowsAffected > 0;










                }

        public static bool _DeleteReferenceAddress(int referenceAddressID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = " exec SP_DeleteReferenceAddressByID @id";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@id", referenceAddressID);

                        connection.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                    }



                }
            }
            catch
            {
                rowsAffected = 0;


            }
            return rowsAffected > 0;
        }

        static public DataTable _GetReferenceAddressByID(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                   string query = "exec Sp_GetReferenceAddressByID  @id ";
               
                    using (SqlCommand cmd=new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id",id);

                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
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
    }
}
