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

namespace HrHammoudCompany.Statements
{
    public partial class Add_Statement : Form
    { 
        string fullname = "";
        ClsStatements _statements = new ClsStatements();
        public Add_Statement(int appid,string name)
        {
            InitializeComponent();
            fullname = name;
            _statements.ApplicationID = appid;
        }

        public Add_Statement()
        {
            InitializeComponent();
         
        }

        OpenFileDialog ofd = new OpenFileDialog();
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

        private void Add_Statement_Load(object sender, EventArgs e)
        {
            label2.Text = label2.Text + fullname;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbtitle2.Text.Trim()) || string.IsNullOrEmpty(tbExplination.Text.Trim())|| dateEntry.Text== "  /  /")
            {
                MessageBox.Show("يجب التأكد من تعبئة جميع الخانات","خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _statements.KindStatement = tbtitle2.Text;
            _statements.DateEntry = dateEntry.Value;
            _statements.Explination = tbExplination.Text;
            _statements.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            if (_statements.AddStatement())
            {

                MessageBox.Show("تمت الإضافة بنجاح", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

             
                linkLabel1.Enabled = true;
                AddImage.Visible = true;
                btAdd.Enabled = false;

                return;

            }
            else
            {
                MessageBox.Show(" فشلت العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
                return;

            }

        }

        private void AddImage_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image == null && ofd.FileName == "")
            {
                MessageBox.Show("يجب تحميل الملف أولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ext = Path.GetExtension(ofd.FileName).ToLower();


            byte[] image = File.ReadAllBytes(ofd.FileName);
            _statements.Image = image;
            _statements.extension = ext;
            if (_statements.UploadImage(_statements.StatementID, image, ext))
            {
                MessageBox.Show("تم حفظ الملف بنجاح", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
                ofd.FileName = "";



            }
            else
            {
                MessageBox.Show("فشلت العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
           if(printDialog1.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    printDocument1.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

              

            }
        }


        private List<string> TreatLongLines(byte LongLine)
        {

            List<string> textTemp = new List<string>();

                for(int i=0;i<tbExplination.Lines.Count();i++)
            {
                string st1 = tbExplination.Lines[i];
                if(st1.Length<= LongLine)
                {
                  
                    textTemp.Add(st1);
                }
                else
                {
                    while(st1.Length> LongLine)
                    {
                        string substring = st1.Substring(0, LongLine);
                        textTemp.Add(substring);
                        st1 = st1.Substring(LongLine, st1.Length - LongLine);

                    }
                    textTemp.Add(st1);


                }
            }
            return textTemp;
         
            //foreach(string str in textTemp)
            //{
            //    tbExplination.Text += str + "\n";

            //}
            //return tbExplination.Text;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          
            SizeF stsize = new SizeF();

            Font myfont = new Font("Microsoft Sans Serif", 17, FontStyle.Bold);

            e.Graphics.DrawImage(Resource1.InfoE, 0, 25);
            e.Graphics.DrawImage(Resource1.InfoA, 620, 25);
            e.Graphics.DrawImage(Resource1.BH, 300, 10, 300, 100);



            myfont = new Font("Arial Rounded MT", 18, FontStyle.Bold);
            float H = 280 + stsize.Height;
            stsize = e.Graphics.MeasureString(tbtitle2.Text, myfont);
            e.Graphics.DrawString(tbtitle1.Text +" "+ tbtitle2.Text, myfont, Brushes.Black, 470-stsize.Width,H );

            H +=60;
            stsize = e.Graphics.MeasureString(label1.Text, myfont);
            e.Graphics.DrawString(label1.Text , myfont, Brushes.Black, 850-stsize.Width,H);

            stsize = e.Graphics.MeasureString(label2.Text, myfont);
            H += 60;
            e.Graphics.DrawString(label2.Text, myfont, Brushes.Black, 850 - stsize.Width, H);

         
            H += 60;
            List<string >Lines= TreatLongLines(70);
           for(int i=0;i<Lines.Count();i++)
            {
                stsize = e.Graphics.MeasureString(Lines[i], myfont);
                e.Graphics.DrawString(Lines[i], myfont, Brushes.Black, 850 - stsize.Width, H);
                H += 60;
            }
           
            
            H += stsize.Height;
            stsize = e.Graphics.MeasureString(label4.Text, myfont);
            e.Graphics.DrawString(label4.Text, myfont, Brushes.Black, 850 - stsize.Width, H);

            H += 60;
            stsize = e.Graphics.MeasureString(label5.Text, myfont);
            e.Graphics.DrawString(label5.Text , myfont, Brushes.Black, 830- stsize.Width, H);
           
            e.Graphics.DrawString(dateEntry.Value.ToString(), myfont, Brushes.Black,475, H);

            H += 80;
           string st4 = "مؤسسة حمود بيوتي هوم________________________________________";
            e.Graphics.DrawString(st4, myfont, Brushes.Black, 50, H);
        }
    }
}
