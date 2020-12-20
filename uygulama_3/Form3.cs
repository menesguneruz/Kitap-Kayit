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
    public partial class Form3 : Form
    {
        public Form3()
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

            OleDbDataAdapter dt = new OleDbDataAdapter("insert into üye(TC_No,Adı_Soyadı,Doğum_Tarihi,Doğum_Yeri,E_Posta,Telefonu,Cinsiyet,Adres,Üyelik_Tarihi) values('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "' ,'" + textBox4.Text + "','" + textBox5.Text + "','" + maskedTextBox1.Text + "','" + comboBox1.Text + "','" + comboBox1.Text + "','" + richTextBox1.Text + "')", baglanti);
            DataSet ds = new DataSet();
            dt.Fill(ds, "üye");
        }
    }
}
