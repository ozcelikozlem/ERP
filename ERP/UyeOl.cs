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
    public partial class UyeOl : Form
    {
        public SqlConnection con = null;
        public UyeOl()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");

            con.Open();

            string sql1 = "select KullaniciID from Kullanicilar where KullaniciMail='" + textBox6.Text + "'";
            SqlCommand com1 = new SqlCommand(sql1, con);
            SqlDataReader oku = com1.ExecuteReader();
            if (oku.Read())
            {
                label5.Text = "mevcut isim tekrar deneyiniz";

            }
            else
            {
                oku.Close();

                string sql3 = "select FirmaID from FirmaBilgileri where FirmaTicariUnvan'" + textBox1.Text + "' and FirmaMail='" + textBox2.Text + "'";

                SqlCommand com2 = new SqlCommand(sql1, con);
                SqlDataReader oku2 = com2.ExecuteReader();
                if (oku2.Read())
                {
                    label8.Text = "mevcut firma bulunmaktadır tekrar deneyiniz";

                }
                else
                {
                   oku2.Close();
                  

              
                string firmaID = null;
                string calisanID = null;

                string sql5 = "select FirmaID from FirmaBilgileri where FirmaMail='" + textBox1.Text + "' AND FirmaMail='" + textBox2.Text + "'";
                SqlCommand com5 = new SqlCommand(sql5, con);
                SqlDataReader oku5 = com5.ExecuteReader();
                if (oku5.Read())
                {

                    firmaID = oku5[0].ToString();

                }

                
                string sql4 = "insert into FirmaCalisanlari(CalisanSoyad,CalisanAd,CalisanMail) values ('" + textBox5.Text + "','" + textBox3.Text + "','" + textBox6.Text + "')";
                 string sql6 = "select CalisanID from FirmaCalisanlari where CalisanAd='" + textBox3.Text + "' AND CalisanMail='" + textBox6.Text + "'";
                  //  oku5.Close();
                    SqlCommand com6 = new SqlCommand(sql6, con);
                    SqlDataReader oku6 = com6.ExecuteReader();
                    if (oku6.Read())
                    {
                       
                        calisanID = oku6[0].ToString();

                    }
                   
                    string sql = "insert into Kullanicilar(KullaniciMail,KullaniciSifre,KullaniciFirma,CalisanKaydi) values ('" + textBox6.Text + "','" + textBox7.Text + "','" + firmaID + "','" + calisanID + "')";
                    SqlCommand com = new SqlCommand(sql, con);
                    com.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();
                    Form1 git = new Form1();
                    git.Show();
                    oku6.Close();

                }

            }


        }
    }
}
