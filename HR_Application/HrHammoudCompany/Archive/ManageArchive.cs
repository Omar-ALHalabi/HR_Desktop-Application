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
    public partial class ManageArchive : Form
    {
        enum enmode { All,ByAppID};
        enmode _mode;

         DataTable DtAllRecords = new DataTable();
        DataTable DtPaging = new DataTable();

        int appID;
        short PageNumber;
        int numberOfRecords;
        int reminderRecords;
        public ManageArchive()
        {
            InitializeComponent();
           
            numberOfRecords = ClsArchive.GetNumberOfRecords();
            PageNumber = 1;
            _mode = enmode.All;


        }

        public ManageArchive(int appid)
        {
            InitializeComponent(); 

            numberOfRecords = ClsArchive.GetNumberOfRecords(appid);

            PageNumber = 1;
            appID = appid;
            _mode = enmode.ByAppID;
            tbSearch.Visible = false;
            cbSearch.Visible = false;
            btSearch.Visible = false;
            lbForm.Visible = false;
            lbto.Visible = false;
            dtstartDate.Visible = false;
            dtEndDate.Visible = false;

        }


        private void _RefreshDGV(DataTable dt )
        {
          

            if (dt != null)
            {
               
                dt = dt.DefaultView.ToTable(false, "LogID", "ApplicationID", "FullName", "name", "KindOperation", "DateAt");
                dataGridView1.DataSource = dt;


                dataGridView1.Columns[0].HeaderText = "رقم العملية";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].HeaderText = "رقم الطلب";
                dataGridView1.Columns[1].Width = 150;

                dataGridView1.Columns[2].HeaderText = "الإسم الثلاثي";
                dataGridView1.Columns[2].Width = 300;

                dataGridView1.Columns[3].HeaderText = "تمت عبر";
                dataGridView1.Columns[3].Width = 150;

                dataGridView1.Columns[4].HeaderText = "نوع العملية";
                dataGridView1.Columns[4].Width = 200;

                dataGridView1.Columns[5].HeaderText = "تاريخ العملية";
                dataGridView1.Columns[5].Width = 200;

                NumRows.Text = numberOfRecords.ToString();


            }
            else
            {
                dataGridView1.DataSource = null;
            }



        }
        private void ManageArchive_Load(object sender, EventArgs e)
        {
          
            dataGridView1.RowTemplate.MinimumHeight = 41;
          
            if(_mode==enmode.All)
            {
                DtPaging = ClsArchive.GetAllRecordsArchive(PageNumber);

                if (DtPaging != null)
                {
                   
                    DtPaging = DtPaging.DefaultView.ToTable(false, "LogID", "ApplicationID", "FullName", "name", "KindOperation", "DateAt");
                    dataGridView1.DataSource = DtPaging;

                    dataGridView1.Columns[0].HeaderText = "رقم العملية";
                    dataGridView1.Columns[0].Width = 100;
                    dataGridView1.Columns[1].HeaderText = "رقم الطلب";
                    dataGridView1.Columns[1].Width = 100;

                    dataGridView1.Columns[2].HeaderText = "الإسم الثلاثي";
                    dataGridView1.Columns[2].Width = 150;

                    dataGridView1.Columns[3].HeaderText = "تمت عبر";
                    dataGridView1.Columns[3].Width = 100;

                    dataGridView1.Columns[4].HeaderText = "نوع العملية";
                    dataGridView1.Columns[4].Width = 100;

                    dataGridView1.Columns[5].HeaderText = "تاريخ العملية";
                    dataGridView1.Columns[5].Width = 200;
                    cbSearch.SelectedIndex = 0;
                }
               
                NumRows.Text = numberOfRecords.ToString();
                btnext.Enabled = (numberOfRecords - (PageNumber * 11)) > 0;
                btback.Enabled = PageNumber > 1;
                lbPageNumber.Text = PageNumber.ToString();
            }
            else
            {

                DtPaging = ClsArchive.GetAllRecordsArchiveByAppid(appID, PageNumber);

                if (DtPaging != null)
                {
                    NumRows.Text = numberOfRecords.ToString();
                    DtPaging = DtPaging.DefaultView.ToTable(false, "LogID", "ApplicationID", "FullName", "name", "KindOperation", "DateAt");
                    dataGridView1.DataSource = DtPaging;

                    dataGridView1.Columns[0].HeaderText = "رقم العملية";
                    dataGridView1.Columns[0].Width = 100;
                    dataGridView1.Columns[1].HeaderText = "رقم الطلب";
                    dataGridView1.Columns[1].Width = 100;

                    dataGridView1.Columns[2].HeaderText = "الإسم الثلاثي";
                    dataGridView1.Columns[2].Width = 150;

                    dataGridView1.Columns[3].HeaderText = "تمت عبر";
                    dataGridView1.Columns[3].Width = 100;

                    dataGridView1.Columns[4].HeaderText = "نوع العملية";
                    dataGridView1.Columns[4].Width = 100;

                    dataGridView1.Columns[5].HeaderText = "تاريخ العملية";
                    dataGridView1.Columns[5].Width = 200;
                }
                btnext.Enabled = (numberOfRecords - (PageNumber * 11)) > 0;
                btback.Enabled = PageNumber > 1;
                lbPageNumber.Text = PageNumber.ToString();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)

        {
            reminderRecords = numberOfRecords - (PageNumber * 11);


             if (reminderRecords > 11)
            {
                PageNumber++;
                ManageArchive_Load(null, null);
                //  btnext.Enabled = false;


            }
            else if (reminderRecords > 0)

            {
                PageNumber++;
                ManageArchive_Load(null, null);
                btnext.Enabled = false;

            }
            else
            {
                btnext.Enabled = false;

            }


            lbPageNumber.Text = PageNumber.ToString();

        }

        private void btback_Click(object sender, EventArgs e)
        {

            if (PageNumber > 1)
            {

           
                    PageNumber--;
                ManageArchive_Load(null, null);
            }
            else
            {
                btback.Enabled = false;
            }
            lbPageNumber.Text = PageNumber.ToString();
        }

      
      

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSearch.PerformClick();
                tbSearch.Focus();
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

            DtAllRecords = ClsArchive.GetAllRecordsArchive();

            string filterColumn = "لا شيء";


            switch (cbSearch.Text)
            {
                case "رقم العملية":
                    filterColumn = "LogID";

                    break;

                case "رقم الطلب":
                    filterColumn = "ApplicationID";

                    break;

                case "الإسم الثلاثي":
                    filterColumn = "FullName";
                    break;

                case "نوع العملية":
                    filterColumn = "KindOperation";
                    break;

                case "تاريخ العملية":
                    filterColumn = "DateAt";
                    break;

                default:
                    filterColumn = "لا شيء";

                    break;



            }


            if (filterColumn == "DateAt")
            {
                DtAllRecords = ClsArchive.SearchBetweenTwoDates(dtstartDate.Text,dtEndDate.Text);
                _RefreshDGV(DtAllRecords);
                return;
                /*select LOgid,DateAt from ArchifeLog where DateAt >'2024-05-1' and DateAt <'2024-05-29'*/

            }


            if (cbSearch.Text.Trim() == "لا شيء" || cbSearch.SelectedIndex == -1||string.IsNullOrEmpty(tbSearch.Text.Trim()))
            {
                PageNumber = 1;

                ManageArchive_Load(null, null);


                return;

            }


          


            if (filterColumn == "ApplicationID" || filterColumn == "LogID")
            //in this case we deal with integer not string.
            {

                DtAllRecords.DefaultView.RowFilter = string.Format("[{0}] = {1} ", filterColumn, tbSearch.Text.Trim());
            }
            else
            {
                DtAllRecords.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%' ", filterColumn, tbSearch.Text.Trim());
            }

           // dataGridView1.DataSource = DtAllRecords;
             _RefreshDGV(DtAllRecords);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbSearch.Text == "رقم العملية" || cbSearch.Text == "رقم الطلب")
            {
                if (char.IsNumber(e.KeyChar) || e.KeyChar==(char)8)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;

                }
            }
        }

        private void cbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
           
             
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.Text == "رقم العملية" || cbSearch.Text == "رقم الطلب")
            {
                tbSearch.Text = "";
            }


            if(cbSearch.Text== "تاريخ العملية")
            {
                tbSearch.Visible = false;
                lbForm.Visible = true;
                lbto.Visible = true;
                dtstartDate.Visible = true;
                dtEndDate.Visible = true;
            }
            else
            {
                tbSearch.Visible = true;
                lbForm.Visible = false;
                lbto.Visible = false;
                dtstartDate.Visible = false;
                dtEndDate.Visible = false;
            }
        }

        private void lbPageNumber_Click(object sender, EventArgs e)
        {

        }
    }

       

            
    
}
