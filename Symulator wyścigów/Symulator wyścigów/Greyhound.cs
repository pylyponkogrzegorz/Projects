using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symulator_wyścigów
{

    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public static Random MyRandom = new Random();
        
        public bool Run()
        {
            Location += MyRandom.Next(1, 20);
            MyPictureBox.Location = new Point(Location, MyPictureBox.Location.Y);
            if (Location >= (RacetrackLength - 80))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            Location = StartingPosition;
            MyPictureBox.Location = new Point(Location, MyPictureBox.Location.Y);
        }
    }
}
