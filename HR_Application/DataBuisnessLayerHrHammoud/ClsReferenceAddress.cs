using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_HrHammoud;

namespace DataBuisnessLayerHrHammoud
{
    public class ClsReferenceAddress
    {
       public enum enmode { addNew, update }
        enmode _mode=enmode.addNew;
        public int ReferenceAddressID { get; set; }
        public int AppID { get; set; }
        public string NameAsReferenceAddress { get; set; }
        public string Typeofknowledge { get; set; }
        public string PhoneAsReferenceAddress { get; set; }
        public string Address { get; set; }


       public ClsReferenceAddress()
        {
            AppID = 0;
            ReferenceAddressID = 0;
            NameAsReferenceAddress = "";
            Typeofknowledge = "";
            PhoneAsReferenceAddress = "";
            Address = "";

            _mode = enmode.addNew;

        }

        public ClsReferenceAddress(int refAdressID,int ApplicationID,string Name ,string KindKnowiedge,string phone,string address)
        {
           this.AppID = ApplicationID;
           this.ReferenceAddressID = refAdressID;
           this.NameAsReferenceAddress = Name;
           this.Typeofknowledge = KindKnowiedge;
           this.PhoneAsReferenceAddress = phone;
           this.Address = address;
            _mode = enmode.update;



        }



        public bool AddNewAddress()
        {
            return ReferenceAddress._AddReferenceAddress(this.AppID, this.NameAsReferenceAddress, this.Typeofknowledge, this.PhoneAsReferenceAddress, this.Address);




        }


        public bool UpdateAddress()
        {
            return ReferenceAddress._UpdateReferenceAddress(this.ReferenceAddressID, this.NameAsReferenceAddress, this.Typeofknowledge, this.PhoneAsReferenceAddress, this.Address);




        }

       static public bool DeleteReferenceAddress(int addressid)
        {

            return ReferenceAddress._DeleteReferenceAddress(addressid);

        }

         public DataTable GetAdressesByID()
        {

            return ReferenceAddress._GetReferenceAddressByID(this.AppID);

        }
        //public bool Save()
        //{

        //    switch(_mode)
        //    {
        //        case enmode.addNew:
        //            if (AddNewAddress())
        //            {
        //                _mode=enmode.update;
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }

        //        case enmode.update:
        //            {
        //                return UpdateAddress();
        //            }

               

        //    }

        //    return false;





        //}



    }



}
