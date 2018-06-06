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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ALFIYANJUNIZARS\ALFIN;Initial Catalog=Tugas Besar Petruk;Integrated Security=True");
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 k = new Form2();
            k.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO Servis(Kode_Servis,Nama_Servis,Harga_Servis) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Berhasil Disimpan");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE Servis SET Nama_Servis = '" + textBox2.Text + "',Harga_Servis = '" + textBox3.Text + "' WHERE Kode_Servis ='" + textBox1.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Berhasil Diedit");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM Servis WHERE Kode_Servis='" + textBox1.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Berhasil Dihapus");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM Servis";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            MessageBox.Show("Berhasil Ditampilkan");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
