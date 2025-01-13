using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int counter = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            counter++;
            label1.Text += counter;

        }
    }
}
