using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrHammoudCompany.Users
{
    public partial class InfoUsers : Form
    {
        int appid;
        public InfoUsers(int id)
        {
            InitializeComponent();
            appid = id;
        }




        private void InfoUsers_Load(object sender, EventArgs e)
        {
            userCard2._LoadDataUserByAppId(appid);
      



        }
    }
}
