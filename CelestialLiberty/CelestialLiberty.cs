using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelestialLiberty
{
    public partial class CelestialLiberty : Form
    {
        bool left, right;
        int score, lives;
        string move;
        Graphics g; //Declare a graphics object called g
        // declare space for an array of 7 objects called planet 
        Rival[] rival = new Rival[7];
        Random xspeed = new Random();
        Serpent serpent = new Serpent();

        public CelestialLiberty()
        {
            InitializeComponent();

            for (int i = 0; i <= 6; i++)
            {
                int y = 380 + (i * 75);
                rival[i] = new Rival(y);
            }
        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //Get the graphics used to paint on the panel control
            g = e.Graphics;

            //Call the Planet class's DrawPlanet method to draw the image planet1 
            for (int i = 0; i <= 6; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = xspeed.Next(5, 20);
                rival[i].x += rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                rival[i].drawRival(g);
            }
            serpent.drawSerpent(g);
        }

        private void CelestialLiberty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
        }

        private void CelestialLiberty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
        }

        private void tmrSerpent_Tick(object sender, EventArgs e)
        {
            if (right) //If right arrow key pressed
            {
                move = "right";
                serpent.moveSerpent(move);
            }
            if (left) //If left arrow key pressed
            {
                move = "left";
                serpent.moveSerpent(move);
            }
        }

        private void CelestialLiberty_Load(object sender, EventArgs e)
        {
            tmrSerpent.Enabled = false;
            tmrRival.Enabled = false;
            MessageBox.Show("Use the left and right arrow keys to move the spaceship. \n Don't get hit by the planets! \n Every planet that gets past scores a point. \n If a planet hits a spaceship a life is lost! \n \n Enter your Name press tab and enter the number of lives \n Click Start to begin", "Game Instructions");
            TxtName.Focus();
        }

        private void FileStart_Click(object sender, EventArgs e)
        {
            score = 0;
            LblScore.Text = score.ToString();
            lives = int.Parse(TxtLives.Text);// pass lives entered from textbox to lives variable
            tmrRival.Enabled = true;
            tmrSerpent.Enabled = true;
        }

        private void FileStop_Click(object sender, EventArgs e)
        {
            tmrSerpent.Enabled = false;
            tmrRival.Enabled = false;
        }

        private void FileExit_Click(object sender, EventArgs e)
        {
            tmrSerpent.Enabled = false;
            tmrRival.Enabled = false;
            string message = "Are you sure you want to exit?";
            string message2 = "Click File->Start to continue playing.";
            string caption = "Confirm exit";
            string caption2 = "Continue playing";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxButtons buttons2 = MessageBoxButtons.OK;
            MessageBoxIcon icon1 = MessageBoxIcon.Question;
            MessageBoxIcon icon2 = MessageBoxIcon.Information;

            //Displays the MessageBox.
            DialogResult quit = MessageBox.Show(message, caption, buttons, icon1);
            if (quit == DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }
            //If the player ends up choosing not to (rage) quit, display this MessageBox.
            else if (quit == DialogResult.No)
            {
                MessageBox.Show(message2, caption2, buttons2, icon2);
            }
        }

        private void tmrRival_Tick(object sender, EventArgs e)
        {
            score = 0;
            for (int i = 0; i <= 6; i++)
            {
                score += rival[i].score; //Get score from Rival class (in moveRival method)
                LblScore.Text = score.ToString(); //Dsiplay score
                rival[i].moveRival();
                if (serpent.serpentRec.IntersectsWith(rival[i].rivalRec))
                {
                    //reset rival[i] back to top of panel
                    rival[i].x = 380; //Set  y value of rivalRec
                    lives -= 1;//Lose a life
                    TxtLives.Text = lives.ToString();//Display number of lives
                    checkLives();
                }

            }
            pnlGame.Invalidate(); //Makes the paint event fire to redraw the panel
        }
        private void checkLives()
        {
            if (lives == 0)
            {
                tmrRival.Enabled = false;
                tmrSerpent.Enabled = false;
                MessageBox.Show("Game Over!");
            }
        }
    }
}
