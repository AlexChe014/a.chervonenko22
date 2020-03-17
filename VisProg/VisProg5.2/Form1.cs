using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace VisProg5._2
{
    public partial class Form1 : Form
    {
        public int hour = 0, min = 0;
        public string text;
        DateTime now = DateTime.Now;
        DateTime dt = new DateTime();
        Form2 f2 = new Form2();
        public SoundPlayer player = new SoundPlayer("C:/Users/alexc/source/repos/VisProg/002.wav");
        public Form1()
        {
            Program.f1 = this;
            InitializeComponent();
            Program.f2.label2.Text = "WAKE UP, BASTARD!";
            button1.Enabled = false;
            timer1.Enabled = true;
            label2.Text = DateTime.Now.ToShortTimeString();
            notifyIcon1.ContextMenuStrip = new ContextMenuStrip();
            var mi = new ToolStripMenuItem("Показать");
            mi.Click += (o, e) =>
            {
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;
            };
            notifyIcon1.ContextMenuStrip.Items.Add(mi);
            var mi2 = new ToolStripMenuItem("Выход");
            mi2.Click += (o, e) => Application.Exit();
            notifyIcon1.ContextMenuStrip.Items.Add(mi2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortTimeString();
            now = DateTime.Now;
            if (dt.Hour == now.Hour && dt.Minute == now.Minute && dt.Second == now.Second)
            {
                f2.Show();
                player.Play();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                button1.Enabled = true;
                hour = Convert.ToInt32(numericUpDown1.Value);
                min = Convert.ToInt32(numericUpDown2.Value);
                dt = new DateTime(now.Year, now.Month, now.Day, hour, min, 0);
            }
            else
            {
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                button1.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Program.f2.label2.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
            
            notifyIcon1.Text = hour + ":" + min;
            text = textBox1.Text;
            Program.f2.label1.Text = dt.ToShortTimeString();
        }
    }
}
