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
    public partial class Ürün : Form
    {
        public Ürün()
        {
            InitializeComponent();
        }
        Model1Container baglanti = new Model1Container();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.ÜrünlerSet.ToList();
        }

        private void Ürün_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ürünler ekle = new Ürünler();
            ekle.ÜrünAdı = textBox1.Text.ToString();
            ekle.StokMiktar = Convert.ToInt32(textBox2.Text);
            ekle.ÜrünTipi = textBox3.Text.ToString();
            baglanti.ÜrünlerSet.Add(ekle);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.ÜrünlerSet.ToList();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBox1.Tag);
           Ürünler  sil = baglanti.ÜrünlerSet.SingleOrDefault(s => s.ÜrünID == id);
            baglanti.ÜrünlerSet.Remove(sil);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.ÜrünlerSet.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textBox1.Text = satır.Cells["ÜrünAdı"].Value.ToString();
            textBox1.Tag = satır.Cells["ÜrünID"].Value;
            textBox2.Text = satır.Cells["StokMiktar"].Value.ToString();
            textBox3.Text = satır.Cells["ÜrünTipi"].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            Ürünler yenile = baglanti.ÜrünlerSet.SingleOrDefault(y => y.ÜrünID == id);
            yenile.ÜrünAdı = textBox1.Text;
            yenile.StokMiktar = Convert.ToInt32(textBox2.Text);
            yenile.ÜrünTipi = textBox3.Text;
            

            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.ÜrünlerSet.ToList();
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
            var arama = baglanti.ÜrünlerSet.Where(p => p.ÜrünID == id);
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
