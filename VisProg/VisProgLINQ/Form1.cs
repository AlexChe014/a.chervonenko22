using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NPOI.XSSF.UserModel;

namespace VisProgLINQ
{
    public partial class Form1 : Form
    {
        public demoEntities db = new demoEntities();
        public List<students> studentSheet;
        public List<progress> progSheet;
        public Form1()
        {
            InitializeComponent();
            studentSheet = (from stud in db.students
                            select stud).ToList();
            progSheet = (from prog in db.progress
                         select prog).ToList();

            var query = (from stud in studentSheet
                         join g in db.groups on stud.code_group equals g.code_group
                         orderby stud.code_stud
                         select new { stud.code_stud, stud.surname, stud.name, g.name_group/*, stud.code_group */}).ToList();
            var query2 = (from prog in db.progress
                          join s in db.students on prog.code_stud equals s.code_stud
                          join sub in db.subjects on prog.code_subject equals sub.code_subject
                          join l in db.lectors on prog.code_lector equals l.code_lector
                          orderby prog.code_stud
                          select new { s.surname, s.name, sub.name_subject, prog.date_exam, prog.estimate, l.name_lector }).ToList();
            if (radioButton1.Checked)
            {
                dataGridView1.DataSource = query;
                dataGridView1.Columns[0].HeaderText = "Номер студента";
                dataGridView1.Columns[1].HeaderText = "Фамилия";
                dataGridView1.Columns[2].HeaderText = "Имя";
                dataGridView1.Columns[3].HeaderText = "Номер группы";
            }
            else
                dataGridView1.DataSource = query2;
            dataGridView1.ReadOnly = true;
            if (dataGridView1.RowCount == 0) label1.Visible = true;
            else label1.Visible = false;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoDataSet.students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.demoDataSet.students);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var query = (from stud in db.students
                             join g in db.groups on stud.code_group equals g.code_group
                             orderby stud.code_stud
                             select new { stud.code_stud, stud.surname, stud.name, g.name_group/*, stud.code_group */}).ToList();
                if (textBox1.Text != "")
                {
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            dataGridView1.DataSource = query.Where(p => p.code_stud.ToString() == textBox1.Text.ToString()).ToList(); break;
                        case 1:
                            dataGridView1.DataSource = query.Where(p => p.surname.ToString() == textBox1.Text.ToString()).ToList(); break;
                        case 2:
                            dataGridView1.DataSource = query.Where(p => p.name.ToString() == textBox1.Text.ToString()).ToList(); break;
                        case 3:
                            dataGridView1.DataSource = query.Where(p => p.name_group.ToString() == textBox1.Text.ToString()).ToList(); break;
                    }
                }
                else dataGridView1.DataSource = query;
                dataGridView1.Update();
                if (dataGridView1.RowCount == 0) label1.Visible = true;
                else label1.Visible = false;
            }
            else if (radioButton2.Checked)
            {
                var query = (from prog in db.progress
                             join s in db.students on prog.code_stud equals s.code_stud
                             join sub in db.subjects on prog.code_subject equals sub.code_subject
                             join l in db.lectors on prog.code_lector equals l.code_lector
                             orderby prog.code_stud
                             select new { s.surname, s.name, sub.name_subject, prog.date_exam, prog.estimate, l.name_lector }).ToList();
                if (textBox1.Text != "")
                {
                    switch(comboBox2.SelectedIndex)
                    {
                        case 0:
                            dataGridView1.DataSource = query.Where(p => p.name_lector.ToString() == textBox1.Text).ToList(); break;
                        case 1:
                            dataGridView1.DataSource = query.Where(p => p.surname.ToString() == textBox1.Text).ToList(); break;
                        case 2:
                            dataGridView1.DataSource = query.Where(p => p.name_subject.ToString() == textBox1.Text).ToList(); break;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (Application.OpenForms.Count == 1)
                {
                    FormAddStudent addSt = new FormAddStudent();
                    addSt.Owner = this;
                    addSt.Show();
                }
                else Application.OpenForms[0].Focus();
            }
            else if (radioButton2.Checked)
            {
                if (Application.OpenForms.Count == 1)
                {
                    FormAddProg addPr = new FormAddProg();
                    addPr.Owner = this;
                    addPr.Show();
                }
                else Application.OpenForms[0].Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                List<students> query = (from stud in db.students
                                        select stud).ToList();
                if (dataGridView1.SelectedCells.Count == 1)
                {
                    if (Application.OpenForms.Count == 1)
                    {
                        students item = query.First(w => w.code_stud.ToString() == dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

                        FormEditStudent edtSt = new FormEditStudent(item);
                        edtSt.Owner = this;
                        edtSt.Show();
                    }
                    else Application.OpenForms[0].Focus();
                }
            }
            else if (radioButton2.Checked)
            {
                List<progress> query = (from prog in db.progress
                                        
                                        select prog).ToList();
                if (dataGridView1.SelectedCells.Count == 1)
                {
                    if (Application.OpenForms.Count == 1)
                    {
                        progress item = query.First(w => w.code_stud.ToString() == dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString() && w.code_subject.ToString() == dataGridView1.SelectedCells[0].OwningRow.Cells[7].Value.ToString());

                        FormEditProg edtPr = new FormEditProg(item);
                        edtPr.Owner = this;
                        edtPr.Show();

                    }
                    else Application.OpenForms[0].Focus();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var query = (from stud in db.students
                             join g in db.groups on stud.code_group equals g.code_group
                             orderby stud.code_stud
                             select new { stud.code_stud, stud.surname, stud.name, g.name_group/*, stud.code_group */}).ToList();
                dataGridView1.DataSource = query;
            }
            else if (radioButton2.Checked)
            {
                var query = (from prog in db.progress
                             join s in db.students on prog.code_stud equals s.code_stud
                             join sub in db.subjects on prog.code_subject equals sub.code_subject
                             join l in db.lectors on prog.code_lector equals l.code_lector
                             orderby prog.code_stud
                             select new { s.surname, s.name, sub.name_subject, prog.date_exam, prog.estimate, l.name_lector }).ToList();
                dataGridView1.DataSource = query;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dialog.DefaultExt = ".xls";
                dialog.Filter = "Таблицы Excel (*.xls)|*.xls|Все файлы (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.FileName = "Отчет";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var file = new FileStream(dialog.FileName, FileMode.Create, FileAccess.ReadWrite);
                    var query = (from stud in db.students
                                 join g in db.groups on stud.code_group equals g.code_group
                                 orderby stud.code_stud
                                 select new { stud.code_stud, stud.surname, stud.name, g.name_group }).ToList();
                    var template = new MemoryStream(Properties.Resources.template, true);
                    var workbook = new XSSFWorkbook(template);
                    var sheet1 = workbook.GetSheet("Лист1");

                    int row = 8;
                    foreach (var item in query.OrderBy(o => o.code_stud))
                    {
                        var rowInsert = sheet1.CreateRow(row);
                        rowInsert.CreateCell(2).SetCellValue(item.code_stud);
                        rowInsert.CreateCell(3).SetCellValue(item.surname);
                        rowInsert.CreateCell(4).SetCellValue(item.name);
                        rowInsert.CreateCell(5).SetCellValue(item.name_group);
                        row++;

                    }
                    workbook.Write(file);
                }
            }
            else if (radioButton2.Checked)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                dialog.DefaultExt = ".xls";
                dialog.Filter = "Таблицы Excel (*.xls)|*.xls|Все файлы (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.FileName = "Отчет";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var file = new FileStream(dialog.FileName, FileMode.Create, FileAccess.ReadWrite);
                    var query = (from prog in db.progress
                                 join s in db.students on prog.code_stud equals s.code_stud
                                 join sub in db.subjects on prog.code_subject equals sub.code_subject
                                 join l in db.lectors on prog.code_lector equals l.code_lector
                                 orderby prog.code_stud
                                 select new { prog.code_stud, s.surname, s.name, sub.name_subject, prog.date_exam, prog.estimate, l.name_lector, prog.code_subject }).ToList();
                    var template = new MemoryStream(Properties.Resources.template2);
                    var workbook = new XSSFWorkbook(template);
                    var sheet1 = workbook.GetSheet("Лист1");

                    int row = 3;
                    foreach (var item in query.OrderBy(o => o.date_exam))
                    {
                        var rowInsert = sheet1.CreateRow(row);
                        rowInsert.CreateCell(0).SetCellValue(item.surname);
                        rowInsert.CreateCell(1).SetCellValue(item.name);
                        rowInsert.CreateCell(2).SetCellValue(item.name_subject);
                        rowInsert.CreateCell(3).SetCellValue(item.date_exam);
                        rowInsert.CreateCell(4).SetCellValue((double)item.estimate);
                        rowInsert.CreateCell(5).SetCellValue(item.name_lector);
                        row++;

                    }
                    workbook.Write(file);
                }

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            var query = (from prog in db.progress
                         join s in db.students on prog.code_stud equals s.code_stud
                         join sub in db.subjects on prog.code_subject equals sub.code_subject
                         join l in db.lectors on prog.code_lector equals l.code_lector
                         orderby prog.code_stud
                         select new { prog.code_stud, s.surname, s.name, sub.name_subject, prog.date_exam, prog.estimate, l.name_lector, prog.code_subject }).ToList();
            dataGridView1.DataSource = query;
            dataGridView1.Columns[0].HeaderText = "Номер студента";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Дисциплина";
            dataGridView1.Columns[4].HeaderText = "Дата";
            dataGridView1.Columns[5].HeaderText = "Оценка";
            dataGridView1.Columns[6].HeaderText = "Преподаватель";
            comboBox1.Visible = false;
            comboBox2.Visible = true;
            dataGridView1.Columns[7].Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var query = (from stud in db.students
                         join g in db.groups on stud.code_group equals g.code_group
                         orderby stud.code_stud
                         select new { stud.code_stud, stud.surname, stud.name, g.name_group/*, stud.code_group */}).ToList();
            dataGridView1.DataSource = query;
            dataGridView1.Columns[0].HeaderText = "Номер студента";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Номер группы";
            comboBox1.Visible = true;
            comboBox2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены?", "Внимание!", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                if (radioButton1.Checked)
                {
                    try
                    {
                        List<students> query = (from stud in db.students
                                                select stud).ToList();
                        if (dataGridView1.SelectedCells.Count == 1)
                        {
                            students item = query.First(w => w.code_stud.ToString() == dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                            db.students.Remove(item);
                            db.SaveChanges();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка изменения данных");
                    }
                }
                else if (radioButton2.Checked)
                {
                    try
                    {
                        List<progress> query = (from prog in db.progress
                                                select prog).ToList();
                        if (dataGridView1.SelectedCells.Count == 1)
                        {

                            progress item = query.First(w => w.code_stud.ToString() == dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString() && w.code_subject.ToString() == dataGridView1.SelectedCells[0].OwningRow.Cells[7].Value.ToString());
                            db.progress.Remove(item);
                            db.SaveChanges();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка изменения данных");
                    }
                }
            }
        }
    }
}
