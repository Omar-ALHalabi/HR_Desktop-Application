using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrHammoudCompany.Applications
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportViewer1Resignation.RefreshReport();
            reportViewer1.Visible = false;
            reportViewer1Resignation.Visible = true;
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reportViewer1Resignation.Visible = false;
            reportViewer1.Visible = true;
            reportViewer1.RefreshReport();
        }

        private void Print_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
