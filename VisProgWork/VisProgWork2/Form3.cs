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
    public partial class Form3 : Form
    {
        public contEntities db = new contEntities();
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
            var groups = (from g in db.s_in_group
                          select g.group_num).ToList();
            int gr_id = db.s_in_group.Max(p => p.id_group) + 1;
            int gr_num = 1;
            if (!groups.Contains((int)numericUpDown2.Value))
            {
                gr_num = (int)numericUpDown2.Value;
                s_in_group new_g = new s_in_group
                {
                    id_group = gr_id,
                    kurs_num = (int)numericUpDown1.Value,
                    group_num = gr_num
                };
                db.s_in_group.Add(new_g);
                db.SaveChanges();
                this.Close();
            }
            else MessageBox.Show("Такая группа уже существует");


        }
    }
}
