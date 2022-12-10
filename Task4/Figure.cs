using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Figure
    {
        public Point PointA { get; }
        public Point PointB { get; }
        public Point PointC { get; }
        public Point PointD { get; } = new Point(0, 0);
        public Point PointE { get; } = new Point(0, 0);

        public Figure(Point a, Point b, Point c)
        {
            PointA = a;
            PointB = b;
            PointC = c;
            Console.WriteLine("Трикутник");
        }
        public Figure(Point a, Point b, Point c, Point d)
        {
            PointA = a;
            PointB = b;
            PointC = c;
            PointD = d;
            Console.WriteLine("Чотирикутник");
        }
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            PointA = a;
            PointB = b;
            PointC = c;
            PointD = d;
            PointE = e;
            Console.WriteLine("П'ятикутник");
        }
        private double LengthSide(Point a, Point b)
        {
            //AB = √(xb - xa)2 + (yb - ya)2
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }
        public void PerimeterCalculator()
        {
            double sideA = LengthSide(PointA, PointB);
            double sideB = LengthSide(PointB, PointC);
            double sideC = LengthSide(PointC, PointD);
            double sideD = LengthSide(PointD, PointE);
            Console.WriteLine("Perimetr = " + (sideA + sideB + sideC + sideD));
        }
    }
}
