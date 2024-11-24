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
        // To track pressed keys
        private HashSet<Keys> pressedKeys = new HashSet<Keys>();
        private Dictionary<PictureBox, int> obstacleSpeeds = new Dictionary<PictureBox, int>();
        private Dictionary<PictureBox, int> horizontalDirections = new Dictionary<PictureBox, int>();
        private Random random = new Random();
        int blueCarScore = 0;
        int redCarScore = 0;
        int speed = 5;

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;

            // Add human and tree obstacles at the beginning
            AddObstacle(human, 3);
            AddObstacle(tree, 5);
        }

        private void AddObstacle(PictureBox obstacle, int speed)
        {
            obstacleSpeeds[obstacle] = speed;
            horizontalDirections[obstacle] = random.Next(0, 2) == 0 ? -1 : 1; // -1: move left, 1: move right
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            middleLineMoves(speed);

            // Increase speed
            if (blueCarScore % 100 == 0 || redCarScore % 100 == 0)
            {
                speed++;
            }

            // Increase score
            if (pressedKeys.Contains(Keys.Left) || pressedKeys.Contains(Keys.Right))
                redCarScore++;

            if (pressedKeys.Contains(Keys.A) || pressedKeys.Contains(Keys.D))
                blueCarScore++;

            blueCarScoreLabel.Text = $"Score: {blueCarScore}";
            redCarScoreLabel.Text = $"Score: {redCarScore}";

            // Move cars based on pressed keys
            if (pressedKeys.Contains(Keys.Left))
                redCar.Left -= 3;
            if (pressedKeys.Contains(Keys.Right))
                redCar.Left += 3;
            if (pressedKeys.Contains(Keys.A))
                blueCar.Left -= 3;
            if (pressedKeys.Contains(Keys.D))
                blueCar.Left += 3;

            // Create collision bounds
            Rectangle redCarBounds = new Rectangle(redCar.Left + 10, redCar.Top + 5, redCar.Width - 20, redCar.Height - 10);
            Rectangle blueCarBounds = new Rectangle(blueCar.Left + 10, blueCar.Top + 5, blueCar.Width - 20, blueCar.Height - 10);

            // Check if the cars collide with each other
            if (redCarBounds.IntersectsWith(blueCarBounds))
            {
                timer1.Stop(); // Stop the timer

                // Determine the initiator of the collision
                string winner;
                if (pressedKeys.Contains(Keys.Left) || pressedKeys.Contains(Keys.Right))
                    winner = "Blue Car Wins! (Red collided)";
                else if (pressedKeys.Contains(Keys.A) || pressedKeys.Contains(Keys.D))
                    winner = "Red Car Wins! (Blue collided)";
                else
                    winner = "It's a Tie!";

                MessageBox.Show($"Collision! Game Over! {winner}");
                return; // Exit further execution
            }

            // Check if cars collide with obstacles
            foreach (var obstacle in obstacleSpeeds.Keys)
            {
                if (redCarBounds.IntersectsWith(obstacle.Bounds) || blueCarBounds.IntersectsWith(obstacle.Bounds))
                {
                    timer1.Stop();
                    MessageBox.Show("You collided with an obstacle! Game Over!");
                    return;
                }

                // Vertical movement of obstacles
                obstacle.Top += obstacleSpeeds[obstacle];
                if (obstacle.Top >= this.ClientSize.Height)
                {
                    obstacle.Top = -obstacle.Height;
                    obstacle.Left = random.Next(0, this.ClientSize.Width - obstacle.Width);
                }

                // Horizontal movement of obstacles
                obstacle.Left += horizontalDirections[obstacle];
                if (obstacle.Left <= 0 || obstacle.Left >= this.ClientSize.Width - obstacle.Width)
                {
                    horizontalDirections[obstacle] *= -1; // Change direction
                }
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
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Add pressed keys to the list
            if (!pressedKeys.Contains(e.KeyCode))
                pressedKeys.Add(e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // Remove key from the list when released
            if (pressedKeys.Contains(e.KeyCode))
                pressedKeys.Remove(e.KeyCode);
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            // Clear all pressed keys when form loses focus
            pressedKeys.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
