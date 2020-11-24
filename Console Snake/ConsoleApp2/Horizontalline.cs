using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Horizontalline : Figure
    {
        public Horizontalline(int xLeft, int xRight, int y, char z)
        {
            plist = new List<Point> ();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p2 = new Point(x, y, z);
                plist.Add (p2);
            }
        }
    }
}
