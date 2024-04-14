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
using MimeImage = System.Net.Mime.MediaTypeNames.Image;


namespace HrHammoudCompany.ManageOfficialDocuments
{
    public partial class ManageDocuments : Form
    {
        static DataTable _dtAllFile;
        ClsOfficialDocuments _documents = new ClsOfficialDocuments();
        string FilePath = "";

        public ManageDocuments(int appid)
        {
            InitializeComponent();
            _documents.ApplicationID = appid;
        }

        private void ManageOfficialDocuments_Load(object sender, EventArgs e)
        {
            _dtAllFile = _documents.GetAllDocumentsByAppID();
            if (_dtAllFile != null)
            {
                _dtAllFile = _dtAllFile.DefaultView.ToTable(false, "OfficialDocumentsID", "DocumentName", "DocumentDate", "FileType");

                dataGridView1.DataSource = _dtAllFile;
                lbRows.Text = _dtAllFile.Rows.Count.ToString();

                dataGridView1.Columns[1].HeaderText = "رقم الملف";
                dataGridView1.Columns[1].Width = 120;

                dataGridView1.Columns[2].HeaderText = "إسم الملف";
                 dataGridView1.Columns[2].Width = 250;

                dataGridView1.Columns[3].HeaderText = "تاريخ الإدخال";
                dataGridView1.Columns[3].Width = 350;
               
                dataGridView1.Columns[4].HeaderText = "صيغة الملف";
                 dataGridView1.Columns[4].Width = 150;


            }

        }
      
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "اختيار صورة";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "All Files|*.jpg;*.png;*.gif;*.bmp;*.pdf";
            ofd.Filter += "|Images|*.jpg;*.png;*.gif;";
            ofd.Filter += "|Pdf Files|*.pdf";

            ofd.FilterIndex = 1;

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



        private void BtAdd_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrEmpty(tbName.Text.Trim()))
            {
                MessageBox.Show("يجب تعبئة حقل الإسم ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pictureBox1.Image == null && FilePath == "")
            {
                MessageBox.Show("يجب تحميل صورة ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _documents.DocumentName = tbName.Text.Trim();

            if (FilePath != "")
            {
                byte[] Image = File.ReadAllBytes(FilePath);
                _documents.DocumentImage = Image;
                _documents.fileType = Path.GetExtension(FilePath);

            }
            else
            {
                MessageBox.Show("لا يمكنك إضافة نفس الصورة من هنا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            _documents.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (_documents.AddNewDocument())
            {

                MessageBox.Show("تمت الإضافة بنجاح", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ManageOfficialDocuments_Load(null, null);
                tbName.Text = "";
                FilePath = "";
                pictureBox1.Image = null;
                return;

            }
            else
            {
                MessageBox.Show(" فشلت العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Clear();
                return;

            }


        }



        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {



        }

        private void BtShow_Click(object sender, EventArgs e)
        {
            string ext = dataGridView1.CurrentRow.Cells[3].Value.ToString().ToLower();

            if (ext != ".pdf")
            {

                byte[] image = ClsOfficialDocuments.GetImageByID((int)dataGridView1.CurrentRow.Cells[0].Value);
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);

                tbName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            }
            else
            {
                string fileName = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                tbName.Text = fileName;
                byte[] image = ClsOfficialDocuments.GetImageByID((int)dataGridView1.CurrentRow.Cells[0].Value);
                File.WriteAllBytes(fileName, image);
                Process.Start(fileName);

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtEdit_Click(object sender, EventArgs e)
        {



            if (pictureBox1.Image == null && FilePath == "")
            {
                MessageBox.Show("يجب تحميل صورة ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(tbName.Text.Trim()))
            {
                MessageBox.Show("يجب تعبئة حقل الإسم ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            
            _documents.DocumentName = tbName.Text.Trim();
            _documents.DateOfEntry = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy hh:m"));
            ImageConverter _imageConverter = new ImageConverter();
            byte[] imageByte = (byte[])_imageConverter.ConvertTo(pictureBox1.Image, typeof(byte[]));
            _documents.DocumentImage = imageByte;
            _documents.fileType = Path.GetExtension(FilePath);
            _documents.DocumentID = (int)dataGridView1.CurrentRow.Cells[1].Value;
            _documents.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (_documents.UpdateDocument())
            {

                MessageBox.Show("تمت الإضافة بنجاح", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ManageOfficialDocuments_Load(null, null);

                tbName.Text = "";
                pictureBox1.Image = null;
                return;

            }
            else
            {
                MessageBox.Show(" فشلت العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Clear();
                return;

            }



        }


        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {


                DialogResult dr = MessageBox.Show("هل أنت متأكد من عملية الحذف؟", "سؤال؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int currentrow = (int)dataGridView1.CurrentRow.Cells[1].Value;

                    _documents.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                    if (ClsOfficialDocuments.DeleteDocument(currentrow))
                    {

                        MessageBox.Show("تمت عملية الحذف بنجاح", "تمت العملية؟", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbName.Text = "";
                        pictureBox1.Image = null;
                        ManageOfficialDocuments_Load(null, null);

                        return;
                    }
                    else
                    {
                        MessageBox.Show("لم تنجح العملية", "فشلت العملية؟", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("لا يوجد ملف كي يتم تعديله", "خطأ؟", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }



        private void CmsSave_Click(object sender, EventArgs e)
        {
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                string ext = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                if (dataGridView1.Columns[e.ColumnIndex].Name == "BtImage")
                {



                    byte[] image = ClsOfficialDocuments.GetImageByID((int)dataGridView1.CurrentRow.Cells[1].Value);
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
    }
}

                
            




        