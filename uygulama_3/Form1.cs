using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace uygulama_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 yeni = new Form3();
            yeni.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 yeni = new Form4();
            yeni.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 yeni = new Form5();
            yeni.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
