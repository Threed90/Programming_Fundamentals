using System;
using System.Linq;

namespace _04.DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = ReadPoint();
            Point point2 = ReadPoint();

            Console.WriteLine($"{Point.GetDistance(point, point2):f3}");

        }

        private static Point ReadPoint()
        {
            int[] coordinats = Console.ReadLine().Split().Select(int.Parse).ToArray();

            return new Point(coordinats[0], coordinats[1]);
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static double GetDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
    }

}
