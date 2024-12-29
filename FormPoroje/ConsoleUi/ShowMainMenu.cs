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
    public partial class ShowMainMenu : Form
    {
        UserRepository userRepository;
         ReportRepository reportRepository;
        internal ShowMainMenu(UserRepository userRep, ReportRepository rep)
        {
            reportRepository = rep;
            userRepository = userRep;
            InitializeComponent();
        }
        //internal ShowMainMenu(UserRepository userRep)
        //{
        //    userRepository = userRep;
        //    InitializeComponent();
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserForm us = new UserForm(userRepository, reportRepository);
            us.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm us = new AdminForm(userRepository, reportRepository);
            us.Show();
            this.Hide();
        }

        private void ShowMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
