using FormPoroje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPoroje.Repository
{
    class UserRepository
    {
        private List<User> users;           //مثل دیتابیس//گرفتن حافظه

        public UserRepository()
        {
            users = new List<User>();       //اختصاص دادن حافظه

            users.Add(new User()            //ایجاد یک مدیر
            {
                UserId = 1,
                UserName = "admin",
                Password = "123",
                MobileNumber = "09120052976",
                Email = "r.shahabi@gmail.com",
                IsActive = true,
                UserRole = Role.Admin

            });


        }

        public void AddEmployee(User user)      //اضافه کردن کاربر
        {
            users.Add(user);
            Console.WriteLine("User Register...");
        }

        public void DeletUser(int userId)      //حذف کاربر
        {
            var user = users.FirstOrDefault(t => t.UserId == userId && t.UserRole != Role.Admin);
            if (user != null)
            {
                users.Remove(user);
                Console.WriteLine("User Deleted...");
            }
            else
            {
                Console.WriteLine("Not Found...");
            }
        }

        public void ShowAllUser()             //نمایش کاربران
        {
            ShowAlluser sh = new ShowAlluser(users);
            sh.Show();
        }

        public int GetUsersCount()           //نمایش تعداد کاربران
        {
            return users.Count;
        }


        public bool Login(string userName, string password)        //اهراز هویت
        {
            return users.Any(t => t.UserName.Equals(userName) && t.Password.Equals(password));
        }


        public User GetUser(string userName, string password)        //
        {
            return users.FirstOrDefault(t => t.UserName.Equals(userName) && t.Password.Equals(password));
        }


        public int GetNewId()                //تولید آیدی جدید
        {
            return users.Last().UserId + 1;
        }

        public void EditProfile(UserRepository r)
        {
            EditProfile ed = new EditProfile(r,users);
            ed.Show();
            
           

        }
    }
}
