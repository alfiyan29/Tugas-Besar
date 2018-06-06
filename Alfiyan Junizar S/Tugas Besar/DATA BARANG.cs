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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ALFIYANJUNIZARS\ALFIN;Initial Catalog=Tugas Besar Petruk;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 k = new Form2();
            k.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO Barang(Kode_Barang,Nama_Barang,Stock_Barang,Harga) VALUES ('" + textBox1.Text + "','" + textBox2.Text+ "','" + textBox3.Text + "','" + textBox4.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query,con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Berhasil Disimpan");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE Barang SET Nama_Barang = '" + textBox2.Text + "',Stock_Barang = '" + textBox3.Text + "',Harga = '" + textBox4.Text + "' WHERE Kode_Barang ='" + textBox1.Text+"'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Berhasil Diedit");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM Barang WHERE Kode_Barang='" + textBox1.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Berhasil Dihapus");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Barang";
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
        }
    }
}