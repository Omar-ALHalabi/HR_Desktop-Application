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
using HrHammoudCompany.Users;

namespace HrHammoudCompany
{
    public partial class FrmListUsers : Form
    {
        DataTable dtAllUsers;
        public FrmListUsers()
        {
            InitializeComponent();
        }
     

        
        private void FrmListUsers_Load(object sender, EventArgs e)
        {
            dtAllUsers= ClsUsers.GetAllUsers();
            if (dtAllUsers != null)
            {

                dataGridView1.RowTemplate.MinimumHeight = 35;
                dtAllUsers = dtAllUsers.DefaultView.ToTable(false, "UserID", "AppID", "FullName", "UserName", "Password", "IsActive");
                dataGridView1.DataSource = dtAllUsers;
                lbNRows.Text = dtAllUsers.Rows.Count.ToString();

                dataGridView1.Columns[0].HeaderText = "رقم المستخدم";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].HeaderText = "الرقم الوظيفي";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[2].HeaderText = "الإسم الكامل";
                dataGridView1.Columns[2].Width = 300;
                dataGridView1.Columns[3].HeaderText = "إسم المستخدم";
                dataGridView1.Columns[3].Width = 300;
                dataGridView1.Columns[4].HeaderText = "كلمة السر";
                dataGridView1.Columns[4].Width = 300;
                dataGridView1.Columns[5].HeaderText = "مفعل؟";
                dataGridView1.Columns[5].Width = 100;
            }





        }

        private void cmsInfoUser_Click(object sender, EventArgs e)
        {
            Form frm = new InfoUsers((int)dataGridView1.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

      

        private void إضافةمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Add_EditUsers();
            frm.ShowDialog();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Form frm = new Add_EditUsers((int)dataGridView1.CurrentRow.Cells[1].Value);
                frm.ShowDialog();
            

          
        }
    }
}
