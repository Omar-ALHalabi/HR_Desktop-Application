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
    public partial class PrintHealthyForm : Form
    {
        public PrintHealthyForm()
        {
            InitializeComponent();
        }

        private void PrintHealthyForm_Load(object sender, EventArgs e)
        {
           
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
