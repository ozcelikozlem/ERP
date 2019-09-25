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
    public partial class FisFatura : Form
    {
        public SqlConnection con = null;
        public FisFatura()
        {
            InitializeComponent();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");
            con.Open();
            string sql2 = "insert into Fis(FisAciklama,FisToplamFiyat) values ('" + textBox1.Text + "','" + textBox2.Text + "')";
            SqlCommand com3 = new SqlCommand(sql2, con);
            com3.ExecuteNonQuery();
            DataTable dokum = new DataTable();
            // musteri.Clear();

            SqlDataAdapter adaptor = new SqlDataAdapter("Select FisID,FisAciklama,FisToplamFiyat from Fis",con);
            dataGridView1.DataSource = dokum;
            adaptor.Dispose();

            con.Close();
            con.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");
            con.Open();
            string sql2 = "insert into Faturalar(FaturaNo,FaturaAcilama,FaturaTuru,ToplamTutar) values ('" + textBox3.Text + "','" + textBox4.Text + "','"+textBox5.Text+"')";
            SqlCommand com3 = new SqlCommand(sql2, con);
            com3.ExecuteNonQuery();
            DataTable dokum = new DataTable();
            // musteri.Clear();

            SqlDataAdapter adaptor = new SqlDataAdapter("Select FaturaAcilama,FaturaTuru,ToplamTutar from Faturalar", con);
            dataGridView2.DataSource = dokum;
            adaptor.Dispose();

            con.Close();
            con.Dispose();

        }

        private void FisFatura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eRPDataSet19.Fis' table. You can move, or remove it, as needed.
            this.fisTableAdapter.Fill(this.eRPDataSet19.Fis);
            // TODO: This line of code loads data into the 'eRPDataSet9.Faturalar' table. You can move, or remove it, as needed.
            this.faturalarTableAdapter.Fill(this.eRPDataSet9.Faturalar);
            // TODO: This line of code loads data into the 'eRPDataSet8.FirmaCalisanlari' table. You can move, or remove it, as needed.
            this.firmaCalisanlariTableAdapter.Fill(this.eRPDataSet8.FirmaCalisanlari);

        }

        private void sil_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");
            con.Open();
            SqlCommand kmt = new SqlCommand("DELETE Faturalar  where FaturaNo=" + textBox7.Text, con);
            kmt.ExecuteNonQuery();
            DataTable dokum = new DataTable();
            // musteri.Clear();
            SqlDataAdapter adaptor = new SqlDataAdapter("Select FisID,FisAciklama,FisToplamFiyat from Fis", con);
            adaptor.Fill(dokum);
            dataGridView1.DataSource = dokum;
            adaptor.Dispose();
            MessageBox.Show("başaralı bir şekilde silinmiştir.");
            con.Close();
            con.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");
            con.Open();
            SqlCommand kmt = new SqlCommand("DELETE Fis  where FisID=" + textBox6.Text, con);
            kmt.ExecuteNonQuery();
            DataTable dokum = new DataTable();
            // musteri.Clear();
            SqlDataAdapter adaptor = new SqlDataAdapter("Select FaturaAcilama,FaturaTuru,ToplamTutar from Faturalar", con);
            adaptor.Fill(dokum);
            dataGridView1.DataSource = dokum;
            adaptor.Dispose();
            MessageBox.Show("başaralı bir şekilde silinmiştir.");
            con.Close();
            con.Dispose();
        }
    }
}
