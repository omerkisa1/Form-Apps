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
        int[] stages = new int[] {10, 12, 15};


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
            bottomPipe2.Left -= mapSpeed;
            topPipe2.Left -= mapSpeed;
            scoreLabel.Text = "Score: " + score.ToString();

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
            if(bottomPipe2.Left < -150)
            {
                bottomPipe2.Left = 770;
                score++;
            }
            if(topPipe2.Left < - 145)
            {
                topPipe2.Left = 800;
                score++;
            }

  
            if (isColliding(Bird, bottomPipe) || isColliding(Bird, topPipe) || Bird.Bounds.IntersectsWith(ground.Bounds) || Bird.Top < -20)
            {
                endGame();
            }


            if (score > 15)
            {
                mapSpeed = stages[2];  
    
            }
            else if (score > 10)
            {
                mapSpeed = stages[1];  

            }
            else if (score > 5)
            {
                mapSpeed = stages[0];  
  
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
