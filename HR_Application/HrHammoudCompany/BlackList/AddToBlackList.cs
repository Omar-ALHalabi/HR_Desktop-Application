using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DataBuisnessLayerHrHammoud;

namespace HrHammoudCompany.BlackList
{
    public partial class AddToBlackList : Form
    {
        ClsBlackList _blackList = new ClsBlackList();
        string fullname;
        public AddToBlackList(int appid,string name)
        {
            InitializeComponent();
            _blackList.BlackListID = appid;
          fullname = name;


        }

        private void tbAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbReason.Text.Trim()))
            {

                MessageBox.Show("يجب التأكذ من وضع السبب ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _blackList.reason = tbReason.Text;
            _blackList.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if(_blackList.AddToBlackList())
            {
                MessageBox.Show("تم وضعه على القائمة السوداء ", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tbAdd.Enabled = false;
                tbReason.ReadOnly = true;
            }


        }

        private void AddToBlackList_Load(object sender, EventArgs e)
        {
            textBox1.Text = fullname;

        }
    }
}
