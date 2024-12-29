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
    public partial class AdminForm : Form
    {
        UserRepository userRepository;
        ReportRepository reportRepository;
        internal AdminForm(UserRepository userRep,ReportRepository r)
        {
            reportRepository = r;
             userRepository =userRep;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            User user1 = userRepository.GetUser(txtuser.Text, txtpass.Text);
            bool userLogined2 = userRepository.Login(txtuser.Text, txtpass.Text);

            if (!userLogined2)
            {
                MessageBox.Show("Correct Username or Password....", "....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowAdminPanel sh1 = new ShowAdminPanel(userRepository, reportRepository);
                sh1.Show();
                this.Close();
            }
            else
            {
                ShowAdminPanel sh = new ShowAdminPanel(userRepository, reportRepository);
                sh.Show();
                this.Hide();
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
