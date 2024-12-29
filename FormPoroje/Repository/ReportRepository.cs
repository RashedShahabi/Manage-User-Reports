using FormPoroje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPoroje.Repository
{
    class ReportRepository
    {
        private List<Report> Reports;


        public ReportRepository()
        {
            Reports = new List<Report>();
        }

        public bool RegisterReport(Report report)
        {
            try
            {
                Reports.Add(report);
                Console.WriteLine("Report Registered...");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public void ShowAllRrportByUserId(int userId)
        {
            ShowAllReport rp = new ShowAllReport(Reports,userId);
            rp.Show();
           // Reports.Where(t => t.UserId == userId).ToList().ForEach(report => Console.Write(report));
            //Console.ReadKey();
        }


        public int GetNewReportId()                //تولید آیدی جدید
        {
            int id = 0;
            if (Reports.Count > 0)
            {
                id = Reports.Last().ReportId + 1;
            }
            return id + 1;
        }
    }
}
