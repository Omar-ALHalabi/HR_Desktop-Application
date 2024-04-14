using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Configuration;

namespace DataAccessLayer_HrHammoud
{
    public class Settings
    {
     

        static public DataTable _GetAllNationalities()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "exec sp_GetAllNationalites";

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

        static public bool _AddNationality(string DrivingLicensesName)
        {
            int id = -1;
            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "sp_AddNationality @nationalityName";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nationalityName", DrivingLicensesName);
                       

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

            return id!=-1;


        }


        static public DataTable _GetAllDrivingLicenses()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "exec sp_GetAllDrivingLicenses";

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
        static public bool _AddDrivingLicenses(string DrivingLicensesName)
        {
            int id = -1;
            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "sp_AddDrivingLicenses @DrivingLicensesName";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@DrivingLicensesName", DrivingLicensesName);


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

            return id != -1;


        }


        static public DataTable _GetAllDepartments()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "exec sp_GetAllDepartments";

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

        static public bool _AddDepartment(string DepartmentName)
        {
            int id = -1;
            try
            {


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "sp_AddDepartments @departmenName";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@departmenName", DepartmentName);


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

            return id != -1;


        }

    }
}
