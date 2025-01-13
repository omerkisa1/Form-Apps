using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elements1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(inputBox.Text))
            {
                label1.Text = inputBox.Text;
            }
            else
            {
                MessageBox.Show("Input cannot be empty", "input error",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                label1.Text = "Hata";
            }


        }
    }
}
