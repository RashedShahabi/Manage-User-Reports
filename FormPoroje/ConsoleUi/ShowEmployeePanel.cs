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
    public partial class ShowEmployeePanel : Form
    {
        User users;
         ReportRepository reportRepository;
         UserRepository userRepository;
         internal ShowEmployeePanel(User u, ReportRepository rep, UserRepository us)
        {
            reportRepository = rep;
            users = u;
            userRepository = us;
            InitializeComponent();
        }
         internal ShowEmployeePanel(UserRepository us)
         {
             userRepository = us;
             InitializeComponent();
         }
        
        private void button1_Click(object sender, EventArgs e)
        {
            RegisterReport r = new RegisterReport(users, reportRepository,userRepository);
            r.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reportRepository.ShowAllRrportByUserId(users.UserId);
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            userRepository.EditProfile(userRepository);
        }

        private void ShowEmployeePanel_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowMainMenu sh = new ShowMainMenu(userRepository,reportRepository);
           // ShowAdminPanel sh = new ShowAdminPanel(userRepository, reportRepository); 
            this.Hide();
           sh.Show();
        }
    }
}
