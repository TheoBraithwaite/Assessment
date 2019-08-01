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
