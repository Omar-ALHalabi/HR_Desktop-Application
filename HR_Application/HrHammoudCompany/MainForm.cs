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
using HrHammoudCompany.Applications;
using HrHammoudCompany.BlackList;
using HrHammoudCompany.Settings;
using HrHammoudCompany.Users;
using HrHammoudCompany.Vacations;
using HrHammoudCompany.Warnings;
using Microsoft.ReportingServices.Interfaces;

namespace HrHammoudCompany
{
    public partial class MainForm : Form
    {
        LoggingScreen _log;

        public MainForm(LoggingScreen log)
        {
            InitializeComponent();
            _log = log;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            _log.Show();
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void الموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void إضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Add_EditUsers();
            frm.ShowDialog();
        }

      

        private void قائمةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListUsers frm = new FrmListUsers();
            frm.Show();
        }

        private void معلوماتالمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new InfoUsers(Convert.ToInt32(clsGlobal.CurrentUser.AppID));
            frm.Show();
        }

        private void employees_Click(object sender, EventArgs e)
        {
           
            if (clsGlobal.CheckPermission(clsGlobal.CurrentUser.Permission,Convert.ToByte(employees.Tag)))
            {
                ListAppBySelectFilter form = new ListAppBySelectFilter(true);
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("لا تملك صلاحية الدخول! يرجى مراجعة الأدمن", "لا يمكن الدخول ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckPermission(clsGlobal.CurrentUser.Permission, Convert.ToByte(toolStripMenuItem3.Tag)))
            {
                Add_EdiitApplication form = new Add_EdiitApplication();
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("لا تملك صلاحية الدخول! يرجى مراجعة الأدمن", "لا يمكن الدخول ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckPermission(clsGlobal.CurrentUser.Permission, Convert.ToByte(toolStripMenuItem4.Tag)))
            {
                ListApplications form = new ListApplications();
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("لا تملك صلاحية الدخول! يرجى مراجعة الأدمن", "لا يمكن الدخول ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

       
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckPermission(clsGlobal.CurrentUser.Permission, Convert.ToByte(toolStripMenuItem5.Tag)))
            {

                ListAppBySelectFilter form = new ListAppBySelectFilter(false);
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("لا تملك صلاحية الدخول! يرجى مراجعة الأدمن", "لا يمكن الدخول ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

     

     

        private void vaccations_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckPermission(clsGlobal.CurrentUser.Permission, Convert.ToByte(vaccations.Tag)))
            {

                LogVaccations form = new LogVaccations();
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("لا تملك صلاحية الدخول! يرجى مراجعة الأدمن", "لا يمكن الدخول ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
       
        }

        private void history_Click(object sender, EventArgs e)
        {
        
                if (clsGlobal.CheckPermission(clsGlobal.CurrentUser.Permission, Convert.ToByte(history.Tag)))
                {
               
                    ManageArchive form = new ManageArchive();
                    form.ShowDialog();
               
                }
                else
                {
                    MessageBox.Show("لا تملك صلاحية الدخول! يرجى مراجعة الأدمن", "لا يمكن الدخول ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
         
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
         if (clsGlobal.CheckPermission(clsGlobal.CurrentUser.Permission, Convert.ToByte(toolStripMenuItem12.Tag)))
            {
                Add_EditUsers form = new Add_EditUsers();
                form.ShowDialog();
            }
              
            else
            {
                MessageBox.Show("لا تملك صلاحية الدخول! يرجى مراجعة الأدمن", "لا يمكن الدخول ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckPermission(clsGlobal.CurrentUser.Permission, Convert.ToByte(toolStripMenuItem13.Tag)))
            {

                FrmListUsers form = new FrmListUsers();
                form.ShowDialog();

            }
            else
            {
                MessageBox.Show("لا تملك صلاحية الدخول! يرجى مراجعة الأدمن", "لا يمكن الدخول ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            InfoUsers form = new InfoUsers(clsGlobal.CurrentUser.AppID);
            form.ShowDialog();
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

          
        }

        private void تسجيلالخروجToolStripMenuItem1_Click(object sender, EventArgs e)
        {


        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckPermission(clsGlobal.CurrentUser.Permission, Convert.ToByte(toolStripMenuItem6.Tag)))
            {
                ListBlackList frm = new ListBlackList();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("لا تملك صلاحية الدخول! يرجى مراجعة الأدمن", "لا يمكن الدخول ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
        }

        private void applications_Click(object sender, EventArgs e)
        {

        }

        private void userss_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckPermission(clsGlobal.CurrentUser.Permission, Convert.ToByte(toolStripMenuItem1.Tag)))
            {
                Form frm = new Add_EditUsers(true);
                frm.ShowDialog();
            }

            else
            {
                MessageBox.Show("لا تملك صلاحية الدخول! يرجى مراجعة الأدمن", "لا يمكن الدخول ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
         
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
           
        }

        private void تسجيلالخروجToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            this.Close();

            _log.Show();
        }

        private void mswarnings_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckPermission(clsGlobal.CurrentUser.Permission, Convert.ToByte(mswarnings.Tag)))
            {

                ListWarnings frm = new ListWarnings();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("لا تملك صلاحية الدخول! يرجى مراجعة الأدمن", "لا يمكن الدخول ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AddNationality_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckPermission(clsGlobal.CurrentUser.Permission, Convert.ToByte(clssettings.Tag)))
            {
                FormSettings frm = new FormSettings(true, false, false);
                frm.Show();
            }
            else
            {
                MessageBox.Show("لا تملك صلاحية الدخول! يرجى مراجعة الأدمن", "لا يمكن الدخول ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            
        }

        private void addDepartment_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckPermission(clsGlobal.CurrentUser.Permission, Convert.ToByte(clssettings.Tag)))
            {
                FormSettings frm = new FormSettings(false, true, false);
                frm.Show();
            }
            else
            {
                MessageBox.Show("لا تملك صلاحية الدخول! يرجى مراجعة الأدمن", "لا يمكن الدخول ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AddDrivingLicense_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckPermission(clsGlobal.CurrentUser.Permission, Convert.ToByte(clssettings.Tag)))
            {
                FormSettings frm = new FormSettings(false, false, true);
                frm.Show();
            }
            else
            {
                MessageBox.Show("لا تملك صلاحية الدخول! يرجى مراجعة الأدمن", "لا يمكن الدخول ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }
    }

 }  





