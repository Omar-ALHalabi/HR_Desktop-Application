using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBuisnessLayerHrHammoud;

namespace HrHammoudCompany.Vacations
{
    public partial class LogVaccations : Form
    {
        public LogVaccations()
        {
            InitializeComponent();
        }
        int pagenumber=1;
        int numberofrecords;
        DataTable dt = new DataTable();
        int reminderRecords;
        private void LogVaccations_Load(object sender, EventArgs e)
        {
             numberofrecords = ClsVaccations._NumberOfRecords();
            NumberRecords.Text = numberofrecords.ToString();
            dt = ClsVaccations._logVaccations(pagenumber);
            if(dt!=null)
            {
             
                dt = dt.DefaultView.ToTable(false, "VaccationID", "EmploymentName", "dateOfApplication");
                dataGridView3.DataSource = dt;

                dataGridView3.Columns[0].HeaderText = "رقم الإجازة";
     
                dataGridView3.Columns[1].HeaderText = "الإسم الثلاثي";
        
                dataGridView3.Columns[2].HeaderText = "تاريخ الإدخال";
         


            }


            btnext.Enabled = numberofrecords / pagenumber > 15;
            btback.Enabled = pagenumber > 1;
            lbPageNumber.Text = pagenumber.ToString();
        }

        private void btnext_Click(object sender, EventArgs e)
        {
            reminderRecords = numberofrecords - (pagenumber * 11);


            if (reminderRecords > 11)
            {
                pagenumber++;
                LogVaccations_Load(null, null);
                //  btnext.Enabled = false;


            }
            else if (reminderRecords > 0 && reminderRecords <= 1)

            {
                pagenumber++;
                LogVaccations_Load(null, null);
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
                LogVaccations_Load(null, null);
            }
            else
            {
                btback.Enabled = false;
            }

            lbPageNumber.Text = pagenumber.ToString();
        }
    }
}
