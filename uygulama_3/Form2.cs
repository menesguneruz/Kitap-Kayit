using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace uygulama_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection();
            baglanti.ConnectionString = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=kitap.accdb";
            baglanti.Open();

            OleDbDataAdapter dt = new OleDbDataAdapter("insert into kayıt(BarkodNo,KitapAdı,YazarAdı,YayınEvi,KitapTürü,StokSayısı) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "')", baglanti);
            DataSet ds = new DataSet();
            dt.Fill(ds, "kayıt");
            
        }
    }
}
