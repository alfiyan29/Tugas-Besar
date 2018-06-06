using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tugas_Besar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="alfiyan"&&textBox2.Text=="*****"||textBox1.Text=="nagib"&&textBox2.Text=="nagib"||textBox1.Text=="rama"&&textBox2.Text=="rama")
            {
            Form2 m = new Form2();
            m.Show();
            this.Hide();

            MessageBox.Show("Berhasil Login");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
  
        }
    }
}
