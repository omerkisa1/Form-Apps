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
        int speed = 5;

        private void timer1_Tick(object sender, EventArgs e)
        {
            middleLineMoves(speed);

            if (blueCarScore % 100 == 0 || redCarScore % 100 == 0)
            {
                speed++;
            }


            if (pressedKeys.Contains(Keys.Left) || pressedKeys.Contains(Keys.Right))
                redCarScore++; 

            if (pressedKeys.Contains(Keys.A) || pressedKeys.Contains(Keys.D))
                blueCarScore++; 

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


            // Çarpışma alanlarını oluştur
            Rectangle redCarBounds = new Rectangle(redCar.Left + 10, redCar.Top + 5, redCar.Width - 20, redCar.Height - 10);
            Rectangle blueCarBounds = new Rectangle(blueCar.Left + 10, blueCar.Top + 5, blueCar.Width - 20, blueCar.Height - 10);

            // Arabalar birbiriyle çarpışıyor mu?
            if (redCarBounds.IntersectsWith(blueCarBounds))
            {
                timer1.Stop(); // Timer'ı durdur

                // Çarpışmayı başlatanı belirle
                string winner;
                if (pressedKeys.Contains(Keys.Left) || pressedKeys.Contains(Keys.Right))
                    winner = "Mavi Araba Kazandı! (Kırmızı çarptı)";
                else if (pressedKeys.Contains(Keys.A) || pressedKeys.Contains(Keys.D))
                    winner = "Kırmızı Araba Kazandı! (Mavi çarptı)";
                else
                    winner = "Beraberlik!";

                MessageBox.Show($"Çarpışma! Oyun Bitti! {winner}");
                return; // Daha fazla işlem yapmadan çık
            }

            // Arabalar engellerle çarpışıyor mu?
            if (redCarBounds.IntersectsWith(pictureBox5.Bounds) ||
                redCarBounds.IntersectsWith(pictureBox6.Bounds) ||
                blueCarBounds.IntersectsWith(pictureBox5.Bounds) ||
                blueCarBounds.IntersectsWith(pictureBox6.Bounds))
            {
                timer1.Stop(); // Timer'ı durdur
                MessageBox.Show("Çarpışma! Oyun Bitti!");
                return; // Daha fazla işlem yapmadan çık
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
