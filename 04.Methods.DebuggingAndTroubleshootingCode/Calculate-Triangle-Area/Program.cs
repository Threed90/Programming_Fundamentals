using System;

namespace Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(GetTriangleArea(width, height));
        }
        /// <summary>
        /// Write width(base) and height on triangle to calculate area. Values must be double types.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
