using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DataBuisnessLayerHrHammoud;
using HrHammoudCompany.Applications;
using HrHammoudCompany.Applications.PrintReports;
using HrHammoudCompany.BlackList;
using HrHammoudCompany.ManageOfficialDocuments;
using HrHammoudCompany.Reference_Address;
using HrHammoudCompany.Statements;
using HrHammoudCompany.Warnings;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.ReportingServices.Interfaces;
using System.Configuration;

namespace HrHammoudCompany
{
    public partial class Add_EdiitApplication : Form
    {
        ClsApplication _application;
      
        enum enmode { AddNew = 0, Update = 1 };
        enmode _mode;
        private int _AppID;
        public Add_EdiitApplication()
        {
            InitializeComponent();
            _mode = enmode.AddNew;

        }
        public Add_EdiitApplication(int AppID)
        {
            InitializeComponent();

            _mode = enmode.Update;
            _AppID = AppID;

        }

        public Add_EdiitApplication(int AppID,bool isreadonly)
        {
            InitializeComponent();

            _mode = enmode.Update;
            _AppID = AppID;
         
            BtSave.Enabled = false;
          

        }


        private void _ResetDefualtValues()
        {
            if (_mode == enmode.AddNew)
            {
                _application = new ClsApplication();
                cbAppStatus.SelectedIndex = 0;
                this.Text = "إضافة طلب";
                DateBirth.MaxDate = DateTime.Now.AddYears(-17);
                DateBirth.Value = DateBirth.MaxDate;
                DateBirth.MinDate = DateTime.Now.AddYears(-100);
                DateOfApplicatiom.Value =DateTime.Now;
                EditLastDate.Value = DateTime.Now;
                DateStartWork.Visible = false;


                LinkLabelReferencesAddress.Enabled = false;
               
              
            }
            else
            {
                this.Text ="تعديل الطلب";
                DateStartWork.Visible = true;


                LinkLabelReferencesAddress.Enabled = true;
                EditLastDate.Value = DateTime.Now;
            }




        }

        private void _AddNewApp()
        {
            _application = new ClsApplication();
           
                _application.ID = -1;
           
            _application.FirstName = tbFirstName.Text.Trim();
            _application.FatherName = tbFathertName.Text.Trim();
            _application.FamilyName = tbFamilyName.Text.Trim();
            _application.MotherName = MotherName.Text.Trim();
            _application.RegionInIdentity = cityInIdentificationDocument.Text;
            _application.RegisterNumber = tbRegisterNumber.Text;
            _application.BloodType = cbBloodType.Text;
            _application.Nationality = CbNationality.Text;
            _application.BirthPlace = tbBirthPlace.Text.Trim();
            _application.DateOfBirth = DateBirth.Value;
            _application.AcademyLevel = cbAcademyLevel.Text;
           _application.Languages = tbLanguages.Text;
            
      


            if (cbArmyServices.SelectedIndex == -1)
            {
                _application.ArmyServices =null;
            }
            else
            {
                _application.ArmyServices = Convert.ToBoolean(cbArmyServices.SelectedIndex);
            }
            
            _application.IsFoundDrivingLicense = cbDriverLicese.Text;
            _application.ExpirationDateDrivingLicense = dateExpirationDriverLicense.Value;
            _application.MaritalStatus = cbMaritalStatus.Text;
            if(_application.Applicationstatus== "طلب مقبول")
            {
                _application.WorkStartDate = DateTime.Now;
            }
            else
            {
                _application.WorkStartDate = null;
            }

            if (cbWifeWork.SelectedIndex == -1)
            {
                _application.WorksWife = null;
            }
            else
            {
                _application.WorksWife = Convert.ToBoolean(cbWifeWork.SelectedIndex);
            }

            if (IsFoundInsuranceForWife.SelectedIndex == -1)
            {
                _application.IsGuaranteeForWife = null;
            }
            else
            {
                _application.IsGuaranteeForWife = Convert.ToBoolean(IsFoundInsuranceForWife.SelectedIndex);
            }

            if (string.IsNullOrEmpty(tbNumberOfChildren.Text))
            {
                _application.NumChildren = null;
            }
            else
            {
                _application.NumChildren = Convert.ToByte(tbNumberOfChildren.Text);
            }


            if (string.IsNullOrEmpty(tbCertificates.Text))
            {
                _application.Certificates = null;
            }
            else
            {
                _application.Certificates = tbCertificates.Text;
            }

           
                if (cbregisterUN.SelectedIndex!=-1)
                {
                    _application.IsRegisterUN = Convert.ToBoolean(cbregisterUN.SelectedIndex);
                    
                }
                else
                {
                    _application.IsRegisterUN = null;
                }

                if (tbSponsor.SelectedIndex != -1)
                {
                    _application.IsFoundSponsor = Convert.ToBoolean(tbSponsor.SelectedIndex);

                }
                else
                {
                    _application.IsFoundSponsor = null;
                }

            

            _application.PersonalPhone = tbPersonalNumber.Text;


            //cuurent Residense
            if (rdoutcompany.Checked)
            {
                    _application.IsOutCompany = true;
                    _application.RegionOfResidence = tbCurrentCity.Text;
                    _application.StreetResidence = tbStreet.Text;
                     _application.NextTo = tbNextTo.Text;
                    _application.Building = TbBuilding.Text;
                    _application.Floor = tbFloor.Text;
                  

            } else
            {
                _application.IsOutCompany = false ;
                _application.NumRomResidence = tbNumberOfRoom.Text;
            }


            //residense in syria
            if(CbNationality.Text=="سوري"|| CbNationality.Text=="فلسطيني سوري")
            {
                    _application.RegionInSyria = tbRegionInSyria.Text;
                    _application.StreetInSyria = tbstreetInSyria.Text;
                    _application.NextToInSyria = tbNextToInSyria.Text;
                    _application.BuildingInSyria = TbBuildingInSyria.Text;
                    _application.FloorInSyria = TbFloorInSyria.Text;
                    _application.PhoneInSyria = tBPhoneInSyria.Text;
            }


            //PREVIOUS WORK
           
                _application.previousWork = tbPreviousWork.Text;
                _application.PreviousSalary = PreviousSalary.Text;
                _application.ReasonforLeavingWork = tbReasonLeavingPreviousWork.Text;
                _application.previousWorkPhone = tbPreviousWorkPhone.Text;
                _application.Experiences = tbExperiences.Text;
                _application.wantedJob = WantedJob.Text;
                _application.EndDateOfTheCurrentCommitment = DtExpirationDateCurrentcommitent.Value;
                _application.SecurityNumber = tbsecurityNumber.Text;
          

            //details The job after agree
           
                _application.Department = CbDepartment.Text;
                _application.WorkHours = cbWorkHours.Text;
            if(tbsalary.Text=="")
            {
                _application.Salary = 0;
            }
            else
            {
                _application.Salary = Convert.ToDecimal(tbsalary.Text);
            }

                _application.KindWork = KindWork.Text;
          
            //  DateTime dt = DateTime.Now.ToString("dd/mm/yyyy");
            _application.DateOfApplication = DateTime.Now;
           _application.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _application.EditLastDate = DateTime.Now;
           
            Byte[] ByteImage = null;
            if (ofd.FileName!="")
            {
                ByteImage = File.ReadAllBytes(ofd.FileName);
                _application.PersonalImage = ByteImage;

            }
            else
            {
                _application.PersonalImage = ByteImage;
            }

            _application.ReasonAppStatus = ReasonAppStatus.Text;
            _application.Transportation = tbTransportation.Text;
            _application.Applicationstatus = cbAppStatus.Text;

            _AddHealthyForm();


            
           

        }

        private void _LoadData()
        {
            _application = ClsApplication._GetInfoAppByID(_AppID);

            if (_application == null)
            {

                MessageBox.Show(" :لا يوجد طلب توظيف بهذا الرقم  " + _AppID.ToString(), " غير موجود ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            LoadHealthyForm();

            ReasonAppStatus.Text = _application.ReasonAppStatus;
            cbAppStatus.Text = _application.Applicationstatus;
            CbDepartment.Text = _application.Department;
            tbTransportation.SelectedIndex= tbTransportation.FindString(_application.Transportation);
                tbID.Text = _application.ID.ToString();
                tbFirstName.Text= _application.FirstName  ;
                tbFathertName.Text=_application.FatherName ;
                tbFamilyName.Text=_application.FamilyName ;
                MotherName.Text=_application.MotherName  ;
                cityInIdentificationDocument.Text=_application.RegionInIdentity ;
                tbRegisterNumber.Text= _application.RegisterNumber;
                cbBloodType.Text= _application.BloodType  ;
                cbregisterUN.SelectedIndex = Convert.ToByte(_application.IsRegisterUN);
                CbNationality.Text=_application.Nationality ;
                tbBirthPlace.Text=_application.BirthPlace ;
                DateBirth.Value=_application.DateOfBirth ;
                cbAcademyLevel.Text= _application.AcademyLevel ;
                tbLanguages.Text = _application.Languages;
                cbArmyServices.SelectedIndex = Convert.ToByte(_application.ArmyServices);
                cbDriverLicese.Text= _application.IsFoundDrivingLicense ;
                dateExpirationDriverLicense.Value= (DateTime)_application.ExpirationDateDrivingLicense ;
                cbMaritalStatus.Text= _application.MaritalStatus;
                tbNumberOfChildren.Text=_application.NumChildren.ToString();
                cbWifeWork.SelectedIndex= Convert.ToByte(_application.WorksWife) ;
                tbNumberOfChildren.Text=_application.NumChildren.ToString() ;
                IsFoundInsuranceForWife.SelectedIndex = Convert.ToByte(_application.IsGuaranteeForWife) ;
                tbCertificates.Text= _application.Certificates;
                 cbregisterUN.SelectedIndex= Convert.ToByte(_application.IsRegisterUN) ;
                 tbSponsor.SelectedIndex = Convert.ToByte(_application.IsFoundSponsor);


            tbPersonalNumber.Text = _application.PersonalPhone;
            //cuurent Residense
            if (_application.IsOutCompany==true)
                {
                    rdoutcompany.Checked = true;
                    tbCurrentCity.Text= _application.RegionOfResidence ;
                    tbStreet.Text= _application.StreetResidence ;
                    tbNextTo.Text= _application.NextTo ;
                    TbBuilding.Text=_application.Building ;
                    tbFloor.Text= _application.Floor ;
                   


                }
                else
                {
                    rdincompany.Checked=true ;
                    tbNumberOfRoom.Text= _application.NumRomResidence;

                }


                //residense in syria

                tbRegionInSyria.Text = _application.RegionInSyria;
              tbstreetInSyria.Text= _application.StreetInSyria;
              tbNextToInSyria.Text= _application.NextToInSyria;
              TbBuildingInSyria.Text=_application.BuildingInSyria;
              TbFloorInSyria.Text=_application.FloorInSyria ;
              tBPhoneInSyria.Text=_application.PhoneInSyria;

                //PREVIOUS WORK 
                tbPreviousWork.Text= _application.previousWork;
                PreviousSalary.Text =_application.PreviousSalary ;
                tbReasonLeavingPreviousWork.Text=_application.ReasonforLeavingWork;
                tbPreviousWorkPhone.Text= _application.previousWorkPhone ;
                tbExperiences.Text= _application.Experiences;
                WantedJob.Text= _application.wantedJob ;
                DtExpirationDateCurrentcommitent.Value =(DateTime)_application.EndDateOfTheCurrentCommitment;
                tbsecurityNumber.Text= _application.SecurityNumber;

                //details The job after agree
                CbDepartment.Text= _application.Department ;
                cbWorkHours.Text = _application.WorkHours;
                tbsalary.Text = _application.Salary.ToString();
               
                KindWork.Text = _application.KindWork;
                DateOfApplicatiom.Value= _application.DateOfApplication ;

               lbCreatedByUser.Text = ClsUsers.GetUserNameByUserID(_application.CreatedByUserID);
               EditLastDate.Value= _application.EditLastDate ;
             
            if (_application.WorkStartDate<DateTime.Now.AddYears(100))
            {
                DateStartWork.Visible = false;
            }
            else
            {
                DateStartWork.Visible = true;
            }


            if (!_application.PersonalImage.SequenceEqual(new byte[0]))
 
                {
                    byte[] ImageByte = _application.PersonalImage;
                    MemoryStream stream = new MemoryStream(ImageByte);
                    PersonalImage.Image =System.Drawing.Image.FromStream(stream);

                }
              
        }

        private bool _CheckAddHealthyForm()
        {
            if(RdAns1Yes.Checked==true && detail1.Text.Trim()=="")
            {
                MessageBox.Show("يرجى ذكر التفاصيل عندما تكون الإجابة نعم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (RdAns2Yes.Checked == true && detail2.Text.Trim() == "")
            {
                MessageBox.Show("يرجى ذكر التفاصيل عندما تكون الإجابة نعم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (RdAns3Yes.Checked == true && detail3.Text.Trim() == "")
            {
                MessageBox.Show("يرجى ذكر التفاصيل عندما تكون الإجابة نعم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (RdAns4Yes.Checked == true && detail4.Text.Trim() == "")
            {
                MessageBox.Show("يرجى ذكر التفاصيل عندما تكون الإجابة نعم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (RdAns5Yes.Checked == true && detail5.Text.Trim() == "")
            {
                MessageBox.Show("يرجى ذكر التفاصيل عندما تكون الإجابة نعم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (RdAns6Yes.Checked == true && detail6.Text.Trim() == "")
            {
                MessageBox.Show("يرجى ذكر التفاصيل عندما تكون الإجابة نعم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (RdAns7Yes.Checked == true && detail7.Text.Trim() == "")
            {
                MessageBox.Show("يرجى ذكر التفاصيل عندما تكون الإجابة نعم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (RdAns8Yes.Checked == true && detail8.Text.Trim() == "")
            {
                MessageBox.Show("يرجى ذكر التفاصيل عندما تكون الإجابة نعم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (RdAns9Yes.Checked == true && detail9.Text.Trim() == "")
            {
                MessageBox.Show("يرجى ذكر التفاصيل عندما تكون الإجابة نعم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 return false;
            }
            if (RdAns10Yes.Checked == true && detail10.Text.Trim() == "")
            {
                MessageBox.Show("يرجى ذكر التفاصيل عندما تكون الإجابة نعم ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;

        }


        private void _AddHealthyForm()
        {
            
            _application.Physical_psychological_neurologicalDiseases = RdAns1No.Checked ? false : true;
            _application.DetailsOne = detail1.Text;

            _application.SpineOrSkeleton = RdAns2No.Checked ? false : true;
            _application.Details2 = detail2.Text;

            _application.diabetes_pressure_rheumatism = RdAns3No.Checked ? false : true;
            _application.Details3 = detail3.Text;

            _application.RespiratorySystem = RdAns4No.Checked ? false : true;
            _application.Details4 = detail4.Text;

            _application.HeartAndArteries = RdAns5No.Checked ? false : true;
            _application.Details5 = detail5.Text;

            _application.BloodDiseases = RdAns6No.Checked ? false : true;
            _application.Details6 = detail6.Text;

            _application.AnyotherDisease = RdAns7No.Checked ? false : true;
            _application.detail7 = detail7.Text;

            _application.Surgeries = RdAns8No.Checked ? false : true;
            _application.Details8 = detail8.Text;

            _application.DoYouUseMedications = RdAns9No.Checked ? false : true;
            _application.Details9 = detail9.Text;

            _application.AreYouASmoker = RdAns10Yes.Checked ? true : false;
            _application.Details10 = detail10.Text;

        }

        private void LoadHealthyForm()
        {            
            //1
            if (_application.Physical_psychological_neurologicalDiseases)
            {
                RdAns1Yes.Checked = true;
            }
            else
            {
                RdAns1No.Checked = true;
            }
            detail1.Text = _application.DetailsOne;

            //2
            if (_application.SpineOrSkeleton)
            {
                RdAns2Yes.Checked = true;
            }
            else
            {
                RdAns2No.Checked = true;
            }
            detail2.Text = _application.Details2;
            //3

            if (_application.diabetes_pressure_rheumatism)
            {
                RdAns3Yes.Checked = true;
            }
            else
            {
                RdAns3No.Checked = true;
            }
            detail3.Text = _application.Details3;
            //4
         
           if(_application.RespiratorySystem)
            {

                RdAns4Yes.Checked = true;
            }
            else
            {
                RdAns4No.Checked = true;
            }
            detail4.Text = _application.Details4;

            //5

            if (_application.HeartAndArteries)
            {

                RdAns5Yes.Checked = true;
            }
            else
            {
                RdAns5No.Checked = true;
            }
            detail5.Text = _application.Details5;
            //6
            if (_application.BloodDiseases)
            {

                RdAns6Yes.Checked = true;
            }
            else
            {
                RdAns6No.Checked = true;
            }
            detail6.Text = _application.Details6;

            //7

            if (_application.AnyotherDisease)
            {

                RdAns7Yes.Checked = true;
            }
            else
            {
                RdAns7No.Checked = true;
            }
            detail7.Text = _application.detail7;

            //8
            if (_application.Surgeries)
            {

                RdAns8Yes.Checked = true;
            }
            else
            {
                RdAns8No.Checked = true;
            }
            detail8.Text = _application.Details8;

            //9

            if (_application.DoYouUseMedications)
            {

                RdAns9Yes.Checked = true;
            }
            else
            {
                RdAns9No.Checked = true;
            }
            detail9.Text = _application.Details9;

            //10

            detail10.Text = _application.Details10;
            if (_application.AreYouASmoker)
            {

                RdAns10Yes.Checked = true;
            }
            else
            {
                RdAns10No.Checked = true;
            }
         



        }

        private void UpdateData()
        {
            //_application.ID = -1;
          


            _application.FirstName = tbFirstName.Text.Trim();
            _application.FatherName = tbFathertName.Text.Trim();
            _application.FamilyName = tbFamilyName.Text.Trim();
            _application.MotherName = MotherName.Text.Trim();
            _application.RegionInIdentity = cityInIdentificationDocument.Text;
            _application.RegisterNumber = tbRegisterNumber.Text;
            _application.BloodType = cbBloodType.Text;
            _application.Nationality = CbNationality.Text;
            _application.BirthPlace = tbBirthPlace.Text.Trim();
            _application.DateOfBirth = DateBirth.Value;
            _application.AcademyLevel = cbAcademyLevel.Text;
            _application.Languages = tbLanguages.Text;




            if (cbArmyServices.SelectedIndex == -1)
            {
                _application.ArmyServices = null;
            }
            else
            {
                _application.ArmyServices = Convert.ToBoolean(cbArmyServices.SelectedIndex);
            }

            _application.IsFoundDrivingLicense = cbDriverLicese.Text;
            _application.ExpirationDateDrivingLicense = dateExpirationDriverLicense.Value;
            _application.MaritalStatus = cbMaritalStatus.Text;

            if (cbWifeWork.SelectedIndex == -1)
            {
                _application.WorksWife = null;
            }
            else
            {
                _application.WorksWife = Convert.ToBoolean(cbWifeWork.SelectedIndex);
            }

            if (IsFoundInsuranceForWife.SelectedIndex == -1)
            {
                _application.IsGuaranteeForWife = null;
            }
            else
            {
                _application.IsGuaranteeForWife = Convert.ToBoolean(IsFoundInsuranceForWife.SelectedIndex);
            }

            if (string.IsNullOrEmpty(tbNumberOfChildren.Text))
            {
                _application.NumChildren = null;
            }
            else
            {
                _application.NumChildren = Convert.ToByte(tbNumberOfChildren.Text);
            }


            if (string.IsNullOrEmpty(tbCertificates.Text))
            {
                _application.Certificates = null;
            }
            else
            {
                _application.Certificates = tbCertificates.Text;
            }


            if (cbregisterUN.SelectedIndex != -1)
            {
                _application.IsRegisterUN = Convert.ToBoolean(cbregisterUN.SelectedIndex);

            }
            else
            {
                _application.IsRegisterUN = null;
            }

            if (tbSponsor.SelectedIndex != -1)
            {
                _application.IsFoundSponsor = Convert.ToBoolean(tbSponsor.SelectedIndex);

            }
            else
            {
                _application.IsFoundSponsor = null;
            }



            _application.PersonalPhone = tbPersonalNumber.Text;


            //cuurent Residense
            if (rdoutcompany.Checked)
            {
                _application.IsOutCompany = true;
                _application.RegionOfResidence = tbCurrentCity.Text;
                _application.StreetResidence = tbStreet.Text;
                _application.NextTo = tbNextTo.Text;
                _application.Building = TbBuilding.Text;
                _application.Floor = tbFloor.Text;


            }
            else
            {
                _application.IsOutCompany = false;
                _application.NumRomResidence = tbNumberOfRoom.Text;
            }


            //residense in syria
            if (CbNationality.Text == "سوري" || CbNationality.Text == "فلسطيني سوري")
            {
                _application.RegionInSyria = tbRegionInSyria.Text;
                _application.StreetInSyria = tbstreetInSyria.Text;
                _application.NextToInSyria = tbNextToInSyria.Text;
                _application.BuildingInSyria = TbBuildingInSyria.Text;
                _application.FloorInSyria = TbFloorInSyria.Text;
                _application.PhoneInSyria = tBPhoneInSyria.Text;
            }


            //PREVIOUS WORK

            _application.previousWork = tBPhoneInSyria.Text;
            _application.PreviousSalary = PreviousSalary.Text;
            _application.ReasonforLeavingWork = tbReasonLeavingPreviousWork.Text;
            _application.previousWorkPhone = tbPreviousWorkPhone.Text;
            _application.Experiences = tbExperiences.Text;
            _application.wantedJob = WantedJob.Text;
            _application.EndDateOfTheCurrentCommitment = DtExpirationDateCurrentcommitent.Value;
            _application.SecurityNumber = tbsecurityNumber.Text;


            //details The job after agree

            _application.Department = CbDepartment.Text;
            _application.WorkHours = cbWorkHours.Text;
            if (tbsalary.Text == "")
            {
                _application.Salary = 0;
            }
            else
            {
                _application.Salary = Convert.ToDecimal(tbsalary.Text);
            }

            _application.KindWork = KindWork.Text;

           // _application.DateOfApplication = DateTime.Now;
           // _application.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _application.EditLastDate = DateTime.Now;
            ImageConverter _imageConverter = new ImageConverter();
            byte[] imageByte = (byte[])_imageConverter.ConvertTo(PersonalImage.Image, typeof(byte[]));
            _application.PersonalImage = imageByte;


            _application.ReasonAppStatus = ReasonAppStatus.Text;
            _application.Transportation = tbTransportation.Text;
            _application.Applicationstatus = cbAppStatus.Text;
            if (_application.Applicationstatus == "طلب مقبول")
            {
                _application.WorkStartDate = DateTime.Now;
            }
            else
            {
                _application.WorkStartDate = null;
            }

            _AddHealthyForm();
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, " يجب ملئ هذا الحقل");

            }
            else
            {
                errorProvider1.SetError(temp, null);
            }

        }

        private void tbFathertName_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, " يجب ملئ هذا الحقل");

            }
            else
            {
                errorProvider1.SetError(temp, null);
            }
        }

        private void FamilyName_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = ((TextBox)sender);

            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider1.SetError(temp, "يجب ملئ هذا الحقل");

            }
            else
            {
                errorProvider1.SetError(temp, null);
            }
        }

        private void MotherName_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = ((TextBox)sender);

            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider1.SetError(temp, "يجب ملئ هذا الحقل");

            }
            else
            {
                errorProvider1.SetError(temp, null);
            }
        }

        private void tbRegisterNumber_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = ((TextBox)sender);

            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider1.SetError(temp, "يجب ملئ هذا الحقل");

            }
            else
            {
                errorProvider1.SetError(temp, null);
            }
        }

        private void cbNationality_Validating(object sender, CancelEventArgs e)
        {
            ComboBox temp = ((ComboBox)sender);

            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider1.SetError(temp, "يجب ملئ هذا الحقل");

            }
            else
            {
                errorProvider1.SetError(temp, null);
            }
        }

      

        private void tbBirthPlace_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = ((TextBox)sender);

            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider1.SetError(temp, "يجب ملئ هذا الحقل");

            }
            else
            {
                errorProvider1.SetError(temp, null);
            }
        }

        private void DateBirth_Validating(object sender, CancelEventArgs e)
        {


            if (DateBirth.Value >= DateTime.Now.AddYears(-17))
            {

                e.Cancel = true;
                errorProvider1.SetError(DateBirth, DateTime.Now.AddYears(-17).ToShortDateString() + " يجب أن يكون تاريخ الميلاد أقل من  ");


            }
            else
            {
                errorProvider1.SetError(DateBirth, null);
            }
        }

        private void cbAcademyLevel_Validating(object sender, CancelEventArgs e)
        {
            ComboBox temp = ((ComboBox)sender);

            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider1.SetError(temp, "يجب ملئ هذا الحقل");

            }
            else
            {
                errorProvider1.SetError(temp, null);
            }
        }

        private void cbDriverLicese_Validating(object sender, CancelEventArgs e)
        {
            ComboBox temp = ((ComboBox)sender);

            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider1.SetError(temp, "يجب ملئ هذا الحقل");

            }
            else
            {
                errorProvider1.SetError(temp, null);
            }
        }

        private void dateExpirationDriverLicense_Validating(object sender, CancelEventArgs e)
        {
            DateTimePicker temp = ((DateTimePicker)sender);

            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider1.SetError(temp, "يجب ملئ هذا الحقل");

            }
            else
            {
                errorProvider1.SetError(temp, null);
            }
        }

        private void tbSponsor_Validating(object sender, CancelEventArgs e)
        {
            ComboBox temp = ((ComboBox)sender);
            if (CbNationality.Text != "لبناني" && CbNationality.Text != "فلسطيني لبناني")
            {
                if (string.IsNullOrEmpty(temp.Text.Trim()))
                {

                    e.Cancel = true;
                    errorProvider1.SetError(temp, "يجب ملئ هذا الحقل");

                }
                else
                {
                    errorProvider1.SetError(temp, null);
                }
            }
        }

      
     

        private void tbPersonalNumber_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, "يجب ملئ هذا الحقل");

            }
            else
            {
                errorProvider1.SetError(temp, null);
            }

        }


        private void cbBloodType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbBloodType.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider1.SetError(cbBloodType, "يجب ملئ هذا الحقل");


            }
            else
            {
                errorProvider1.SetError(cbBloodType, null);
            }

        }

        private void pictureBox1_Validating(object sender, CancelEventArgs e)
        {
            if (PersonalImage.Image == null)
            {
                e.Cancel = true;
                errorProvider1.SetError(PersonalImage, "يجب إرفاق صورة");
            }
            else
            {
                errorProvider1.SetError(PersonalImage, null);
            }
        }

      

     

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
                button2.Text = "رجوع";
                button2.Image = Resource1.next;

            }
            else
            {
                tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];

                button2.Text = "التالي";
                button2.Image = Resource1.back;

            }

         
           
        }

       

     

        private void cbNationality_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        

       
        private void linkLabelRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            PersonalImage.Image = null;
            linkLabelRemoveImage.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (CbNationality.Text == "لبناني" || CbNationality.Text == "فلسطيني لبناني")
            {
                if (cbMaritalStatus.Text == "متزوج")
                {

                    IsFoundInsuranceForWife.Enabled = true;
                   
                    cbWifeWork.Enabled = true;

                }
                else if (cbMaritalStatus.Text == "مطلق")
                {
                    cbWifeWork.Enabled = false;
                    IsFoundInsuranceForWife.Enabled = false;
                    cbWifeWork.SelectedIndex = -1;
                    IsFoundInsuranceForWife.SelectedIndex = -1;


                }
                else
                {
                    cbWifeWork.Enabled = false;
                    tbNumberOfChildren.Enabled = false;
                    IsFoundInsuranceForWife.Enabled = false;
                    cbWifeWork.SelectedIndex = -1;
                    IsFoundInsuranceForWife.SelectedIndex = -1;
                   
                }

            }
            else
            {
                IsFoundInsuranceForWife.Enabled = false;
                cbWifeWork.Enabled = false;
                cbWifeWork.SelectedIndex = -1;
                IsFoundInsuranceForWife.SelectedIndex = -1;
             
                if (cbMaritalStatus.Text == "أعزب")
                {

                    tbNumberOfChildren.Enabled = false;

                }
               


            }
         
        }

        private void cbDriverLicese_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbDriverLicese.Text == "لا يوجد")
            {

                dateExpirationDriverLicense.Enabled = false;
                dateExpirationDriverLicense.Text = "01 - Jan - 00";
            }
            else
            {
                dateExpirationDriverLicense.Enabled = true;
                dateExpirationDriverLicense.Value = DateTime.Now;


            }
        }

        private void CbNationality_SelectedIndexChanged_2(object sender, EventArgs e)
        {

            if (CbNationality.Text == "سوري" || CbNationality.Text == "فلسطيني سوري")
            {
                cbWifeWork.Enabled = false;
                IsFoundInsuranceForWife.Enabled = false;
                tbsecurityNumber.Enabled = false;
                cbWifeWork.SelectedIndex = -1;
                tbsecurityNumber.Text = "";
                IsFoundInsuranceForWife.SelectedIndex = -1;

                cbregisterUN.Enabled = true;
                gbLiveInSyria.Enabled = true;
                tbSponsor.Enabled = true;
              
            }
            else
            {
                cbregisterUN.Enabled = false;
                tbSponsor.Enabled = false;
                gbLiveInSyria.Enabled = false;
                cbregisterUN.SelectedIndex = -1;
                tbSponsor.SelectedIndex = -1;
                tbRegionInSyria.Text = "";
                tbstreetInSyria.Text = "";
                tbNextToInSyria.Text = "";
                TbBuildingInSyria.Text = "";
                TbFloorInSyria.Text = "";
                tBPhoneInSyria.Text = "";
               
                cbWifeWork.Enabled = true;
                tbNumberOfChildren.Enabled = true;
                IsFoundInsuranceForWife.Enabled = true;
                tbsecurityNumber.Enabled = true;

            }
        }

     
      
        



        private void tbReasonLeavingPreviousWork_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = ((TextBox)sender);

            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider1.SetError(temp, "يجب ملئ هذا الحقل");

            }
            else
            {
                errorProvider1.SetError(temp, null);
            }
        }

        private void cityInIdentificationDocument_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cityInIdentificationDocument.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider1.SetError(cityInIdentificationDocument, "يجب ملئ هذا الحقل");

            }
            else
            {
                errorProvider1.SetError(cityInIdentificationDocument,null);

            }
        }



        private void cbMaritalStatus_Validating(object sender, CancelEventArgs e)
        {
            ComboBox temp = ((ComboBox)sender);

            if (string.IsNullOrEmpty(temp.Text.Trim()))
            {

                e.Cancel = true;
                errorProvider1.SetError(temp, "يجب ملئ هذا الحقل");

            }
            else
            {
                errorProvider1.SetError(temp, null);
            }
        }

        private void tbNumberOfChildren_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
            {
                e.Handled = false ;
            }else
            {
                e.Handled = true;
            }
        }

       OpenFileDialog ofd = new OpenFileDialog();
        private void LinkLabelDownloadImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofd.FileName = "";
           
            ofd.Filter = "Image Files| *.png;*.jpg;*.gif;";
            ofd.Title = "إختيار صورة";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Title = "Untitled";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PersonalImage.Image =System.Drawing.Image.FromFile(ofd.FileName);
                linkLabelRemoveImage.Visible = true;
            }
        }

        
        private void _LoadNationalities()
        {


            DataTable dt = ClsSettings.getAllNationalities();

            foreach (DataRow row in dt.Rows)
            {

                CbNationality.Items.Add(row["Nationality"]);
            }



        }

        private void _LoadDrivingLicenses()
        {


            DataTable dt = ClsSettings.getAllDrivingLicenses();

            foreach (DataRow row in dt.Rows)
            {

                cbDriverLicese.Items.Add(row["DrivingLicenseName"]);
            }



        }
        private void _LoadDepartments()
        {


            DataTable dt = ClsSettings.getAllDepartments();

            foreach (DataRow row in dt.Rows)
            {

                CbDepartment.Items.Add(row["DepartmentName"]);
            }



        }
        private void Add_EdiitApplication_Load(object sender, EventArgs e)
        {
           
            _ResetDefualtValues();
            _LoadNationalities();
            _LoadDrivingLicenses();
            _LoadDepartments();


            if (_mode==enmode.Update)
            {
                BtSave.Text = "تعديل الطلب";
                _LoadData();
                this.ContextMenuStrip = contextMenuStrip2;
            }

        

           
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
            
        private void tbNumberOfChildren_Validating(object sender, CancelEventArgs e)
        { 
            if(!string.IsNullOrEmpty(tbNumberOfChildren.Text.Trim()))
            {
                byte num = byte.Parse(tbNumberOfChildren.Text);
                if (num > 20)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbNumberOfChildren, "يرجى وضع عدد معقول");


                }
                else
                {
                    errorProvider1.SetError(tbNumberOfChildren, null);

                }
            }
           

                  

        }

    

        private void cbWifeWork_Validating(object sender, CancelEventArgs e)
        {
            if ((cbMaritalStatus.Text == "متزوج") &&( CbNationality.Text== "فلسطيني لبناني"||CbNationality.Text== "لبناني"))
            {
                if(string.IsNullOrEmpty(cbWifeWork.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbWifeWork,"يجب ملئ هذا الحقل" );

                }
                else
                {
                    errorProvider1.SetError(cbWifeWork, null);
                }


            }
        }

        private void IsFoundInsuranceForWife_Validating(object sender, CancelEventArgs e)
        {
            if ((cbMaritalStatus.Text == "متزوج") && (CbNationality.Text == "فلسطيني لبناني" || CbNationality.Text == "لبناني"))
            {
                
                if (string.IsNullOrEmpty(IsFoundInsuranceForWife.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(IsFoundInsuranceForWife, "يجب ملئ هذا الحقل");

                }
                else
                {
                    errorProvider1.SetError(IsFoundInsuranceForWife, null);
                }


            }
        }

        private void tbSponsor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbNumberOfRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) || e.KeyChar==(char)8)
            {
                e.Handled = false;

            }else
            {
                e.Handled = true;
            }
                



            
        }

        private void tbNumberOfChildren_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoutcompany_Validating(object sender, CancelEventArgs e)
        {
            RadioButton temp = ((RadioButton)sender);

            if (rdoutcompany.Checked = false && rdincompany.Checked == false)
            {

                e.Cancel = true;
                errorProvider1.SetError(temp, "(يجب تعبئة أحد الحقلين (داخل الشركة, خارج الشركة");

            }
            else
            {
                errorProvider1.SetError(temp, null);
            }
        }

        private void rdincompany_CheckedChanged(object sender, EventArgs e)
        {
            tbNumberOfRoom.Enabled = true;

            tbCurrentCity.Enabled = false;
            tbCurrentCity.Text = "";
            tbStreet.Enabled = false;
            tbStreet.Text = "";
            tbNextTo.Enabled = false;
            tbNextTo.Text = "";
            TbBuilding.Enabled = false;
            TbBuilding.Text = "";
            tbFloor.Enabled = false;
            tbFloor.Text = "";

        }

        private void rdoutcompany_CheckedChanged(object sender, EventArgs e)
        {
           

            tbNumberOfRoom.Enabled = false;
            tbNumberOfRoom.Text = "";
            tbCurrentCity.Enabled = true;
            tbStreet.Enabled = true;
            tbNextTo.Enabled = true;
            TbBuilding.Enabled = true;
            tbFloor.Enabled = true;

        }

        private void tbsalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) || e.KeyChar==(char)8)
            {
                e.Handled = false;
                errorProvider1.SetError(tbsalary,null);


            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(tbsalary, "يسمح فقط بإدخال أرقام");
            }
        }


        private void btUpdateApp_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("هنالك بعض الحقول الإلزامية فارغة ومشار إليها بالدائرة الأحمر مطلوب تعبئتها", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
             

            if ((_application.Applicationstatus== "طلب مقبول") && (cbAppStatus.Text== "طلب مرفوض" ||cbAppStatus.Text== "طلب ملغى"))
            {
                MessageBox.Show("لا يمكن تحويل طلب مقبول إلى طلب ملغى أو مرفوض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;


            }

            DataTable dt = ClsBlackList.IsFoundOnBlackList(_application.ID);

            DialogResult dr = MessageBox.Show("هل أنت متأكد من إجراء هذه العملية؟", "سؤال؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                if(cbAppStatus.Text== "طلب مقبول" && dt!=null)
                {
                    MessageBox.Show(" ملاحظة: هذا الشخص  على القائمة السوداء ولا يمكن قبول توظيفه قبل إزالته من تلك القائمة ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show(" لم يتم الحفظ ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;

                }

                switch(_mode)
                {

                    case enmode.AddNew:
                        {
                           if(!_CheckAddHealthyForm())
                            {
                                MessageBox.Show("لم يتم الحفظ", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;

                            }
                            _AddNewApp();
                            if (_application.SaveApplication())
                            {
                                tbID.Text = _application.ID.ToString();
                                lbCreatedByUser.Text = ClsUsers.GetUserNameByUserID(_application.CreatedByUserID);
                                _mode = enmode.Update;
                                BtSave.Image = Resource1.Save_32;
                                EditLastDate.Value = _application.EditLastDate;
                                BtSave.Text = "حفظ التعديل ";
                                this.Text = "تعديل الطلب";
                                LinkLabelReferencesAddress.Enabled = _application.Applicationstatus != "";
                                if(_application.Applicationstatus== "طلب مقبول")
                                {
                                    DateStartWork.Visible = true;

                                }

                                
                                MessageBox.Show("تمت إضافة الطلب بنجاح ", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.ContextMenuStrip = contextMenuStrip2;
                            }
                            else
                            {

                                MessageBox.Show("فشلت عملية   ", " خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                            break;
                        }

                    case enmode.Update:
                        {
                            if (!_CheckAddHealthyForm())
                            {
                                MessageBox.Show("لم يتم الحفظ", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;

                            }
                            UpdateData();
                            if (_application.SaveApplication())
                            {
                                tbID.Text = _application.ID.ToString();
                                lbCreatedByUser.Text = ClsUsers.GetUserNameByUserID(_application.CreatedByUserID);
                                _mode = enmode.Update;
                                BtSave.Image = Resource1.Save_32;
                                EditLastDate.Value = _application.EditLastDate;
                                BtSave.Text = "حفظ التعديل ";
                                this.Text = "تعديل الطلب";
                                MessageBox.Show("تمت عملية حفظ التعديل بنجاح", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                LinkLabelReferencesAddress.Enabled = _application.Applicationstatus != "";
                                if (_application.Applicationstatus == "طلب مقبول")
                                {
                                    DateStartWork.Visible = true;

                                }
                            

                            }
                            else
                            {

                                MessageBox.Show("فشلت عملية   ", " خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                            break;
                        }

                     
                }

             

            }
            if((_application.Applicationstatus== "طلب مرفوض" || _application.Applicationstatus== "طلب ملغى"|| _application.Applicationstatus== "طلب سابق")&&(dt==null))
            { 
                
                    DialogResult dr1 = MessageBox.Show("هل تريد وضعه على القائمة السوداء؟", "سؤال؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (dr1 == DialogResult.Yes)
                    {
                        string fullname = tbFirstName.Text + " " + tbFathertName.Text + " " + tbFamilyName.Text;

                        AddToBlackList form = new AddToBlackList(int.Parse(tbID.Text), fullname);
                        form.Show();
                      }
                

                
                //else
                //{
                //    MessageBox.Show("ملاحظة: هذا الشخص  على القائمة السوداء ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}


            }


            if (_application.Applicationstatus == "طلب سابق")
            {
                Print frm = new Print();
                frm.Show();


            }
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageReferenceAddress frm = new ManageReferenceAddress(_application.ID);
            frm.Show();
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void تعديلالطلبToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void سجلالعملياتللطلبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckPermission(clsGlobal.CurrentUser.Permission, 16))
            {

                string fullname = Convert.ToString(tbFirstName.Text + " " + tbFathertName.Text + " " + tbFamilyName.Text);
                ListWarnings frm = new ListWarnings(int.Parse(tbID.Text), fullname);
                frm.Show();
            }
            else
            {
                MessageBox.Show("لا تملك صلاحية الدخول! يرجى مراجعة الأدمن", "لا يمكن الدخول ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
         
        }

        private void الإجازاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckPermission(clsGlobal.CurrentUser.Permission, 4))
            {

                string fullname = Convert.ToString(tbFirstName.Text + " " + tbFathertName.Text + " " + tbFamilyName.Text);

                AddVaccations frm = new AddVaccations(int.Parse(tbID.Text), fullname);
                frm.Show();

            }
            else
            {
                MessageBox.Show("لا تملك صلاحية الدخول! يرجى مراجعة الأدمن", "لا يمكن الدخول ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
        }

        private void الملفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDocuments frm = new ManageDocuments(int.Parse(tbID.Text));
            frm.Show();
        }

        private void الإفاداتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fullname = Convert.ToString(tbFirstName.Text + " " + tbFathertName.Text + " " + tbFamilyName.Text);

            ListStatement frm = new ListStatement(int.Parse(tbID.Text), fullname);
            frm.Show();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
            {
                PrintHealthyForm frm = new PrintHealthyForm();
                SqlDataAdapter da = new SqlDataAdapter("[printHealthForm] " + _application.ID.ToString(), con);
                da.Fill(frm.hr_HammoudCompanyDataSet3.printHealthForm);
                frm.reportViewer1.RefreshReport();
                frm.ShowDialog();

            }

             
        }

        private void _printApplications()
        {
            int ID;
            if (string.IsNullOrEmpty(tbID.Text.Trim()))
            {
                ID = 0;
                rdoutcompany.Checked = true;
            }
            else
            {
                ID = int.Parse(tbID.Text);
            }
            switch (rdoutcompany.Checked)
            {

                case true:
                    {
                        if (CbNationality.Text == "لبناني" || CbNationality.Text == "فلسطيني لبناني")
                        {


                            PrintAppMonthly frm = new PrintAppMonthly();
                            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                            {
                                SqlDataAdapter dt = new SqlDataAdapter("sp_PrintAppMonthly " + ID, con);
                                dt.Fill(frm.printApplications.sp_PrintAppMonthly);

                                SqlDataAdapter dt1 = new SqlDataAdapter("sp_PrintReferencAddressMonthly " + ID, con);
                                dt1.Fill(frm.printApplications.sp_PrintReferencAddressMonthly);
                                frm.reportViewer1.RefreshReport();
                                frm.ShowDialog();
                                break;
                            }

                        }
                        else
                        {
                            PrintAppDaily frm = new PrintAppDaily();
                            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                            {
                                SqlDataAdapter dt = new SqlDataAdapter("sp_PrintAppMonthly " + ID, con);
                                dt.Fill(frm.printApplications.sp_PrintAppMonthly);

                                SqlDataAdapter dt1 = new SqlDataAdapter("sp_PrintReferencAddressMonthly " + ID, con);
                                dt1.Fill(frm.printApplications.sp_PrintReferencAddressMonthly);
                                frm.reportViewer1.RefreshReport();
                                frm.ShowDialog();
                                break;

                            }
                        }


                    
                    }
                case false:
                    {
                        if (CbNationality.Text == "لبناني" || CbNationality.Text == "فلسطيني لبناني")
                        {


                            PrintAppMonthlyInCompany frm = new PrintAppMonthlyInCompany();
                            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                            {
                                SqlDataAdapter dt = new SqlDataAdapter("sp_PrintAppMonthly " + ID, con);
                                dt.Fill(frm.printApplications.sp_PrintAppMonthly);

                                SqlDataAdapter dt1 = new SqlDataAdapter("sp_PrintReferencAddressMonthly " + ID, con);
                                dt1.Fill(frm.printApplications.sp_PrintReferencAddressMonthly);
                                frm.reportViewer1.RefreshReport();
                                frm.ShowDialog();
                                break;
                            }

                        }
                        else
                        {
                            PrintAppDailyInCompany frm = new PrintAppDailyInCompany();
                            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
                            {
                                SqlDataAdapter dt = new SqlDataAdapter("sp_PrintAppMonthly " + ID, con);
                                dt.Fill(frm.printApplications.sp_PrintAppMonthly);

                                SqlDataAdapter dt1 = new SqlDataAdapter("sp_PrintReferencAddressMonthly " + ID, con);
                                dt1.Fill(frm.printApplications.sp_PrintReferencAddressMonthly);
                                frm.reportViewer1.RefreshReport();
                                frm.ShowDialog();
                                break;

                            }
                        }


                    }


            }    




        }
           

        private void LinkLabelReferencesAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManageReferenceAddress frm = new ManageReferenceAddress(int.Parse(tbID.Text));
            frm.ShowDialog();
        }

        private void BtPrintApplications_Click(object sender, EventArgs e)
        {
            _printApplications();
        }

      
    }
}
