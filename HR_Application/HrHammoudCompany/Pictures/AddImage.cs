using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBuisnessLayerHrHammoud;

namespace HrHammoudCompany.Pictures
{
    public partial class AddImage : Form
    {
        public AddImage(int warnningid)
        {
            InitializeComponent();
            _warning.WarningID = warnningid;
        }

        ClsWarnings _warning = new ClsWarnings();

        OpenFileDialog ofd = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
        

            if (pictureBox1.Image == null && ofd.FileName == "")
            {
                MessageBox.Show("يجب تحميل الملف أولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ext = Path.GetExtension(ofd.FileName).ToLower();


            byte[] image = File.ReadAllBytes(ofd.FileName);
            _warning.image = image;
            _warning.ext = ext;
            if (_warning.UploadImage(_warning.WarningID, image, ext))
            {
                MessageBox.Show("تم حفظ الملف بنجاح", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Image = null;
                ofd.FileName = "";



            }
            else
            {
                MessageBox.Show("فشلت العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ofd.Title = "اختيار صورة";
            ofd.RestoreDirectory = true;
            ofd.Filter = "AllFiles|*.jpg;*.png;*.gif;*.pdf;*.bmp";


            if (ofd.ShowDialog() == DialogResult.OK)
            {

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
    }
    
}
