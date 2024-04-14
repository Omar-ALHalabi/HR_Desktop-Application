using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataAccessLayer_HrHammoud;

namespace DataBuisnessLayerHrHammoud
{
    public class ClsHealthForm
    {
        public enum enmode { addnew=0,update=1}
      public   enmode _mode=enmode.addnew;

       public int HealthFormID {get;set;}
        public bool Physical_psychological_neurologicalDiseases { get; set; }
        public string DetailsOne { get; set; }

        public bool SpineOrSkeleton { get; set; }
        public string Details2 { get; set; }

        public bool diabetes_pressure_rheumatism { get; set; }
        public string Details3 { get; set; }

        public bool RespiratorySystem { get; set; }
        public string Details4 { get; set; }

        public bool HeartAndArteries { get; set; }
        public string Details5 { get; set; }

        public bool BloodDiseases { get; set; }
        public string Details6 { get; set; }

        public bool AnyotherDisease { get; set; }
        public string detail7 { get; set; }
    

        public bool Surgeries { get; set; }
        public string Details8 { get; set; }

        public bool DoYouUseMedications { get; set; }
        public string Details9 { get; set; }

        public bool AreYouASmoker { get; set; }
        public string Details10 { get; set; }



        public ClsHealthForm()
        {
            HealthFormID = -1;

            Physical_psychological_neurologicalDiseases = false;
            DetailsOne = null;
            SpineOrSkeleton = false ;
            Details2 = null;
            diabetes_pressure_rheumatism = false;
            Details3 = null;
            RespiratorySystem = false;
            Details4 = null;
            HeartAndArteries = false;
           Details5=null;
            BloodDiseases=false;
           Details6=null;
           AnyotherDisease=false;
           detail7=null;
           Surgeries=false;
           Details8=null;
           DoYouUseMedications=false;
           Details9=null;
           AreYouASmoker=false;
           Details10=null;

            _mode = enmode.addnew;

        }


        public ClsHealthForm(int ID, bool Ans1, string detail1, bool Ans2, string detail2, bool Ans3, string detail3, bool Ans4, string detail4, bool Ans5, string detail5, bool Ans6, string detail6, bool Ans7, string detail7, bool Ans8, string detail8, bool Ans9, string detail9, bool ans10, string detail10)
        {

          this.HealthFormID = ID;

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

            _mode = enmode.update;



        }




        private bool AddHealthyForm()
        {

            return  HealthForm._AddHealthForm(this.HealthFormID, this.Physical_psychological_neurologicalDiseases, this.DetailsOne, this. SpineOrSkeleton, this.Details2, this.diabetes_pressure_rheumatism, this.Details3, this.RespiratorySystem, this.Details4, this.HeartAndArteries, this.Details5, this.BloodDiseases, this.Details6, this.AnyotherDisease, this.detail7,this.Surgeries, this.Details8,this.DoYouUseMedications, this.Details9, this.AreYouASmoker, this.Details10);




        }

        private bool UpdateHealthyForm()
        {

            return HealthForm._updateHealthForm(this.HealthFormID, this.Physical_psychological_neurologicalDiseases, this.DetailsOne, this.SpineOrSkeleton, this.Details2, this.diabetes_pressure_rheumatism, this.Details3, this.RespiratorySystem, this.Details4, this.HeartAndArteries, this.Details5, this.BloodDiseases, this.Details6, this.AnyotherDisease, this.detail7, this.Surgeries, this.Details8, this.DoYouUseMedications, this.Details9, this.AreYouASmoker, this.Details10);


        }

        public bool save()
        {

            switch (_mode)
            {
                case enmode.addnew:
                    {
                        if (AddHealthyForm())
                        {
                            _mode = enmode.update;
                            return true;
                        }
                        else
                        {
                            
                            return false;
                        }

                      
                    }

                case enmode.update:
                    {
                        return UpdateHealthyForm();
                        
                    }



            }


            return false;


        }

        static public ClsHealthForm GetInfoHealthyFormByID(int HealthFormID)
        {
       

            bool Physical_psychological_neurologicalDiseases = false;
          string  DetailsOne = null;
            bool SpineOrSkeleton = false;
          string  Details2 = null;
            bool diabetes_pressure_rheumatism = false;
          string  Details3 = null;
            bool RespiratorySystem = false;
           string Details4 = null;
            bool HeartAndArteries = false;
           string Details5 = null;
            bool BloodDiseases = false;
           string Details6 = null;
            bool AnyotherDiseases = false;
           string Deatils7 = null;
            bool Surgeries = false;
           string Details8 = null;
            bool DoYouUseMedications = false;
           string Details9 = null;
            bool AreYouASmoker = false;
           string Details10 = null;

            if (HealthForm._GetInfoHealthFormByID(ref HealthFormID, ref Physical_psychological_neurologicalDiseases, ref DetailsOne, ref SpineOrSkeleton, ref Details2, ref diabetes_pressure_rheumatism, ref Details3, ref RespiratorySystem, ref Details4, ref HeartAndArteries,
                ref Details5, ref BloodDiseases, ref Details6, ref AnyotherDiseases, ref Deatils7, ref Surgeries, ref Details8, ref DoYouUseMedications, ref Details9, ref AreYouASmoker, ref Details10))
            {
                return new ClsHealthForm(HealthFormID, Physical_psychological_neurologicalDiseases, DetailsOne, SpineOrSkeleton, Details2, diabetes_pressure_rheumatism, Details3, RespiratorySystem,  Details4, HeartAndArteries,
                 Details5, BloodDiseases, Details6, AnyotherDiseases, Deatils7, Surgeries, Details8, DoYouUseMedications, Details9, AreYouASmoker, Details10);
            } else
            {
                return null;
            }


        }


    }
}
