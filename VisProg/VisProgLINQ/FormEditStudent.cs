using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisProgLINQ
{
    public partial class FormEditStudent : Form
    {
        public demoEntities db = new demoEntities();
        students item;
        public FormEditStudent(students stud)
        {
            item = stud;
            InitializeComponent();
            
            var groups_for_list = (from g in db.groups
                                   select g.name_group).Distinct();
            foreach (string it in groups_for_list)
                comboBox1.Items.Add(it);

            textBox1.Text = item.surname.ToString();
            textBox2.Text = item.name.ToString();

            var query = (from g in db.groups
                         where g.code_group == item.code_group
                         select g.name_group).ToList();

            comboBox1.SelectedItem = query[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var result = ((Form1)Owner).db.students.SingleOrDefault(w => w.code_stud == item.code_stud);
                result.surname = textBox1.Text.ToString().Trim();
                result.name = textBox2.Text.ToString().Trim();
                var query = (from g in db.groups
                             where g.name_group == comboBox1.SelectedItem.ToString()
                             select g.code_group).ToList();
                result.code_group = query[0];

                ((Form1)Owner).studentSheet = ((Form1)Owner).db.students.OrderBy(o => o.code_stud).ToList();
                ((Form1)Owner).db.SaveChanges();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка изменения данных");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
