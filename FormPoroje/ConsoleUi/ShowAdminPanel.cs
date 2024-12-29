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
    public partial class ShowAdminPanel : Form
    {
        UserRepository userRepository = new UserRepository();
        ReportRepository reportRepository;
        internal ShowAdminPanel(UserRepository u,ReportRepository r)
        {
            reportRepository = r;
            userRepository = u;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteUser d = new DeleteUser(userRepository, reportRepository);
            d.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            userRepository.ShowAllUser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddUser ad = new AddUser(userRepository, reportRepository);
            ad.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowMainMenu sh = new ShowMainMenu(userRepository,reportRepository);
            sh.Show();
            this.Hide();
        }

        private void ShowAdminPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
