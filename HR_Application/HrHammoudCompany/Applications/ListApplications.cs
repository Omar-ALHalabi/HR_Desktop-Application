using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBuisnessLayerHrHammoud;
using HrHammoudCompany.ManageOfficialDocuments;
using HrHammoudCompany.Statements;
using HrHammoudCompany.Warnings;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HrHammoudCompany.Applications
{
    public partial class ListApplications : Form
    {


       DataTable dtallrecords = new DataTable();
        DataTable CurrentDataTable = new DataTable();
   

        int reminder;
        short pagenumber;
        int numberofrecords;


    
        public ListApplications()
        {
            InitializeComponent();
            pagenumber = 1;
          
            dtallrecords = ClsApplication._GetAllApplications();
           numberofrecords = dtallrecords.Rows.Count;


        }

      //  static DataTable _dtAllAppChooses = new DataTable();

        private DataTable GetPagedTable(DataTable dt, short pageSize, int pageNumber)
        {
            // تحويل DataTable إى Enumerable لاستخدام LINQ
            var query = dt.AsEnumerable()
                           .Skip((pageNumber - 1) * pageSize)
                           .Take(pageSize);
            DataTable pagedTable = new DataTable();

            try
            {
                pagedTable = query.CopyToDataTable();
                lbnumrows.Text = dt.Rows.Count.ToString();


            }
            catch
            {

                pagedTable = null;
                lbnumrows.Text = "0";


            }


            return pagedTable;
        }

        private void ListApplications_Load(object sender, EventArgs e)
        {
            
          
            cbSearch.SelectedIndex = 0;
            CurrentDataTable = ClsApplication._GetAllApplications(pagenumber);
         

            if (CurrentDataTable != null)
            {
                dgvallapp.DataSource = CurrentDataTable;
                lbnumrows.Text = numberofrecords.ToString();

                dgvallapp.Columns[0].HeaderText = "الرقم الوظيفي";
                dgvallapp.Columns[0].Width = 90;

                dgvallapp.Columns[1].HeaderText = "الإسم الأول";
                dgvallapp.Columns[1].Width = 100;

                dgvallapp.Columns[2].HeaderText = "إسم الأب";
                dgvallapp.Columns[2].Width = 100;

                dgvallapp.Columns[3].HeaderText = "إسم العائلة";
                dgvallapp.Columns[3].Width = 100;

                dgvallapp.Columns[4].HeaderText = "إسم الأم";
                dgvallapp.Columns[4].Width = 130;

                dgvallapp.Columns[5].HeaderText = "الجنسية";
                dgvallapp.Columns[5].Width = 120;


                dgvallapp.Columns[6].HeaderText = "فئة الدم";
                dgvallapp.Columns[6].Width = 50;

                dgvallapp.Columns[7].HeaderText = "محل الولادة";
                dgvallapp.Columns[7].Width = 100;

                dgvallapp.Columns[8].HeaderText = "تاريخ الولادة";
                dgvallapp.Columns[8].Width = 80;


                dgvallapp.Columns[9].HeaderText = "رقم الهاتف";
                dgvallapp.Columns[9].Width = 100;



                dgvallapp.Columns[10].HeaderText = "القسم";
                dgvallapp.Columns[10].Width = 100;

                dgvallapp.Columns[11].HeaderText = "ساعات العمل";
                dgvallapp.Columns[11].Width = 80;


                dgvallapp.Columns[12].HeaderText = "الوضع العائلي";
                dgvallapp.Columns[12].Width = 100;

                dgvallapp.Columns[13].HeaderText = "المستوى العلمي";
                dgvallapp.Columns[13].Width = 100;


                dgvallapp.Columns[14].HeaderText = "الخبرات";
                dgvallapp.Columns[14].Width = 100;

                dgvallapp.Columns[15].HeaderText = "عدد الأولاد";
                dgvallapp.Columns[15].Width = 100;

                dgvallapp.Columns[16].HeaderText = "الشهادات";
                dgvallapp.Columns[16].Width = 100;

                dgvallapp.Columns[17].HeaderText = "اللغات";
                dgvallapp.Columns[17].Width = 100;

                dgvallapp.Columns[18].HeaderText = "مسجل أمم؟";
                dgvallapp.Columns[18].Width = 50;

                dgvallapp.Columns[19].HeaderText = "تاريخ تقديم الطلب";
                dgvallapp.Columns[19].Width = 100;

                dgvallapp.Columns[20].HeaderText = "تاريخ بدء العمل";
                dgvallapp.Columns[20].Width = 100;

                dgvallapp.Columns[21].HeaderText = "تاريخ التعديل الأخير";
                dgvallapp.Columns[21].Width = 100;

                dgvallapp.Columns[22].HeaderText = "حالة الطلب";
                dgvallapp.Columns[22].Width = 100;

            }
            else
            {
                dgvallapp.DataSource = null;
                

            }
            numberofrecords = int.Parse(lbnumrows.Text);
            CurrentDataTable = dtallrecords;



        }



        private void _RefreshPeoplList(DataTable _currentDataTable)
        {
        
            _currentDataTable = GetPagedTable(_currentDataTable, 11, pagenumber);

            if (_currentDataTable != null)
            {

                _currentDataTable = _currentDataTable.DefaultView.ToTable(false, "ID", "FirstName", "FatherName", "FamilyName", "MotherName", "Nationality", "BloodType", "BirthPlace", "DateBirth",
                            "PersonalPhone", "Department", "WorkHours", "MaritalStatus", "AcademyLevel", "Experiences", "NumChildren", "Certificate", "Languages", "IsRegisterdUN", "DateOfApplication", "WorkStartDate", "EditLastDate", "Applicationstatus");
                dgvallapp.DataSource = _currentDataTable;
               // lbnumrows.Text = numberofrecords.ToString();

                dgvallapp.Columns[0].HeaderText = "الرقم الوظيفي";
                dgvallapp.Columns[0].Width = 90;

                dgvallapp.Columns[1].HeaderText = "الإسم الأول";
                dgvallapp.Columns[1].Width = 100;

                dgvallapp.Columns[2].HeaderText = "إسم الأب";
                dgvallapp.Columns[2].Width = 100;

                dgvallapp.Columns[3].HeaderText = "إسم العائلة";
                dgvallapp.Columns[3].Width = 100;

                dgvallapp.Columns[4].HeaderText = "إسم الأم";
                dgvallapp.Columns[4].Width = 130;

                dgvallapp.Columns[5].HeaderText = "الجنسية";
                dgvallapp.Columns[5].Width = 120;


                dgvallapp.Columns[6].HeaderText = "فئة الدم";
                dgvallapp.Columns[6].Width = 50;

                dgvallapp.Columns[7].HeaderText = "محل الولادة";
                dgvallapp.Columns[7].Width = 100;

                dgvallapp.Columns[8].HeaderText = "تاريخ الولادة";
                dgvallapp.Columns[8].Width = 80;


                dgvallapp.Columns[9].HeaderText = "رقم الهاتف";
                dgvallapp.Columns[9].Width = 100;



                dgvallapp.Columns[10].HeaderText = "القسم";
                dgvallapp.Columns[10].Width = 100;

                dgvallapp.Columns[11].HeaderText = "ساعات العمل";
                dgvallapp.Columns[11].Width = 80;


                dgvallapp.Columns[12].HeaderText = "الوضع العائلي";
                dgvallapp.Columns[12].Width = 100;

                dgvallapp.Columns[13].HeaderText = "المستوى العلمي";
                dgvallapp.Columns[13].Width = 100;


                dgvallapp.Columns[14].HeaderText = "الخبرات";
                dgvallapp.Columns[14].Width = 100;

                dgvallapp.Columns[15].HeaderText = "عدد الأولاد";
                dgvallapp.Columns[15].Width = 100;

                dgvallapp.Columns[16].HeaderText = "الشهادات";
                dgvallapp.Columns[16].Width = 100;

                dgvallapp.Columns[17].HeaderText = "اللغات";
                dgvallapp.Columns[17].Width = 100;

                dgvallapp.Columns[18].HeaderText = "مسجل أمم؟";
                dgvallapp.Columns[18].Width = 50;

                dgvallapp.Columns[19].HeaderText = "تاريخ تقديم الطلب";
                dgvallapp.Columns[19].Width = 100;

                dgvallapp.Columns[20].HeaderText = "تاريخ بدء العمل";
                dgvallapp.Columns[20].Width = 100;

                dgvallapp.Columns[21].HeaderText = "تاريخ التعديل الأخير";
                dgvallapp.Columns[21].Width = 100;

                dgvallapp.Columns[22].HeaderText = "حالة الطلب";
                dgvallapp.Columns[22].Width = 100;

              
                numberofrecords = int.Parse(lbnumrows.Text);
             

            }
            else
            {
                dgvallapp.DataSource = null;

                numberofrecords = 0;
            }

         
        }


  
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtallrecords.DefaultView;
            pagenumber = 1;

            string filterColumn = "لا شي";


            switch (cbSearch.Text)
            {
                case "الرقم الوظيفي":
                    filterColumn = "ID";

                    break;

                case "الإسم الأول":
                    filterColumn = "FirstName";

                    break;

                case "إسم الأب":
                    filterColumn = "FatherName";
                    break;

                case "إسم العائلة":
                    filterColumn = "FamilyName";
                    break;

                case "إسم الأم":
                    filterColumn = "MotherName";
                    break;

                case "الجنسية":
                    filterColumn = "Nationality";
                    break;

                case "فئة الدم":
                    filterColumn = "BloodType";
                    break;

                case "رقم الهاتف":
                    filterColumn = "PersonalPhone";
                    break;

                case "القسم":
                    filterColumn = "Department";
                    break;

                case "ساعات العمل":
                    filterColumn = "WorkHours";
                    break;

                case "الوضع العائلي":
                    filterColumn = "MaritalStatus";
                    break;

                case "المستوى العلمي":
                    filterColumn = "AcademyLevel";
                    break;

                case "عدد الأولاد":
                    filterColumn = "NumChildren";
                    break;

                case "الشهادات":
                    filterColumn = "Certificate";
                    break;

                case "مسجل أمم؟":
                    filterColumn = "IsRegisterdUN";
                    break;

                case "اللغات":
                    filterColumn = "Languages";
                    break;

                case "تاريخ تقديم الطلب":
                    filterColumn = "DateOfApplication";
                    break;

                case "تاريخ بدء العمل":
                    filterColumn = "WorkStartDate";
                    break;

                case "تاريخ التعديل الأخير":
                    filterColumn = "EditLastDate";
                    break;

                default:
                    filterColumn = "لا شيء";
                    break;



            }



            if (rdAll.Checked)
            {
                if (string.IsNullOrEmpty(tbSearch.Text.Trim()))
                {
                    dv.RowFilter = "";
                    CurrentDataTable = dv.ToTable();
                    _RefreshPeoplList(CurrentDataTable);
                    btnext.Enabled = true;
                    btback.Enabled = true;
                    lbPageNumber.Text = "1";
                    return;
                }

                if (filterColumn == "ID" || filterColumn == "NumChildren")
                {
                
                   dv.RowFilter = string.Format("[{0}] = {1}", filterColumn, tbSearch.Text.Trim());
                    CurrentDataTable = dv.ToTable();
                    _RefreshPeoplList(CurrentDataTable);
                    btnext.Enabled = true;
                    btback.Enabled = true;
                    lbPageNumber.Text = "1";
                    return;


                }
               

                else
                {
                 
                   
                    dv.RowFilter = string.Format("[{0}] LIKE '{1}%' ", filterColumn, tbSearch.Text.Trim());
                   
                    CurrentDataTable = dv.ToTable();
                    _RefreshPeoplList(CurrentDataTable);
                    btnext.Enabled = true;
                    btback.Enabled = true;
                    lbPageNumber.Text = "1";
                    return;
                }

            }
            else if (rdPinned.Checked)
            {
                if (string.IsNullOrEmpty(tbSearch.Text.Trim()))
                {
                   dv.RowFilter= string.Format("[{0}] LIKE '{1}%'", "Applicationstatus", "طلب معلق");
                    CurrentDataTable = dv.ToTable();
                    _RefreshPeoplList(CurrentDataTable);
                    btnext.Enabled = true;
                    btback.Enabled = true;
                    lbPageNumber.Text = "1";
                    return;
                }
                if (filterColumn == "ID" || filterColumn == "NumChildren")
                {
                    //in this case we deal with integer not string.
                    dv.RowFilter = string.Format("[{0}] = {1} and [{2}] LIKE '{3}%' ", filterColumn, tbSearch.Text.Trim(), "Applicationstatus", "طلب معلق");
                    CurrentDataTable = dv.ToTable();
                    _RefreshPeoplList(CurrentDataTable);
                    btnext.Enabled = true;
                    btback.Enabled = true;
                    lbPageNumber.Text = "1";
                    return;
                }
                else
                {
                    dv.RowFilter= string.Format("[{0}] LIKE '{1}%'  and [{2}] LIKE '{3}%' ", filterColumn, tbSearch.Text.Trim(), "Applicationstatus", "طلب معلق");
                    CurrentDataTable = dv.ToTable();
                    _RefreshPeoplList(CurrentDataTable);
                    btnext.Enabled = true;
                    btback.Enabled = true;
                    lbPageNumber.Text = "1";
                    return;
                }
            }
            else if (rdPrevious.Checked)
            {
                if (string.IsNullOrEmpty(tbSearch.Text.Trim()))
                {
                    dv.RowFilter = string.Format("[{0}] LIKE '{1}%'", "Applicationstatus", "طلب سابق");

                    CurrentDataTable = dv.ToTable();
                    _RefreshPeoplList(CurrentDataTable);
                    btnext.Enabled = true;
                    btback.Enabled = true;
                    lbPageNumber.Text = "1";
                    return;
                }

                if (filterColumn == "ID" || filterColumn == "NumChildren")
                {
                   dv.RowFilter = string.Format("[{0}] = {1} and[{2}] LIKE '{3}%' ", filterColumn, tbSearch.Text.Trim(), "Applicationstatus", "طلب سابق");
                    CurrentDataTable = dv.ToTable();
                    _RefreshPeoplList(CurrentDataTable);
                    btnext.Enabled = true;
                    btback.Enabled = true;
                    lbPageNumber.Text = "1";
                    return;
                }

                else
                {
                    dv.RowFilter = string.Format("[{0}] LIKE '{1}%' and [{2}] LIKE '{3}%' ", filterColumn, tbSearch.Text.Trim(), "Applicationstatus", "طلب سابق");

                    CurrentDataTable = dv.ToTable();
                    _RefreshPeoplList(CurrentDataTable);
                    btnext.Enabled = true;
                    btback.Enabled = true;
                    lbPageNumber.Text = "1";
                    return;
                }

            }
            else if (rdUnAcceptable.Checked)
            {
                if (string.IsNullOrEmpty(tbSearch.Text.Trim()))
                {
                   dv.RowFilter= string.Format("[{0}] LIKE '{1}%' or [{2}] like '{3}%'", "Applicationstatus", "طلب مرفوض", "Applicationstatus", "طلب ملغى");
                    CurrentDataTable = dv.ToTable();
                    _RefreshPeoplList(CurrentDataTable);
                    btnext.Enabled = true;
                    btback.Enabled = true;
                    lbPageNumber.Text = "1";
                    return;
                }

                if (filterColumn == "ID" || filterColumn == "NumChildren")
                {
                    dv.RowFilter = string.Format("[{0}] = {1} and ([{2}] LIKE '{3}%' or [{4}] like '{5}%')", filterColumn, tbSearch.Text.Trim(), "Applicationstatus", "طلب مرفوض", "Applicationstatus", "طلب ملغى");
                    CurrentDataTable = dv.ToTable();
                    _RefreshPeoplList(CurrentDataTable);
                    btnext.Enabled = true;
                    btback.Enabled = true;
                    lbPageNumber.Text = "1";
                    return;
                }
                else
                {
                  dv.RowFilter = string.Format("[{0}] LIKE '{1}%'  and ([{2}] LIKE '{3}%' or [{4}] like '{5}%')", filterColumn, tbSearch.Text.Trim(), "Applicationstatus", "طلب مرفوض", "Applicationstatus", "طلب ملغى");
                    CurrentDataTable = dv.ToTable();
                    _RefreshPeoplList(CurrentDataTable);
                    btnext.Enabled = true;
                    btback.Enabled = true;
                    lbPageNumber.Text = "1";
                    return;
                }

            }







           
    

        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (cbSearch.Text == "الرقم الوظيفي" || cbSearch.Text == "عدد الأولاد")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbSearch.Text == "لا شيء")
            {

                tbSearch.Visible = false;
                CbUN.Visible = false;
            }
            else
            {
                tbSearch.Visible = true;
                tbSearch.Text = "";
                tbSearch.Focus();
            }

          


            if (cbSearch.Text == "مسجل أمم؟")
            {
                CbUN.Visible = true;
                //CbUN.SelectedIndex = 0;
                tbSearch.Visible = false;
                return;
            }


            if (cbSearch.Text == "تاريخ الولادة" || cbSearch.Text == "تاريخ تقديم الطلب" || cbSearch.Text == "تاريخ بدء العمل" || cbSearch.Text == "تاريخ التعديل الأخير")
            {
                btSearch.Visible = true;
                tbSearch.Visible = false;
                lbForm.Visible = true;
                lbto.Visible = true;
                dtstartDate.Visible = true;
                dtEndDate.Visible = true;
                rdAll.Checked = true;
                CbUN.Visible = false;

                return;



            }
            else
            {
                btSearch.Visible = false;
                tbSearch.Visible = true;
                lbForm.Visible = false;
                lbto.Visible = false;
                dtstartDate.Visible = false;
                dtEndDate.Visible = false;
                tbSearch.Text = "";
                CbUN.Visible = false;

                tbSearch.Focus();
                return;

            }
        }

        private void تعديلالطلبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_EdiitApplication app = new Add_EdiitApplication((int)dgvallapp.CurrentRow.Cells[0].Value);

            app.ShowDialog();
            ListApplications_Load(null, null);
        }

        private void رؤيةالطلبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_EdiitApplication app = new Add_EdiitApplication((int)dgvallapp.CurrentRow.Cells[0].Value, true);

            app.ShowDialog();
        }

        private void rdPinned_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPinned.Checked)
            {
              
            }

        }

        private void rdPrevious_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPrevious.Checked)
            {
               
            }

        }

        private void rdUnAcceptable_CheckedChanged(object sender, EventArgs e)
        {
            if (rdUnAcceptable.Checked)
            {
             
            }


        }

        private void سجلالعملياتللطلبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fullname = Convert.ToString(dgvallapp.CurrentRow.Cells[1].Value + " " + dgvallapp.CurrentRow.Cells[2].Value + " " + dgvallapp.CurrentRow.Cells[3].Value);
            ListWarnings frm = new ListWarnings((int)dgvallapp.CurrentRow.Cells[0].Value, fullname);
            frm.Show();
        }

        private void الملفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDocuments frm = new ManageDocuments((int)dgvallapp.CurrentRow.Cells[0].Value);
            frm.Show();

        }

        private void الإجازاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fullname = (string)dgvallapp.CurrentRow.Cells[1].Value + " " + dgvallapp.CurrentRow.Cells[2].Value + " " + dgvallapp.CurrentRow.Cells[3].Value;

            AddVaccations frm = new AddVaccations((int)dgvallapp.CurrentRow.Cells[0].Value, fullname);
            frm.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void الإفاداتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fullname = (string)dgvallapp.CurrentRow.Cells[1].Value + " " + dgvallapp.CurrentRow.Cells[2].Value + " " + dgvallapp.CurrentRow.Cells[3].Value;

            ListStatement frm = new ListStatement((int)dgvallapp.CurrentRow.Cells[0].Value, fullname);
            frm.Show();
        }

        private void سجلالعملياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageArchive form = new ManageArchive((int)dgvallapp.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void القائمةالسوداءToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnext_Click(object sender, EventArgs e)
        {//
          

            reminder = numberofrecords - (pagenumber * 11);
            
            //if(rdAll.Checked && tbSearch.Text.Trim()==string.Empty)

            if (reminder > 11)
            {
                pagenumber++;
                _RefreshPeoplList(CurrentDataTable);
                lbPageNumber.Text = pagenumber.ToString();
                btback.Enabled = true;
                return;



            }
            else if (reminder > 0 )

            {
                pagenumber++;
                _RefreshPeoplList(CurrentDataTable);
                btnext.Enabled = false;
                lbPageNumber.Text = pagenumber.ToString();
                btback.Enabled = true;
                return;

            }
            else
            {
                btnext.Enabled = false;
                return;

            }


          
        }

        private void btback_Click(object sender, EventArgs e)
        {
            if(btnext.Enabled == false )
            {
                btnext.Enabled = true;
            }

            if (pagenumber > 1)
            {

             
                    pagenumber--;
                _RefreshPeoplList(CurrentDataTable);
            }
            else
            {
                btback.Enabled = false;
            }
            lbPageNumber.Text = pagenumber.ToString();
        }
       
        private void btSearch_Click(object sender, EventArgs e)
        {
            switch (cbSearch.Text)
            {
                case "تاريخ تقديم الطلب":
                    {
                       CurrentDataTable = ClsApplication._SearchByDateOfApp(dtstartDate.Text, dtEndDate.Text);
                        if(CurrentDataTable!=null)
                        {
                            _RefreshPeoplList(CurrentDataTable);
                            btnext.Enabled = true;
                            btback.Enabled = true;
                            lbPageNumber.Text = "1";
                        }
                        else
                        {
                            dgvallapp.DataSource = null;
                        }
                      


                        break;
                    }
                case "تاريخ الولادة":
                    {
                        CurrentDataTable = ClsApplication._SearchByDateOfBirth(dtstartDate.Text, dtEndDate.Text);
                        if(CurrentDataTable!=null)
                        { 
                          _RefreshPeoplList(CurrentDataTable);
                          btnext.Enabled = true;
                          btback.Enabled = true;
                          lbPageNumber.Text = "1";
                        }
                        else
                        {
                            dgvallapp.DataSource = null;
                        }

                        break;
                    }
                case "تاريخ بدء العمل":
                    {
                        CurrentDataTable = ClsApplication.SearchByStartWorkDate(dtstartDate.Text, dtEndDate.Text);
                        if(CurrentDataTable!=null)
                        {

                        
                          _RefreshPeoplList(CurrentDataTable);
                          btnext.Enabled = true;
                          btback.Enabled = true;
                          lbPageNumber.Text = "1";
                        }
                        else
                        {
                            dgvallapp.DataSource = null;
                        }
                        break;
                    }
                case "تاريخ التعديل الأخير":
                    {
                        CurrentDataTable = ClsApplication.SearchByDateLastDateEdit(dtstartDate.Text, dtEndDate.Text);
                        if(CurrentDataTable!=null)
                        { 
                        _RefreshPeoplList(CurrentDataTable);
                        btnext.Enabled = true;
                        btback.Enabled = true;
                        lbPageNumber.Text = "1";
                        }
                        else
                        {
                            dgvallapp.DataSource = null;
                        }
                        break;
                    }
            }
        }

        private void rdPinned_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            DataView dv1 = dtallrecords.DefaultView;
            dv1.RowFilter = string.Format("[{0}] LIKE '{1}%'", "Applicationstatus", "طلب معلق");

            CurrentDataTable = dv1.ToTable();
            _RefreshPeoplList(CurrentDataTable);
            return;
        }

        private void rdAll_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            DataView dv1 = dtallrecords.DefaultView;
            dv1.RowFilter = "";
            CurrentDataTable = dv1.ToTable();
            _RefreshPeoplList(CurrentDataTable);
            return;
        }

        private void rdPrevious_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            DataView dv1 = dtallrecords.DefaultView;
            dv1.RowFilter = string.Format("[{0}] LIKE '{1}%'", "Applicationstatus", "طلب سابق");
            CurrentDataTable = dv1.ToTable();
            _RefreshPeoplList(CurrentDataTable);
            return;
        }

        private void rdUnAcceptable_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            DataView dv1 = dtallrecords.DefaultView;
            dv1.RowFilter = string.Format("[{0}] LIKE '{1}%' or [{2}] like '{3}%'", "Applicationstatus", "طلب مرفوض", "Applicationstatus", "طلب ملغى");
            CurrentDataTable = dv1.ToTable();
            _RefreshPeoplList(CurrentDataTable);
            return;

        }

        private void CbUN_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = dtallrecords.DefaultView;
            dv.RowFilter = "";
            pagenumber = 1;
            rdAll.Checked = true;
            if (CbUN.SelectedIndex == 0)
            {

                dv.RowFilter = string.Format("[{0}] = {1} ", "IsRegisterdUN", 0);

                CurrentDataTable = dv.ToTable();
                _RefreshPeoplList(CurrentDataTable);
                btnext.Enabled = true;
                btback.Enabled = true;
                lbPageNumber.Text = "1";
            }
            else
            {
                dv.RowFilter = string.Format("[{0}] = {1} ", "IsRegisterdUN", 1);

                CurrentDataTable = dv.ToTable();
                _RefreshPeoplList(CurrentDataTable);
                btnext.Enabled = true;
                btback.Enabled = true;
                lbPageNumber.Text = "1";
            }
        }
    }
}



