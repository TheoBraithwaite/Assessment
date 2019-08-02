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
        string move;
        Graphics g; //Declare a graphics object called g
        // declare space for an array of 7 objects called planet 
        Rival[] rival = new Rival[7];
        Random yspeed = new Random();
        Serpent serpent = new Serpent();

        public CelestialLiberty()
        {
            InitializeComponent();

            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 75);
                rival[i] = new Rival(x);
            }
        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //Get the graphics used to paint on the panel control
            g = e.Graphics;

            //Call the Planet class's DrawPlanet method to draw the image planet1 
            for (int i = 0; i < 7; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(5, 20);
                rival[i].y += rndmspeed;

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

        private void tmrRival_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                rival[i].moveRival();
            }
            pnlGame.Invalidate(); //Makes the paint event fire to redraw the panel
        }
    }
}
