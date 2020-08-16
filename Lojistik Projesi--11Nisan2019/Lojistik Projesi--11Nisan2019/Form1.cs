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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Model1Container baglanti = new Model1Container();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirmaSeç git = new FirmaSeç();
            git.Show();
            this.Hide();
        }

        private void alıcıFirmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deprtmanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departmanlar git = new Departmanlar();
            git.Show();
            this.Hide();
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personeller git = new Personeller();
            git.Show();
            this.Hide();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ürün git = new Ürün();
            git.Show();
            this.Hide();
        }

        private void sevkiyatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sevk git = new sevk();
            git.Show();
            this.Hide();
        }
    }
}
