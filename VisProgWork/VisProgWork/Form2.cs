using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisProgWork
{
    public partial class Form2 : Form
        
    {
        int check = 0;
        Form3 f3 = new Form3();
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = imageList1.Images[0];
            check = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = imageList1.Images[1];
            check = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = imageList1.Images[2];
            check = 3;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
             if (radioButton1.Checked) button1.BackgroundImage = imageList1.Images[0];
             else if (radioButton2.Checked) button1.BackgroundImage = imageList1.Images[1];
             else if (radioButton3.Checked) button1.BackgroundImage = imageList1.Images[2];
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = imageList1.Images[check - 1];
            groupBox1.Visible = false;
            pictureBox1.Visible = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            f3.Show();
            this.Hide();
            timer1.Enabled = false;
        }
    }
}
