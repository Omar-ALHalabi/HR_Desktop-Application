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


namespace HrHammoudCompany.BlackList
{
    public partial class ListBlackList : Form
    {


        DataTable dtPaging = new DataTable();
        DataTable dtAllRecords = new DataTable();

        short PageNumber;
        short NumberOfRecords;
        int reminder;
        public ListBlackList()
        {
            InitializeComponent();
            NumberOfRecords = ClsBlackList.getNumberOfRecords();
            PageNumber = 1;
           
        }

        private void _RefreshDGV(DataTable dt)
        {

            if (dt != null)
            {
            
                NumRows.Text = NumberOfRecords.ToString();
                dt = dt.DefaultView.ToTable(false, "ID", "FullName", "Reason", "DatePutOn", "CreatedByUser");
                dataGridViewBlackList.DataSource = dt;

                dataGridViewBlackList.Columns[0].HeaderText = "رقم الطلب";
                dataGridViewBlackList.Columns[0].Width = 70;

                dataGridViewBlackList.Columns[1].HeaderText = "الإسم الثلاثي";
                dataGridViewBlackList.Columns[1].Width = 190;

                dataGridViewBlackList.Columns[2].HeaderText = "السبب";
                dataGridViewBlackList.Columns[2].Width = 235;

                dataGridViewBlackList.Columns[3].HeaderText = " تاريخ العملية";
                dataGridViewBlackList.Columns[3].Width = 90;

                dataGridViewBlackList.Columns[4].HeaderText = " تمت عبر";
                dataGridViewBlackList.Columns[4].Width = 100;




            }
        }

            private void ListBlackList_Load(object sender, EventArgs e)
        {
            dtPaging = ClsBlackList.GetBlackListRecords(PageNumber);
            if(dtPaging!=null)
            {
                dataGridViewBlackList.RowTemplate.MinimumHeight=40;
                NumberOfRecords = ClsBlackList.getNumberOfRecords();
                dtPaging = dtPaging.DefaultView.ToTable(false, "ID", "FullName", "Reason", "DatePutOn", "CreatedByUser");
                dataGridViewBlackList.DataSource = dtPaging;

                
             
                dataGridViewBlackList.Columns[0].HeaderText = "رقم الطلب";
                dataGridViewBlackList.Columns[0].Width = 70;

                dataGridViewBlackList.Columns[1].HeaderText = "الإسم الثلاثي";
                dataGridViewBlackList.Columns[1].Width = 190;

                dataGridViewBlackList.Columns[2].HeaderText = "السبب";
                dataGridViewBlackList.Columns[2].Width = 235;

                dataGridViewBlackList.Columns[3].HeaderText = " تاريخ العملية";
                dataGridViewBlackList.Columns[3].Width = 90;

                dataGridViewBlackList.Columns[4].HeaderText = " تمت عبر";
                dataGridViewBlackList.Columns[4].Width = 100;


        


            }
            NumRows.Text = NumberOfRecords.ToString();
            btnext.Enabled = (NumberOfRecords - (PageNumber * 11)) > 0;
            btback.Enabled = PageNumber > 1;
            lbPageNumber.Text = PageNumber.ToString();


        }

        private void btnext_Click(object sender, EventArgs e)
        {
            reminder = NumberOfRecords - (NumberOfRecords * 11);


            if (reminder > 11)
            {
                PageNumber++;
                ListBlackList_Load(null, null);
                //  btnext.Enabled = false;


            }
            else if (reminder > 0 && reminder <= 1)

            {
                PageNumber++;
                ListBlackList_Load(null, null);
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

                if (PageNumber > 1)
                    PageNumber--;
                ListBlackList_Load(null, null);
            }
            else
            {
                btback.Enabled = false;
            }
            lbPageNumber.Text = PageNumber.ToString();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }


        private void tbSearch_Enter(object sender, EventArgs e)
        {
           
        }

    

        private void btPrint_Click(object sender, EventArgs e)
        {
            PrintDGV frm = new PrintDGV();
            frm.ShowDialog();
        }

        private void tbSearch_TextChanged_1(object sender, EventArgs e)
        {
           dtAllRecords = ClsBlackList.GetAllBlackListRecords();

            string filterColumn = "لا شيء";

            switch (cbSearch.Text)
            {


                case "الإسم الثلاثي":
                    filterColumn = "FullName";
                    break;

                case "السبب":
                    filterColumn = "Reason";
                    break;

                default:
                    filterColumn = "لا شيء";

                    break;

            }

            if (cbSearch.Text.Trim() == "لا شيء" || cbSearch.SelectedIndex == -1 || string.IsNullOrEmpty(tbSearch.Text.Trim()))
            {
                PageNumber = 1;
                tbSearch.Text = "";
                ListBlackList_Load(null, null);


                return;

            }


            dtAllRecords.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%' ", filterColumn, tbSearch.Text.Trim());


         _RefreshDGV(dtAllRecords);
        }

        private void إزالةمنالقائمةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("هل أنت متأكد من أنك تريد إزالته من القائمة السوداء؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (ClsBlackList.DeleteFromBlackList((int)dataGridViewBlackList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("تمت عملية الإزالة بنجاح", "نجحت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
                else
                {
                    MessageBox.Show("لم تنجح عملية الإزالة ", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  

                }

                ListBlackList_Load(null, null);

            }
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = "";
        }
    }
}
