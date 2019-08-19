﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace CelestialLiberty
{
    class Missile
    {
        public int x, y, width, height;//variables for the rectangle
        public Image missile;//variable for the planet's image

        public Rectangle missileRec;//variable for a rectangle to place our image in
        public Rectangle serpentRec;

        //Create a constructor (initialises the values of the fields)
        public Missile()
        {
            width = 30;
            height = 30;
            missile = Image.FromFile("planet1.png");
            missileRec = new Rectangle(x, y, width, height);
        }
        public void drawMissile(Graphics g)
        {
            g.DrawImage(missile, missileRec);
        }
        public void shootMissile(string space)
        {
            missileRec.Location = new Point(x, y);
            if (space == "shoot")
            {
                if (missileRec.Location.X > 390)
                {
                    x = 20;
                    y = 200;
                    missileRec.Location = new Point(x, y);
                }
            }
            else
            {
                x += 30;
                missileRec.Location = new Point(x, y);
            }
        }
    }
}
