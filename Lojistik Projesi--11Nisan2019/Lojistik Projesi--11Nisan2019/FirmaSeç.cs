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
    public partial class FirmaSeç : Form
    {
        public FirmaSeç()
        {
            InitializeComponent();
        }
        Model1Container baglanti = new Model1Container();
        private void FirmaSeç_Load(object sender, EventArgs e)
        {
          
            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "AlıcıFirma")
            {
                Alıcı git = new Alıcı();
                git.Show();
                this.Hide();
            }
            else if(comboBox1.SelectedItem.ToString() == "ÜreticiFirma")
            {
                Üretici git = new Üretici();
                git.Show();
                this.Hide();

            }
            else
            {
                Taşıyıcı git = new Taşıyıcı();
                git.Show();
                this.Hide();
            }
    }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }
    }
}
