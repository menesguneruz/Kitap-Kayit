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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection();
            baglanti.ConnectionString = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=kitap.accdb";
            baglanti.Open();

            OleDbDataAdapter dt = new OleDbDataAdapter("select * from kayıt", baglanti);
            DataSet ds = new DataSet();
            dt.Fill(ds, "kayıt");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "kayıt";
        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection();
            baglanti.ConnectionString = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=kitap.accdb";
            baglanti.Open();

            OleDbDataAdapter dt = new OleDbDataAdapter("delete from kayıt where BarkodNo='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", baglanti);
            DataSet ds = new DataSet();
            dt.Fill(ds, "kayıt");
            dataGridView1.DataSource = ds;
            OleDbDataAdapter dt1 = new OleDbDataAdapter("select * from kayıt", baglanti);
            DataSet ds1 = new DataSet();
            dt1.Fill(ds1, "kayıt");
            dataGridView1.DataSource = ds1;
            dataGridView1.DataMember = "kayıt";
        }
    }
}
