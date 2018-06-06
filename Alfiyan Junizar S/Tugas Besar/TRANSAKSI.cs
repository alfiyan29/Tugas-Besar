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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ALFIYANJUNIZARS\ALFIN;Initial Catalog=Tugas Besar Petruk;Integrated Security=True");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 k = new Form2();
            k.Show();
            this.Close();
        }

        private void TRANSAKSI_Load(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE Transaksi SET Nama_Pembeli = '" + textBox2.Text + "',Nama_Barang = '" + textBox3.Text + "',Jumlah = '" + textBox4.Text + "',Harga = '" + textBox5.Text + "',Total = '" + textBox6.Text + "' WHERE Kode_Transaksi ='" + textBox1.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Berhasil Diedit");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM Transaksi WHERE Kode_Transaksi='" + textBox1.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Berhasil Dihapus");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO Transaksi(Kode_Transaksi,Nama_Pembeli,Nama_Barang,Jumlah,Harga,Total) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "' + '" + textBox5.Text + "' + '" + textBox6.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Berhasil Disimpan");
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double jml = double.Parse(textBox4.Text);
                double hrg = double.Parse(textBox5.Text);
                textBox6.Text = (jml * hrg).ToString();
            }
            catch
            {
                MessageBox.Show(null, "Inputan Salah", "Salah", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
