using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lojistik_Projesi__11Nisan2019
{
    public partial class Üretici : Form
    {
        public Üretici()
        {
            InitializeComponent();
        }
        Model1Container baglanti = new Model1Container();

        private void Üretici_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Evet")
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
                MessageBox.Show("Aramanız Tanımlanamadı..");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox4.Text);
            var arama = baglanti.ÜreticiFirmaSet.Where(p => p.ÜreticiFirmaID== id);
            dataGridView1.DataSource = arama.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["Adı"].Value.ToString();
            textBox1.Tag = satir.Cells["ÜreticiFirmaID"].Value.ToString();
            textBox2.Text = satir.Cells["Adres"].Value.ToString();
            textBox3.Text = satir.Cells["Telefon"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.ÜreticiFirmaSet.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ÜreticiFirma ekle = new ÜreticiFirma();
            ekle.Adı = textBox1.Text.ToString();
            ekle.Adres = textBox2.Text.ToString();
            ekle.Telefon = Convert.ToInt32(textBox3.Text);
            ekle.FirmalarFirmaID = 1;
            baglanti.ÜreticiFirmaSet.Add(ekle);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.ÜreticiFirmaSet.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            ÜreticiFirma sil = baglanti.ÜreticiFirmaSet.SingleOrDefault(s => s.ÜreticiFirmaID == id);
            baglanti.ÜreticiFirmaSet.Remove(sil);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.ÜreticiFirmaSet.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBox1.Tag);
            ÜreticiFirma yenile = baglanti.ÜreticiFirmaSet.SingleOrDefault(y => y.ÜreticiFirmaID == id);
            yenile.Adı = textBox1.Text;
            yenile.Adres = textBox2.Text;
            yenile.Telefon = Convert.ToInt32(textBox3.Text);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.ÜreticiFirmaSet.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FirmaSeç git = new FirmaSeç();
            git.Show();
            this.Hide();
        }
    }
}
