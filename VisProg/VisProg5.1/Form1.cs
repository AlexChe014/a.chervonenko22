using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisProg5._1
{
    public partial class Form1 : Form
    {
        int time, min = 0, sec = 0;
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button2.Visible = false;
            button1.Visible = true;
            groupBox1.Visible = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            min = Convert.ToInt32(numericUpDown1.Value);
            if (min == 0 && sec == 0)
                button1.Enabled = false;
            else button1.Enabled = true;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            sec = Convert.ToInt32(numericUpDown2.Value);
            if (min == 0 && sec == 0)
                button1.Enabled = false;
            else button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            time = 60 * min + sec;
            groupBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label1.Text = string.Format($"{time / 60:d2}:{time % 60:d2}");
            if (time == 0)
            {
                timer1.Enabled = false;
                button1.Text = "Пуск";
                groupBox1.Visible = true;
                button1.Visible = true;
                button2.Visible = false;
                MessageBox.Show("Время истекло!");
            }
            
            
        }
    }
}
