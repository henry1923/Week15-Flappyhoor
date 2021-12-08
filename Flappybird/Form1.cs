using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappybird
{
    public partial class grounds : Form
    {
        int gravity = 10;
        int pipeSpeed = 6;
        int score - 0;
        score.text = $"score: {score}";
        public grounds()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipeTop.Left -= pipeSpeed;
            pipeBottom.Left -= pipeSpeed;


            if(pipeTop.Left < -100)
            {
                pipeTop.Left = 581;
                score++;
            }

            if(pipeBottom.Left < -100)
            {
                pipeBottom.Left = 600;
                score++;
            }

            if(bird.Top < -25)
            {
                gameOver();
            }



             if(bird.Bounds.IntersectsWith(pipeTop.Bounds) || bird.Bounds.IntersectWith(pipeBottom.Bounds)
                    bird.Bounds.IntersectsWith(grounds.Bounds))
                 {

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space) 
            {
                gravity = 5;
            }
        }

        private void bird_Click(object sender, EventArgs e)
        {

        }

        private void gameOver()
        {
            timer1.Stop();
            score.text = $"Game Over!";
        }
    }
}
