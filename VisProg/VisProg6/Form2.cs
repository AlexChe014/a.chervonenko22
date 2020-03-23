using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisProg6
{
    public partial class Form2 : Form
    {
        public int line;
        public User user;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.ChangePassword(textBox1.Text, line);
            this.Hide();
        }
    }
}
