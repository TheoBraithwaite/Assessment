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
        Rival planet1 = new Rival(); //Create the object, planet1
        public CelestialLiberty()
        {
            InitializeComponent();
        }
    }
}
