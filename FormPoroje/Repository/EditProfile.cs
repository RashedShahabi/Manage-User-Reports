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
    public partial class EditProfile : Form
    {
        UserRepository userRepository;
        List<User> users;  
        internal EditProfile(UserRepository re,List<User> u)
        {
            userRepository = re;
            users = u;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userId =Convert.ToInt32(txtuser.Text);
            var user = users.FirstOrDefault(t => t.UserId == userId && t.UserRole != Role.Admin);
            if (user != null)
            {
                label1.Text=user.UserName+" "+ user.Password+" "+ user.MobileNumber+ " " +user.Email;
                    
            }
            else
            {
                MessageBox.Show("User Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(txtuser.Text);
            var user = users.FirstOrDefault(t => t.UserId == userId && t.UserRole != Role.Admin);
            if (radioButton1.Checked)
            {
                user.UserName = textBox1.Text;
                MessageBox.Show("Your information etited.", "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            if (radioButton2.Checked)
            {
                user.Password = textBox1.Text;
                MessageBox.Show("Your information etited.", "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            if (radioButton3.Checked)
            {
                user.MobileNumber = textBox1.Text;
                MessageBox.Show("Your information etited.", "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            if (radioButton4.Checked)
            {
                user.Email = textBox1.Text;
                MessageBox.Show("Your information etited.", "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowEmployeePanel sh = new ShowEmployeePanel(userRepository);
            sh.Show();
            this.Hide();
        }
    }
}
