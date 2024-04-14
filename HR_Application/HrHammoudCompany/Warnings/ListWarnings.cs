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
using HrHammoudCompany.Pictures;

namespace HrHammoudCompany.Warnings
{
    public partial class ListWarnings : Form
    {enum enmode { All=0,ByAppID=1};
        enmode _mode;
        ClsWarnings _warnin = new ClsWarnings();
        DataTable dt=new DataTable();
        string fullname = "";
        int pagenumber;
        int numberofrecords;
        int reminderRecords;
        public ListWarnings(int appid,string name)
        {
            InitializeComponent();
            _warnin.ApplicationID = appid;
            fullname = name;
            pagenumber = 1;
            numberofrecords = ClsWarnings._NumberOfRecordsInWarning();
            _mode = enmode.ByAppID;

        }

        public ListWarnings()
        {
            InitializeComponent();
          
            pagenumber = 1;
            numberofrecords = ClsWarnings._NumberOfRecordsInWarning();
            _mode = enmode.All;
            btAddWarning.Visible = false;
            NumRows.Text = numberofrecords.ToString();

        }


        private void ListWarnings_Load(object sender, EventArgs e)
        {
            if (_mode == enmode.ByAppID)
            {


                dt = _warnin.getWarningsByAppID(pagenumber);

                if (dt != null)
                {
                    dt = dt.DefaultView.ToTable(false, "WarningID", "KindWarning", "DateWarning", "extension");
                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns[1].HeaderText = "رقم الانذار";

                    dataGridView1.Columns[2].HeaderText = "نوع التحذير";

                    dataGridView1.Columns[3].HeaderText = "تاريخ التحذير";

                    dataGridView1.Columns[4].HeaderText = "صيغة الملف";
                    btnext.Enabled = (numberofrecords - (pagenumber * 11)) > 0;
                    btback.Enabled = pagenumber > 1;
                }

            }
            else
            {
                dt = _warnin.geAlltWarnings(pagenumber);

                if (dt != null)
                {
                    dt = dt.DefaultView.ToTable(false, "WarningID", "KindWarning", "DateWarning", "extension");
                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns[1].HeaderText = "رقم الانذار";

                    dataGridView1.Columns[2].HeaderText = "نوع التحذير";

                    dataGridView1.Columns[3].HeaderText = "تاريخ التحذير";

                    dataGridView1.Columns[4].HeaderText = "صيغة الملف";
                    btnext.Enabled = (numberofrecords - (pagenumber * 11)) > 0;
                    btback.Enabled = pagenumber > 1;


                }
            }

        }

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows.Count>0)
            {

              
                if (dataGridView1.Columns[e.ColumnIndex].Name == "ShowImage")
                {
                    string ext = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    if (string.IsNullOrEmpty(ext.Trim()))
                    {
                        MessageBox.Show("لا يمكن تحميل الملف دون معرفة الصيغة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return;
                    }



                    byte[] _image = ClsWarnings.ShowImage((int)dataGridView1.CurrentRow.Cells[1].Value);
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

        private void تعديلالصورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int warnningid = (int)dataGridView1.CurrentRow.Cells[1].Value;
            AddImage frm = new AddImage(warnningid);
            frm.ShowDialog();
            ListWarnings_Load(null, null);
        }

     

      
        private void btAddWarning_Click(object sender, EventArgs e)
        {
            short count = 1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "إنذار خطي")
                {
                    count++;

                }
            }

            Add_Warnings frm = new Add_Warnings(fullname, count, _warnin.ApplicationID);
            frm.ShowDialog();
            ListWarnings_Load(null, null);
        }

        private void btnext_Click_1(object sender, EventArgs e)
        {
            reminderRecords = numberofrecords - (pagenumber * 11);

            if (reminderRecords > 11)
            {
                pagenumber++;
                ListWarnings_Load(null, null);
                //  btnext.Enabled = false;


            }
            else if (reminderRecords > 0 && reminderRecords <= 1)

            {
                pagenumber++;
                ListWarnings_Load(null, null);
                btnext.Enabled = false;

            }
            else
            {
                btnext.Enabled = false;

            }

            lbPageNumber.Text = pagenumber.ToString();
        }

        private void btback_Click_1(object sender, EventArgs e)
        {

            if (pagenumber > 1)
            {

                pagenumber--;
                ListWarnings_Load(null, null);
            }
            else
            {
                btback.Enabled = false;
            }

            lbPageNumber.Text = pagenumber.ToString();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {


                if (dataGridView1.Columns[e.ColumnIndex].Name == "ShowImage")
                {


                    string ext = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    if (string.IsNullOrEmpty(ext.Trim()))
                    {
                        MessageBox.Show("لا يمكن تحميل الملف دون معرفة الصيغة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return;
                    }

                    byte[] image = ClsWarnings.ShowImage((int)dataGridView1.CurrentRow.Cells[1].Value);
                    if (image == null)
                    {
                        MessageBox.Show("الصورة غير موجودة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    switch (ext)
                    {
                        case ".pdf":
                            {
                                string fileName = "تنبيه خطي";



                                File.WriteAllBytes(fileName, image);
                                Process.Start(fileName);
                                break;
                            }

                        default:
                            {
                                MemoryStream stream = new MemoryStream(image);
                                ShowPictures frm = new ShowPictures(stream, ext);
                                frm.Show();


                                break;
                            }

                    }
                }


            }
        }
    }
}
