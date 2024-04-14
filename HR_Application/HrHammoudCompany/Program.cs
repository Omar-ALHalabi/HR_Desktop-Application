using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HrHammoudCompany.Applications;
using HrHammoudCompany.BlackList;
using HrHammoudCompany.Statements;

namespace HrHammoudCompany
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoggingScreen());
            Application.Run(new LoggingScreen());


         
        }
    }
}