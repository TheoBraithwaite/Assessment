using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace CelestialLiberty
{
    class Serpent
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image serpent;//variable for the planet's image

        public Rectangle serpentRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Serpent()
        {
            x = 250;
            y = 360;
            width = 40;
            height = 40;
            serpent = Image.FromFile("alien1.png");
            serpentRec = new Rectangle(x, y, width, height);
        }

        //methods
        public void drawSerpent(Graphics g)
        {
            g.DrawImage(serpent, serpentRec);
        }
        public void moveSerpent (string move)
        {
            if (move == "right")
            {
                if (serpentRec.Location.X > 450) //Is Serpent within 50 of right side
                {
                    x = 450;
                    serpentRec.Location = new Point(x, y);
                }
                else
                {
                    x += 5;
                    serpentRec.Location = new Point(x, y);
                }
            }
            if (move == "left")
            {
                if (serpentRec.Location.X < 10) // is spaceship within 10 of left side
                {

                    x = 10;
                    serpentRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 5;
                    serpentRec.Location = new Point(x, y);
                }

            }

        }
    }
}
