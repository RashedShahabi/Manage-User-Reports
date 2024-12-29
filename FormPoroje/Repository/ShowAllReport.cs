using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormPoroje.ConsoleUi;
using FormPoroje.Models;
using FormPoroje.Repository;
namespace FormPoroje.Repository
{
    public partial class ShowAllReport : Form
    {
        List<Report> Reports;
        int userId;
        internal ShowAllReport(List<Report> Rep, int uId)
        {
            Reports = Rep;
            userId = uId;
            InitializeComponent();
        }

        private void ShowAllReport_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ReportId", 50);
            listView1.Columns.Add("ReportDate",150);
            listView1.Columns.Add("UserId", 70);
            listView1.Columns.Add("ReportText", 150);
            for (int i = 0; i < Reports.Count; i++)
            {
                string[] arr = { Reports[i].ReportId.ToString(), Reports[i].ReportDate.ToString(), Reports[i].UserId.ToString(), Reports[i].ReportText.ToString() };
                ListViewItem itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }

        }
    }
}
