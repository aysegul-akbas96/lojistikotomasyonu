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
    public partial class Taşıyıcı : Form
    {
        public Taşıyıcı()
        {
            InitializeComponent();
        }
        Model1Container baglanti = new Model1Container();
        private void Taşıyıcı_Load(object sender, EventArgs e)
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
                MessageBox.Show("Arama İşleminiz Tanımlanamadı...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaşıyıcıFirma ekle = new TaşıyıcıFirma();
            ekle.Adı = textBox1.Text.ToString();
            ekle.Adres = textBox2.Text.ToString();
            ekle.Telefon = Convert.ToInt32(textBox3.Text);
            ekle.TaşımaŞekli = textBox5.Text;
            ekle.FirmalarFirmaID = 3;
           
            baglanti.TaşıyıcıFirmaSet.Add(ekle);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.TaşıyıcıFirmaSet.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textBox1.Text = satır.Cells["Adı"].Value.ToString();
            textBox1.Tag = satır.Cells["TaşıyıcıFirmaID"].Value;
            textBox2.Text = satır.Cells["Adres"].Value.ToString();
            textBox3.Text = satır.Cells["Telefon"].Value.ToString();
            textBox5.Text = satır.Cells["TaşımaŞekli"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.TaşıyıcıFirmaSet.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            TaşıyıcıFirma yenile = baglanti.TaşıyıcıFirmaSet.SingleOrDefault(y => y.TaşıyıcıFirmaID== id);
            yenile.Adı = textBox1.Text;
            yenile.Adres = textBox2.Text;
            yenile.Telefon = Convert.ToInt32(textBox3.Text);
            yenile.TaşımaŞekli = textBox5.Text;
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.TaşıyıcıFirmaSet.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            TaşıyıcıFirma  sil = baglanti.TaşıyıcıFirmaSet.SingleOrDefault(s => s.TaşıyıcıFirmaID == id);
            baglanti.TaşıyıcıFirmaSet.Remove(sil);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.AlıcıFirmaSet.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FirmaSeç git = new FirmaSeç();
            git.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox4.Text);
            var arama = baglanti.TaşıyıcıFirmaSet.Where(p => p.TaşıyıcıFirmaID == id);
            dataGridView1.DataSource = arama.ToList();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
