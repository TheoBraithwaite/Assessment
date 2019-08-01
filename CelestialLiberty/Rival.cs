using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace CelestialLiberty
{
    class Rival
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image rivalImage;//variable for the planet's image

        public Rectangle rivalRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Rival()
        {
            x = 10;
            y = 10;
            width = 20;
            height = 20;
            rivalImage = Image.FromFile("rival.png");
            rivalRec = new Rectangle(x, y, width, height);
            g.DrawImage(rivalImage, rivalRec);
        }
        //Methods for the Planet class
        public void drawRival(Graphics g)
        {
            g.DrawImage(rivalImage, rivalRec);
        }
    }
}
