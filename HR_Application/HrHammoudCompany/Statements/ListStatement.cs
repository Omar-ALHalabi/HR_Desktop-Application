using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBuisnessLayerHrHammoud;

namespace HrHammoudCompany.Statements
{
    public partial class ListStatement : Form
    {
       
        string _fullname = "";
        int _appid;
        short pagenumber;
        int reminder;
        int numberOfRecords;
        public ListStatement(int appid,string fullname)
        {
            InitializeComponent();
            _appid = appid;
            pagenumber = 1;
            numberOfRecords = ClsStatements.GetNumberOfRecordsStatements();
        }
        DataTable dt = new DataTable();  

        private void ListStatement_Load(object sender, EventArgs e)
        {
            dt = ClsStatements.getAllStatementsByAppID(_appid,pagenumber);
            if (dt != null)
            {
                dt = dt.DefaultView.ToTable(false, "StatementID", "KindStatement", "DateEntry", "extenstion");
                dataGridView2.DataSource = dt;
                dataGridView2.Columns[1].HeaderText = "رقم الإفادة";
                dataGridView2.Columns[2].HeaderText = "نوع الإفادة";
                dataGridView2.Columns[3].HeaderText = "تاريخ الإنشاء";
                dataGridView2.Columns[4].HeaderText = "صيغة الملف";
             
            }
            btnext.Enabled = (numberOfRecords - (pagenumber * 11)) > 0;
            btback.Enabled = pagenumber > 1;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Statement frm = new Add_Statement(_appid, _fullname);
            frm.ShowDialog();
            ListStatement_Load(null, null);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {


                if (dataGridView2.Columns[e.ColumnIndex].Name == "ShowImage")
                {

                    string ext = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                    if (string.IsNullOrEmpty(ext.Trim()))
                    {
                        MessageBox.Show("لا يمكن تحميل الملف دون معرفة الصيغة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return;
                    }


                    byte[] _image = ClsStatements.ShowImage((int)dataGridView2.CurrentRow.Cells[1].Value);
                    if (_image == null)
                    {
                        MessageBox.Show("الصورة غير موجودة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    switch (ext)
                    {
                        case ".pdf":
                            {
                                string fileName = "طلب إجازة";



                                File.WriteAllBytes(fileName, _image);
                                Process.Start(fileName);
                                break;
                            }

                        default:
                            {
                                MemoryStream stream = new MemoryStream(_image);
                                ShowPictures frm = new ShowPictures(stream, ext);
                                frm.Show();


                                break;
                            }

                    }
                }




            }
        }

        private void btnext_Click(object sender, EventArgs e)
        {

            reminder = numberOfRecords - (pagenumber * 11);


            if (reminder > 11)
            {
                pagenumber++;
                ListStatement_Load(null, null);
                //  btnext.Enabled = false;


            }
            else if (reminder > 0 && reminder <= 1)

            {
                pagenumber++;
                ListStatement_Load(null, null);
                btnext.Enabled = false;

            }
            else
            {
                btnext.Enabled = false;

            }


            lbPageNumber.Text = pagenumber.ToString();
        }

        private void btback_Click(object sender, EventArgs e)
        {
            if (pagenumber > 1)
            {

                if (pagenumber > 1)
                    pagenumber--;
                ListStatement_Load(null, null);
            }
            else
            {
                btback.Enabled = false;
            }

            lbPageNumber.Text = pagenumber.ToString();
        }
    }
}
