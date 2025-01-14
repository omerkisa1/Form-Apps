using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox2.Text) || !string.IsNullOrWhiteSpace(richTextBox1.Text))
            {

                string baslik = textBox1.Text;
                string konu = textBox2.Text;
                string icerik = richTextBox1.Text;
                dataGridView1.Rows.Add(baslik, konu, icerik);
            }
            else
            {
                MessageBox.Show("Text spaces can not be empyt");
            }
        }
    }
}
