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
    public partial class DeleteUser : Form
    {
        UserRepository userRepository;
        ReportRepository reportRepository;
        internal DeleteUser(UserRepository u,ReportRepository r)
        {
            reportRepository = r;
            userRepository = u;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = Convert.ToInt32(txtuser.Text);
                userRepository.DeletUser(userId);
                MessageBox.Show("Delete Successfull.", "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch
            {
                MessageBox.Show("No Delete, Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowAdminPanel p = new ShowAdminPanel(userRepository, reportRepository);
            this.Hide();
            p.Show();
        }
    }
}
