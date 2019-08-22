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
            x = 20;
            y = 200;
            width = 30;
            height = 30;
            serpent = Image.FromFile("serpent.png");
            serpentRec = new Rectangle(x, y, width, height);
        }


        //Methods for the Serpent class
        public void drawSerpent(Graphics g)
        {
            g.DrawImage(serpent, serpentRec);
        }
        public void moveSerpent (string move)
        {
            if (move == "up")
            {
                if (serpentRec.Location.Y < 10) //Is Serpent within 50 of right side
                {
                    y = 10;
                    serpentRec.Location = new Point(x, y);
                }
                else
                {
                    y -= 5;
                    serpentRec.Location = new Point(x, y);
                }
            }
            if (move == "down")
            {
                if (serpentRec.Location.X > 490) // is spaceship within 10 of left side
                {

                    x = 490;
                    serpentRec.Location = new Point(x, y);
                }
                else
                {
                    y += 5;
                    serpentRec.Location = new Point(x, y);
                }

            }

        }
    }
}
