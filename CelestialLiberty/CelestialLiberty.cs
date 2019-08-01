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
        Planet[] planet = new Planet[7];

        public CelestialLiberty()
        {
            InitializeComponent();

            for (int i = 0; i < 7; i++)
            {
                Rival[i] = new Rival();
            }
        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //Get the graphics used to paint on the panel control
            g = e.Graphics;
            //Call the Planet class's DrawPlanet method to draw the image planet1 
            for (int i = 0; i < 7; i++)
            {
                //call the Planet class's drawPlanet method to draw the images
                Rival[i].drawRival(g);
            }
        }
    }
}
