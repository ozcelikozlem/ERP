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
    public partial class MusteriTedarikci : Form
    {
        public SqlConnection con = null;
        public MusteriTedarikci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");
            con.Open();
            string sql2 = "insert into MusteriVeTedarikci(MTFirmaUnvan,MTFirmaKisaAd,MTFirmaMail,MTFirmaFaks,MTFirmaIban,MTFirmaAdres,MTFirmaGorev,MTFirmaVergiDairesi) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
            SqlCommand com3 = new SqlCommand(sql2, con);
            com3.ExecuteNonQuery();
            DataTable dokum = new DataTable();
            // musteri.Clear();

            SqlDataAdapter adaptor = new SqlDataAdapter("Select MTFirmaUnvan,MTFirmaKisaAd,MTFirmaMail,MTFirmaFaks,MTFirmaIban,MTFirmaAdres,MTFirmaGorev,MTFirmaVergiDairesi from MusteriVeTedarikci", con);
            adaptor.Fill(dokum);
            dataGridView1.DataSource = dokum;
            adaptor.Dispose();

            con.Close();
            con.Dispose();

        }

        private void MusteriTedarikci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eRPDataSet10.MusteriVeTedarikci' table. You can move, or remove it, as needed.
            this.musteriVeTedarikciTableAdapter.Fill(this.eRPDataSet10.MusteriVeTedarikci);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");
            con.Open();
            SqlCommand kmt = new SqlCommand("DELETE MusteriVeTedarikci  where MTFirmaMail=" + textBox9.Text, con);
            kmt.ExecuteNonQuery();
            DataTable dokum = new DataTable();
            // musteri.Clear();
            SqlDataAdapter adaptor = new SqlDataAdapter("Select MTFirmaUnvan,MTFirmaKisaAd,MTFirmaMail,MTFirmaFaks,MTFirmaIban,MTFirmaAdres,MTFirmaGorev,MTFirmaVergiDairesi from MusteriVeTedarikci", con);
            adaptor.Fill(dokum);
            dataGridView1.DataSource = dokum;
            adaptor.Dispose();
            MessageBox.Show("başaralı bir şekilde silinmiştir.");
            con.Close();
            con.Dispose();
        }
    }
}
