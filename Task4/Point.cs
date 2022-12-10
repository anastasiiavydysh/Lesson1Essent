using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Point
    {
        int x, y;
        string text;
        public int X { get; }
        public int Y { get; }
        public string Text { get; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
