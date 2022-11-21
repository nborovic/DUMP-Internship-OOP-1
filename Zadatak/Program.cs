using System;
using Zadatak.Classes;

namespace Zadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var square = new Square()
            {
                PointA = new Point(5, 0),
                PointB = new Point(10, 0),
                PointC = new Point(10, 5),
                PointD = new Point(5, 5)
            };
            var triangle = new Triangle()
            {
                PointA = new Point(5, 0),
                PointB = new Point(8, 0),
                PointC = new Point(8, 4),
            };

            Console.WriteLine($"Square circumference: {square.GetCircumference()}");
            Console.WriteLine($"Square area: {square.GetArea()}");
            Console.WriteLine($"Triangle circumference: {triangle.GetCircumference()}");
            Console.WriteLine($"Triangle area: {triangle.GetArea()}");
        }
    }
}