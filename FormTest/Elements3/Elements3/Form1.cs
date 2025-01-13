using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elements3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(maskedTextBox1.Text);
            int number2 = Convert.ToInt32(maskedTextBox2.Text);

            char operater = Convert.ToChar(comboBox1.Text);
            double result = 0;

            switch (operater)
            {
                case '+':
                     result = number1 + number2;
                    break;
                case '-':
                     result = number1 - number2;
                    break;
                case '/':
                     result = number1 / number2;
                    break;
                case '*':
                     result = number1 * number2;
                    break;
                default:
                    MessageBox.Show("You need to choose an operator to continue");
                    break;
            }
            listBox2.Items.Add(result);

        }
    }
}
