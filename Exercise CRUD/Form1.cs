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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sander, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 baru = new Form2();
            baru.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 laku = new Form3();
            laku.Show();
            this.Hide();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRDataSet1.tbKeluar' table. You can move, or remove it, as needed.
            this.tbKeluarTableAdapter.Fill(this.hRDataSet1.tbKeluar);
            // TODO: This line of code loads data into the 'hRDataSet.tbMasuk' table. You can move, or remove it, as needed.
            this.tbMasukTableAdapter.Fill(this.hRDataSet.tbMasuk);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
