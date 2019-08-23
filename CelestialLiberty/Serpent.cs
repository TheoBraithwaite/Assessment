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
                if (serpentRec.Location.Y < 10) //Is Serpent's y location below 10
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
                if (serpentRec.Location.Y > 350) // is Serpent's y location above 350
                {

                    y = 350;
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
