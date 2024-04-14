using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBuisnessLayerHrHammoud;

namespace HrHammoudCompany
{
    public partial class AddVaccations : Form
    {
        DataTable dt = new DataTable();
            string FilePath = "";
        short pagenumber;
        int reminder;
        short numberOfRecords;
        ClsVaccations _vaccation = new ClsVaccations();
        
        OpenFileDialog ofd=new OpenFileDialog();
        public AddVaccations(int appid, string name)
        {
            InitializeComponent();
            _vaccation.AppID = appid;
            _vaccation.EmploymentName = name;
            pagenumber = 1;
            numberOfRecords = ClsVaccations._NumberOfRecordsByAppid(appid);
        }


        private void AddVaccations_Load(object sender, EventArgs e)
        {
            dt = _vaccation._getAllVaccByAppID(pagenumber);
            if(dt!=null)
            {
                dt = dt.DefaultView.ToTable(false, "VaccationID", "dateOfApplication", "Extension");
                DGV.DataSource = dt;

                lbRows.Text= numberOfRecords.ToString();

                DGV.Columns[1].HeaderText = "رقم الصورة";
                DGV.Columns[2].HeaderText = "تاريخ تقديم الطلب";
                DGV.Columns[3].HeaderText = "صيغة الملف";
            }
            btnext.Enabled = (numberOfRecords - (pagenumber * 11)) > 0;
            btback.Enabled = pagenumber > 1;
            lbPageNumber.Text = pagenumber.ToString();

            ofd.FileName = "";
        }



     
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ofd.Title = "اختيار صورة";
            ofd.RestoreDirectory = true;
            ofd.Filter = "AllFiles|*.jpg;*.png;*.gif;*.pdf;*.bmp";

           
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FilePath = ofd.FileName;
                string ext = Path.GetExtension(ofd.FileName);
                if (ext.ToLower() != ".pdf")
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
                else
                {

                    MessageBox.Show("تم تحميل الملف بنجاح");
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("هل أنت متأكد من إضافة طلب إجازة جديد؟", "سؤال؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr != DialogResult.Yes)
            {
                return;
            }


            if (pictureBox1.Image == null && ofd.FileName == "")
            {
                MessageBox.Show("يجب تحميل الصورة أولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ext = Path.GetExtension(ofd.FileName).ToLower();

            _vaccation.dateOfVaccation = DateTime.Now;
            byte[] image = File.ReadAllBytes(ofd.FileName);
            _vaccation.Image = image;
            _vaccation.extension = ext;
            _vaccation.CreatesByUserID = clsGlobal.CurrentUser.UserID;
            if (_vaccation.AddNewVaccation())
            {
                MessageBox.Show("تم حفظ الملف بنجاح", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Image = null;
                ofd.FileName = "";
                AddVaccations_Load(null, null);


            }
            else
            {
                MessageBox.Show("فشلت العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV.Rows.Count > 0)
            {
            

                if (DGV.Columns[e.ColumnIndex].Name == "showImage")
                {


                    string ext = DGV.CurrentRow.Cells[3].Value.ToString();
                    if (string.IsNullOrEmpty(ext.Trim()))
                    {
                        MessageBox.Show("لا يمكن تحميل الملف دون معرفة الصيغة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return;
                    }

                    byte[] image = ClsVaccations._ShowImage((int)DGV.CurrentRow.Cells[1].Value);
                    if (image == null)
                    {
                        MessageBox.Show("الصورة غير موجودة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    switch (ext)
                    {
                        case ".pdf":
                            {
                                string fileName = "طلب إجازة";



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

        private void btnext_Click(object sender, EventArgs e)
        {
            reminder = numberOfRecords - (pagenumber * 11);


            if (reminder > 11)
            {
                pagenumber++;
                AddVaccations_Load(null, null);
                //  btnext.Enabled = false;


            }
            else if (reminder > 0 && reminder <= 1)

            {
                pagenumber++;
                AddVaccations_Load(null, null);
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
                AddVaccations_Load(null, null);
            }
            else
            {
                btback.Enabled = false;
            }
            lbPageNumber.Text = pagenumber.ToString();
        }
    }
}




         

             
               

            


