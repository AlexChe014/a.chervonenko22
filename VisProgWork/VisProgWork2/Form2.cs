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
    public partial class Form2 : Form
    {
        public contEntities db = new contEntities();
        public List<s_students> studentsSheet;
        public Form2()
        {
            InitializeComponent();
            studentsSheet = (from stud in db.s_students
                             select stud).ToList();
            var query = (from stud in db.s_students
                         join gr in db.s_in_group on stud.id_group equals gr.id_group
                         orderby stud.id
                         select new { stud.id, stud.surname, stud.name, stud.middlename, gr.kurs_num, gr.group_num }).ToList(); ;
            dataGridView1.DataSource = query;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = (from stud in db.s_students
                         join gr in db.s_in_group on stud.id_group equals gr.id_group
                         orderby stud.id
                         select new { stud.id, stud.surname, stud.name, stud.middlename, gr.kurs_num, gr.group_num }).ToList(); ;
            if (textBox1.Text != "")
            {
                dataGridView1.DataSource = query.Where(p => p.surname.ToString() == textBox1.Text).ToList();
            }
            if (textBox2.Text != "")
            {
                dataGridView1.DataSource = query.Where(p => p.kurs_num.ToString() == textBox2.Text).ToList();
            }
            if (textBox3.Text != "")
            {
                dataGridView1.DataSource = query.Where(p => p.group_num.ToString() == textBox3.Text).ToList();
            }
            dataGridView1.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var query = (from stud in db.s_students
                         join gr in db.s_in_group on stud.id_group equals gr.id_group
                         orderby stud.id
                         select new { stud.id, stud.surname, stud.name, stud.middlename, gr.kurs_num, gr.group_num }).ToList(); ;
            dataGridView1.DataSource = query;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ((Form1)Owner).Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 2)
            {
                Form3 f3 = new Form3();
                f3.Owner = this;
                f3.Show();
            }
            else Application.OpenForms[0].Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<s_students> query = (from s in db.s_students
                                      select s).ToList();
                    s_students item = query.First(w => w.id.ToString() == dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

                    Form4 edt = new Form4(item);
                    edt.Owner = this;
                    edt.Show();
 
        }
    }
}
