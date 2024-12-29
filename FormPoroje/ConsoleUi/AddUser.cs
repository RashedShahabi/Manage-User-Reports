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
    public partial class AddUser : Form
    {
        UserRepository userRepository;
        ReportRepository reportRepository;
        internal AddUser(UserRepository u,ReportRepository r)
        {
            reportRepository = r;
            userRepository = u;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();            //ایجاد کاربر جدید  
                user.UserId = userRepository.GetNewId();
                user.UserName = txtuser.Text;
                user.Password = txtpass.Text;
                user.MobileNumber = txtmobile.Text;
                user.Email = txtemail.Text;
                user.IsActive = true;
                user.UserRole = Role.User;
                userRepository.AddEmployee(user);
                MessageBox.Show("Insert Successful.", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowAdminPanel p = new ShowAdminPanel(userRepository, reportRepository);
                this.Hide();
                p.Show();

            }
            catch
            {
                MessageBox.Show("Please Enter Correcrt Information", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
