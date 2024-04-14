using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_HrHammoud
{
    public class Users
    {


        static public byte _AddNewUser(int appid, string username, string password, byte permission, bool isactive)
        {
            byte id = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "declare @id int; " +
                   "exec SP_AddNewUser @Appid,@Username,@password,@permission,@isactive," +
                   "@userid=@id OutPut; select @id as userID;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Appid", appid);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@permission", permission);
                        cmd.Parameters.AddWithValue("@isactive", isactive);

                        connection.Open();

                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedid))
                        {
                            id = Convert.ToByte(insertedid);
                        }




                    }
                }







            }
            catch (Exception)
            {

                id = 0;
            }
            return id;



        }

        static public bool _UpdateUser(byte? userid, int appid, string username, string password, byte permission, bool isactive)
        {
            int rowsAffected = 0;
            try

            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = " exec SP_UpdateUser @userid,@appid,@UserName,@Password,@Permission,@isactive";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@appid", appid);
                        cmd.Parameters.AddWithValue("@UserName", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Permission", permission);
                        cmd.Parameters.AddWithValue("@isactive", isactive);
                        cmd.Parameters.AddWithValue("@userid", userid);

                        connection.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                    }

                }

            }
            catch
            {
                return false;


            }
            return (rowsAffected > 0);








        }

        static public DataTable _GetAllUsers()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "exec SP_GetAllUsers";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

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
            }
            catch
            {
                dt = null;

            }
            return dt;

        }

        public static bool IsUserExistByFullName(string fullname)
        {
            bool isFound = false;
            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec sp_IsuserExistByFullName @fullname";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@fullname", fullname);


                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            isFound = reader.HasRows;

                        }





                    }




                }



            }
            catch
            {
                isFound = false;


            }
            return isFound;




        }




        public static bool IsUserExistByUserName(string username)
        {
            bool isFound = false;
            try
            {

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec SP_IsUserExistByUseName  @username";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@username", username);


                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            isFound = reader.HasRows;

                        }



                    }
                }
            }
            catch
            {
                isFound = false;


            }
            return isFound;
        }



        public static bool IsUserExistByAppID(int appid)
        {
            bool isFound = false;
            try
            {

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec sp_IsUserExistByAppID  @appid";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@appid", appid);


                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            isFound = reader.HasRows;

                        }



                    }
                }
            }
            catch
            {
                isFound = false;


            }
            return isFound;




        }
        public static bool ChangePassword(byte? userid,string password)
        {
            int rowaffacted = 0;
            try
            {
                using (SqlConnection connection=new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
            {

                string query = "exec SP_changepassword @id,@password";

              

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@id", userid);
                        cmd.Parameters.AddWithValue("@password", password);

                        connection.Open();
                        rowaffacted = cmd.ExecuteNonQuery();


                    }
               


            }
            }
            catch
            {
                return false;



            }
            return rowaffacted > 0;

        }

        public static bool GetUserInfoByUserNameAndPassword(ref byte  userid, ref int appid,  string username,  string password, ref byte permission, ref bool isactive)
        {    
           
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "exec GetUserInfoByUsernameAndPassword @username,@password";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {





                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            { 
                                isFound = true;
                            
                                userid = (byte)reader["UserID"];
                                appid = (int)reader["AppID"];
                                username = (string)reader["UserName"];
                                password = (string)reader["Password"];
                                permission = (byte)reader["Permission"];
                                isactive = (bool)reader["IsActive"];


                            }




                        }

                    }

                    }

                }
            catch
            {
                isFound = false;


            } return isFound;
        
   


        }

        public static bool GetUserInfoByUserID( byte userid, ref int appid,ref string username,ref string password, ref byte permission, ref bool isactive)
        {
            bool isFound = false;

            try
            {

                using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec SP_GetUserInfoByUserID @id";

                    using(SqlCommand cmd=new SqlCommand(query,connection))
                    {
                        cmd.Parameters.AddWithValue("@id", userid);

                        using(SqlDataReader reader=cmd.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                 isFound = true ;

                                userid = (byte)reader["UserID"];
                                appid = (int)reader["AppID"];
                                username = (string)reader["UserName"];
                                password = (string)reader["Password"];
                                permission = (byte)reader["Permission"];
                                isactive = (bool)reader["Password"];


                            }

                        }
                    }

                   
                }



            }
            catch
            {

                 isFound = false;

            }
            return isFound;

        }


        public static bool GetUserInfoByUserName(ref byte userid, ref int appid,  string username, ref string password, ref byte permission, ref bool isactive)
        {
            bool isFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec sp_getinfouserByUserName  @username";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                userid = (byte)reader["UserID"];
                                appid = (int)reader["AppID"];
                                username = (string)reader["UserName"];
                                password = (string)reader["Password"];
                                permission = (byte)reader["Permission"];
                                isactive = (bool)reader["IsActive"];


                            }

                        }
                    }


                }



            }
            catch
            {

                isFound = false;

            }
            return isFound;

        }

        public static bool GetUserInfoByAppID(ref byte userid,  int appid, ref string username, ref string password, ref byte permission, ref bool isactive)
        {
            bool isFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec sp_getinfouserByAppID @appid";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@appid", appid);

                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                userid = (byte)reader["UserID"];
                                appid = (int)reader["AppID"];
                                username = (string)reader["UserName"];
                                password = (string)reader["Password"];
                                permission = (byte)reader["Permission"];
                                isactive = (bool)reader["IsActive"];


                            }

                        }
                    }


                }



            }
            catch
            {

                isFound = false;

            }
            return isFound;

        }


        public static string _GetUserNameByUserID(byte UserID)
        {
            string username = "";

            try
            {

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec SP_GetUserNameByUserID @ID";


                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", UserID);

                        connection.Open();
                        object Name = cmd.ExecuteScalar();
                        if(Name!=null)
                        {
                            username = Name.ToString();

                        }
                    }


                }



            }
            catch
            {

                username = "";

            }
            return username;

        }


        static public DataTable _GetAllFullNameApp()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "exec sp_getAllFullName";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

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
            }
            catch
            {
                dt = null;

            }
            return dt;

        }



    }
}

         






                    
                        
    

                   

       