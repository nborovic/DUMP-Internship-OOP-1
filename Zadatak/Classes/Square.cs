using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak.Classes
{
    public class Square
    {
        public Point PointA { get; set; }
        public Point PointB { get; set; }
        public Point PointC { get; set; }
        public Point PointD { get; set; }

        public double GetDistance(double x1, double x2)
        {
            return Math.Abs(x1 - x2);
        }

        public double GetSide(Point firstPoint, Point secondPoint)
        {
            var distanceX = GetDistance(PointA.X, PointB.X);
            var distanceY = GetDistance(PointA.Y, PointB.Y);

            return Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2));
        }

        public double GetCircumference()
        {
            return 4 * GetSide(PointA, PointB);
        }

        public double GetArea()
        {
            return Math.Pow(GetSide(PointA, PointB), 2);
        }
    }
}
