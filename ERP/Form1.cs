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
    public partial class Form1 : Form
    {
        public SqlConnection con = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=.;Database=ERP;Trusted_Connection=true;");

            con.Open();
            string ad = textBox1.Text;
            string sifre = textBox2.Text;
            
            SqlCommand com = new SqlCommand("select * from Kullanicilar where KullaniciMail='" + ad + "' and KullaniciSifre='" + sifre + "' ", con);
            SqlDataReader oku = com.ExecuteReader();

            if (oku.Read())
            {
              
                Anasayfa giris = new Anasayfa();
                giris.Show();
                oku.Close();
               
            }
            else
            {
                label3.Text = "kullanıcı adı veya şifre yanlış tekrar deneyiniz.";

            }



        }

       
    }
}
