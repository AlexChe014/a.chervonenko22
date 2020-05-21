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
    public partial class Form2 : Form
    {
        public controshaEntities db = new controshaEntities();
        int pic;
        string name, em, em_p;
        public Form2(string name_p, string em_p, string poz, string name_o, string em_o, int activePicture)
        {
            pic = activePicture;
            name = name_o;
            em = em_o;
            this.em_p = em_p;
            InitializeComponent();           
            label1.Text = name_p;
            label2.Text = poz;
            label3.Text = name_o + Environment.NewLine + em_o;
            pictureBox1.Image = Image.FromFile("img/" + activePicture + ".jpg");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int id_adr = db.adresats.Max(n => n.id_a) + 1;
            adresats adres = new adresats
            {
                id_a = id_adr,
                snp = name,
                email = em,
                adr = ((Form1)Owner).new_id,
                message_t = label2.Text
            };
            db.adresats.Add(adres);
            db.SaveChanges();
            Form2 f2 = new Form2(label1.Text, em_p, label2.Text, name, em, pic);
            f2.Owner = this;
            f2.button1.Visible = f2.button2.Visible = false;
            f2.label5.Visible = true;
            f2.label5.Text = $"Открытка отправлена по адресу: {Environment.NewLine}{em_p}";
            f2.Show();
            
        }
    }
}
