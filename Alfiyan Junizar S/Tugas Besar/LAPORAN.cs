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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ALFIYANJUNIZARS\ALFIN;Initial Catalog=Tugas Besar Petruk;Integrated Security=True");
        private void button5_Click(object sender, EventArgs e)
        {
            Form2 k = new Form2();
            k.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Transaksi";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            MessageBox.Show("Berhasil Ditampilkan");
        }
    }
}
