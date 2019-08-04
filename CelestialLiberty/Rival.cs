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
        public Rival(int spacing)
        {
            x = spacing;
            y = 10;
            width = 20;
            height = 20;
            rivalImage = Image.FromFile("planet1.png");
            rivalRec = new Rectangle(x, y, width, height);
        }
        //Methods for the Planet class
        public void drawRival(Graphics g)
        {
            g.DrawImage(rivalImage, rivalRec);
        }
        public void moveRival()
        {
            rivalRec.Location = new Point(x, y);

            if (rivalRec.Location.Y > 400)
            {
                score += 1; //Add 1 to score when rival reaches far-left side of panel
                y = 20;
                rivalRec.Location = new Point(x, y);
            }
        }
    }
}
