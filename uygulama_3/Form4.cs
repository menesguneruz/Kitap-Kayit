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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection();
            baglanti.ConnectionString = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=kitap.accdb";
            baglanti.Open();

            OleDbDataAdapter dt = new OleDbDataAdapter("select * from üye", baglanti);
            DataSet ds = new DataSet();
            dt.Fill(ds, "üye");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "üye";
        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection();
            baglanti.ConnectionString = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=kitap.accdb";
            baglanti.Open();

            OleDbDataAdapter dt = new OleDbDataAdapter("delete from üye where TC_No='"+dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'", baglanti);
            DataSet ds = new DataSet();
            dt.Fill(ds, "üye");
            dataGridView1.DataSource = ds;
            OleDbDataAdapter dt1 = new OleDbDataAdapter("select * from üye", baglanti);
            DataSet ds1 = new DataSet();
            dt1.Fill(ds1, "üye");
            dataGridView1.DataSource = ds1;
            dataGridView1.DataMember = "üye";
          
        }
    }
}
