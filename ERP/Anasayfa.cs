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
    public partial class Anasayfa : Form
    {
        public SqlConnection con = null;
        public Anasayfa()
        {
            InitializeComponent();

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eRPDataSet.BankaGideri' table. You can move, or remove it, as needed.
            this.bankaGideriTableAdapter.Fill(this.eRPDataSet.BankaGideri);




        }

        private void button1_Click(object sender, EventArgs e)
        {
            BankaKasa git1 = new BankaKasa();
            git1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriTedarikci git2 = new MusteriTedarikci();
            git2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calisanlar git3= new Calisanlar();
            git3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Odemeler git4= new Odemeler();
            git4.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FisFatura git5 = new FisFatura();
            git5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UrunHizmet git6 = new UrunHizmet();
            git6.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    }
