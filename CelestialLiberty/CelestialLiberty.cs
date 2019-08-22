using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelestialLiberty
{
    public partial class CelestialLiberty : Form
    {
        bool up, down;
        bool space;
        bool text;
        bool txtlives;
        int score, lives;
        string move;
        string shoot;
        Graphics g; //Declare a graphics object called g
        // declare space for an array of 7 objects called planet 
        Rival[] rival = new Rival[7];
        Random xspeed = new Random();
        Serpent serpent = new Serpent();
        Missile missile = new Missile();

        public CelestialLiberty()
        {
            InitializeComponent();

            //Block to prevent code from flickering.------------------------------
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty 
                | BindingFlags.Instance 
                | BindingFlags.NonPublic, null, pnlGame, new object[] { true });
            //--------------------------------------------------------------------

            for (int i = 0; i <= 6; i++)
            {
                int y = 30 + (i * 50);
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
                int rndmspeed = xspeed.Next(5);
                rival[i].x -= rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                rival[i].drawRival(g);
            }
            serpent.drawSerpent(g);
            missile.drawMissile(g);
        }

        private void CelestialLiberty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up) { up = true; }
            if (e.KeyData == Keys.Down) { down = true; }
            if (e.KeyData == Keys.Space) { space = true; } { missile.missileRec.X = serpent.serpentRec.X; missile.missileRec.Y = serpent.serpentRec.Y; }
        }

        private void CelestialLiberty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up) { up = false; }
            if (e.KeyData == Keys.Down) { down = false; }
            if (e.KeyData == Keys.Space) { space = false; } { missile.missileRec.X = serpent.serpentRec.X; missile.missileRec.Y = serpent.serpentRec.Y; }
        }

        private void tmrSerpent_Tick(object sender, EventArgs e)
        {
            if (up) //If right arrow key pressed
            {
                move = "up";
                serpent.moveSerpent(move);
            }
            if (down) //If left arrow key pressed
            {
                move = "down";
                serpent.moveSerpent(move);
            }
        }

        private void CelestialLiberty_Load(object sender, EventArgs e)
        {
            tmrSerpent.Enabled = false;
            tmrRival.Enabled = false;
            tmrMissile.Enabled = false;
            MessageBox.Show("Use the left and right arrow keys to move the spaceship. \n Don't get hit by the planets! \n Every planet that gets past scores a point. \n If a planet hits a spaceship a life is lost! \n \n Enter your Name press tab and enter the number of lives \n Click Start to begin", "Game Instructions");
            FileStart.Enabled = false;
            TxtName.Focus();
        }

        private void FileStart_Click(object sender, EventArgs e)
        {
            score = 0;
            LblScore.Text = score.ToString();
            lives = int.Parse(TxtLives.Text);// pass lives entered from textbox to lives variable
            tmrRival.Enabled = true;
            tmrSerpent.Enabled = true;
            tmrMissile.Enabled = true;
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

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            string context = TxtName.Text;
            bool isletter = true;
            //for loop checks for letters as characters are entered
            for (int i = 0; i < context.Length; i++)
            {
                if (!char.IsLetter(context[i]))// if current character not a letter
                {
                    isletter = false;//make isletter false
                    break; // exit the for loop
                }

            }

            // if not a letter clear the textbox and focus on it
            // to enter name again
            if (isletter == false)
            {
                TxtName.Clear();
                TxtName.Focus();
            }
            else
            {
                text = true;
            }
        }

        private void TxtLives_TextChanged(object sender, EventArgs e)
        {
            string context = TxtLives.Text;
            bool isnumber = true;
            //This loop checks for numbers as characters are entered
            for (int i = 0; i < context.Length; i++)
            {
                if (!char.IsNumber(context[i]))//If current character is not a number
                {
                    isnumber = false;
                    break;
                }
            }
            //If not a number clear the textbox and focus on it
            //to enter lives again
            if (isnumber == false)
            {
                TxtLives.Clear();
                TxtLives.Focus();
            }

            else
            {
                txtlives = true;
                if (text && txtlives == true)
                {
                    FileStart.Enabled = true;
                }
                else
                {
                    FileStart.Enabled = false;
                }
            }
        }

        private void tmrMissile_Tick(object sender, EventArgs e)
        {
            if (space) //If right arrow key pressed
            {
                //missile.missileRec.Location = new Point(missile.missileRec.X, missile.missileRec.Y);
                shoot = "shoot";
                missile.shootMissile(shoot);
                //if (missile.missileRec.Location.X > 390)
                //{
                //    missile.missileRec.X = serpent.serpentRec.X;
                //    missile.missileRec.Y = serpent.serpentRec.Y;
                //}
            }
            for (int i = 0; i <= 6; i++)
            {
                rival[i].moveRival();
                if (missile.missileRec.IntersectsWith(rival[i].rivalRec))
                {
                    //reset rival[i] back to top of panel
                    rival[i].x = 460; //Set  y value of rivalRec
                    lives -= 1; //Lose a life
                    TxtLives.Text = lives.ToString(); //Display number of lives
                    checkLives();
                }

            }
            pnlGame.Invalidate(); //Makes the paint event fire to redraw the panel
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
                    rival[i].x = 460; //Set  y value of rivalRec
                    lives -= 1; //Lose a life
                    TxtLives.Text = lives.ToString(); //Display number of lives
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
                Application.Exit();
            }
        }
    }
}
