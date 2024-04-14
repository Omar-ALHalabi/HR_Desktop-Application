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
using System.Xml.Linq;
using DataBuisnessLayerHrHammoud;

namespace HrHammoudCompany
{
    public partial class Add_Warnings : Form
    {

        string _fullname = "";
        string _Count;
        ClsWarnings _warning = new ClsWarnings();
        public Add_Warnings(string name, short count, int appid)
        {
            InitializeComponent();
            _fullname = name;
            _Count = count.ToString();
            _warning.ApplicationID = appid;
           
        }



        private List<string> TreatLongLines( byte LongLine)
        {

            List<string> textTemp = new List<string>();

            for (int i = 0; i < tbexplaination.Lines.Count(); i++)
            {
                string st1 = tbexplaination.Lines[i];
                if (st1.Length <= LongLine)
                {

                    textTemp.Add(st1);
                }
                else
                {
                    while (st1.Length > LongLine)
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



            myfont = new Font("Arial Rounded MT", 18, FontStyle.Bold);
            myfont = new Font("Arial Rounded MT", 18, FontStyle.Bold);  
            float heghit = 100;
            if (cbWarning.Text == "إنذار خطي")
            {
                stsize = e.Graphics.MeasureString(LBTopic.Text + " " + cbWarning.Text + " " + NumberWarning.Text, myfont);
                heghit = 302 + stsize.Height;
                e.Graphics.DrawString(LBTopic.Text + " " + cbWarning.Text + " " + NumberWarning.Text, myfont, Brushes.Black, 850 - stsize.Width, heghit);

            }
            else
            {
                stsize = e.Graphics.MeasureString(LBTopic.Text + " " + cbWarning.Text + " " + cbWarning.Text, myfont);
                heghit = 302 + stsize.Height;
                e.Graphics.DrawString(LBTopic.Text + " " + cbWarning.Text, myfont, Brushes.Black, 850 - stsize.Width, heghit);
            }


            stsize = e.Graphics.MeasureString(lbName.Text, myfont);
            heghit = heghit + stsize.Height + 20;
            e.Graphics.DrawString(lbName.Text, myfont, Brushes.Black, 850 - stsize.Width, heghit);

            stsize = e.Graphics.MeasureString(lbDate.Text, myfont);

            e.Graphics.DrawString(lbDate.Text, myfont, Brushes.Black, 10, heghit);


            stsize = e.Graphics.MeasureString(Lb1.Text + lb2.Text, myfont);
            heghit = heghit + stsize.Height + 50;
            e.Graphics.DrawString(Lb1.Text + lb2.Text, myfont, Brushes.Black, 850 - stsize.Width, heghit);

            heghit += 50;
            List<string> Lines = TreatLongLines(98);
            for (int i = 0; i < Lines.Count(); i++)
            {
                stsize = e.Graphics.MeasureString(Lines[i], myfont);
                e.Graphics.DrawString(Lines[i], myfont, Brushes.Black, 850 - stsize.Width, heghit);
                heghit =heghit +stsize.Height + 20;
            }

            stsize = e.Graphics.MeasureString(tbexplaination.Text.Trim(), myfont);
            heghit = heghit + stsize.Height + 20;
            e.Graphics.DrawString(tbexplaination.Text.Trim(), myfont, Brushes.Black, 850 - stsize.Width, heghit);

            stsize = e.Graphics.MeasureString(lb3.Text, myfont);
            heghit = heghit + stsize.Height + 20;
            e.Graphics.DrawString(lb3.Text, myfont, Brushes.Black, 850 - stsize.Width, heghit);


            e.Graphics.DrawString("توقيع الموظف", myfont, Brushes.Black, 720, heghit + 300);
            e.Graphics.DrawString("توقيع المسؤول", myfont, Brushes.Black, 520, heghit + 300);
            e.Graphics.DrawString("توقيع الإداري", myfont, Brushes.Black, 310, heghit + 300);
            e.Graphics.DrawString("توقيع الشؤون", myfont, Brushes.Black, 100, heghit + 300);




        }


        private void Warnings_Load(object sender, EventArgs e)
        {
         
            
                cbWarning.SelectedIndex = 0;
                lbDate.Text = lbDate.Text + DateTime.Now.ToString("dd/MM/yyyy");
                lbName.Text = lbName.Text + " " + _fullname;
                Point p1 = new Point(1056 - lbName.Size.Width, 150);
                lbName.Location = p1;
                NumberWarning.Text = NumberWarning.Text + _Count;
                Lb1.Text = Lb1.Text + _Count;

            

           



        }

        

        private void cbWarning_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWarning.Text == "إنذار خطي")
            {
                NumberWarning.Visible = true;


            }
            else
            {
                NumberWarning.Visible = false;
            }

        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tbexplaination.Text.Trim()))
                {
                MessageBox.Show("(يجب تعبئة خانة الشرح(سبب الإنذار", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _warning.KindWarning = cbWarning.Text;
            _warning.ReasonForWarning = tbexplaination.Text;
            _warning.image = new byte[0];
            _warning.DateWarning = DateTime.Now.ToString("dd/MM/yyyy");
            _warning.CreatedByUserID = clsGlobal.CurrentUser.UserID;
          // _warning.ext = Path.GetExtension(ofd.FileName);
         
            if (_warning.AddWarning())
            {

                MessageBox.Show("تمت الإضافة بنجاح", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                tbexplaination.Text = "";
                linkLabel1.Enabled = true;
                AddImage.Visible = true;
                btAdd.Enabled = false;
                return;

            }
            else
            {
                MessageBox.Show(" فشلت العملية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Clear();
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
            _warning.image = image;
            _warning.ext = ext;
            if (_warning.UploadImage(_warning.WarningID,image, ext))
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


    }
}
        

    

             


                   
         

