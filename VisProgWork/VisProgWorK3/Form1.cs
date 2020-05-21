using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace VisProgWorK3
{
    
    public partial class Form1 : Form
    {
        int activePicture = 1;
        public controshaEntities db = new controshaEntities();
        public static bool isValid(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);

            if (isMatch.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text)) MessageBox.Show("Не заполнено имя");
            else
            {
                if (isValid(textBox3.Text) && isValid(textBox4.Text))
                {
                    Form2 f2 = new Form2(textBox1.Text, textBox3.Text, richTextBox1.Text, textBox2.Text, textBox4.Text, activePicture);
                    f2.Owner = this;
                    f2.Show();
                }
                else MessageBox.Show("Неверно введен e-mail!", "Ошибка");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            activePicture = 1;
            pictureBox2.Image = pictureBox3.Image = null;
            pictureBox1.Image = imageList1.Images[0];
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            activePicture = 2;
            pictureBox1.Image = pictureBox3.Image = null;
            pictureBox2.Image = imageList1.Images[1];
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            activePicture = 3;
            pictureBox1.Image = pictureBox2.Image = null;
            pictureBox3.Image = imageList1.Images[2];
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != 8 && l != 32)
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != 8 && l != 32)
                e.Handled = true;
        }
        public int new_id;
        private void button2_Click(object sender, EventArgs e)
        {
            int new_id = db.clients.Max(n => n.id_c) + 1;
            clients cl = new clients
            { 
                id_c = new_id,
                snp = label2.Text,
                email = textBox4.Text
            };
            db.clients.Add(cl);
            db.SaveChanges();
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.Show();

        }
    }
}
