using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisProgWorK3
{
    public partial class Form3 : Form
    {
        public controshaEntities db = new controshaEntities();
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = (from ad in db.adresats
                         select ad).ToList();
            dataGridView1.DataSource = query;
        }
    }
}
