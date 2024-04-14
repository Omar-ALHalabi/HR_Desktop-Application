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
    public partial class PrintAppDaily : Form
    {
        public PrintAppDaily()
        {
            InitializeComponent();
        }

      

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void PrintAppDaily_Load(object sender, EventArgs e)
        {

        }
    }
}
