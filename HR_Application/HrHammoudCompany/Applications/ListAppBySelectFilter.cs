using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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
    public partial class ListAppBySelectFilter : Form
    {
        bool IsEmployees;
        short pagenumber;
        int reminder;
        int numberofrecords;
        string Status = "";
        public ListAppBySelectFilter(bool islistemployees)
        {
            InitializeComponent();
            IsEmployees = islistemployees;
            pagenumber = 1;


        }
       
        private DataTable _dtAllAppChooses;
        private DataTable currentDataTable=new DataTable();
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
                numrows.Text = dt.Rows.Count.ToString();


            }
            catch
            {

                pagedTable = null;
                numrows.Text = "0";


            }


            return pagedTable;
        }

        private void IsListEmployees(bool istrue)
        {
        
            if (istrue)
            {
                Status = "طلب مقبول";
                numberofrecords =ClsApplication.GetNumberOfRecordsAppByStatus("طلب مقبول");
                _dtAllAppChooses = ClsApplication.GetAppBySelectStatus("طلب مقبول");
                LbTitle.Text = "الموظفين";
                this.Text = "الطلبات المقبولة";
               
                _checkLastUpdate();
                DgvEmployees.ContextMenuStrip = cmspinnedapp;
            }else
            {
                Status = "طلب معلق";
                numberofrecords = ClsApplication.GetNumberOfRecordsAppByStatus("طلب معلق");
                _dtAllAppChooses = ClsApplication.GetAppBySelectStatus("طلب معلق");
                
                LbTitle.Text = "الطلبات المعلقة";
                this.Text = "طلبات قيد الدراسة";
            
                DgvEmployees.ContextMenuStrip = null;

            }


    }



        private void _checkLastUpdate()
        {//DataRow row in  dgvallapp.Rows
            for (int i = 0; i < DgvEmployees.Rows.Count; i++)
            {
                if (DateTime.Now.AddYears(-1) >= (DateTime)DgvEmployees.Rows[i].Cells[21].Value)
                {
                    DgvEmployees.Rows[i].DefaultCellStyle.BackColor = Color.Red;

                }
            }


        }
       
        private void _RefreshTable(DataTable _curreentDt)
        {
            _curreentDt = GetPagedTable(_curreentDt, 11, pagenumber);


            if (_curreentDt != null)
            {
                _curreentDt = _curreentDt.DefaultView.ToTable(false, "ID", "FirstName", "FatherName", "FamilyName", "MotherName", "Nationality", "BloodType", "BirthPlace", "DateBirth",
                "PersonalPhone", "Department", "WorkHours", "MaritalStatus", "AcademyLevel", "Experiences", "NumChildren", "Certificate", "Languages", "IsRegisterdUN", "DateOfApplication", "WorkStartDate", "EditLastDate", "Applicationstatus");
                DgvEmployees.DataSource = _curreentDt;

                DgvEmployees.Columns[0].HeaderText = "الرقم الوظيفي";
                DgvEmployees.Columns[0].Width = 90;

                DgvEmployees.Columns[1].HeaderText = "الإسم الأول";
                DgvEmployees.Columns[1].Width = 90;

                DgvEmployees.Columns[2].HeaderText = "إسم الأب";
                DgvEmployees.Columns[2].Width = 90;

                DgvEmployees.Columns[3].HeaderText = "إسم العائلة";
                DgvEmployees.Columns[3].Width = 90;

                DgvEmployees.Columns[4].HeaderText = "إسم الأم";
                DgvEmployees.Columns[4].Width = 140;

                DgvEmployees.Columns[5].HeaderText = "الجنسية";
                DgvEmployees.Columns[5].Width = 120;


                DgvEmployees.Columns[6].HeaderText = "فئة الدم";
                DgvEmployees.Columns[6].Width = 40;



                DgvEmployees.Columns[7].HeaderText = "محل الولادة";
                DgvEmployees.Columns[7].Width = 100;

                DgvEmployees.Columns[8].HeaderText = "تاريخ الولادة";
                DgvEmployees.Columns[8].Width = 80;

                DgvEmployees.Columns[9].HeaderText = "رقم الهاتف";
                DgvEmployees.Columns[9].Width = 100;

                DgvEmployees.Columns[10].HeaderText = "القسم";
                DgvEmployees.Columns[10].Width = 100;

                DgvEmployees.Columns[11].HeaderText = "ساعات العمل";
                DgvEmployees.Columns[11].Width = 70;


                DgvEmployees.Columns[12].HeaderText = "الوضع العائلي";
                DgvEmployees.Columns[12].Width = 90;

                DgvEmployees.Columns[13].HeaderText = "المستوى العلمي";
                DgvEmployees.Columns[13].Width = 80;

                DgvEmployees.Columns[14].HeaderText = "الخبرات";
                DgvEmployees.Columns[14].Width = 100;

                DgvEmployees.Columns[15].HeaderText = "عدد الأولاد";
                DgvEmployees.Columns[15].Width = 100;


                DgvEmployees.Columns[16].HeaderText = "الشهادات";
                DgvEmployees.Columns[16].Width = 100;

                DgvEmployees.Columns[17].HeaderText = "اللغات";
                DgvEmployees.Columns[17].Width = 170;


                DgvEmployees.Columns[18].HeaderText = "مسجل أمم؟";
                DgvEmployees.Columns[18].Width = 50;

                DgvEmployees.Columns[19].HeaderText = "تاريخ تقديم الطلب";
                DgvEmployees.Columns[19].Width = 70;

                DgvEmployees.Columns[20].HeaderText = "تاريخ بدء العمل";
                DgvEmployees.Columns[20].Width = 70;

                DgvEmployees.Columns[21].HeaderText = "تاريخ التعديل الأخير";
                DgvEmployees.Columns[21].Width = 70;

                DgvEmployees.Columns[22].HeaderText = "حالة الطلب";
                DgvEmployees.Columns[22].Width = 70;
                numberofrecords = int.Parse(numrows.Text);
            }
            else
            {
                DgvEmployees.DataSource = null;
                numberofrecords = 0;
            }

        }
        private void ListEmployees_Load(object sender, EventArgs e)
        {


            IsListEmployees(IsEmployees);
           

            if (_dtAllAppChooses != null)
            {
                currentDataTable = GetPagedTable(_dtAllAppChooses, 11, pagenumber);
                currentDataTable = currentDataTable.DefaultView.ToTable(false, "ID", "FirstName", "FatherName", "FamilyName", "MotherName", "Nationality", "BloodType", "BirthPlace", "DateBirth",
              "PersonalPhone", "Department", "WorkHours", "MaritalStatus", "AcademyLevel", "Experiences", "NumChildren", "Certificate", "Languages", "IsRegisterdUN", "DateOfApplication", "WorkStartDate", "EditLastDate", "Applicationstatus");
                DgvEmployees.DataSource = currentDataTable;

                cbSearch.SelectedIndex = 0;


                DgvEmployees.Columns[0].HeaderText = "الرقم الوظيفي";
                DgvEmployees.Columns[0].Width = 90;

                DgvEmployees.Columns[1].HeaderText = "الإسم الأول";
                DgvEmployees.Columns[1].Width = 90;

                DgvEmployees.Columns[2].HeaderText = "إسم الأب";
                DgvEmployees.Columns[2].Width = 90;

                DgvEmployees.Columns[3].HeaderText = "إسم العائلة";
                DgvEmployees.Columns[3].Width = 90;

                DgvEmployees.Columns[4].HeaderText = "إسم الأم";
                DgvEmployees.Columns[4].Width = 140;

                DgvEmployees.Columns[5].HeaderText = "الجنسية";
                DgvEmployees.Columns[5].Width = 120;


                DgvEmployees.Columns[6].HeaderText = "فئة الدم";
                DgvEmployees.Columns[6].Width = 40;



                DgvEmployees.Columns[7].HeaderText = "محل الولادة";
                DgvEmployees.Columns[7].Width = 100;

                DgvEmployees.Columns[8].HeaderText = "تاريخ الولادة";
                DgvEmployees.Columns[8].Width = 80;

                DgvEmployees.Columns[9].HeaderText = "رقم الهاتف";
                DgvEmployees.Columns[9].Width = 100;

                DgvEmployees.Columns[10].HeaderText = "القسم";
                DgvEmployees.Columns[10].Width = 100;

                DgvEmployees.Columns[11].HeaderText = "ساعات العمل";
                DgvEmployees.Columns[11].Width = 70;


                DgvEmployees.Columns[12].HeaderText = "الوضع العائلي";
                DgvEmployees.Columns[12].Width = 90;

                DgvEmployees.Columns[13].HeaderText = "المستوى العلمي";
                DgvEmployees.Columns[13].Width = 80;

                DgvEmployees.Columns[14].HeaderText = "الخبرات";
                DgvEmployees.Columns[14].Width = 100;

                DgvEmployees.Columns[15].HeaderText = "عدد الأولاد";
                DgvEmployees.Columns[15].Width = 100;


                DgvEmployees.Columns[16].HeaderText = "الشهادات";
                DgvEmployees.Columns[16].Width = 100;

                DgvEmployees.Columns[17].HeaderText = "اللغات";
                DgvEmployees.Columns[17].Width = 170;


                DgvEmployees.Columns[18].HeaderText = "مسجل أمم؟";
                DgvEmployees.Columns[18].Width = 50;

                DgvEmployees.Columns[19].HeaderText = "تاريخ تقديم الطلب";
                DgvEmployees.Columns[19].Width = 70;

                DgvEmployees.Columns[20].HeaderText = "تاريخ بدء العمل";
                DgvEmployees.Columns[20].Width = 70;

                DgvEmployees.Columns[21].HeaderText = "تاريخ التعديل الأخير";
                DgvEmployees.Columns[21].Width = 70;

                DgvEmployees.Columns[22].HeaderText = "حالة الطلب";
                DgvEmployees.Columns[22].Width = 70;

                numrows.Text = numberofrecords.ToString();
                btnext.Enabled = (numberofrecords - (pagenumber * 11)) > 0;
                btback.Enabled = pagenumber > 1;
            }else
            {
                DgvEmployees.DataSource = null;
            }

            currentDataTable = _dtAllAppChooses;
        }


        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

           if(cbSearch.Text == "لا شيء")
            {
                tbSearch.Visible = false;
                ListEmployees_Load(null,null);
                btSearch.Visible = false;
                CbUN.Visible = false;
                lbForm.Visible = false;
                lbto.Visible = false;
                dtstartDate.Visible = false;
                dtEndDate.Visible = false;
               
                return;

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

          
           

            if (cbSearch.Text== "تاريخ الولادة"|| cbSearch.Text== "تاريخ تقديم الطلب" || cbSearch.Text== "تاريخ بدء العمل"|| cbSearch.Text == "تاريخ التعديل الأخير")
            {
              
                tbSearch.Visible = false;
                lbForm.Visible = true;
                lbto.Visible = true;
                dtstartDate.Visible = true;
                dtEndDate.Visible = true;
                btSearch.Visible = true;
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
                CbUN.Visible = false;
                dtEndDate.Visible = false;
                tbSearch.Text = "";
                tbSearch.Focus();
                return;

            }
           

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dt = _dtAllAppChooses.DefaultView;
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
                case "تاريخ الولادة":
                    filterColumn = "DateBirth";
                    break;
                case "محل الولادة":
                    filterColumn = "BirthPlace";
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

                case "الخبرات":
                    filterColumn = "Experiences";
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


            if (string.IsNullOrEmpty(tbSearch.Text.Trim()) || cbSearch.Text == "لا شيء")
            {

                dt.RowFilter = "";
                currentDataTable = dt.ToTable();
                _RefreshTable(currentDataTable);
                btnext.Enabled = true;
                btback.Enabled = true;
                lbPageNumber.Text = "1";
                _checkLastUpdate();
                return;
            }
               
            


            switch (filterColumn)
            {
                case "ID":
                    {
                       
                        dt.RowFilter = string.Format("[{0}] = {1} ", filterColumn, tbSearch.Text.Trim());
                        currentDataTable = dt.ToTable();
                        _RefreshTable(currentDataTable);
                        btnext.Enabled = true;
                        btback.Enabled = true;
                        lbPageNumber.Text = "1";
                        break;
                    }
                case "NumChildren":
                    {
                        dt.RowFilter= string.Format("[{0}] = {1} ", filterColumn, tbSearch.Text.Trim());
                        currentDataTable = dt.ToTable();
                        _RefreshTable(currentDataTable);
                        btnext.Enabled = true;
                        btback.Enabled = true;
                        lbPageNumber.Text = "1";
                        break;
                    }
              
                default:
                    {
                      dt.RowFilter= string.Format("[{0}] LIKE '{1}%' ", filterColumn, tbSearch.Text.Trim());
                        currentDataTable = dt.ToTable();
                        _RefreshTable(currentDataTable);
                        btnext.Enabled = true;
                        btback.Enabled = true;
                        lbPageNumber.Text = "1";

                        break;
                    }

            }
               

            _checkLastUpdate();




        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
           


                if (cbSearch.Text == "الرقم الوظيفي" || cbSearch.Text == "عدد الأولاد")
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            
        }

        private void طلبالتوظيفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_EdiitApplication app = new Add_EdiitApplication((int)DgvEmployees.CurrentRow.Cells[0].Value, true);

            app.ShowDialog();
        }

        private void تعديلالطلبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_EdiitApplication app = new Add_EdiitApplication((int)DgvEmployees.CurrentRow.Cells[0].Value);

            app.ShowDialog();
            ListEmployees_Load(null,null);
        }

        private void توجيهإنذارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fullname = Convert.ToString(DgvEmployees.CurrentRow.Cells[1].Value + " " + DgvEmployees.CurrentRow.Cells[2].Value + " " + DgvEmployees.CurrentRow.Cells[3].Value);
            ListWarnings frm = new ListWarnings((int)DgvEmployees.CurrentRow.Cells[0].Value, fullname);
            frm.Show();
        }

        private void إعطاءإجازةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fullname = (string)DgvEmployees.CurrentRow.Cells[1].Value + " " + DgvEmployees.CurrentRow.Cells[2].Value + " " + DgvEmployees.CurrentRow.Cells[3].Value;

            AddVaccations frm = new AddVaccations((int)DgvEmployees.CurrentRow.Cells[0].Value, fullname);
            frm.Show();
        }

        private void سجلالعملياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDocuments frm = new ManageDocuments((int)DgvEmployees.CurrentRow.Cells[0].Value);
            frm.Show();

        }

        private void الإفاداتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fullname = (string)DgvEmployees.CurrentRow.Cells[1].Value + " " + DgvEmployees.CurrentRow.Cells[2].Value + " " + DgvEmployees.CurrentRow.Cells[3].Value;

            ListStatement frm = new ListStatement((int)DgvEmployees.CurrentRow.Cells[0].Value, fullname);
            frm.Show();
        }

        private void سجلالعملياتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManageArchive form =new ManageArchive((int)DgvEmployees.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void DgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DgvEmployees_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         
            _checkLastUpdate();
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            reminder = numberofrecords - (pagenumber * 11);


            if (reminder > 11)
            {
                pagenumber++;
                _RefreshTable(currentDataTable);
                btback.Enabled = true;


            }
            else if (reminder > 0 )

            {
                pagenumber++;
                _RefreshTable(currentDataTable);
                btnext.Enabled = false;
                btback.Enabled = true;

            }
            else
            {
                btnext.Enabled = false;

            }


            lbPageNumber.Text = pagenumber.ToString();
        }

        private void btback_Click(object sender, EventArgs e)
        {
            if (btnext.Enabled == false)
            {
                btnext.Enabled = true;
            }

            if (pagenumber > 1)
            { 
                pagenumber--;
                _RefreshTable(currentDataTable);
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
                        currentDataTable = ClsApplication._SearchByDateOfApp(dtstartDate.Text, dtEndDate.Text,Status);
                        if (currentDataTable != null)
                        {
                            _RefreshTable(currentDataTable);
                            btnext.Enabled = true;
                            btback.Enabled = true;
                            lbPageNumber.Text = "1";
                        }
                        else
                        {
                            DgvEmployees.DataSource = null;
                        }


                        break;
                    }
                case "تاريخ الولادة":
                    {
                        currentDataTable = ClsApplication._SearchByDateOfBirth(dtstartDate.Text, dtEndDate.Text, Status);
                        if (currentDataTable != null)
                        {
                            _RefreshTable(currentDataTable);
                            btnext.Enabled = true;
                            btback.Enabled = true;
                            lbPageNumber.Text = "1";
                        }
                        else
                        {
                            DgvEmployees.DataSource = null;
                        }

                        break;
                    }
                case "تاريخ بدء العمل":
                    {
                        currentDataTable = ClsApplication.SearchByStartWorkDate(dtstartDate.Text, dtEndDate.Text, Status);
                        if (currentDataTable != null)
                        {
                            _RefreshTable(currentDataTable);
                            btnext.Enabled = true;
                            btback.Enabled = true;
                            lbPageNumber.Text = "1";
                        }
                        else
                        {
                            DgvEmployees.DataSource = null;
                        }


                        break;
                    }
                case "تاريخ التعديل الأخير":
                    {
                        currentDataTable = ClsApplication.SearchByDateLastDateEdit(dtstartDate.Text, dtEndDate.Text, Status);
                        if (currentDataTable != null)
                        {
                            _RefreshTable(currentDataTable);
                            btnext.Enabled = true;
                            btback.Enabled = true;
                            lbPageNumber.Text = "1";
                        }
                        else
                        {
                            DgvEmployees.DataSource = null;
                        }


                        break;
                    }
            }
        }

        private void CbUN_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = _dtAllAppChooses.DefaultView;
            dv.RowFilter = "";
            pagenumber = 1;
            
            if (CbUN.SelectedIndex == 0)
            {

                dv.RowFilter = string.Format("[{0}] = {1} ", "IsRegisterdUN", 0);

                currentDataTable = dv.ToTable();
                _RefreshTable(currentDataTable);
                btnext.Enabled = true;
                btback.Enabled = true;
                lbPageNumber.Text = "1";
            }
            else
            {
                dv.RowFilter = string.Format("[{0}] = {1} ", "IsRegisterdUN", 1);

                currentDataTable = dv.ToTable();
                _RefreshTable(currentDataTable);
                btnext.Enabled = true;
                btback.Enabled = true;
                lbPageNumber.Text = "1";
            }

        }

             

          
            
    }
    
}
