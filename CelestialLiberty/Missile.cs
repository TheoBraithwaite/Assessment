using System;
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
        public Image missile;//variable for the missile's image

        public Rectangle missileRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Missile()
        {
            x = 20;
            y = 200;
            width = 30;
            height = 30;
            missile = Image.FromFile("missile1.png");
            missileRec = new Rectangle(x, y, width, height);
        }
        public void drawMissile(Graphics g)
        {
            g.DrawImage(missile, missileRec);
        }
        public void shootMissile(string shoot)
        {
            if (shoot == "shoot")
            {
                if (missileRec.X < 390)
                {
                    missileRec.Location = new Point(x, y);
                }
            }
        }
    }
}
