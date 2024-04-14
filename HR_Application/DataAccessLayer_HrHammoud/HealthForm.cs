using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_HrHammoud
{
    public class HealthForm
    {
        static public bool _AddHealthForm(int HealthFormID,bool Ans1,string detail1, bool Ans2, string detail2, bool Ans3, string detail3, bool Ans4, string detail4, bool Ans5, string detail5, bool Ans6, string detail6, bool Ans7, string detail7, bool Ans8, string detail8, bool Ans9, string detail9,bool ans10,string detail10)
        {
            int rowaaffacted = 0;
            try
            {

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec SP_AddHealthForm @HelthFormID,@Ans1,@Details1,@Ans2,@Details2,@Ans3,@Details3,@Ans4,@Details4,@Ans5,@Details5,@Ans6,@Details6,@Ans7,@Details7,@Ans8,@Details8,@Ans9,@Details9,@Ans10 ,@Details10";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@HelthFormID", HealthFormID);
                        cmd.Parameters.AddWithValue("@Ans1", Ans1);
                        cmd.Parameters.AddWithValue("@Details1", detail1??DBNull.Value.ToString());

                        cmd.Parameters.AddWithValue("@Ans2", Ans2);
                        cmd.Parameters.AddWithValue("@Details2", detail2 ?? DBNull.Value.ToString());

                        cmd.Parameters.AddWithValue("@Ans3", Ans3);
                        cmd.Parameters.AddWithValue("@Details3", detail3 ?? DBNull.Value.ToString());

                        cmd.Parameters.AddWithValue("@Ans4", Ans4);
                        cmd.Parameters.AddWithValue("@Details4", detail4 ?? DBNull.Value.ToString());

                        cmd.Parameters.AddWithValue("@Ans5", Ans5);
                        cmd.Parameters.AddWithValue("@Details5", detail5 ?? DBNull.Value.ToString());


                        cmd.Parameters.AddWithValue("@Ans6", Ans6);
                        cmd.Parameters.AddWithValue("@Details6", detail6 ?? DBNull.Value.ToString());

                        cmd.Parameters.AddWithValue("@Ans7", Ans7);
                        cmd.Parameters.AddWithValue("@Details7", detail7 ?? DBNull.Value.ToString());

                        cmd.Parameters.AddWithValue("@Ans8", Ans8);
                        cmd.Parameters.AddWithValue("@Details8", detail8 ?? DBNull.Value.ToString());

                        cmd.Parameters.AddWithValue("@Ans9", Ans9);
                        cmd.Parameters.AddWithValue("@Details9", detail9 ?? DBNull.Value.ToString());

                        cmd.Parameters.AddWithValue("@Ans10", ans10);
                        cmd.Parameters.AddWithValue("@Details10", detail10 ?? DBNull.Value.ToString());

                        connection.Open();
                        rowaaffacted = cmd.ExecuteNonQuery();

                    }


                }



            }
            catch
            {
                rowaaffacted = 0;


            }
            return rowaaffacted > 0;
           





        }

      static public bool _updateHealthForm(int HealthFormID, bool Ans1, string detail1, bool Ans2, string detail2, bool Ans3, string detail3, bool Ans4, string detail4, bool Ans5, string detail5, bool Ans6, string detail6, bool Ans7, string detail7, bool Ans8, string detail8, bool Ans9, string detail9, bool ans10, string detail10)
        {

            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection=new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "exec  SP_UpdateHealthForm @ID,@Ans1,@Details1,@Ans2,@Details2,@Ans3,@Details3,@Ans4,@Details4,@Ans5,@Details5,@Ans6,@Details6,@Ans7,@Details7,@Ans8,@Details8,@Ans9,@Details9,@Ans10 ,@Details10";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@ID", HealthFormID);
                    cmd.Parameters.AddWithValue("@Ans1", Ans1);
                    cmd.Parameters.AddWithValue("@Details1", detail1??DBNull.Value.ToString());

                    cmd.Parameters.AddWithValue("@Ans2", Ans2);
                    cmd.Parameters.AddWithValue("@Details2", detail2 ?? DBNull.Value.ToString());

                    cmd.Parameters.AddWithValue("@Ans3", Ans3);
                    cmd.Parameters.AddWithValue("@Details3", detail3??DBNull.Value.ToString());

                    cmd.Parameters.AddWithValue("@Ans4", Ans4);
                    cmd.Parameters.AddWithValue("@Details4", detail4??DBNull.Value.ToString());

                    cmd.Parameters.AddWithValue("@Ans5", Ans5);
                    cmd.Parameters.AddWithValue("@Details5", detail5??DBNull.Value.ToString());


                    cmd.Parameters.AddWithValue("@Ans6", Ans6);
                    cmd.Parameters.AddWithValue("@Details6", detail6??DBNull.Value.ToString());

                    cmd.Parameters.AddWithValue("@Ans7", Ans7);
                    cmd.Parameters.AddWithValue("@Details7", detail7??DBNull.Value.ToString());

                    cmd.Parameters.AddWithValue("@Ans8", Ans8);
                    cmd.Parameters.AddWithValue("@Details8", detail8 ?? DBNull.Value.ToString());

                    cmd.Parameters.AddWithValue("@Ans9", Ans9);
                    cmd.Parameters.AddWithValue("@Details9", detail9??DBNull.Value.ToString());

                    cmd.Parameters.AddWithValue("@Ans10", ans10);
                    cmd.Parameters.AddWithValue("@Details10", detail10??DBNull.Value.ToString());

                    connection.Open();

                    rowsAffected = cmd.ExecuteNonQuery();
                }





            }
            catch
            {
                rowsAffected = 0;



            }
            return rowsAffected>0;




        }


        static public bool _GetInfoHealthFormByID(ref int HealthFormID, ref bool Ans1, ref string detail1, ref bool Ans2, ref string detail2, ref bool Ans3, ref string detail3, ref bool Ans4, ref string detail4, ref bool Ans5, ref string detail5, ref bool Ans6, ref string detail6, ref bool Ans7, ref string detail7, ref bool Ans8,
            ref string detail8, ref bool Ans9, ref string detail9, ref bool ans10, ref string detail10)
        {
            bool IsFound = false;
            try
            {
                using(SqlConnection connection =new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "exec SP_GetHealtyFormInfoByID @ID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", HealthFormID);

                        connection.Open();

                        using(SqlDataReader reader=cmd.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                IsFound = true;
                                HealthFormID = (int)reader["HealthFormID"];
                                Ans1 = (bool)reader["Physical_psychological_neurologicalDiseases"];
                                detail1 = (string)reader["DetailsOne"];

                                Ans2 = (bool)reader["SpineOrSkeleton"];
                                detail2 = (string)reader["Details2"];

                                Ans3 = (bool)reader["diabetes_pressure_rheumatism"];
                                detail3 = (string)reader["Details3"];

                                Ans4 = (bool)reader["RespiratorySystem"];
                                detail4 = (string)reader["Details4"];

                                Ans5 = (bool)reader["HeartAndArteries"];
                                detail5 = (string)reader["Details5"];


                                Ans6 = (bool)reader["BloodDiseases"];
                                detail6 = (string)reader["Details6"];

                                Ans7 = (bool)reader["AnyotherDisease"];
                                detail7 = (string)reader["Deatils7"];

                                Ans8 = (bool)reader["Surgeries"];
                                detail8 = (string)reader["Details8"];

                                Ans9 = (bool)reader["DoYouUseMedications"];
                                detail9 = (string)reader["Details9"];

                                ans10 = (bool)reader["AreYouASmoker"];
                                detail10 = (string)reader["Details10"];


                            }

                        }
                    }
                }
            }
            catch
            {
                IsFound = false;

            }

            return IsFound;



        }

    }
}
