using System;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            // coordinate system points - (x1,y1),(x2,y2)
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            if (GetDistance(x1, y1) > GetDistance(x2, y2))
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");

            }
        }
        /// <summary>
        /// Calculate distance between center (zero point) of coordinate system and a sigle point with coodinates (x1,y1).
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        static double GetDistance(double x, double y)
        {
            double distance = Math.Sqrt(x * x + y * y);

            return distance;
        }
    }
}
