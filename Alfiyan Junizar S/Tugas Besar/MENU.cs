using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Besar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataServisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 m = new Form4();
            m.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 m = new Form3();
            m.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 k = new Form1();
            k.Show();
            this.Close();
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 m = new Form5();
            m.Show();
            this.Hide();
        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 m = new Form6();
            m.Show();
            this.Hide();
        }
    }
}
