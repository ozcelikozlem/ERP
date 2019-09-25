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
    public partial class Odemeler : Form
    {
        public SqlConnection con = null;
        public Odemeler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");
            con.Open();
            string sql2 = "insert into BankaGideri(FBDToplamTutar,BDAciklama) values ('" + textBox2.Text + "','" + textBox1.Text + "')";
            SqlCommand com3 = new SqlCommand(sql2, con);
            com3.ExecuteNonQuery();
            DataTable dokum = new DataTable();
            // musteri.Clear();

            SqlDataAdapter adaptor = new SqlDataAdapter("Select FBDToplamTutar,BDAciklama from BankaGideri", con);
            dataGridView1.DataSource = dokum;
            adaptor.Dispose();

            int bakiye = 0;
            int sonuc = 0;
            string sql7 = "select BankaBakiye from BankaHesabı where BankaIban='" + textBox11.Text + "'";
            SqlCommand com7 = new SqlCommand(sql7, con);
            SqlDataReader oku7 = com7.ExecuteReader();
            if (oku7.Read())
            {
                bakiye = Convert.ToInt32(oku7[0].ToString());


            }

            sonuc = bakiye - Convert.ToInt32(textBox2.Text);
            string sql6 = "update BankaHesabı set BankaBakiye='" + sonuc + "' where BankaIban='" + textBox11.Text + "'";
            SqlCommand com6 = new SqlCommand(sql6, con);
            com6.ExecuteNonQuery();





            con.Close();
            con.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");
            con.Open();
            string sql2 = "insert into CalisanaOdeme(CMeblag,CAciklama) values ('" + textBox3.Text + "','" + textBox4.Text + "')";
            SqlCommand com3 = new SqlCommand(sql2, con);
            com3.ExecuteNonQuery();
            DataTable dokum = new DataTable();
            // musteri.Clear();

            SqlDataAdapter adaptor = new SqlDataAdapter("Select CMeblag,CAciklama from CalisanaOdeme", con);
            dataGridView2.DataSource = dokum;
            adaptor.Dispose();

            int bakiye = 0;
            int sonuc = 0;
            string sql7 = "select BankaBakiye from BankaHesabı where BankaIban='" + textBox10.Text + "'";
            SqlCommand com7 = new SqlCommand(sql7, con);
            SqlDataReader oku7 = com7.ExecuteReader();
            if (oku7.Read())
            {
                bakiye = Convert.ToInt32(oku7[0].ToString());


            }

            sonuc = bakiye - Convert.ToInt32(textBox4.Text);
            string sql6 = "update BankaHesabı set BankaBakiye='" + sonuc + "' where BankaIban='" + textBox10.Text + "'";
            SqlCommand com6 = new SqlCommand(sql6, con);
            com6.ExecuteNonQuery();





            con.Close();
            con.Dispose();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");
            con.Open();
            string sql2 = "insert into Vergi(VergiDonemAy,VergiDonemYıl,VergiTutar,VergiAciklama) values ('" + textBox5.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox7.Text + "')";
            SqlCommand com3 = new SqlCommand(sql2, con);
            com3.ExecuteNonQuery();
            DataTable dokum = new DataTable();
            // musteri.Clear();

            SqlDataAdapter adaptor = new SqlDataAdapter("Select VergiDonemAy,VergiDonemYıl,VergiTutar,VergiAciklamafrom Vergi", con);
            dataGridView3.DataSource = dokum;
            adaptor.Dispose();

            int bakiye = 0;
            int sonuc = 0;
            string sql7 = "select BankaBakiye from BankaHesabı where BankaIban='" + textBox9.Text + "'";
            SqlCommand com7 = new SqlCommand(sql7, con);
            SqlDataReader oku7 = com7.ExecuteReader();
            if (oku7.Read())
            {
                bakiye = Convert.ToInt32(oku7[0].ToString());


            }

            sonuc = bakiye - Convert.ToInt32(textBox8.Text);
            string sql6 = "update BankaHesabı set BankaBakiye='" + sonuc + "' where BankaIban='" + textBox9.Text + "'";
            SqlCommand com6 = new SqlCommand(sql6, con);
            com6.ExecuteNonQuery();



            con.Close();
            con.Dispose();

        }

        private void Odemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eRPDataSet13.Vergi' table. You can move, or remove it, as needed.
            this.vergiTableAdapter.Fill(this.eRPDataSet13.Vergi);
            // TODO: This line of code loads data into the 'eRPDataSet12.CalisanaOdeme' table. You can move, or remove it, as needed.
            this.calisanaOdemeTableAdapter.Fill(this.eRPDataSet12.CalisanaOdeme);
            // TODO: This line of code loads data into the 'eRPDataSet11.BankaGideri' table. You can move, or remove it, as needed.
            this.bankaGideriTableAdapter.Fill(this.eRPDataSet11.BankaGideri);

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
