using FormPoroje.ConsoleUi;
using FormPoroje.Models;
using FormPoroje.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPoroje
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserRepository userRepository = new UserRepository();
            ReportRepository reportRepository = new ReportRepository();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ShowMainMenu(userRepository, reportRepository));
        }
    }
}
