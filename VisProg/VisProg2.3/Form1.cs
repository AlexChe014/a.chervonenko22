using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisProg2._3
{
    public partial class Form1 : Form
    {
        ColorDialog colorDialog = new ColorDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                label3.BackColor = colorDialog.Color;
                this.BackColor = colorDialog.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wid = Convert.ToInt32(textBox1.Text);
            int hei = Convert.ToInt32(textBox2.Text);
            if (wid >= 400) this.Width = wid;
            if (hei >= 300) this.Height = hei;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Opacity = Convert.ToDouble(numericUpDown1.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.Opacity = Convert.ToDouble(numericUpDown1.Value) / 100;
        }
    }
}
