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
    public partial class Add_EditUsers : Form
    {
        enum enmode { add=0,update=1}
        enmode _mode;

        

    

        public Add_EditUsers()
        {
            InitializeComponent();
           
            cbSearch.Items.RemoveAt(2);
            _loadCombBoxInFullName();
            _mode = enmode.add;
        }

        public Add_EditUsers(bool isupdate)
        {
            InitializeComponent();
            comboboxsearch.Visible = false;
            tbsearch1.Visible = true;
            _loadCombBoxInFullName();

            _mode = enmode.update;
          
            
        }

        public Add_EditUsers(int appid)
        {
            InitializeComponent();
            comboboxsearch.Visible = false;
            tbsearch1.Visible = false;
            label2.Visible = false;
            cbSearch.Visible = false;
            PerformSearch.Visible = false;
           userCard1._LoadDataUserByAppId(appid);

            _mode = enmode.update;


        }



        private void PerformSearch_Click(object sender, EventArgs e)
        {
           //if(cbSearch.Text=="إسم المستخدم" && _mode==enmode.add)
           // {
           //     MessageBox.Show("لا يمكن البحث عن اسم مستخدم في حالة الإضافة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           //     return;
           // }

            if(_mode==enmode.add)
            {
                switch (cbSearch.Text)
                {
                    case "الرقم الوظيفي":
                        {
                            if (ClsUsers._isuserExistByAppID(Convert.ToInt32(tbsearch1.Text)))
                            {
                                MessageBox.Show("هذا المستخدم موجود بالفعل يرجى اختيار رقم مستخدم أخر.", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                userCard1._LoadDataPersonByAppid(int.Parse(tbsearch1.Text));

                                _mode = enmode.add;

                                return;
                            }


                        }

                    case "الإسم الثلاثي":
                        {
                            if (ClsUsers._IsUserExistByFullName(comboboxsearch.Text))
                            {
                                MessageBox.Show("هذا المستخدم موجود بالفعل يرجى اختيار اسم مستخدم أخر.", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;

                            }
                            else
                            {
                                userCard1._LoadDataPersonFullName(comboboxsearch.Text);
                                return;
                            }

                        }

                }
            }
            else
            {
                switch (cbSearch.Text)
                {
                    case "الرقم الوظيفي":
                        {
                            if (ClsUsers._isuserExistByAppID(Convert.ToInt32(tbsearch1.Text)))
                            {
                                userCard1._LoadDataUserByAppId(Convert.ToInt32(tbsearch1.Text));
                                return;
                            }
                            else
                            {
                                MessageBox.Show("هذا المستخدم غير موجود  يرجى اختيار رقم مستخدم أخر.", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;


              
                            }

                           
                        }

                    case "إسم المستخدم":
                        {
                            if (ClsUsers._IsUserExistByUsername(tbsearch1.Text))
                            {
                                userCard1._LoadDataUserByUserName(tbsearch1.Text);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("هذا المستخدم غير موجود يرجى اختيار اسم مستخدم أخر.", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                        }

                    case "الإسم الثلاثي":
                        {
                            if (ClsUsers._IsUserExistByFullName(comboboxsearch.Text))
                            {
                                MessageBox.Show("هذا المستخدم موجود بالفعل يرجى اختيار اسم مستخدم أخر.", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;

                            }
                            else
                            {
                                userCard1._LoadDataPersonFullName(comboboxsearch.Text);
                                return;
                            }

                        }

                }

            }

           


        }

        private void btSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("هل أنت متأكد من إضافة مستخدم جديد؟", "سؤال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (_mode == enmode.add)
                {
                    if (userCard1._AddNewUser())
                    {
                        _mode = enmode.update;
                        btSave.Text = "تعديل";
                        lbTitle.Text = "تعديل معلومات المستخدم";

                    }
                }
                else
                {
                    userCard1._updateUser();
                }

            }
        }
        private void _loadCombBoxInFullName()
        {

            DataTable dt = ClsUsers.getAllFullNameApplication();

           foreach(DataRow row in dt.Rows)
            {

                comboboxsearch.Items.Add(row["FullName"]);
            }

        }
    
        private void Add_EditUsers_Load(object sender, EventArgs e)
        {
           
           // cbSearch.SelectedIndex = 0;
         

            if (_mode == enmode.add)
            {
                lbTitle.Text = "إضافة مستخدم جديد";
                btSave.Text = "إضافة";
              
            }
            else
            {
                lbTitle.Text = "تعديل معلومات المستخدم";
                btSave.Text = "تعديل";
     


            }
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbSearch.Text)
            {
                case "الإسم الثلاثي":
                    {
                        comboboxsearch.Visible = true;
                        tbsearch1.Visible = false;
                        break;
                    }
                case "الرقم الوظيفي":
                    {
                        tbsearch1.Visible = true;
                        comboboxsearch.Visible = false;

                        break;
                    }
                case "إسم المستخدم":
                    {
                        tbsearch1.Visible = true;
                        comboboxsearch.Visible = false;

                        break;
                    }


            }
         
          

            
        }

        private void tbsearch1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbSearch.Text== "الرقم الوظيفي")
            {
                if(char.IsNumber(e.KeyChar)|| e.KeyChar==(char)8)
                {
                    e.Handled = false;
                }else
                {
                    e.Handled=true;
                }

            }
        }

        private void tbsearch1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearch.PerformClick();

            }
        }
    }
}
