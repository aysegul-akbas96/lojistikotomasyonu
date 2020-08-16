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
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }
        Model1Container baglanti = new Model1Container();
        private void Personeller_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            comboBox2.DataSource = baglanti.DepartmanSet.ToList();
            comboBox2.DisplayMember = "DepartmanAdı";
            comboBox2.ValueMember = "DeparmanID";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textBox1.Text = satır.Cells["PersonlAdı"].Value.ToString();
            textBox1.Tag = satır.Cells["PersonelID"].Value;
            textBox2.Text = satır.Cells["PersonelSoyadı"].Value.ToString();
            textBox3.Text = satır.Cells["Telefon"].Value.ToString();
            textBox5.Text = satır.Cells["Adres"].Value.ToString();
            comboBox2.SelectedIndex = Convert.ToInt32(satır.Cells["DepartmanDeparmanID"].Value) - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.PersonelSet.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personel ekle = new Personel();
            ekle.PersonlAdı = textBox1.Text.ToString();
            ekle.PersonelSoyadı = textBox2.Text.ToString();
            ekle.Telefon = Convert.ToInt32(textBox3.Text);
            ekle.Adres = textBox4.Text.ToString();
            ekle.DepartmanDeparmanID = comboBox2.SelectedIndex + 1;
            baglanti.PersonelSet.Add(ekle);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.PersonelSet.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBox1.Tag);
            Personel sil = baglanti.PersonelSet.SingleOrDefault(s => s.PersonelID == id);
            baglanti.PersonelSet.Remove(sil);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.PersonelSet.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            Personel yenile = baglanti.PersonelSet.SingleOrDefault(y => y.PersonelID == id);
            yenile.PersonlAdı = textBox1.Text;
            yenile.PersonelSoyadı = textBox2.Text;
            yenile.Telefon = Convert.ToInt32(textBox3.Text);
            yenile.Adres = textBox4.Text;
            yenile.DepartmanDeparmanID= comboBox2.SelectedIndex +1;

            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.PersonelSet.ToList();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox4.Text);
            var arama = baglanti.PersonelSet.Where(p => p.PersonelID == id);
            dataGridView1.DataSource = arama.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }
    }
}
