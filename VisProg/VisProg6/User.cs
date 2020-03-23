using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace VisProg6
{
    public class User
    {
        public string login { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public User (string login, string password)
        {
            this.login = login;
            this.password = password;
        }
        public User(string str)
        {
            string[] array = str.Split(' ');
            this.login = array[0].Trim();
            this.password = array[1].Trim();
            this.role = array[2].Trim();
        }
        public void CheckUser()
        {
            StreamReader sr = new StreamReader(@"users.txt");
            bool check = false;
            string str;
            int i = 0;
            while ((str = sr.ReadLine()) != null)
            {
                
                User user = new User(str);
                if ((user.login == this.login) && (user.password == this.password))
                {
                    check = true;
                    Form2 f2 = new Form2();
                    f2.Text = user.role;
                    f2.line = i;
                    f2.user = user;
                    f2.Show();
                    break;
                }
                i++;
                
            }
            sr.Close();
            if (!check) MessageBox.Show("Неверный логин или пароль");
            
        }
        public void ChangePassword(string newPass, int line)
        {
            string[] str;
            string[] lines = File.ReadAllLines(@"users.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                if (line == i)
                {
                    str = lines[i].Split(' ');
                    lines[i] = $"{str[0]} {newPass} {str[2]}";
                }
            }
            File.WriteAllLines(@"users.txt", lines);
        }
    }
}
