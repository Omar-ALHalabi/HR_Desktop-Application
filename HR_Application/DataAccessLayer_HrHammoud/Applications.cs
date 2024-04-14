using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;



namespace DataAccessLayer_HrHammoud
{
    public class Applications
    {


        static public int _AddNewApplication(string FirstName, string FatherName, string FamilyName, string MotherName, bool? IsRegisterUN, string BloodType, bool? IsFoundSponsor, string RegionInIdentity,
string RegisterNumber, string Nationality, string BirthPlace, DateTime DateOfBirth, string AcademyLevel, string Languages, bool? ArmyServices, string IsFoundDrivingLicense,
DateTime? ExpirationDateDrivingLicense, string MaritalStatus, bool? WorksWife, byte? NumChildren, bool? IsGuaranteeForWife, string Certificates, bool? IsOutCompany, string RegionOfResidence, string StreetResidence,
string NextTo, string Building, string Floor, string PersonalPhone, byte[] PersonalImage, string NumRomResidence, string RegionInSyria, string StreetInSyria, string NextToInSyria,
string BuildingInSyria, string FloorInSyria, string PhoneInSyria, string previousWork, string PreviousSalary, string ReasonforLeavingWork, string previousWorkPhone, string Experiences, string wantedJob,
DateTime? EndDateOfTheCurrentCommitment, string SecurityNumber, string Department, string WorkHours, decimal Salary, string KindWork, DateTime DateOfApplication, DateTime? WorkStartDate,
string Applicationstatus, DateTime EditLastDate, byte? CreatedByUserID,string transportation,string ReasonAppStatues)
        {
            int ID = -1;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
            {



                try
                {

                    string query = "declare @ID int;  exec sp_AddNewApplication  @FirstName ,@FatherName ,@FamilyName,@MotherName,@IsRegisterdUN ,@BloodType,@IsFoundSponsor,@RegionInIdentity,@RegisterNumber,@Nationality," +
                        "@BirthPlace,@DateBirth,@AcademyLevel,@Languages,@ArmyServices,@IsFoundDrivingLicense,@ExpirationDateDrivingLicense,@MaritalStatus,@WorksWife,@NumChildren,@IsGuaranteeForWife,@Certificate,@OutCompany,@RegionOfResidence,@StreetResidence,@NextTo,@Building,@Floors,@PersonalPhone,@NumRomResidence" +
                        ",@RegionInSyria,@StreetInSyria,@NextToInSyria,@BuildingInSyria,@FloorInSyria,@PhoneInSyria,@PersonalImage,@previousWork,@PreviousSalary,@ReasonforLeavingWork,@previousWorkPhone,@Experiences,@wantedJob,@EndDateOfTheCurrentCommitment,@SecurityNumber" +
                        ",@Department,@WorkHours,@Salary,@KindWork,@DateOfApplication,@WorkStartDate,@Applicationstatus,@CreatedByUser,@EditLastDate,@Transportation,@ReasonAppStatus;";



                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@AppId", ID);
                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        cmd.Parameters.AddWithValue("@FatherName", FatherName);
                        cmd.Parameters.AddWithValue("@FamilyName", FamilyName);
                        cmd.Parameters.AddWithValue("@MotherName", MotherName);
                        cmd.Parameters.AddWithValue("@BloodType", BloodType);


                        if (IsRegisterUN != null)
                        {
                            cmd.Parameters.AddWithValue("@IsRegisterdUN", IsRegisterUN);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@IsRegisterdUN", DBNull.Value);

                        }



                        if (IsFoundSponsor != null)
                        {
                            cmd.Parameters.AddWithValue("@IsFoundSponsor", IsFoundSponsor);

                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@IsFoundSponsor", DBNull.Value);
                        }

                        cmd.Parameters.AddWithValue("@RegionInIdentity", RegionInIdentity);
                        cmd.Parameters.AddWithValue("@RegisterNumber", RegisterNumber);
                        cmd.Parameters.AddWithValue("@Nationality", Nationality);
                        cmd.Parameters.AddWithValue("@BirthPlace", BirthPlace);
                        cmd.Parameters.AddWithValue("@DateBirth", DateOfBirth);
                        cmd.Parameters.AddWithValue("@AcademyLevel", AcademyLevel);
                        cmd.Parameters.AddWithValue("@Languages", Languages ?? string.Empty);

                        if (ArmyServices != null)
                        {
                            cmd.Parameters.AddWithValue("@ArmyServices", ArmyServices);

                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ArmyServices", DBNull.Value);
                        }

                        cmd.Parameters.AddWithValue("@IsFoundDrivingLicense", IsFoundDrivingLicense);

                        cmd.Parameters.AddWithValue("@ExpirationDateDrivingLicense", ExpirationDateDrivingLicense ?? null);
                        cmd.Parameters.AddWithValue("@MaritalStatus", MaritalStatus);

                        if (WorksWife != null)
                        {
                            cmd.Parameters.AddWithValue("@WorksWife", WorksWife);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@WorksWife", DBNull.Value);

                        }
                  

                     
                      

                        // الآن يمكنك استخدام dbNullValue لإدخال القيمة في قاعدة البيانات
                        // ...
                        if (NumChildren==null)
                        {
                            cmd.Parameters.AddWithValue("@NumChildren", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@NumChildren", NumChildren );

                        }
                    
                        

                        if (IsGuaranteeForWife != null)
                        {
                            cmd.Parameters.AddWithValue("@IsGuaranteeForWife", IsGuaranteeForWife);

                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@IsGuaranteeForWife", DBNull.Value);

                        }

                        cmd.Parameters.AddWithValue("@Certificate", Certificates ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@Transportation", transportation ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@ReasonAppStatus", ReasonAppStatues ?? DBNull.Value.ToString());

                        if (IsOutCompany != null)
                        {
                            cmd.Parameters.AddWithValue("@OutCompany", IsOutCompany);

                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@OutCompany", DBNull.Value);

                        }

                        cmd.Parameters.AddWithValue("@RegionOfResidence", RegionOfResidence ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@StreetResidence", StreetResidence ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@NextTo", NextTo ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@Building", Building ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@Floors", Floor ?? DBNull.Value.ToString());

                        cmd.Parameters.AddWithValue("@PersonalPhone", PersonalPhone ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@NumRomResidence", NumRomResidence ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@RegionInSyria", RegionInSyria ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@StreetInSyria", StreetInSyria ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@NextToInSyria", NextToInSyria ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@BuildingInSyria", BuildingInSyria ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@FloorInSyria", FloorInSyria ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@PhoneInSyria", PhoneInSyria ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@previousWork", previousWork ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@PreviousSalary", PreviousSalary ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@ReasonforLeavingWork", ReasonforLeavingWork ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@Experiences", Experiences ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@wantedJob", wantedJob ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@EndDateOfTheCurrentCommitment", EndDateOfTheCurrentCommitment);
                        cmd.Parameters.AddWithValue("@SecurityNumber", SecurityNumber ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@Department", Department ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@WorkHours", WorkHours ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@Salary", Salary);
                        cmd.Parameters.AddWithValue("@KindWork", KindWork ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@DateOfApplication", DateOfApplication);
                        cmd.Parameters.AddWithValue("@WorkStartDate", WorkStartDate ?? default(DateTime).AddYears(1753));
                        cmd.Parameters.AddWithValue("@Applicationstatus", Applicationstatus ?? DBNull.Value.ToString());

                        cmd.Parameters.AddWithValue("@previousWorkPhone", previousWorkPhone ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@PersonalImage", PersonalImage ?? new byte[0]);
                        cmd.Parameters.AddWithValue("@EditLastDate", EditLastDate);
                        cmd.Parameters.AddWithValue("@CreatedByUser", CreatedByUserID ?? 0);


                        connection.Open();

                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {

                            ID = insertedID;

                        }

                    }
                }
                catch
                {
                    ID = -1;



                }
                return ID;


            }

            

        }



        static public bool GetInfoAppByID(ref int id, ref string FirstName, ref string FatherName, ref string FamilyName,ref  string MotherName,ref  bool? IsRegisterUN, ref string BloodType,ref  bool? IsFoundSponsor,ref  string RegionInIdentity,
ref string RegisterNumber, ref string Nationality, ref string BirthPlace, ref DateTime DateOfBirth, ref string AcademyLevel,ref  string Languages, ref bool? ArmyServices, ref string IsFoundDrivingLicense,
ref DateTime? ExpirationDateDrivingLicense,ref  string MaritalStatus, ref bool? WorksWife, ref byte? NumChildren, ref bool? IsGuaranteeForWife,ref string Certificates,ref  bool IsOutCompany,ref  string RegionOfResidence, ref string StreetResidence,
ref string NextTo, ref string Building, ref string Floor, ref string PersonalPhone, ref byte[] PersonalImage, ref string NumRomResidence, ref string RegionInSyria, ref string StreetInSyria,ref  string NextToInSyria,
ref string BuildingInSyria, ref string FloorInSyria, ref string PhoneInSyria, ref string previousWork, ref string PreviousSalary, ref string ReasonforLeavingWork,ref  string previousWorkPhone, ref string Experiences,ref  string wantedJob,
ref DateTime? EndDateOfTheCurrentCommitment, ref string SecurityNumber, ref string Department,ref  string WorkHours,ref decimal Salary, ref string KindWork, ref DateTime DateOfApplication, ref DateTime? WorkStartDate,
ref string Applicationstatus, ref DateTime EditLastDate, ref byte CreatedByUserID,ref string transportation,ref string ReasonAppStatues)
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
            {

                string query = "exec GetApplicationInfoByAppID @appid";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@appid", id);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;



                                FirstName = (string)reader["FirstName"];
                                FatherName = (string)reader["FatherName"];
                                FamilyName = (string)reader["FamilyName"];
                                MotherName = (string)reader["MotherName"];
                                if (reader["IsRegisterdUN"] != DBNull.Value)
                                {
                                    IsRegisterUN = (bool?)reader["IsRegisterdUN"];
                                }
                                else
                                {
                                    IsRegisterUN = null;
                                }
                              
                                
                                BloodType = (string)reader["BloodType"];
                               
                                if (reader["IsFoundSponsor"] != DBNull.Value)
                                {
                                    IsFoundSponsor = (bool?)reader["IsFoundSponsor"];
                                }
                                else
                                {
                                    IsFoundSponsor = null;
                                }

                                RegionInIdentity = (string)reader["RegionInIdentity"];
                                RegisterNumber = (string)reader["RegisterNumber"];
                                Nationality = (string)reader["Nationality"];
                                BirthPlace = (string)reader["BirthPlace"];
                                DateOfBirth = (DateTime)reader["DateBirth"];
                                AcademyLevel = (string)reader["AcademyLevel"];
                                Languages = (string)reader["Languages"];
                                if (reader["ArmyServices"] != DBNull.Value)
                                {
                                    ArmyServices = (bool?)reader["ArmyServices"];
                                }
                                else
                                {
                                    ArmyServices = null;
                                }


                                IsFoundDrivingLicense = (string)reader["IsFoundDrivingLicense"];
                                ExpirationDateDrivingLicense = (DateTime)reader["ExpirationDateDrivingLicense"];
                                MaritalStatus = (string)reader["MaritalStatus"];

                                if (reader["WorksWife"] != DBNull.Value)
                                {
                                    WorksWife = (bool?)reader["WorksWife"];
                                }
                                else
                                {
                                    ArmyServices = null;
                                }

                                if (reader["NumChildren"] != DBNull.Value)
                                {
                                    NumChildren = (byte?)reader["NumChildren"];
                                }
                                else
                                {
                                    NumChildren = null;
                                }

                                if (reader["IsGuaranteeForWife"] != DBNull.Value)
                                {
                                    IsGuaranteeForWife = (bool?)reader["IsGuaranteeForWife"];
                                }
                                else
                                {
                                    IsGuaranteeForWife = null;
                                }

                                if (reader["ReasonAppStatus"] != DBNull.Value)
                                {
                                    transportation = (string)reader["ReasonAppStatus"];
                                }
                                else
                                {
                                    transportation = null;
                                }

                             
                                if (reader["ReasonAppStatus"] != DBNull.Value)
                                {
                                    ReasonAppStatues = (string)reader["ReasonAppStatus"];
                                }
                                else
                                {
                                    ReasonAppStatues = null;
                                }


                                IsOutCompany = (bool)reader["OutCompany"];
                                RegionOfResidence = (string)reader["RegionOfResidence"];
                                StreetResidence = (string)reader["StreetResidence"];
                                NextTo = (string)reader["NextTo"];
                                Building = (string)reader["Building"];
                                Floor = (string)reader["Floors"];
                                PersonalPhone = (string)reader["PersonalPhone"];   
                              NumRomResidence= (string)reader["NumRomResidence"];
                              RegionInSyria = (string)reader["RegionInSyria"];
                              StreetInSyria = (string)reader["StreetInSyria"];
                              NextToInSyria = (string)reader["NextToInSyria"];
                              BuildingInSyria   = (string)reader["BuildingInSyria"];
                              FloorInSyria= (string)reader["FloorInSyria"];
                              PhoneInSyria  = (string)reader["PhoneInSyria"];
                                previousWork = (string)reader["previousWork"];
                                PreviousSalary = (string)reader["PreviousSalary"];
                                ReasonforLeavingWork = (string)reader["ReasonforLeavingWork"];
                                previousWorkPhone = (string)reader["previousWorkPhone"];
                                Experiences = (string)reader["Experiences"];
                                wantedJob = (string)reader["wantedJob"];
                                EndDateOfTheCurrentCommitment = (DateTime)reader["EndDateOfTheCurrentCommitment"];
                                SecurityNumber = (string)reader["SecurityNumber"];
                                Department = (string)reader["Department"];
                                WorkHours = (string)reader["WorkHours"];
                                Salary = (decimal)reader["Salary"];

                                KindWork = (string)reader["KindWork"];
                                DateOfApplication = (DateTime)reader["DateOfApplication"];
                                WorkStartDate = (DateTime)reader["WorkStartDate"];
                                Applicationstatus = (string)reader["Applicationstatus"];
                                CreatedByUserID = (byte)reader["CreatedByUser"];
                                EditLastDate = (DateTime)reader["EditLastDate"];
                                if (reader["PersonalImage"] != DBNull.Value)
                                {
                                    PersonalImage = (byte[])reader["PersonalImage"];
                                }
                                else
                                {
                                    PersonalImage = null;
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



        static public bool UpdateApplication(int id, string FirstName, string FatherName, string FamilyName, string MotherName, bool? IsRegisterUN, string BloodType, bool? IsFoundSponsor, string RegionInIdentity,
string RegisterNumber, string Nationality, string BirthPlace, DateTime DateOfBirth, string AcademyLevel, string Languages, bool? ArmyServices, string IsFoundDrivingLicense,
DateTime? ExpirationDateDrivingLicense, string MaritalStatus, bool? WorksWife, byte? NumChildren, bool? IsGuaranteeForWife, string Certificates, bool? IsOutCompany, string RegionOfResidence, string StreetResidence,
string NextTo, string Building, string Floor, string PersonalPhone, byte[] PersonalImage, string NumRomResidence, string RegionInSyria, string StreetInSyria, string NextToInSyria,
string BuildingInSyria, string FloorInSyria, string PhoneInSyria, string previousWork, string PreviousSalary, string ReasonforLeavingWork, string previousWorkPhone, string Experiences, string wantedJob,
DateTime? EndDateOfTheCurrentCommitment, string SecurityNumber, string Department, string WorkHours, decimal Salary, string KindWork, DateTime DateOfApplication, DateTime? WorkStartDate,
string Applicationstatus, DateTime EditLastDate, byte? CreatedByUserID,string transportation,string reasonAppStatus)

        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection=new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = " exec SP_UpdateApplicationByAPPID  @id,@FirstName, @FatherName, @FamilyName,@MotherName,@IsRegisterdUN,@BloodType,@IsFoundSponsor," +
                        "@RegionInIdentity,@RegisterNumber,@Nationality,@BirthPlace, @DateBirth, @AcademyLevel,@Languages,@ArmyServices ,@IsFoundDrivingLicense," +
                        " @ExpirationDateDrivingLicense, @MaritalStatus,  @WorksWife, @NumChildren,  @IsGuaranteeForWife,@Certificate,@OutCompany, @RegionOfResidence, @StreetResidence, " +
                        " @NextTo,  @Building, @Floors,  @PersonalPhone,@NumRomResidence,@RegionInSyria, @StreetInSyria, @NextToInSyria,  @BuildingInSyria,@FloorInSyria, " +
                        " @PhoneInSyria,@PersonalImage,@previousWork,  @PreviousSalary, @ReasonforLeavingWork,@previousWorkPhone," +
                        "@Experiences, @wantedJob,  @EndDateOfTheCurrentCommitment,@SecurityNumber, @Department, @WorkHours,  @Salary,  @KindWork, " +
                        "@DateOfApplication, @WorkStartDate, @Applicationstatus, @CreatedByUser,@EditLastDate,@transpotation,@reasonAppStatus";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {




                       cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        cmd.Parameters.AddWithValue("@FatherName", FatherName);
                        cmd.Parameters.AddWithValue("@FamilyName", FamilyName);
                        cmd.Parameters.AddWithValue("@MotherName", MotherName);

                        if (IsRegisterUN == null)
                        {
                            cmd.Parameters.AddWithValue("@IsRegisterdUN", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@IsRegisterdUN", IsRegisterUN);
                        }


                      
                        cmd.Parameters.AddWithValue("@BloodType", BloodType);
                       

                        if (IsFoundSponsor==null)
                        {
                            cmd.Parameters.AddWithValue("@IsFoundSponsor", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@IsFoundSponsor", IsFoundSponsor);
                        }

                        cmd.Parameters.AddWithValue("@RegionInIdentity", RegionInIdentity);
                        cmd.Parameters.AddWithValue("@RegisterNumber", RegisterNumber);
                        cmd.Parameters.AddWithValue("@Nationality", Nationality);
                        cmd.Parameters.AddWithValue("@BirthPlace", BirthPlace);
                        cmd.Parameters.AddWithValue("@DateBirth", DateOfBirth);
                        cmd.Parameters.AddWithValue("@AcademyLevel", AcademyLevel);
                        cmd.Parameters.AddWithValue("@Languages", Languages??DBNull.Value.ToString());
                    
                        if(ArmyServices!=null)
                        {
                            cmd.Parameters.AddWithValue("@ArmyServices", ArmyServices);

                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ArmyServices", DBNull.Value);

                        }

                        cmd.Parameters.AddWithValue("@IsFoundDrivingLicense", IsFoundDrivingLicense ?? DBNull.Value.ToString());

                        cmd.Parameters.AddWithValue("@ExpirationDateDrivingLicense", ExpirationDateDrivingLicense);
                        cmd.Parameters.AddWithValue("@MaritalStatus", MaritalStatus);
                       

                        if (WorksWife != null)
                        {
                            cmd.Parameters.AddWithValue("@WorksWife", WorksWife);

                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@WorksWife", DBNull.Value);

                        }
                        if(NumChildren!=null)
                        {
                            cmd.Parameters.AddWithValue("@NumChildren", NumChildren);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@NumChildren", DBNull.Value);
                        }
                        
                    

                       
                        if (IsGuaranteeForWife == null)
                        {
                            cmd.Parameters.AddWithValue("@IsGuaranteeForWife", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@IsGuaranteeForWife", IsGuaranteeForWife);
                        }


                        cmd.Parameters.AddWithValue("@Certificate", Certificates ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@reasonAppStatus", reasonAppStatus ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@transpotation", transportation ?? DBNull.Value.ToString());
                        if (IsOutCompany != null)
                        {
                            cmd.Parameters.AddWithValue("@OutCompany", IsOutCompany);
                        }
                        else
                        {
                           
                            cmd.Parameters.AddWithValue("@OutCompany", DBNull.Value);
                        }



                        cmd.Parameters.AddWithValue("@RegionOfResidence", RegionOfResidence ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@StreetResidence", StreetResidence ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@NextTo", NextTo ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@Building", Building ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@Floors", Floor ?? DBNull.Value.ToString());

                        cmd.Parameters.AddWithValue("@PersonalPhone", PersonalPhone??DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@NumRomResidence",NumRomResidence ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@RegionInSyria", RegionInSyria ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@StreetInSyria", StreetInSyria ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@NextToInSyria", NextToInSyria ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@BuildingInSyria", BuildingInSyria ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@FloorInSyria", FloorInSyria ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@PhoneInSyria", PhoneInSyria ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@previousWork", previousWork ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@PreviousSalary", PreviousSalary ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@ReasonforLeavingWork", ReasonforLeavingWork ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@Experiences", Experiences ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@wantedJob", wantedJob ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@EndDateOfTheCurrentCommitment", EndDateOfTheCurrentCommitment);
                        cmd.Parameters.AddWithValue("@SecurityNumber", SecurityNumber ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@Department", Department ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@WorkHours", WorkHours ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@Salary", Salary );
                        cmd.Parameters.AddWithValue("@KindWork", KindWork ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@DateOfApplication", DateOfApplication);
                        cmd.Parameters.AddWithValue("@WorkStartDate", WorkStartDate??default(DateTime).AddYears(1753));

                        cmd.Parameters.AddWithValue("@Applicationstatus", Applicationstatus ?? DBNull.Value.ToString());

                        cmd.Parameters.AddWithValue("@previousWorkPhone", previousWorkPhone ?? DBNull.Value.ToString());
                        cmd.Parameters.AddWithValue("@PersonalImage", PersonalImage??new byte[0]);
                        cmd.Parameters.AddWithValue("@EditLastDate", EditLastDate);
                        cmd.Parameters.AddWithValue("@CreatedByUser", CreatedByUserID);

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


        static public bool UpdateStatus(int appid,string applicationstatus)
        {
            int rowaffacted = 0;

            try
            {
                using(SqlConnection connection=new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec SP_EditApplicationStatues @appstatus,@id";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@appstatus", applicationstatus);
                        cmd.Parameters.AddWithValue("@id", appid);

                        connection.Open();
                        rowaffacted = cmd.ExecuteNonQuery();


                    }

                      



                }



            }
            catch
            {
                rowaffacted = 0;


            }

            return rowaffacted>0;


        }

        static public DataTable GetAllApplications(short pagenumber)
        {
            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "exec SP_GetAllApplications @pagenumber";
                    using(SqlCommand cmd=new SqlCommand(query,connection))
                    {
                        cmd.Parameters.AddWithValue("@pagenumber", pagenumber);

                        connection.Open();

                        using(SqlDataReader reader=cmd.ExecuteReader())
                        {

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
            }
            catch
            {


            }
           
            return dt;





        }
        static public DataTable GetAllApplications()
        {
            DataTable dt = new DataTable();

            try
            {

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "exec getallrecordsapplication ";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                       

                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }

                        }

                    }


                }
            }
            catch
            {


            }

            return dt;





        }

        static public DataTable _GetAllAppByFilterStatus(string appStatus,short pagenumber)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "exec SP_GetAllApplicationByFilterStatus @status,@PageNumber";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@status", appStatus);
                        cmd.Parameters.AddWithValue("@PageNumber", pagenumber);
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



            }
            return dt;
           





        }

        static public DataTable _GetAllAppByFilterStatus(string appStatus)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "exec SP_GetAllApplicationByFilterStatusWithoutPaging @status";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@status", appStatus);
                     
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



            }
            return dt;






        }


        static public bool GetInfoAppByFullName(string fullnaem,ref int id, ref string FirstName, ref string FatherName, ref string FamilyName, ref string MotherName, ref bool? IsRegisterUN, ref string BloodType, ref bool? IsFoundSponsor, ref string RegionInIdentity,
ref string RegisterNumber, ref string Nationality, ref string BirthPlace, ref DateTime DateOfBirth, ref string AcademyLevel, ref string Languages, ref bool? ArmyServices, ref string IsFoundDrivingLicense,
ref DateTime? ExpirationDateDrivingLicense, ref string MaritalStatus, ref bool? WorksWife, ref byte? NumChildren, ref bool? IsGuaranteeForWife, ref string Certificates, ref bool IsOutCompany, ref string RegionOfResidence, ref string StreetResidence,
ref string NextTo, ref string Building, ref string Floor, ref string PersonalPhone, ref byte[] PersonalImage, ref string NumRomResidence, ref string RegionInSyria, ref string StreetInSyria, ref string NextToInSyria,
ref string BuildingInSyria, ref string FloorInSyria, ref string PhoneInSyria, ref string previousWork, ref string PreviousSalary, ref string ReasonforLeavingWork, ref string previousWorkPhone, ref string Experiences, ref string wantedJob,
ref DateTime? EndDateOfTheCurrentCommitment, ref string SecurityNumber, ref string Department, ref string WorkHours, ref decimal Salary, ref string KindWork, ref DateTime DateOfApplication, ref DateTime? WorkStartDate,
ref string Applicationstatus, ref DateTime EditLastDate, ref byte CreatedByUserID, ref string transportation, ref string ReasonAppStatues)
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
            {

                string query = "exec sp_GetApplicationInfoByFullName @fullname";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@fullname", fullnaem);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;


                                id = (int)reader["ID"];
                                FirstName = (string)reader["FirstName"];
                                FatherName = (string)reader["FatherName"];
                                FamilyName = (string)reader["FamilyName"];
                                MotherName = (string)reader["MotherName"];
                                if (reader["IsRegisterdUN"] != DBNull.Value)
                                {
                                    IsRegisterUN = (bool?)reader["IsRegisterdUN"];
                                }
                                else
                                {
                                    IsRegisterUN = null;
                                }


                                BloodType = (string)reader["BloodType"];

                                if (reader["IsFoundSponsor"] != DBNull.Value)
                                {
                                    IsFoundSponsor = (bool?)reader["IsFoundSponsor"];
                                }
                                else
                                {
                                    IsFoundSponsor = null;
                                }

                                RegionInIdentity = (string)reader["RegionInIdentity"];
                                RegisterNumber = (string)reader["RegisterNumber"];
                                Nationality = (string)reader["Nationality"];
                                BirthPlace = (string)reader["BirthPlace"];
                                DateOfBirth = (DateTime)reader["DateBirth"];
                                AcademyLevel = (string)reader["AcademyLevel"];
                                Languages = (string)reader["Languages"];
                                if (reader["ArmyServices"] != DBNull.Value)
                                {
                                    ArmyServices = (bool?)reader["ArmyServices"];
                                }
                                else
                                {
                                    ArmyServices = null;
                                }


                                IsFoundDrivingLicense = (string)reader["IsFoundDrivingLicense"];
                                ExpirationDateDrivingLicense = (DateTime)reader["ExpirationDateDrivingLicense"];
                                MaritalStatus = (string)reader["MaritalStatus"];

                                if (reader["WorksWife"] != DBNull.Value)
                                {
                                    WorksWife = (bool?)reader["WorksWife"];
                                }
                                else
                                {
                                    ArmyServices = null;
                                }

                                if (reader["NumChildren"] != DBNull.Value)
                                {
                                    NumChildren = (byte?)reader["NumChildren"];
                                }
                                else
                                {
                                    NumChildren = null;
                                }

                                if (reader["IsGuaranteeForWife"] != DBNull.Value)
                                {
                                    IsGuaranteeForWife = (bool?)reader["IsGuaranteeForWife"];
                                }
                                else
                                {
                                    IsGuaranteeForWife = null;
                                }

                                if (reader["ReasonAppStatus"] != DBNull.Value)
                                {
                                    transportation = (string)reader["ReasonAppStatus"];
                                }
                                else
                                {
                                    transportation = null;
                                }


                                if (reader["ReasonAppStatus"] != DBNull.Value)
                                {
                                    ReasonAppStatues = (string)reader["ReasonAppStatus"];
                                }
                                else
                                {
                                    ReasonAppStatues = null;
                                }


                                IsOutCompany = (bool)reader["OutCompany"];
                                RegionOfResidence = (string)reader["RegionOfResidence"];
                                StreetResidence = (string)reader["StreetResidence"];
                                NextTo = (string)reader["NextTo"];
                                Building = (string)reader["Building"];
                                Floor = (string)reader["Floors"];
                                PersonalPhone = (string)reader["PersonalPhone"];
                                NumRomResidence = (string)reader["NumRomResidence"];
                                RegionInSyria = (string)reader["RegionInSyria"];
                                StreetInSyria = (string)reader["StreetInSyria"];
                                NextToInSyria = (string)reader["NextToInSyria"];
                                BuildingInSyria = (string)reader["BuildingInSyria"];
                                FloorInSyria = (string)reader["FloorInSyria"];
                                PhoneInSyria = (string)reader["PhoneInSyria"];
                                previousWork = (string)reader["previousWork"];
                                PreviousSalary = (string)reader["PreviousSalary"];
                                ReasonforLeavingWork = (string)reader["ReasonforLeavingWork"];
                                previousWorkPhone = (string)reader["previousWorkPhone"];
                                Experiences = (string)reader["Experiences"];
                                wantedJob = (string)reader["wantedJob"];
                                EndDateOfTheCurrentCommitment = (DateTime)reader["EndDateOfTheCurrentCommitment"];
                                SecurityNumber = (string)reader["SecurityNumber"];
                                Department = (string)reader["Department"];
                                WorkHours = (string)reader["WorkHours"];
                                Salary = (decimal)reader["Salary"];

                                KindWork = (string)reader["KindWork"];
                                DateOfApplication = (DateTime)reader["DateOfApplication"];
                                WorkStartDate = (DateTime)reader["WorkStartDate"];
                                Applicationstatus = (string)reader["Applicationstatus"];
                                CreatedByUserID = (byte)reader["CreatedByUser"];
                                EditLastDate = (DateTime)reader["EditLastDate"];
                                if (reader["PersonalImage"] != DBNull.Value)
                                {
                                    PersonalImage = (byte[])reader["PersonalImage"];
                                }
                                else
                                {
                                    PersonalImage = null;
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


        static public int _GetNumberOfecords()
        {
            int NumberOfRecords = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec getnumberofrecordsApplications ";

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


        static public int _GetNumberOfecordsByStatus(string appstatus)
        {
            int NumberOfRecords = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {

                    string query = "exec GetNumberOfRecordsByAppStatus @Status";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Status", appstatus);


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

        //هذه الفانكشن بمثابة بحث عن الطلبات وفق تاريخين وحالة طلب معينة

        static public DataTable _SearchByDateApp(string startDate,string Enddate,string Status)
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "sp_searchAppBetweenDatesByDateOfApp @startDate,@enddate,@Status";

                    using (SqlCommand cmd=new SqlCommand(query,connection))
                    {
                     
                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@enddate", Enddate);
                        cmd.Parameters.AddWithValue("@Status", Status);
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

        static public DataTable _SearchByDateOfBirth(string startDate, string Enddate,string Status)
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "sp_searchAppByDateBirth @startDate,@enddate,@Status";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@enddate", Enddate);
                        cmd.Parameters.AddWithValue("@Status", Status);
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


        static public DataTable _SearchByLastDateEdit(string startDate, string Enddate, string Status)
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "sp_searchAppByLastEdit @startDate,@enddate,@Status";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@enddate", Enddate);
                        cmd.Parameters.AddWithValue("@Status", Status);
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

        static public DataTable _SearchByWorkStartDate(string startDate, string Enddate,string statues)
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "sp_searchAppByWorkStartDate @startDate,@enddate,@Status";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@enddate", Enddate);
                        cmd.Parameters.AddWithValue("@enddate", statues);
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


        //هذه الفانكشن بمثابة بحث عن الطلبات وفق تاريخين فقط وتشمل جميع الحالات

        static public DataTable _SearchByDateApp(string startDate, string Enddate)
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "sp_GetAllAppByDateOfApp @startDate,@enddate";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@enddate", Enddate);
                
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

        static public DataTable _SearchByDateOfBirth(string startDate, string Enddate )
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "sp_GetAllAppByDateBirth @startDate,@enddate";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@enddate", Enddate);
               
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

        static public DataTable _SearchByLastDateEdit(string startDate, string Enddate )
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "sp_GetAllAppByEdilLastDate @startDate,@enddate";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@enddate", Enddate);
                  
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
        static public DataTable _SearchByWorkStartDate(string startDate, string Enddate )
        {

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                {
                    string query = "sp_GetAllAppByWorkStartDate @startDate,@enddate";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@startDate", startDate);
                        cmd.Parameters.AddWithValue("@enddate", Enddate);
                       
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




                    
                   





                    






                





            


              



