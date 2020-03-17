using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisProg3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult aResult;
            Form2 aForm = new Form2();
            aResult = aForm.ShowDialog();
            if (aResult == DialogResult.OK)
            {
                MessageBox.Show("Your name: " + aForm.textBox1.Text + " " + aForm.textBox2.Text + 
                    "\nYour address: " + aForm.textBox3.Text + "\nYour phone: " + aForm.maskedTextBox1.Text);
            }
            linkLabel1.LinkVisited = true;
        }
    }
}
