using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_HrHammoud;

namespace DataBuisnessLayerHrHammoud
{
    public class ClsApplication:ClsHealthForm
    { 
       public enum EnMode { addnew=0,update=1}
        EnMode _Mode;
       
    
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string FamilyName { get; set; }
        public string MotherName { get; set; }
        public bool? IsRegisterUN { get; set; }
        public string BloodType { get; set; }
        public bool? IsFoundSponsor { get; set; }
        public string RegionInIdentity { get; set; }
        public string RegisterNumber { get; set; }
        public string Nationality { get; set; }
        public string BirthPlace { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AcademyLevel { get; set; }
        public string Languages { get; set; }
        public bool? ArmyServices { get; set; }
        public string IsFoundDrivingLicense { get; set; }
        public DateTime? ExpirationDateDrivingLicense { get; set; }
        public string MaritalStatus { get; set; }
        public bool? WorksWife { get; set; }
        public byte? NumChildren { get; set; }
        public bool? IsGuaranteeForWife { get; set; }
        public string Certificates { get; set; }
        public bool IsOutCompany { get; set; }
        public string RegionOfResidence { get; set; }
        public string StreetResidence { get; set; }
        public string NextTo { get; set; }
        public string Building { get; set; }
        public string Floor { get; set; }
        public string PersonalPhone { get; set; }
        public byte[] PersonalImage { get; set; }
        public string NumRomResidence { get; set; }
        public string RegionInSyria { get; set; }
        public string StreetInSyria { get; set; }
        public string NextToInSyria { get; set; }
        public string BuildingInSyria { get; set; }
        public string FloorInSyria { get; set; }
        public string PhoneInSyria { get; set; }
        public string previousWork { get; set; }
        public string PreviousSalary { get; set; }
        public string ReasonforLeavingWork { get; set; }
        public string previousWorkPhone { get; set; }
        public string Experiences { get; set; }
        public string wantedJob { get; set; }
        public DateTime? EndDateOfTheCurrentCommitment { get; set; }
        public string SecurityNumber { get; set; }
        public string Department { get; set; }
        public string WorkHours { get; set; }
        public decimal Salary { get; set; }
        public string KindWork { get; set; }
        public DateTime DateOfApplication { get; set; }
        public DateTime? WorkStartDate { get; set; }
        public string Applicationstatus { get; set; }
        public DateTime EditLastDate {get; set;}
         public byte CreatedByUserID { set; get; }
        public string ReasonAppStatus { get; set; }
        public string Transportation { get; set; }









        public ClsApplication(int aPPLICATIONid,string FirstName, string FatherName, string FamilyName, string MotherName, bool? IsRegisterUN, string BloodType, bool? IsFoundSponsor, string RegionInIdentity,
string RegisterNumber, string Nationality, string BirthPlace, DateTime DateOfBirth, string AcademyLevel, string Languages, bool? ArmyServices, string IsFoundDrivingLicense,
DateTime? ExpirationDateDrivingLicense, string MaritalStatus, bool? WorksWifes, byte? NumChildren, bool? IsGuaranteeForWife, string Certificates, bool IsOutCompany, string RegionOfResidence, string StreetResidence,
string NextTo, string Building, string Floor, string PersonalPhone, byte[] PersonalImage, string NumRomResidence, string RegionInSyria, string StreetInSyria, string NextToInSyria,
string BuildingInSyria, string FloorInSyria, string PhoneInSyria, string previousWork, string PreviousSalary, string ReasonforLeavingWork,string previousWorkPhone, string Experiences, string wantedJob,
DateTime? EndDateOfTheCurrentCommitment, string SecurityNumber, string Department, string WorkHours, decimal Salary, string KindWork, DateTime DateOfApplication, DateTime? WorkStartDate,
string Applicationstatus,DateTime EditLastDate,byte CreatedByUserID,string Transportations,string _ReasonAppStatues, int HealthyFormID, bool Ans1, string detail1, bool Ans2, string detail2, bool Ans3, string detail3, bool Ans4, string detail4,
bool Ans5, string detail5, bool Ans6, string detail6, bool Ans7, string detail7, bool Ans8, string detail8, bool Ans9, string detail9, bool ans10, string detail10)
        {
            this.ID = aPPLICATIONid;
            this.FirstName = FirstName;
            this.FatherName = FatherName;
            this.FamilyName = FamilyName;
            this.MotherName = MotherName;
            this.IsRegisterUN = IsRegisterUN;
            this.BloodType = BloodType;
            this.IsFoundSponsor = IsFoundSponsor;
            this.RegionInIdentity = RegionInIdentity;
            this.RegisterNumber = RegisterNumber;
            this.Nationality = Nationality;
            this.BirthPlace = BirthPlace;
            this.DateOfBirth = DateOfBirth;
            this.AcademyLevel = AcademyLevel;
            this.Languages = Languages;
            this.ArmyServices = ArmyServices;
            this.IsFoundDrivingLicense = IsFoundDrivingLicense;
            this.ExpirationDateDrivingLicense = ExpirationDateDrivingLicense;
            this.MaritalStatus = MaritalStatus;
            this.WorksWife = WorksWifes;
            this.NumChildren = NumChildren;
            this.IsGuaranteeForWife = IsGuaranteeForWife;
            this.Certificates = Certificates;
            this.IsOutCompany = IsOutCompany;
            this.RegionOfResidence = RegionOfResidence;
            this.StreetResidence = StreetResidence;
            this.NextTo = NextTo;
            this.Building = Building;
            this.Floor = Floor;
            this.PersonalPhone = PersonalPhone;
            this.PersonalImage = PersonalImage;
            this.NumRomResidence = NumRomResidence;
            this.RegionInSyria = RegionInSyria;
            this.StreetInSyria = StreetInSyria;
            this.NextToInSyria = NextToInSyria;
            this.BuildingInSyria = BuildingInSyria;
            this.FloorInSyria = FloorInSyria;
            this.PhoneInSyria = PhoneInSyria;
            this.previousWork = previousWork;
            this.PreviousSalary = PreviousSalary;
            this.ReasonforLeavingWork = ReasonforLeavingWork;
            this.previousWorkPhone = previousWorkPhone;
            this.Experiences = Experiences;
            this.wantedJob = wantedJob;
            this.EndDateOfTheCurrentCommitment = EndDateOfTheCurrentCommitment;
            this.SecurityNumber = SecurityNumber;
            this.Department = Department;
            this.WorkHours = WorkHours;
            this.Salary = Salary;
            this.KindWork = KindWork;
            this.DateOfApplication = DateOfApplication;
            this.WorkStartDate = WorkStartDate;
            this.Applicationstatus = Applicationstatus;
            this.EditLastDate = EditLastDate;
            this.CreatedByUserID = CreatedByUserID;
            //property of healthy Form
            this.HealthFormID = HealthyFormID;
            this.Physical_psychological_neurologicalDiseases = Ans1;
            this.DetailsOne = detail1;
            this.SpineOrSkeleton = Ans2;
            this.Details2 = detail2;
            this.diabetes_pressure_rheumatism = Ans3;
            this.Details3 = detail3;
            this.RespiratorySystem = Ans4;
            this.Details4 = detail4; ;
            this.HeartAndArteries = Ans5;
            this.Details5 = detail5;
            this.BloodDiseases = Ans6;
            this.Details6 = detail6;
            this.AnyotherDisease = Ans7;
            this.detail7 = detail7;
            this.Surgeries = Ans8;
            this.Details8 = detail8;
            this.DoYouUseMedications = Ans9;
            this.Details9 = detail9;
            this.AreYouASmoker = ans10;
            this.Details10 = detail10;
           this. ReasonAppStatus = _ReasonAppStatues;
            this.Transportation = Transportations;

            _Mode = EnMode.update;













        }



        public ClsApplication()
        {

       this. ID = 0;
      this.FirstName = null;
      this.FatherName = null;
      this.FamilyName = null;
      this.MotherName = null;
      this.IsRegisterUN = null;
      this.BloodType = null;
      this.IsFoundSponsor = false;
      this.RegionInIdentity = null;
      this.RegisterNumber = null;
      this.Nationality = null;
      this.BirthPlace = null;
      this.DateOfBirth = DateTime.Now;
      this.AcademyLevel = null;
      this.Languages = null;
      this.ArmyServices = null;
      this.IsFoundDrivingLicense = null;
      this.ExpirationDateDrivingLicense = null;
      this.MaritalStatus = null;
      this.WorksWife = null;
      this.NumChildren = null;
      this.IsGuaranteeForWife = null;
      this.Certificates = null;
      this.IsOutCompany=true;
      this.RegionOfResidence = null;
      this.StreetResidence = null;
      this.NextTo = null;
      this.Building = null;
      this.Floor = null;
      this.PersonalPhone = null;
      this.PersonalImage = null;
      this.NumRomResidence = null;
      this.RegionInSyria = null;
      this.StreetInSyria = null;
      this.NextToInSyria = null;
      this.BuildingInSyria = null;
      this.FloorInSyria = null;
      this.PhoneInSyria = null;
      this.previousWork = null;
      this.PreviousSalary = null;
      this.ReasonforLeavingWork = null;
      this.previousWorkPhone = null;
      this.Experiences = null;
      this.wantedJob = null;
      this.EndDateOfTheCurrentCommitment= null;
      this.SecurityNumber = null;
      this.Department = null;
      this.WorkHours = null;
      this.Salary = 0;
      this.KindWork = null;
      this.DateOfApplication = DateTime.Now;
      this.WorkStartDate = null;
      this.Applicationstatus ="";
      this.EditLastDate = DateTime.Now;
      this.CreatedByUserID =0;
      this.Transportation = "";
      this.ReasonAppStatus = "";

            _Mode = EnMode.addnew;

    }
        
               
        private bool _AddNewApplication()
        {

            this.ID = Applications._AddNewApplication(this.FirstName, this.FatherName, this.FamilyName, this.MotherName, this.IsRegisterUN, this.BloodType, this.IsFoundSponsor, this.RegionInIdentity,
 this.RegisterNumber, this.Nationality, this.BirthPlace, this.DateOfBirth, this.AcademyLevel, this.Languages, this.ArmyServices, this.IsFoundDrivingLicense,
 this.ExpirationDateDrivingLicense, this.MaritalStatus, this.WorksWife, this.NumChildren, this.IsGuaranteeForWife, this.Certificates, this.IsOutCompany, this.RegionOfResidence, this.StreetResidence,
 this.NextTo, this.Building, this.Floor, this.PersonalPhone, this.PersonalImage, this.NumRomResidence, this.RegionInSyria, this.StreetInSyria, this.NextToInSyria,
 this.BuildingInSyria, this.FloorInSyria, this.PhoneInSyria, this.previousWork, this.PreviousSalary, this.ReasonforLeavingWork,this.previousWorkPhone, this.Experiences, this.wantedJob,
 this.EndDateOfTheCurrentCommitment, this.SecurityNumber, this.Department, this.WorkHours, this.Salary, this.KindWork, this.DateOfApplication, this.WorkStartDate,
 this.Applicationstatus, this.EditLastDate,this.CreatedByUserID,this.Transportation,this.ReasonAppStatus);

            return (this.ID != -1);

        }

        //GetInfoAppByFullName
        public static ClsApplication _GetInfoAppByFullName(string fullname)
        {

            int APPID= -1;
            string FirstName = null;
            string FatherName = null;
            string FamilyName = null;
            string MotherName = null;
            bool? IsRegisterUN = null;
            string BloodType = null;
            bool? IsFoundSponsor = null;
            string RegionInIdentity = null;
            string RegisterNumber = null;
            string Nationality = null;
            string BirthPlace = null;
            DateTime DateOfBirth = DateTime.Now.AddYears(-17);
            string AcademyLevel = null;
            string Languages = null;
            bool? ArmyServices = null;
            string IsFoundDrivingLicense = "";
            DateTime? ExpirationDateDrivingLicense = null;
            string MaritalStatus = null;
            bool? WorksWife = null;
            byte? NumChildren = null;
            bool? IsGuaranteeForWife = false;
            string Certificates = null;
            bool IsOutCompany = true;
            string RegionOfResidence = null;
            string StreetResidence = null;
            string NextTo = null;
            string Building = null;
            string Floor = null;
            string PersonalPhone = null;
            byte[] PersonalImage = null;
            string NumRomResidence = null;
            string RegionInSyria = null;
            string StreetInSyria = null;
            string NextToInSyria = null;
            string BuildingInSyria = null;
            string FloorInSyria = null;
            string PhoneInSyria = null;
            string previousWork = null;
            string PreviousSalary = null;
            string ReasonforLeavingWork = null;
            string previousWorkPhone = null;
            string Experiences = null;
            string wantedJob = null;
            DateTime? EndDateOfTheCurrentCommitment = null;
            string SecurityNumber = null;
            string Department = null;
            string WorkHours = null;
            decimal Salary = 0;
            string KindWork = null;
            DateTime DateOfApplication = DateTime.Now;
            DateTime? WorkStartDate = null;
            string Applicationstatus = null;
            DateTime EditLastDate = DateTime.Now;
            byte CreatedByUserID = 0;
            string ReasonAppStatus = "";
            string Transportation = "";

            bool IsFound = Applications.GetInfoAppByFullName(fullname,ref APPID, ref FirstName, ref FatherName, ref FamilyName, ref MotherName, ref IsRegisterUN, ref BloodType, ref IsFoundSponsor, ref RegionInIdentity,
ref RegisterNumber, ref Nationality, ref BirthPlace, ref DateOfBirth, ref AcademyLevel, ref Languages, ref ArmyServices, ref IsFoundDrivingLicense,
ref ExpirationDateDrivingLicense, ref MaritalStatus, ref WorksWife, ref NumChildren, ref IsGuaranteeForWife, ref Certificates, ref IsOutCompany, ref RegionOfResidence, ref StreetResidence,
ref NextTo, ref Building, ref Floor, ref PersonalPhone, ref PersonalImage, ref NumRomResidence, ref RegionInSyria, ref StreetInSyria, ref NextToInSyria,
ref BuildingInSyria, ref FloorInSyria, ref PhoneInSyria, ref previousWork, ref PreviousSalary, ref ReasonforLeavingWork, ref previousWorkPhone, ref Experiences, ref wantedJob,
ref EndDateOfTheCurrentCommitment, ref SecurityNumber, ref Department, ref WorkHours, ref Salary, ref KindWork, ref DateOfApplication, ref WorkStartDate,
ref Applicationstatus, ref EditLastDate, ref CreatedByUserID, ref Transportation, ref ReasonAppStatus);


            if (IsFound)
            {
                ClsHealthForm healthForm = ClsHealthForm.GetInfoHealthyFormByID(APPID);
                return new ClsApplication(APPID, FirstName, FatherName, FamilyName, MotherName, IsRegisterUN, BloodType, IsFoundSponsor, RegionInIdentity,
 RegisterNumber, Nationality, BirthPlace, DateOfBirth, AcademyLevel, Languages, ArmyServices, IsFoundDrivingLicense,
 ExpirationDateDrivingLicense, MaritalStatus, WorksWife, NumChildren, IsGuaranteeForWife, Certificates, IsOutCompany, RegionOfResidence, StreetResidence,
 NextTo, Building, Floor, PersonalPhone, PersonalImage, NumRomResidence, RegionInSyria, StreetInSyria, NextToInSyria,
 BuildingInSyria, FloorInSyria, PhoneInSyria, previousWork, PreviousSalary, ReasonforLeavingWork, previousWorkPhone, Experiences, wantedJob,
 EndDateOfTheCurrentCommitment, SecurityNumber, Department, WorkHours, Salary, KindWork, DateOfApplication, WorkStartDate,
 Applicationstatus, EditLastDate, CreatedByUserID, Transportation, ReasonAppStatus, healthForm.HealthFormID, healthForm.Physical_psychological_neurologicalDiseases, healthForm.DetailsOne, healthForm.SpineOrSkeleton, healthForm.Details2, healthForm.diabetes_pressure_rheumatism, healthForm.Details3, healthForm.RespiratorySystem, healthForm.Details4, healthForm.HeartAndArteries, healthForm.Details5, healthForm.BloodDiseases, healthForm.Details6, healthForm.AnyotherDisease, healthForm.detail7,
 healthForm.Surgeries, healthForm.Details8, healthForm.DoYouUseMedications, healthForm.Details9, healthForm.AreYouASmoker, healthForm.Details10);


            }
            else
            {
                return null;

            }





        }

        public static ClsApplication _GetInfoAppByID(int appID)
        {

          
            string FirstName = null;
            string FatherName = null;
            string FamilyName = null;
             string MotherName = null;
            bool? IsRegisterUN = null ;
            string BloodType = null;
            bool? IsFoundSponsor = null;
            string RegionInIdentity = null;
            string RegisterNumber = null;
            string Nationality = null;
            string BirthPlace = null;
            DateTime DateOfBirth = DateTime.Now.AddYears(-17);
            string AcademyLevel = null;
            string Languages = null;
            bool? ArmyServices = null;
            string IsFoundDrivingLicense = "";
            DateTime? ExpirationDateDrivingLicense = null;
            string MaritalStatus = null;
            bool? WorksWife = null;
            byte? NumChildren = null;
            bool? IsGuaranteeForWife = false;
            string Certificates = null;
            bool IsOutCompany = true ;
            string RegionOfResidence = null;
            string StreetResidence = null;
            string NextTo = null;
            string Building = null;
            string Floor = null;
            string PersonalPhone = null;
            byte[] PersonalImage = null;
            string NumRomResidence = null;
            string RegionInSyria = null;
            string StreetInSyria = null;
            string NextToInSyria = null;
            string BuildingInSyria = null;
            string FloorInSyria = null;
            string PhoneInSyria = null;
            string previousWork = null;
            string PreviousSalary = null;
            string ReasonforLeavingWork = null;
            string previousWorkPhone = null;
            string Experiences = null;
            string wantedJob = null;
            DateTime? EndDateOfTheCurrentCommitment = null;
            string SecurityNumber = null;
             string Department = null;
            string WorkHours = null;
            decimal Salary = 0;
            string KindWork = null;
            DateTime DateOfApplication = DateTime.Now;
            DateTime? WorkStartDate = null;
            string Applicationstatus = null;
            DateTime EditLastDate = DateTime.Now;
            byte CreatedByUserID = 0;
           string ReasonAppStatus ="";
           string Transportation = "";

            bool IsFound = Applications.GetInfoAppByID( ref appID, ref FirstName, ref FatherName, ref FamilyName, ref MotherName, ref IsRegisterUN, ref BloodType, ref IsFoundSponsor, ref RegionInIdentity,
ref RegisterNumber, ref Nationality, ref BirthPlace, ref DateOfBirth, ref AcademyLevel, ref Languages, ref ArmyServices, ref IsFoundDrivingLicense,
ref ExpirationDateDrivingLicense, ref MaritalStatus, ref WorksWife, ref NumChildren, ref IsGuaranteeForWife, ref Certificates, ref IsOutCompany, ref RegionOfResidence, ref StreetResidence,
ref NextTo, ref Building, ref Floor, ref PersonalPhone, ref PersonalImage, ref NumRomResidence, ref RegionInSyria, ref StreetInSyria, ref NextToInSyria,
ref BuildingInSyria, ref FloorInSyria, ref PhoneInSyria, ref previousWork, ref PreviousSalary, ref ReasonforLeavingWork, ref previousWorkPhone, ref Experiences, ref wantedJob,
ref EndDateOfTheCurrentCommitment, ref SecurityNumber, ref Department, ref WorkHours, ref Salary, ref KindWork, ref DateOfApplication, ref WorkStartDate,
ref Applicationstatus, ref EditLastDate,ref CreatedByUserID,ref Transportation,ref ReasonAppStatus);


            if(IsFound)
            {
                ClsHealthForm healthForm = ClsHealthForm.GetInfoHealthyFormByID(appID);
                return new ClsApplication(appID, FirstName, FatherName, FamilyName, MotherName,IsRegisterUN, BloodType, IsFoundSponsor, RegionInIdentity,
 RegisterNumber, Nationality, BirthPlace, DateOfBirth, AcademyLevel, Languages, ArmyServices, IsFoundDrivingLicense,
 ExpirationDateDrivingLicense, MaritalStatus, WorksWife, NumChildren, IsGuaranteeForWife, Certificates, IsOutCompany, RegionOfResidence, StreetResidence,
 NextTo, Building, Floor, PersonalPhone, PersonalImage, NumRomResidence, RegionInSyria, StreetInSyria, NextToInSyria,
 BuildingInSyria, FloorInSyria, PhoneInSyria, previousWork, PreviousSalary, ReasonforLeavingWork, previousWorkPhone, Experiences, wantedJob,
 EndDateOfTheCurrentCommitment, SecurityNumber, Department, WorkHours, Salary, KindWork, DateOfApplication, WorkStartDate,
 Applicationstatus,  EditLastDate,  CreatedByUserID,Transportation ,ReasonAppStatus,healthForm.HealthFormID, healthForm.Physical_psychological_neurologicalDiseases, healthForm.DetailsOne, healthForm.SpineOrSkeleton, healthForm.Details2, healthForm.diabetes_pressure_rheumatism, healthForm.Details3, healthForm.RespiratorySystem, healthForm.Details4, healthForm.HeartAndArteries, healthForm.Details5, healthForm.BloodDiseases, healthForm.Details6, healthForm.AnyotherDisease, healthForm.detail7,
 healthForm.Surgeries, healthForm.Details8, healthForm.DoYouUseMedications, healthForm.Details9, healthForm.AreYouASmoker, healthForm.Details10);

              
            }
            else
            {
                return null;

            }





        }



        private bool _UpdateApplication()
        {
            return Applications.UpdateApplication(this.ID,this.FirstName, this.FatherName, this.FamilyName, this.MotherName, this.IsRegisterUN, this.BloodType, this.IsFoundSponsor, this.RegionInIdentity,
 this.RegisterNumber, this.Nationality, this.BirthPlace, this.DateOfBirth, this.AcademyLevel, this.Languages, this.ArmyServices, this.IsFoundDrivingLicense,
 this.ExpirationDateDrivingLicense, this.MaritalStatus, this.WorksWife, this.NumChildren, this.IsGuaranteeForWife, this.Certificates, this.IsOutCompany, this.RegionOfResidence, this.StreetResidence,
 this.NextTo, this.Building, this.Floor, this.PersonalPhone, this.PersonalImage, this.NumRomResidence, this.RegionInSyria, this.StreetInSyria, this.NextToInSyria,
 this.BuildingInSyria, this.FloorInSyria, this.PhoneInSyria, this.previousWork, this.PreviousSalary, this.ReasonforLeavingWork, this.previousWorkPhone, this.Experiences, this.wantedJob,
 this.EndDateOfTheCurrentCommitment, this.SecurityNumber, this.Department, this.WorkHours, this.Salary, this.KindWork, this.DateOfApplication, this.WorkStartDate,
 this.Applicationstatus, this.EditLastDate, this.CreatedByUserID,this.Transportation,this.ReasonAppStatus);
           



        }

        static public int GetNumberOfRecordsApp()
        {
            return Applications._GetNumberOfecords();
        }


        public bool _UpdateApplicationStatus()
        {
           return  Applications.UpdateStatus(this.ID, this.Applicationstatus);


        }


        static public DataTable _GetAllApplications(short pagenumber)
        {
            return Applications.GetAllApplications(pagenumber);


        }

        static public DataTable _GetAllApplications()
        {
            return Applications.GetAllApplications();


        }


        static public DataTable GetAppBySelectStatus(string status,short pagenumber)
        {

            return Applications._GetAllAppByFilterStatus(status,pagenumber);

        }

        static public DataTable GetAppBySelectStatus(string status)
        {

            return Applications._GetAllAppByFilterStatus(status);

        }

        static public int GetNumberOfRecordsAppByStatus(string status)
        {
            return Applications._GetNumberOfecordsByStatus(status);
        }


        public bool SaveApplication()
        {

            base._mode = (ClsHealthForm.enmode)_Mode;
           
           
           

            switch (_Mode)
            {  

                case EnMode.addnew:
                    if(_AddNewApplication())
                    {
                        this.HealthFormID = this.ID;
                        if (base.save())
                        {
                            _Mode = EnMode.update;
                            return true;

                        }
                        else
                        {
                            return false;
                        }
                          
                        

                    }
                    else
                    {
                        return false;
                    }

                case EnMode.update:
                   if(_UpdateApplication())
                    {
                        this.HealthFormID = this.ID;
                        if (base.save())
                        {
                            _Mode = EnMode.update;
                            return true;

                        }
                        else
                        {
                            return false;
                        }
                    }
                    return false;
                    




            }
            return false;








        }

        //هذه الفانكشن بمثابة بحث عن الطلبات وفق تاريخين وحالة طلب معينة
        static public DataTable _SearchByDateOfApp(string startDate,string EndDate,string status)
        {
            return Applications._SearchByDateApp(startDate, EndDate, status);


        }

        static public DataTable _SearchByDateOfBirth(string startDate, string EndDate,string status)
        {
            return Applications._SearchByDateOfBirth(startDate, EndDate, status);


        }

        static public DataTable SearchByDateLastDateEdit(string startDate, string EndDate,string status)
        {
            return Applications._SearchByLastDateEdit(startDate, EndDate, status);


        }

        static public DataTable SearchByStartWorkDate(string startDate, string EndDate,string status)
        {
            return Applications._SearchByWorkStartDate(startDate, EndDate, status);


        }
        //هذه الفانكشن بمثابة بحث عن الطلبات وفق تاريخين فقط وتشمل جميع الحالات

        static public DataTable _SearchByDateOfApp(string startDate, string EndDate)
        {
            return Applications._SearchByDateApp(startDate, EndDate);


        }

        static public DataTable _SearchByDateOfBirth(string startDate, string EndDate )
        {
            return Applications._SearchByDateOfBirth(startDate, EndDate);


        }

        static public DataTable SearchByDateLastDateEdit(string startDate, string EndDate)
        {
            return Applications._SearchByLastDateEdit(startDate, EndDate);


        }

        static public DataTable SearchByStartWorkDate(string startDate, string EndDate)
        {
            return Applications._SearchByWorkStartDate(startDate, EndDate);


        }


    }
}
        
       
        
        

    

       


    


        


            

