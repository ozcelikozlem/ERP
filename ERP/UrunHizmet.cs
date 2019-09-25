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
    public partial class UrunHizmet : Form
    {
        public SqlConnection con = null;
        public UrunHizmet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");
            con.Open();
            string sql2 = "insert into UrunVeyaHizmet(UrunAdi,BaslangicMiktari,Miktar,SatisFiyati,UrunVergiSatisOTV) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            SqlCommand com3 = new SqlCommand(sql2, con);
            com3.ExecuteNonQuery();
            DataTable dokum = new DataTable();
            // musteri.Clear();

            SqlDataAdapter adaptor = new SqlDataAdapter("Select UrunKodu,UrunAdi,BaslangicMiktari,Miktar,SatisFiyati,UrunVergiSatisOTV from UrunVeyaHizmet", con);
            adaptor.Fill(dokum);
            dataGridView1.DataSource = dokum;
            adaptor.Dispose();
            string urunkodu = null;
            string sql4 = "select max(UrunKodu) from UrunVeyaHizmet ";
            SqlCommand com5 = new SqlCommand(sql4, con);
            SqlDataReader oku = com5.ExecuteReader();
            if (oku.Read())
            {
                urunkodu = oku[0].ToString();


            }
            oku.Close();
            string sql3 = "insert into SatilanUrun(SatilanMiktar,SatilanBirimFiyat,SatilanToplamFiyat,SatilanUrunu) values ('" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" +Convert.ToInt32( urunkodu) + "')";
            SqlCommand com4 = new SqlCommand(sql3, con);
            com4.ExecuteNonQuery();
            DataTable dokum2 = new DataTable();
            // musteri.Clear();

            SqlDataAdapter adaptor1 = new SqlDataAdapter("Select SatilanMiktar,SatilanBirimFiyat,SatilanToplamFiyat,SatilanUrunu from SatilanUrun", con);
            adaptor1.Fill(dokum2);
            dataGridView2.DataSource = dokum2;
            adaptor1.Dispose();

            int bakiye = 0;
            int sonuc = 0;
            string sql7 = "select BankaBakiye from BankaHesabı where BankaIban='" + textBox18.Text + "'";
            SqlCommand com7 = new SqlCommand(sql7, con);
            SqlDataReader oku7 = com7.ExecuteReader();
            if (oku7.Read())
            {
                bakiye = Convert.ToInt32(oku7[0].ToString());


            }

            sonuc = bakiye + Convert.ToInt32(textBox8.Text);
            string sql6 = "update BankaHesabı set BankaBakiye='" + sonuc + "' where BankaIban='" + textBox18.Text + "'";
            SqlCommand com6 = new SqlCommand(sql6, con);
            com6.ExecuteNonQuery();

            con.Close();
            con.Dispose();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");
            con.Open();
            string sql2 = "insert into UrunVeyaHizmet(UrunAdi,BaslangicMiktari,Miktar,AlisFiyati,UrunVergiAlisOTV) values ('" + textBox16.Text + "','" + textBox15.Text + "','" + textBox14.Text + "','" + textBox13.Text + "','" + textBox12.Text + "')";
            SqlCommand com3 = new SqlCommand(sql2, con);
            com3.ExecuteNonQuery();
            DataTable dokum = new DataTable();
            // musteri.Clear();

            SqlDataAdapter adaptor = new SqlDataAdapter("Select UrunKodu,UrunAdi,BaslangicMiktari,Miktar,AlisFiyati,UrunVergiAlisOTV from UrunVeyaHizmet", con);
            adaptor.Fill(dokum);
            dataGridView4.DataSource = dokum;
            adaptor.Dispose();
            string urunkodu = null;
            string sql4 = "select max(UrunKodu) from UrunVeyaHizmet ";
            SqlCommand com5 = new SqlCommand(sql4, con);
            SqlDataReader oku = com5.ExecuteReader();
            if (oku.Read())
            {
                urunkodu = oku[0].ToString();


            }
            oku.Close();
            string sql3 = "insert into AlinanUrun(AlinanMiktar,AlinanBirimFiyat,AlinanToplamFiyat,AlinanUrunu) values ('" + textBox11.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + Convert.ToInt32(urunkodu) + "')";
            SqlCommand com4 = new SqlCommand(sql3, con);
            com4.ExecuteNonQuery();
            DataTable dokum2 = new DataTable();
            // musteri.Clear();

            SqlDataAdapter adaptor1 = new SqlDataAdapter("Select AlinanMiktar,AlinanBirimFiyat,AlinanToplamFiyat,AlinanUrunu from AlinanUrun", con);
            adaptor1.Fill(dokum2);
            dataGridView3.DataSource = dokum2;
            adaptor1.Dispose();


            int bakiye=0;
            int sonuc = 0;
            string sql7 = "select BankaBakiye from BankaHesabı where BankaIban='" + textBox17.Text + "'";
            SqlCommand com7 = new SqlCommand(sql7, con);
            SqlDataReader oku7 = com7.ExecuteReader();
            if (oku7.Read())
            {
                bakiye =Convert.ToInt32( oku7[0].ToString());


            }

            sonuc = bakiye -Convert.ToInt32(textBox9.Text);
            string sql6 = "update BankaHesabı set BankaBakiye='"+sonuc+ "' where BankaIban='" + textBox17.Text + "'";
            SqlCommand com6 = new SqlCommand(sql6, con);
            com6.ExecuteNonQuery();


            con.Close();
            con.Dispose();


        }

        private void UrunHizmet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eRPDataSet17.AlinanUrun' table. You can move, or remove it, as needed.
            this.alinanUrunTableAdapter.Fill(this.eRPDataSet17.AlinanUrun);
            // TODO: This line of code loads data into the 'eRPDataSet16.UrunVeyaHizmet' table. You can move, or remove it, as needed.
            this.urunVeyaHizmetTableAdapter1.Fill(this.eRPDataSet16.UrunVeyaHizmet);
            // TODO: This line of code loads data into the 'eRPDataSet15.SatilanUrun' table. You can move, or remove it, as needed.
            this.satilanUrunTableAdapter.Fill(this.eRPDataSet15.SatilanUrun);
            // TODO: This line of code loads data into the 'eRPDataSet14.UrunVeyaHizmet' table. You can move, or remove it, as needed.
            this.urunVeyaHizmetTableAdapter.Fill(this.eRPDataSet14.UrunVeyaHizmet);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");
            con.Open();
            SqlCommand kmt = new SqlCommand("DELETE UrunVeyaHizmet  where UrunKodu=" + textBox19.Text, con);
            kmt.ExecuteNonQuery();
            SqlCommand kmt1 = new SqlCommand("DELETE SatilanUrun  where SatilanUrunu=" + textBox19.Text, con);
            kmt1.ExecuteNonQuery();
            DataTable dokum = new DataTable();
            // musteri.Clear();
            SqlDataAdapter adaptor = new SqlDataAdapter("Select UrunKodu,UrunAdi,BaslangicMiktari,Miktar,AlisFiyati,UrunVergiAlisOTV from UrunVeyaHizmet", con);
            adaptor.Fill(dokum);
            dataGridView1.DataSource = dokum;
            adaptor.Dispose();
            DataTable dokum1 = new DataTable();
            // musteri.Clear();
            SqlDataAdapter adaptor1 = new SqlDataAdapter("Select SatilanMiktar,SatilanBirimFiyat,SatilanToplamFiyat,SatilanUrunu from SatilanUrun", con);
            adaptor1.Fill(dokum1);
            dataGridView2.DataSource = dokum1;
            adaptor1.Dispose();


            int bakiye = 0;
            int sonuc = 0;
            string sql7 = "select BankaBakiye from BankaHesabı where BankaIban='" + textBox18.Text + "'";
            SqlCommand com7 = new SqlCommand(sql7, con);
            SqlDataReader oku7 = com7.ExecuteReader();
            if (oku7.Read())
            {
                bakiye = Convert.ToInt32(oku7[0].ToString());


            }

            sonuc = bakiye - Convert.ToInt32(textBox8.Text);
            string sql6 = "update BankaHesabı set BankaBakiye='" + sonuc + "' where BankaIban='" + textBox18.Text + "'";
            SqlCommand com6 = new SqlCommand(sql6, con);
            com6.ExecuteNonQuery();

            MessageBox.Show("başaralı bir şekilde silinmiştir.");
            con.Close();
            con.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");
            con.Open();
            SqlCommand kmt = new SqlCommand("DELETE UrunVeyaHizmet  where UrunKodu=" + textBox20.Text, con);
            kmt.ExecuteNonQuery();
            SqlCommand kmt1 = new SqlCommand("DELETE AlinanUrun  where AlinanUrunu=" + textBox20.Text, con);
            kmt1.ExecuteNonQuery();
            DataTable dokum = new DataTable();
            // musteri.Clear();
            SqlDataAdapter adaptor = new SqlDataAdapter("Select UrunKodu,UrunAdi,BaslangicMiktari,Miktar,AlisFiyati,UrunVergiAlisOTV from UrunVeyaHizmet", con);
            adaptor.Fill(dokum);
            dataGridView1.DataSource = dokum;
            adaptor.Dispose();
            DataTable dokum1 = new DataTable();
            // musteri.Clear();
            SqlDataAdapter adaptor1 = new SqlDataAdapter("Select AlinanMiktar,AlinanBirimFiyat,AlinanToplamFiyat,AlinanUrunu from AlinanUrun", con);
            adaptor1.Fill(dokum1);
            dataGridView2.DataSource = dokum1;
            adaptor1.Dispose();


            int bakiye = 0;
            int sonuc = 0;
            string sql7 = "select BankaBakiye from BankaHesabı where BankaIban='" + textBox17.Text + "'";
            SqlCommand com7 = new SqlCommand(sql7, con);
            SqlDataReader oku7 = com7.ExecuteReader();
            if (oku7.Read())
            {
                bakiye = Convert.ToInt32(oku7[0].ToString());


            }

            sonuc = bakiye + Convert.ToInt32(textBox9.Text);
            string sql6 = "update BankaHesabı set BankaBakiye='" + sonuc + "' where BankaIban='" + textBox17.Text + "'";
            SqlCommand com6 = new SqlCommand(sql6, con);
            com6.ExecuteNonQuery();


            MessageBox.Show("başaralı bir şekilde silinmiştir.");
            con.Close();
            con.Dispose();
        }
    }
}
