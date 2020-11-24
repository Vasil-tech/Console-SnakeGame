using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point t1 = new Point (0, 0, '#');
            t1.Draw ();

            Point t2 = new Point (119, 0, '#');
            t2.Draw ();

            Point t3 = new Point (0, 29, '#');
            t3.Draw ();

            Point t4 = new Point (119, 29, '#');
            t4.Draw ();


            Verticalline Leftline = new Verticalline (0, 28, 1, '|');
            Leftline.Drow ();

            Verticalline Rightline = new Verticalline(119, 28, 1, '|');
            Rightline.Drow ();

            Horizontalline Upline = new Horizontalline (1, 118, 0, '-');
            Upline.Drow ();

            Horizontalline Downline = new Horizontalline (1, 118, 29, '_');
            Downline.Drow ();

            Point p = new Point (10, 10, '@');
            Snake z = new Snake (p, 10, Direction.RIGHT);
            z.Drow ();
            z.Move ();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey ();
                    z.Handle (key.Key);
                }
                Thread.Sleep (100);
                z.Move ();
            }
        }
    }  
}
