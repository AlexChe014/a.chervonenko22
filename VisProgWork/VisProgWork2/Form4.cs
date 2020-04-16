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
    public partial class Form4 : Form
    {
        public contEntities db = new contEntities();
        s_students item;
        public Form4(s_students group)
        {
            item = group;
            InitializeComponent();
            var groups = (from g in db.s_in_group
                          select g.group_num).Distinct();
            foreach (var it in groups)
            {
                comboBox1.Items.Add(it);
            }
            var query = (from g in db.s_in_group
                         where g.id_group == item.id_group
                         select g.group_num).ToList();
            comboBox1.SelectedItem = query[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = ((Form2)Owner).db.s_students.SingleOrDefault(w => w.id == item.id);
            var query = (from g in db.s_in_group
                         where g.id_group == item.id_group
                         select g.id_group).ToList();
            result.id_group = query[0];
            ((Form2)Owner).studentsSheet = ((Form2)Owner).db.s_students.OrderBy(o => o.id).ToList();
            ((Form2)Owner).db.SaveChanges();
            this.Close();
        }
    }
}
