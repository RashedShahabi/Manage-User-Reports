using FormPoroje.ConsoleUi;
using FormPoroje.Models;
using FormPoroje.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPoroje
{
    public partial class UserForm : Form
    {
        UserRepository userRepository;
        ReportRepository reportRepository;
        internal UserForm(UserRepository userRep, ReportRepository rep)
        {
            reportRepository = rep; ;
            userRepository = userRep;
            InitializeComponent();
        }       
        private void button1_Click(object sender, EventArgs e)
        {
            User user1 = userRepository.GetUser(txtuser.Text, txtpass.Text);
             bool userLogined2 = userRepository.Login(txtuser.Text, txtpass.Text);

             if (!userLogined2 || user1.UserRole != Role.User)
             {
                 MessageBox.Show("Correct Username or Password...");
                 ShowMainMenu sh = new ShowMainMenu(userRepository, reportRepository);
                 sh.Show();
                   this.Hide();
             }
             else
             {
                 ShowEmployeePanel sh = new ShowEmployeePanel(user1, reportRepository,userRepository);
                 sh.Show();
                 this.Hide();
             }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
