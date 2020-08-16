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
    public partial class Alıcı : Form
    {
        public Alıcı()
        {
            InitializeComponent();
        }
        

        private void Alıcı_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
        Model1Container baglanti = new Model1Container();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.AlıcıFirmaSet.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
   

            AlıcıFirma ekle = new AlıcıFirma();
            ekle.Adı = textBox1.Text.ToString();
            ekle.Adres = textBox2.Text.ToString();
            ekle.Telefon = Convert.ToInt32(textBox3.Text);
            ekle.FirmalarFirmaID = 2;
            baglanti.AlıcıFirmaSet.Add(ekle);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.AlıcıFirmaSet.ToList();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            int id = (int)textBox1.Tag;
            AlıcıFirma sil = baglanti.AlıcıFirmaSet.SingleOrDefault(s => s.AlıcıFirmaID == id);
            baglanti.AlıcıFirmaSet.Remove(sil);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.AlıcıFirmaSet.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
           textBox1.Text = satır.Cells["Adı"].Value.ToString();
            textBox1.Tag = satır.Cells["AlıcıFirmaID"].Value;
            textBox2.Text = satır.Cells["Adres"].Value.ToString();
            textBox3.Text = satır.Cells["Telefon"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            int id = (int)textBox1.Tag;
            AlıcıFirma yenile = baglanti.AlıcıFirmaSet.SingleOrDefault(y => y.AlıcıFirmaID == id);
            yenile.Adı = textBox1.Text;
            yenile.Adres = textBox2.Text;
            yenile.Telefon = Convert.ToInt32(textBox3.Text);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.AlıcıFirmaSet.ToList();        
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
            var arama = baglanti.AlıcıFirmaSet.Where(p => p.AlıcıFirmaID == id);
            dataGridView1.DataSource = arama.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FirmaSeç git = new FirmaSeç();
            git.Show();
            this.Hide();
        }
    }
}
