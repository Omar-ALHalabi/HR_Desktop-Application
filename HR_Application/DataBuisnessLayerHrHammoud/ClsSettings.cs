using DataAccessLayer_HrHammoud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBuisnessLayerHrHammoud
{
    public class ClsSettings
    {
        public int Nationalityid { get; set; }
        public string Nationality { get; set; }

        public int Departmentid { get; set; }
        public string Department { get; set; }
        public int DrivingLicensesid { get; set; }
        public string DrivingLicensName { get; set; }

        public ClsSettings()
        {
            Nationalityid = -1;
            Nationality = "";
            Departmentid = -1;
            Department = "";
            DrivingLicensesid = -1;
            DrivingLicensName = "";
        }

        //nationality
        public static DataTable getAllNationalities()
        {
            return Settings._GetAllNationalities();

        }

        static public bool AddNationality(string nationality)
        {
         return   Settings._AddNationality(nationality);
        }

        //driving licenses
        public static DataTable getAllDrivingLicenses()
        {
            return Settings._GetAllDrivingLicenses();

        }

        static public bool AddDrivingLicenses(string DrivingLicenses)
        {
            return Settings._AddDrivingLicenses(DrivingLicenses);
        }
        //departments
        public static DataTable getAllDepartments()
        {
            return Settings._GetAllDepartments();

        }

        static public bool AddDepartment(string Departments)
        {
            return Settings._AddDepartment(Departments);
        }

    }
}
