using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisProg9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void authorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.authorBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.booksDataSet);
            }
            catch
            {
                MessageBox.Show("Ошибка изменения данных");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "booksDataSet.author". При необходимости она может быть перемещена или удалена.
            this.authorTableAdapter.Fill(this.booksDataSet.author);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }
    }
}
