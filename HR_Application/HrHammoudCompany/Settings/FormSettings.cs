using DataBuisnessLayerHrHammoud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrHammoudCompany.Settings
{
    public partial class FormSettings : Form
    {
        public FormSettings(bool Nationality=false,bool Department=false,bool DrivingLicense=false)
        {
            InitializeComponent();
            if(Nationality==true)
            {
                label1.Text = "إضافة جنسية ";

            }
            else 
            if(DrivingLicense==true)
            {
                label1.Text = "إضافة رخصة قيادة ";
            }
            else
            {
                label1.Text = "إضافة قسم جديد ";
            }
                    


        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("هل أنت متأكد من عملية الإضافة هذه؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)
            {
                if (label1.Text == "إضافة جنسية ")
                {
                    if(ClsSettings.AddNationality(textBox1.Text.Trim()))
                    {
                        MessageBox.Show("تمت عملية الإضافة", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;

                    }
                }
                else if (label1.Text == "إضافة رخصة قيادة ")
                {
                    if(ClsSettings.AddDrivingLicenses(textBox1.Text.Trim()))
                    {
                        MessageBox.Show("تمت عملية الإضافة", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    if(ClsSettings.AddDepartment(textBox1.Text.Trim()))
                    {
                        MessageBox.Show("تمت عملية الإضافة", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }


            }
           
            

        }
    }
}
