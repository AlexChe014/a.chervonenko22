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
    public partial class FormAddProg : Form
    {
        public demoEntities db = new demoEntities();
        public FormAddProg()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime((int)numericUpDown3.Value, (int)numericUpDown2.Value, (int)numericUpDown1.Value);
            progress prog = new progress
            {
                code_stud = (int)numericUpDown1.Value,
                code_subject = (int)numericUpDown3.Value,
                code_lector = (int)numericUpDown2.Value,
                estimate = (int)numericUpDown4.Value,
                date_exam = dt
            };
            db.progress.Add(prog);
            db.SaveChanges();
            this.Close();
        }
    }
}
