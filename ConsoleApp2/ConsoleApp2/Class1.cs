using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Verticalline : Figure
    {
        public Verticalline(int x, int yUp, int yDown, char z)
        {
            plist = new List<Point> ();
            for (int y = yDown; y <= yUp; y++)
            {
                Point p = new Point (x, y, z);
                plist.Add (p);
            }
        } 
    }
}
