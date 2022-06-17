using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_CRUD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-C5A9RCLU\\PRASETYAAGUNGP;Initial Catalog=HR;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tbMasuk values(@Id_Sapi,@Jenis,@Bobot,@Harga,@Tanggal_Beli)", con);
            cmd.Parameters.AddWithValue("@Id_Sapi", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Jenis", textBox2.Text);
            cmd.Parameters.AddWithValue("@Bobot", double.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Harga", double.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@Tanggal_Beli", DateTime.Parse(dateTimePicker1.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Berhasil di Simpan!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-C5A9RCLU\\PRASETYAAGUNGP;Initial Catalog=HR;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update tbMasuk set Jenis = @Jenis, Bobot =@Bobot, Harga=@Harga,Tanggal Beli = @Tanggal_Beli where Id_Sapi = @Id_Sapi", con);
            cmd.Parameters.AddWithValue("@Id_Sapi", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Jenis", textBox2.Text);
            cmd.Parameters.AddWithValue("@Bobot", double.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Harga", double.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@Tanggal_Beli", DateTime.Parse(dateTimePicker1.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Berhasil di Update!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-C5A9RCLU\\PRASETYAAGUNGP;Initial Catalog=HR;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete tbMasuk where Id_Sapi = @Id_Sapi", con);
            cmd.Parameters.AddWithValue("@Id_Sapi", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Berhasil di Hapus!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-C5A9RCLU\\PRASETYAAGUNGP;Initial Catalog=HR;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select*From tbMasuk where Id_Sapi = @Id_Sapi", con);
            cmd.Parameters.AddWithValue("Id_Sapi", int.Parse(textBox1.Text));
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);

            dgvBaru.DataSource = dtb;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
