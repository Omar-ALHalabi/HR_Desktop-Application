using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrHammoudCompany.Applications.PrintReports
{
    public partial class PrintAppMonthlyInCompany : Form
    {
        public PrintAppMonthlyInCompany()
        {
            InitializeComponent();
        }

        private void PrintAppMonthlyInCompany_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
       
        }
    }
}
