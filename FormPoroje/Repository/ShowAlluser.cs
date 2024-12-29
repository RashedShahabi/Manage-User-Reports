using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormPoroje.Models;
using FormPoroje.Repository;
namespace FormPoroje.Repository
{
    public partial class ShowAlluser : Form
    {
        List<User> users;
        internal ShowAlluser(List<User> user)
        {
            users = user;
            InitializeComponent();
        }

        private void ShowAlluser_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("UserId", 50);
            listView1.Columns.Add("UserName", 90);
            listView1.Columns.Add("UserRole", 90);
            listView1.Columns.Add("IsActive", 90);
            for (int i = 0; i < users.Count; i++)
            {
                string[] arr = { users[i].UserId.ToString(), users[i].UserName.ToString() ,users[i].UserRole.ToString(),users[i].IsActive.ToString()};
                ListViewItem itm= new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
        }
    }
}
