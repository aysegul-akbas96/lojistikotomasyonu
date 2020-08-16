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
    public partial class sevk : Form
    {
        public sevk()
        {
            InitializeComponent();
        }
        Model1Container baglanti = new Model1Container();
        private void button6_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }

        private void sevk_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            comboBox2.DataSource = baglanti.ÜrünlerSet.ToList();
            comboBox2.DisplayMember = "ÜrünAdı";
            comboBox2.ValueMember = "ÜrünID";


            comboBox3.DataSource = baglanti.FirmalarSet.ToList();
            comboBox3.DisplayMember = "FirmaTipi";
            comboBox3.ValueMember = "FirmaID";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textBox1.Text = satır.Cells["SevkAdı"].Value.ToString();
            textBox1.Tag = satır.Cells["SevkiyatID"].Value;
            textBox2.Text = satır.Cells["Ülke"].Value.ToString();
            comboBox2.SelectedIndex = Convert.ToInt32(satır.Cells["ÜrünlerÜrünID"].Value) - 1;
            comboBox3.SelectedIndex = Convert.ToInt32(satır.Cells["FirmalarFirmaID"].Value) - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = baglanti.SevkiyatSet.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sevkiyat ekle = new Sevkiyat();
            ekle.SevkAdı = textBox1.Text.ToString();
            ekle.Ülke = textBox2.Text.ToString();
            ekle.ÜrünlerÜrünID= comboBox2.SelectedIndex + 1;
            ekle.FirmalarFirmaID = comboBox3.SelectedIndex + 1;
            baglanti.SevkiyatSet.Add(ekle);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.SevkiyatSet.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
           Sevkiyat sil = baglanti.SevkiyatSet.SingleOrDefault(s => s.SevkiyatID == id);
            baglanti.SevkiyatSet.Remove(sil);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.SevkiyatSet.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            Sevkiyat yenile = baglanti.SevkiyatSet.SingleOrDefault(y => y.SevkiyatID == id);
            yenile.SevkAdı = textBox1.Text;
            yenile.Ülke = textBox2.Text;
            yenile.ÜrünlerÜrünID = comboBox2.SelectedIndex + 1;
            yenile.FirmalarFirmaID = comboBox3.SelectedIndex + 1;

            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.SevkiyatSet.ToList();
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
            var arama = baglanti.SevkiyatSet.Where(p => p.SevkiyatID == id);
            dataGridView1.DataSource = arama.ToList();
        }
    }
    }

