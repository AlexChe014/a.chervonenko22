using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisProgWork2
{
    public partial class Form1 : Form
    {
        public string login, password;
        public Form1()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login = textBox1.Text;
            password = textBox2.Text;
            if (login == "user" && password == "password")
            {
                Form2 f2 = new Form2();
                f2.Owner = this;
                f2.Show();
                this.Hide();
            }
            else MessageBox.Show("Ошибка авторизации");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
