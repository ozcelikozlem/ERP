using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace ERP
{
    public partial class Calisanlar : Form
    {
        public SqlConnection con = null;
        public Calisanlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");
            con.Open();
            string sql2 = "insert into FirmaCalisanlari(CalisanSoyad,CalisanAd,CalisanMail,CalisanIban) values ('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            SqlCommand com3 = new SqlCommand(sql2, con);
            com3.ExecuteNonQuery();
            DataTable dokum = new DataTable();
            // musteri.Clear();

            SqlDataAdapter adaptor = new SqlDataAdapter("Select CalisanSoyad,CalisanAd,CalisanMail,CalisanIban from FirmaCalisanlari", con);
            adaptor.Fill(dokum);
            dataGridView1.DataSource = dokum;
            adaptor.Dispose();

            con.Close();
            con.Dispose();


        }

        private void Calisanlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eRPDataSet5.FirmaCalisanlari' table. You can move, or remove it, as needed.
            this.firmaCalisanlariTableAdapter.Fill(this.eRPDataSet5.FirmaCalisanlari);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");
            con.Open();
            SqlCommand kmt = new SqlCommand("DELETE FirmaCalisanlari  where CalisanMail=" + textBox5.Text, con);
            kmt.ExecuteNonQuery();
            DataTable dokum = new DataTable();
            // musteri.Clear();
            SqlDataAdapter adaptor = new SqlDataAdapter("Select CalisanSoyad,CalisanAd,CalisanMail,CalisanIban from FirmaCalisanlari", con);
            adaptor.Fill(dokum);
            dataGridView1.DataSource = dokum;
            adaptor.Dispose();
            MessageBox.Show("başaralı bir şekilde silinmiştir.");
            con.Close();
            con.Dispose();

        }
    }
}
