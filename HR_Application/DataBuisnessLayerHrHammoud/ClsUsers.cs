using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_HrHammoud;

namespace DataBuisnessLayerHrHammoud
{
    public class ClsUsers
    {
        public enum enmode {AddNew=0,Update=1};
        enmode mode;

        public byte UserID { get; set; }
        public int AppID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte Permission { get; set; }
        public ClsApplication _application;
        public bool IsActive { set; get; }
      


        public  ClsUsers()
        {
            UserID =0;
            AppID = 0;
            UserName = "";
            Password = "";
            Permission = 0;
            IsActive = true;
            mode = enmode.AddNew;

        }

        public ClsUsers(byte UserID,int appid,string username,string password,byte permission,bool isactive)
        {
            this.UserID =UserID;
            this.AppID = appid;
            this.UserName = username;
            this.Password = password;
            this.Permission = permission;
            this._application = ClsApplication._GetInfoAppByID(appid);
            this.IsActive = isactive;
            mode = enmode.Update;
        }


        private bool AddNewUser()
        {

            this.UserID = Users._AddNewUser(this.AppID, this.UserName, this.Password, this.Permission, this.IsActive);

            return (this.UserID != 0);
        }

        private bool UpdateUser()
        {

            return Users._UpdateUser(this.UserID, this.AppID, this.UserName, this.Password, this.Permission, this.IsActive);


        }

        public static DataTable GetAllUsers()
        {
            return Users._GetAllUsers();

        }
        public bool Save()
        {
            switch(mode)
            {
                case enmode.AddNew:
                    {
                        if(AddNewUser())
                        {
                            mode = enmode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }


                    case enmode.Update:
                        return UpdateUser();

            }
            return false;
              



        }

        public static bool _IsUserExistByFullName(string name)
        {

            return Users.IsUserExistByFullName(name);

        }

        public static bool _isuserExistByAppID(int appid)
        {

            return Users.IsUserExistByAppID(appid);

        }

        public static bool _IsUserExistByUsername(string username)
        {

            return Users.IsUserExistByUserName(username);

        }

        public  bool _ChangePassword()
        {
            return Users.ChangePassword(this.UserID,this.Password);


        }

        public static ClsUsers _findUserNameAndPassword(string username,string password)
        {
            byte userid = 0;
            int appid = 0;
            bool isactive = true;
            byte permission = 0;
            bool isfound = Users.GetUserInfoByUserNameAndPassword(ref userid, ref appid, username, password, ref permission, ref isactive);

            if (isfound)
            {
                return new ClsUsers(userid, appid, username, password, permission, isactive);
            }
            else
                {
                return null;
            }

        }

        public static ClsUsers _GetUserInfoByUserID(byte userid)
        {
           
            int appid = 0;
            bool isactive = true;
            byte permission = 0;
            string password = "";
            string username = "";

            bool isfound = Users.GetUserInfoByUserID(userid,ref appid, ref username, ref password, ref permission, ref isactive);


            if(isfound)
            {
                return new ClsUsers(userid, appid, username, password, permission, isactive);
            }
            else
            {
                return null;
            }


        }




        public static ClsUsers _GetUserInfoByApplicationID(int appid)
        {

            byte UserID = 0;
            bool isactive = true;
            byte permission = 0;
            string password = "";
            string username = "";

            bool isfound = Users.GetUserInfoByAppID(ref UserID,  appid, ref username, ref password, ref permission, ref isactive);


            if (isfound)
            {
                return new ClsUsers(UserID, appid, username, password, permission, isactive);
            }
            else
            {
                return null;
            }


        }


        public static ClsUsers _GetUserInfoByusername(string username)
        {

            byte UserID = 0;
            bool isactive = true;
            byte permission = 0;
            string password = "";
            int appid = 0;

            bool isfound = Users.GetUserInfoByUserName(ref UserID, ref appid,  username, ref password, ref permission, ref isactive);


            if (isfound)
            {
                return new ClsUsers(UserID, appid, username, password, permission, isactive);
            }
            else
            {
                return null;
            }


        }

        public static DataTable getAllFullNameApplication()
        {
            return Users._GetAllFullNameApp();

        }


     

        public static string GetUserNameByUserID(byte UserID)
        {

            return Users._GetUserNameByUserID(UserID);

        }
    }
}
