using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int mapSpeed = 8;
        int gravity = 1;  
        int velocity = 0; 
        int score = 0;
        int collisionThreshold = 5; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void bottomPipe_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
 
            velocity += gravity;
            Bird.Top += velocity;

            bottomPipe.Left -= mapSpeed;
            topPipe.Left -= mapSpeed;

 
            if (bottomPipe.Left < -130)
            {
                bottomPipe.Left = 800;
                score++;
            }
            if (topPipe.Left < -165)
            {
                topPipe.Left = 900;
                score++;
            }

  
            if (isColliding(Bird, bottomPipe) || isColliding(Bird, topPipe) || Bird.Bounds.IntersectsWith(ground.Bounds) || Bird.Top < -20)
            {
                endGame();
            }

 
            if (score > 7)
            {
                mapSpeed = 15;
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
 
            if (e.KeyCode == Keys.Space)
            {
                velocity = -12; 
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void endGame()
        {
            gameTimer.Stop(); 
            scoreLabel.Text = "Your Score: " + score + " \nGame is Over!";
        }

 
        private bool isColliding(PictureBox bird, PictureBox pipe)
        {
   
            Rectangle birdRect = bird.Bounds;
            Rectangle pipeRect = pipe.Bounds;

 
            birdRect.Inflate(-10, -10);  
            pipeRect.Inflate(-10, -10);  


            return birdRect.IntersectsWith(pipeRect);
        }

    }
}
