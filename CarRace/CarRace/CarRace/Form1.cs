using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRace
{
    public partial class Form1 : Form
    {
        // Basılı tuşları takip etmek için HashSet
        private HashSet<Keys> pressedKeys = new HashSet<Keys>();

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        int blueCarScore = 0;
        int redCarScore = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            middleLineMoves(5);

            blueCarScore++;
            redCarScore++;
            blueCarScoreLabel.Text = $"Score: {blueCarScore}";
            redCarScoreLabel.Text = $"Score: {redCarScore}";

            // Basılı tuşlara göre araç hareketi
            if (pressedKeys.Contains(Keys.Left))
                redCar.Left -= 3;
            if (pressedKeys.Contains(Keys.Right))
                redCar.Left += 3;
            if (pressedKeys.Contains(Keys.A))
                blueCar.Left -= 3;
            if (pressedKeys.Contains(Keys.D))
                blueCar.Left += 3;


            Rectangle redCarBounds = new Rectangle(redCar.Left , redCar.Top + 5, redCar.Width - 80, redCar.Height - 40);
            Rectangle blueCarBounds = new Rectangle(blueCar.Left , blueCar.Top + 5, blueCar.Width - 80, blueCar.Height - 40); // fix bounds


            if (redCar.Bounds.IntersectsWith(blueCar.Bounds) || redCar.Bounds.IntersectsWith(pictureBox5.Bounds) || redCar.Bounds.IntersectsWith(pictureBox6.Bounds) || blueCar.Bounds.IntersectsWith(pictureBox5.Bounds) || blueCar.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                timer1.Stop(); // Oyunu durdur
                MessageBox.Show("Çarpışma! Oyun Bitti!"); // Uyarı mesajı
            }
        }

        public void middleLineMoves(int speed)
        {
            if (pictureBox1.Top >= 500)
                pictureBox1.Top = 0;
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 500)
                pictureBox2.Top = 0;
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 500)
                pictureBox3.Top = 0;
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
                pictureBox4.Top = 0;
            else
            {
                pictureBox4.Top += speed;
            }
            if (pictureBox9.Top >= 500)
                pictureBox9.Top = 0;
            else
            {
                pictureBox9.Top += speed;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Basılı tuşları listeye ekle
            if (!pressedKeys.Contains(e.KeyCode))
                pressedKeys.Add(e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // Tuş bırakıldığında listeden çıkar
            if (pressedKeys.Contains(e.KeyCode))
                pressedKeys.Remove(e.KeyCode);
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            // Form odağı kaybedildiğinde tüm tuşları sıfırla
            pressedKeys.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
