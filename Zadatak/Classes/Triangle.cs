using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak.Classes
{
    public class Triangle
    {
        public Point PointA { get; set; }
        public Point PointB { get; set; }
        public Point PointC { get; set; }
        
        public double GetDistance(double x1, double x2)
        {
            return Math.Abs(x1 - x2);
        }

        public double GetSide(Point firstPoint, Point secondPoint)
        {
            var distanceX = GetDistance(firstPoint.X, secondPoint.X);
            var distanceY = GetDistance(firstPoint.Y, secondPoint.Y);

            return Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2));
        }

        public double GetCircumference()
        {
            return GetSide(PointA, PointB) + GetSide(PointB, PointC) + GetSide(PointC, PointA);
        }

        public double GetArea()
        {
            return GetSide(PointA, PointB) * GetSide(PointB, PointC) / 2;
        }
    }
}
