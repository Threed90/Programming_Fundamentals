using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Point> points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                points.Add(ReadPoint());
            }

            double distance = double.MaxValue;
            Point resultPoint1 = new Point(0, 0);
            Point resultPoint2 = new Point(0, 0);

            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    if (distance > Point.GetDistance(points[i], points[j]))
                    {
                        distance = Point.GetDistance(points[i], points[j]);
                        resultPoint1 = points[i];
                        resultPoint2 = points[j];
                    }
                }
            }

            Console.WriteLine($"{distance:f3}");
            Console.WriteLine($"({resultPoint1.X}, {resultPoint1.Y}){Environment.NewLine}({resultPoint2.X}, {resultPoint2.Y})");
            
        }

        private static Point ReadPoint()
        {
            int[] coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();

            return new Point(coordinates[0], coordinates[1]);
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

        public static double GetDistance(Point point1, Point point2)
        {
            double distance = Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
            return distance;
        }
    }
}
