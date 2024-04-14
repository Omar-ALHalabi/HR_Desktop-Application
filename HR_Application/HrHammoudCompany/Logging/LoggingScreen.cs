using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBuisnessLayerHrHammoud;

namespace HrHammoudCompany
{
    public partial class LoggingScreen : Form
    {
        public LoggingScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsUsers _user = ClsUsers._findUserNameAndPassword(tbusername.Text.Trim().ToLower(), tbpassword.Text.Trim().ToLower());


            if (string.IsNullOrEmpty(tbusername.Text) || string.IsNullOrEmpty(tbpassword.Text))
            {

                MessageBox.Show("يجب تعبئة جميع الخانات", "فشل الدخول ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if(_user!=null)
            {
                if(chkRememberMe.Checked)
                {

                    clsGlobal.RememberUsernameAndPassword(tbusername.Text.Trim(), tbpassword.Text.Trim());


                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }

               
            }
            else
            {
                MessageBox.Show(".إسم المستخدم هذا أو كلمة السر غير صحيحة ","فشل الدخول ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (!_user.IsActive)
            {

               
                MessageBox.Show("إسم المستخدم هذا غير مفعل! يرجى مراجعة الأدمن", "فشل الدخول ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsGlobal.CurrentUser = _user;
            MainForm frm = new MainForm(this);
            this.Hide();
            frm.ShowDialog();
           
        }

        private void LoggingScreen_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                tbusername.Text = UserName;
                tbpassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;

        }

        private void tbusername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btLogIn.PerformClick();
               
            }
        }

        private void tbpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogIn.PerformClick();
            }
        }
    }
}
