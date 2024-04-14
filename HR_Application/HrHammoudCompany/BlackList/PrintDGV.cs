using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrHammoudCompany.BlackList
{
    public partial class PrintDGV : Form
    {
        public PrintDGV()
        {
            InitializeComponent();
        }
        //
        private void PrintDGV_Load(object sender, EventArgs e)
        {
           // string connectionString = ;

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString))
            {
                this.sp_GetAllBlackListRecordsTableAdapter.Connection = con;
                this.sp_GetAllBlackListRecordsTableAdapter.Fill(this.hr_HammoudCompanyDataSetBlackList.sp_GetAllBlackListRecords);
            }

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
