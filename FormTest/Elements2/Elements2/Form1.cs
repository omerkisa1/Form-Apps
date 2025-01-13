using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elements2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string selectedLanguage = "";

            // Hangi radio button seçili, onu kontrol et.
            if (radioButton1.Checked)
            {
                selectedLanguage = radioButton1.Text; // veya radioButton1.Name
            }
            else if (radioButton2.Checked)
            {
                selectedLanguage = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                selectedLanguage = radioButton3.Text;
            }

            
            if (!string.IsNullOrEmpty(selectedLanguage))
            {
                if (checkBox1.Checked)
                {
                    label1.Text = $"You are a intern at { selectedLanguage}.";
                }
                else if (checkBox2.Checked)
                {
                    label1.Text = $"You are a junior at { selectedLanguage}.";
                }
                else if (checkBox3.Checked)
                {
                    label1.Text = $"You are a senior at { selectedLanguage}.";
                }
                else
                {
                    label1.Text = $"You selected {selectedLanguage}, but no level is specified.";
                }
            }
            else
            {
                Console.WriteLine("No programming language is selected.");
            }
        }
    }
}
