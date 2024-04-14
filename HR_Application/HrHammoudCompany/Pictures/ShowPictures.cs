using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrHammoudCompany
{
    public partial class ShowPictures : Form
    {
        MemoryStream _stream;
        string _ext;
        public ShowPictures(MemoryStream stream,string ext)
        {
            InitializeComponent();
            _stream = stream;
            _ext = ext;
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();

            fd.Title = "اختيار مسار الملف";
            fd.RestoreDirectory = true;
            fd.FileName = "Untitled";
            if (fd.ShowDialog() == DialogResult.OK)
            {
              
                pictureBox1.Image.Save(fd.FileName+_ext);
                MessageBox.Show("تم الحفظ بنجاح","", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void ShowPictures_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromStream(_stream);
        }
    }
}
