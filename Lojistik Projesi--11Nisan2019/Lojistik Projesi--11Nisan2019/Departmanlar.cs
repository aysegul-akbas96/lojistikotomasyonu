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
    public partial class Departmanlar : Form
    {
        public Departmanlar()
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

        private void button2_Click(object sender, EventArgs e)
        {
            Departman ekle = new Departman();
            ekle.DepartmanAdı = textBox1.Text.ToString();
            ekle.FirmalarFirmaID = comboBox2.SelectedIndex + 1;

           

            baglanti.DepartmanSet.Add(ekle);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.DepartmanSet.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.DepartmanSet.ToList();
        }

        private void Departmanlar_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            comboBox2.DataSource = baglanti.FirmalarSet.ToList();
            comboBox2.DisplayMember = "FirmaTipi";
            comboBox2.ValueMember = "FirmaID";
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
            var arama = baglanti.DepartmanSet.Where(p => p.DeparmanID == id);
            dataGridView1.DataSource = arama.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBox1.Tag);
            Departman sil = baglanti.DepartmanSet.SingleOrDefault(s => s.DeparmanID == id);
            baglanti.DepartmanSet.Remove(sil);
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.AlıcıFirmaSet.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBox1.Tag);
            Departman yenile = baglanti.DepartmanSet.SingleOrDefault(y => y.DeparmanID == id);
            yenile.DepartmanAdı= textBox1.Text;
            yenile.FirmalarFirmaID = comboBox2.SelectedIndex + 1;
        
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.TaşıyıcıFirmaSet.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            textBox1.Text = satır.Cells["DepartmanAdı"].Value.ToString();
            textBox1.Tag = satır.Cells["DeparmanID"].Value;
            comboBox2.SelectedIndex = Convert.ToInt32(satır.Cells["FirmalarFirmaID"].Value) - 1;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
