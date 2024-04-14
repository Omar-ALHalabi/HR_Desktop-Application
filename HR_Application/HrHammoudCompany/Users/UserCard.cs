using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBuisnessLayerHrHammoud;

namespace HrHammoudCompany
{
    public partial class UserCard : UserControl
    {
        ClsApplication _application;
        ClsUsers _user;

        public UserCard()
        {
            InitializeComponent();
        }

      
       

        public void IsEnabledOldPassword(bool isvisible)
        {

            tbPassword.Enabled = isvisible;
            lbOldpassword.Enabled = isvisible;

        }

       
        public byte calculatePermission()
        {
            byte permission = 0;
            if (rdmanageEMPLOYEES.Checked)
            {
                permission += Convert.ToByte(rdmanageEMPLOYEES.Tag);
            }

            if(rdPinnedAppOnly.Checked)
            {
                permission += Convert.ToByte(rdPinnedAppOnly.Tag); 
            }
                

            

            if (manageLog.Checked)
            {
                permission += Convert.ToByte(manageLog.Tag);
            }
            if (ManageVacations.Checked)
            {
                permission += Convert.ToByte(ManageVacations.Tag);
            }

            if (ManageUsers.Checked)
            {
                permission += Convert.ToByte(ManageUsers.Tag);
            }

            if (ManageWarnings.Checked)
            {
                permission += Convert.ToByte(ManageWarnings.Tag);
            }

            if (ManageSettings.Checked)
            {
                permission += Convert.ToByte(ManageSettings.Tag);
            }

            return permission;
        }

        private bool CheckPermission(byte Totalpermission,byte unitPermission)
        {
           // byte PermissionPerUnit = Convert.ToByte(contr.Tag);
            byte result = Convert.ToByte(Totalpermission & unitPermission);
            if (result == unitPermission)
            {

                return true;
            }


            return false;
        }

        public void _loadpermission(byte per)
        {



            rdmanageEMPLOYEES.Checked = CheckPermission(per, 1);
            rdPinnedAppOnly.Checked = CheckPermission(per, 2);
            manageLog.Checked = CheckPermission(per, 64);
            ManageUsers.Checked = CheckPermission(per, 8);
            ManageVacations.Checked = CheckPermission(per, 4);
            ManageWarnings.Checked = CheckPermission(per, 16);
            ManageSettings.Checked = CheckPermission(per, 32);




        }

        public void _LoadDataUserByAppId(int id)
        {
            _user = ClsUsers._GetUserInfoByApplicationID(id);
            if (_user != null)
            {
                tbID.Text = _user._application.ID.ToString();
                tbFirstName.Text = _user._application.FirstName;
                tbFathertName.Text = _user._application.FatherName;
                tbFamilyName.Text = _user._application.FamilyName;
                DateBirth.Text = _user._application.DateOfBirth.ToString();
                tbnationality.Text = _user._application.Nationality;
                tbmaritalStatus.Text = _user._application.MaritalStatus;
                tbBloodType.Text = _user._application.BloodType;
                if (!_user._application.PersonalImage.SequenceEqual(new byte[0]))
                {
                    MemoryStream ms = new MemoryStream(_user._application.PersonalImage);
                    pictureBox1.Image = Image.FromStream(ms);

                }


                tbUserName.Text = _user.UserName;
                tbPassword.Text = _user.Password; ;
                if (_user.IsActive)
                {
                    rdActive.Checked = true;

                }
                else
                {
                    rdUnActive.Checked = true;
                }
                _loadpermission(_user.Permission);
            }

        }

        public void _LoadDataUserByUserName(string username)
        {
            _user = ClsUsers._GetUserInfoByusername(username);

            tbID.Text = _user._application.ID.ToString();
            tbFirstName.Text = _user._application.FirstName;
            tbFathertName.Text = _user._application.FatherName;
            tbFamilyName.Text = _user._application.FamilyName;
            DateBirth.Text = _user._application.DateOfBirth.ToString();
            tbnationality.Text = _user._application.Nationality;
            tbmaritalStatus.Text = _user._application.MaritalStatus;
            tbBloodType.Text = _user._application.BloodType;
            MemoryStream ms = new MemoryStream(_user._application.PersonalImage);
            pictureBox1.Image = Image.FromStream(ms);

            tbUserName.Text = _user.UserName;
            tbPassword.Text = _user.Password; ;
            if (_user.IsActive)
            {
                rdActive.Checked = true;

            }
            else
            {
                rdUnActive.Checked = true;
            }
            _loadpermission(_user.Permission);


        }


        public bool _LoadDataPersonByAppid(int Id)
        {
            
            _application = ClsApplication._GetInfoAppByID(Id);
            _clear();
            if (_application == null)
            {
                MessageBox.Show("لا يوجد موظف بهذا الرقم الوظيفي", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            tbID.Text = _application.ID.ToString();
            tbFirstName.Text = _application.FirstName;
            tbFathertName.Text = _application.FatherName;
            tbFamilyName.Text = _application.FamilyName;
            DateBirth.Text = _application.DateOfBirth.ToString();
            tbnationality.Text = _application.Nationality;
            tbmaritalStatus.Text = _application.MaritalStatus;
            tbBloodType.Text = _application.BloodType;
            if(!_application.PersonalImage.SequenceEqual(new byte[0]))
            {
                MemoryStream ms = new MemoryStream(_application.PersonalImage);
                pictureBox1.Image = Image.FromStream(ms);

            }

            


            return true;
        }


        public bool _LoadDataPersonFullName(string fullname)
        {

            _application = ClsApplication._GetInfoAppByFullName(fullname);
            _clear();
            if (_application == null)
            {
                MessageBox.Show("لا يوجد موظف بهذا الرقم الوظيفي", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            tbID.Text = _application.ID.ToString();
            tbFirstName.Text = _application.FirstName;
            tbFathertName.Text = _application.FatherName;
            tbFamilyName.Text = _application.FamilyName;
            DateBirth.Text = _application.DateOfBirth.ToString();
            tbnationality.Text = _application.Nationality;
            tbmaritalStatus.Text = _application.MaritalStatus;
            tbBloodType.Text = _application.BloodType;
            if (!_application.PersonalImage.SequenceEqual(new byte[0]))
            {
                MemoryStream ms = new MemoryStream(_application.PersonalImage);
                pictureBox1.Image = Image.FromStream(ms);

            }



            return true;
        }


        public void UserInfo_Load(object sender, EventArgs e)
        {


        }


        public bool _AddNewUser()
        {
            //if (ClsUsers._IsUserExistByUsername(tbUserName.Text.Trim()))
            //{
            //    MessageBox.Show("هذا المستخدم موجود بالفعل يرجى اختيار اسم مستخدم أخر.", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return false;

            //}
            _user = new ClsUsers();
            _user.UserName = tbUserName.Text.Trim();
            _user.Password = tbPassword.Text.Trim();
            _user.IsActive = rdActive.Checked ? true : false;
            _user.Permission = calculatePermission();
            _user.AppID = int.Parse(tbID.Text.Trim());

            if (_user.Save())
            {
                MessageBox.Show("تم إضافة المستخدم بنجاح ", "نجحت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;


            }
            else
            {
                MessageBox.Show("لم تنجح العملية", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }


        }

        public bool _updateUser()
        {
            // ClsUsers._findUserNameAndPassword(tbUserName.Text.Trim(), tbPassword.Text.Trim());
            _user.UserName = tbUserName.Text.Trim();
            _user.Password = tbPassword.Text.Trim();
            if (rdActive.Checked)
            {
                _user.IsActive = true;
            }
            else
            {
                _user.IsActive = false;
            }
            _user.Permission = calculatePermission();

            _user.AppID = _user.AppID;
            if (_user.Save())
            {
                MessageBox.Show("تم تعديل معلومات المستخدم بنجاح ", "نجحت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;


            }
            else
            {
                MessageBox.Show("لم تنجح العملية", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }






        }

        public void _clear()
        {
            tbID.Text = "";
            tbFirstName.Text = "";
            tbFathertName.Text = "";
            tbFamilyName.Text = "";
            tbnationality.Text = "";
            tbmaritalStatus.Text = "";
            tbBloodType.Text = "";
            tbUserName.Text = "";
            tbPassword.Text = "";
            pictureBox1.Image = null;
            rdActive.Checked = false;
            rdUnActive.Checked = false;
           rdmanageEMPLOYEES.Checked = false;
            rdPinnedAppOnly.Checked = false;
            manageLog.Checked = false;
            ManageSettings.Checked = false;
            ManageUsers.Checked = false;
            ManageVacations.Checked = false;
            ManageWarnings.Checked = false;

        }

     
        private void UserCard_Load(object sender, EventArgs e)
        {
            rdActive.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gbinfoUser_Enter(object sender, EventArgs e)
        {

        }
    }
}
