using System;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            //points on coordinate system - (x1,y1), (x2,y2) - first line
            //                              (x3,y3), (x4, y4) - second line

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            if (GetDistanceBetwinPoints(x1, y1, x2, y2) >= GetDistanceBetwinPoints(x3, y3, x4, y4))
            {
                if (GetDistanceFromZero(x1, y1) <= GetDistanceFromZero(x2, y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else if (GetDistanceBetwinPoints(x1, y1, x2, y2) < GetDistanceBetwinPoints(x3, y3, x4, y4))
            {
                if (GetDistanceFromZero(x3, y3) <= GetDistanceFromZero(x4, y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
            

        }
        /// <summary>
        /// Calculate distance between 2 points of coordinate system - between (x,y) and (x2,y2)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        static double GetDistanceBetwinPoints(double x, double y, double x2, double y2)
        {
            double minX = Math.Min(x, x2);
            double maxX = Math.Max(x, x2);

            double minY = Math.Min(y, y2);
            double maxY = Math.Max(y, y2);
            double distance = Math.Sqrt(Math.Pow(maxX - minX, 2) + Math.Pow(maxY - minY, 2));

            return distance;
        }
        /// <summary>
        /// Calculate distance between center (zero point) of coordinate system and a sigle point with coodinates (x1,y1).
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static double GetDistanceFromZero(double x, double y)
        {
            double distance = Math.Sqrt(x * x + y * y);

            return distance;
        }
    }
}
