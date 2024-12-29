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

namespace FormPoroje.ConsoleUi
{
    public partial class RegisterReport : Form
    {
        User users;
        ReportRepository reportRepository;
        UserRepository userRepository ;
        internal RegisterReport(User  us,ReportRepository rep, UserRepository  usee )
        {
            userRepository = usee;
            users = us;
            reportRepository=rep;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ReportId = reportRepository.GetNewReportId();
            report.UserId = users.UserId;
            report.ReportDate = DateTime.Now;
            report.ReportText = txt.Text;
            bool flag = reportRepository.RegisterReport(report);
            if (flag == true)
            {
                MessageBox.Show("Register Report Successful.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt.Text = " ";
            }
            else
            {
                MessageBox.Show("Register Report Faild.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowEmployeePanel sh = new ShowEmployeePanel(users,reportRepository,userRepository);
            sh.Show();
            this.Hide();
        }
    }
}
