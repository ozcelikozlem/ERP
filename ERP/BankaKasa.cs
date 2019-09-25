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
    public partial class BankaKasa : Form
    {
        public SqlConnection con = null;
        public BankaKasa()
        {
            InitializeComponent();
        }

        private void BankaKasa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eRPDataSet18.KasaHesab' table. You can move, or remove it, as needed.
            this.kasaHesabTableAdapter3.Fill(this.eRPDataSet18.KasaHesab);
            // TODO: This line of code loads data into the 'eRPDataSet7.KasaHesab' table. You can move, or remove it, as needed.
            this.kasaHesabTableAdapter2.Fill(this.eRPDataSet7.KasaHesab);
            // TODO: This line of code loads data into the 'eRPDataSet6.BankaHesabi' table. You can move, or remove it, as needed.
            this.bankaHesabiTableAdapter2.Fill(this.eRPDataSet6.BankaHesabi);
            // TODO: This line of code loads data into the 'eRPDataSet4.BankaHesabi' table. You can move, or remove it, as needed.
            this.bankaHesabiTableAdapter1.Fill(this.eRPDataSet4.BankaHesabi);
            // TODO: This line of code loads data into the 'eRPDataSet3.KasaHesab' table. You can move, or remove it, as needed.
            this.kasaHesabTableAdapter1.Fill(this.eRPDataSet3.KasaHesab);
            // TODO: This line of code loads data into the 'eRPDataSet2.KasaHesab' table. You can move, or remove it, as needed.
            this.kasaHesabTableAdapter.Fill(this.eRPDataSet2.KasaHesab);
            // TODO: This line of code loads data into the 'eRPDataSet1.BankaHesabi' table. You can move, or remove it, as needed.
            this.bankaHesabiTableAdapter.Fill(this.eRPDataSet1.BankaHesabi);
            //DataTable dokum = new DataTable();
            //SqlDataAdapter adaptor = new SqlDataAdapter("Select KasaAcilisBakiyesi,KasaAcilisTarihi,KasaBakiye from KasaHesab", con);
            //adaptor.Fill(dokum);
            //dataGridView1.DataSource = dokum;
            //adaptor.Dispose();


            //DataTable dokum2= new DataTable();
            //// musteri.Clear();

            //SqlDataAdapter adaptor2 = new SqlDataAdapter("Select BankaIban,BankaAcilisBakiyesi,BankaBakiye,BankaIsim,BankaSube,BankaSube,BankaHesapNo from BankaHesabi", con);
            //adaptor2.Fill(dokum2);
            //dataGridView2.DataSource = dokum2;
            //adaptor2.Dispose();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");
            con.Open();
            string sql2 = "insert into BankaHesabi(BankaIban,BankaAcilisBakiyesi,BankaBakiye,BankaIsim,BankaSube,BankaHesapNo) values ('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            SqlCommand com3 = new SqlCommand(sql2, con);
            com3.ExecuteNonQuery();
            DataTable dokum = new DataTable();
            // musteri.Clear();
            
            SqlDataAdapter adaptor = new SqlDataAdapter("Select BankaIban,BankaAcilisBakiyesi,BankaBakiye,BankaIsim,BankaSube,BankaSube,BankaHesapNo from BankaHesabi", con);
            adaptor.Fill(dokum);
            dataGridView1.DataSource = dokum;
            adaptor.Dispose();
          
            con.Close();
            con.Dispose();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");
            con.Open();
            string sql2 = "insert into KasaHesab(KasaAcilisBakiyesi,KasaAcilisTarihi,KasaBakiye) values ('" + textBox2.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')";
            SqlCommand com3 = new SqlCommand(sql2, con);
            com3.ExecuteNonQuery();
            DataTable dokum = new DataTable();
            // musteri.Clear();

            SqlDataAdapter adaptor = new SqlDataAdapter("Select KasaID,KasaAcilisBakiyesi,KasaAcilisTarihi,KasaBakiye from KasaHesab", con);
            adaptor.Fill(dokum);
            dataGridView2.DataSource = dokum;
            adaptor.Dispose();
           
          
            con.Close();
            con.Dispose();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Sil_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");
            con.Open();
            SqlCommand kmt = new SqlCommand("DELETE BankaHesabi  where BankaIban=" + textBox10.Text, con);
            kmt.ExecuteNonQuery();
            DataTable dokum = new DataTable();
            // musteri.Clear();

            SqlDataAdapter adaptor = new SqlDataAdapter("Select BankaIban,BankaAcilisBakiyesi,BankaBakiye,BankaIsim,BankaSube,BankaSube,BankaHesapNo from BankaHesabi", con);
            adaptor.Fill(dokum);
            dataGridView1.DataSource = dokum;
            adaptor.Dispose();
            MessageBox.Show("başaralı bir şekilde silinmiştir.");
            con.Close();
            con.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");
            con.Open();
            SqlCommand kmt = new SqlCommand("DELETE KasaHesab  where KasaID=" + textBox10.Text, con);
            kmt.ExecuteNonQuery();
            DataTable dokum = new DataTable();
            // musteri.Clear();
            SqlDataAdapter adaptor = new SqlDataAdapter("Select KasaID,KasaAcilisBakiyesi,KasaAcilisTarihi,KasaBakiye from KasaHesab", con);
            adaptor.Fill(dokum);
            dataGridView1.DataSource = dokum;
            adaptor.Dispose();
            MessageBox.Show("başaralı bir şekilde silinmiştir.");
            con.Close();
            con.Dispose();
        }
    }
}
