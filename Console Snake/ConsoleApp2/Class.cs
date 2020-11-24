using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Point
    {
        public int x;
        public int y;
        public char z;

        public Point(int _x, int _y, char _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            z = p.z;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)     { x = x + offset; }
            else if (direction == Direction.LEFT) { x = x - offset; }
            else if (direction == Direction.UP)   { y = y + offset; }
            else if (direction == Direction.DOWN) { y = y - offset; }            
        }

        public void Draw()
        {
            Console.SetCursorPosition (x, y);
            Console.WriteLine (z);
        }
        public override string ToString()
        {
            return x + ", " + y + ", " + z;
        }

        public void Clear()
        {
            z = ' ';
            Draw ();
        }
    }
}
