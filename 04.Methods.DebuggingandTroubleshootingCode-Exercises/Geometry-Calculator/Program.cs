using System;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            InputAndPrintFigureParameters(figureType);
        }
        /// <summary>
        /// Write console's input based of string as figure type. String value can be - triangle, rectangle, square, circle.
        /// And then print area value of figure type.
        /// </summary>
        /// <param name="figureType"></param>
        static void InputAndPrintFigureParameters(string figureType)
        {
            if (figureType.ToLower() == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine($"{GetTriangleArea(side, height):f2}");
            }
            else if(figureType.ToLower() == "square")
            {
                double side = double.Parse(Console.ReadLine());

                Console.WriteLine($"{GetSquareArea(side):f2}");
            }
            else if(figureType.ToLower() == "rectangle")
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine($"{GetRectangleArea(length, width):f2}");
            }
            else if (figureType.ToLower() == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                Console.WriteLine($"{GetCircleArea(radius):f2}");
            }
        }
        /// <summary>
        /// Calculation triangle area.
        /// </summary>
        /// <param name="side"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        static double GetTriangleArea(double side, double height)
        {
            double area = side * height / 2;
            return area;
        }
        /// <summary>
        /// Calculation of square area.
        /// </summary>
        /// <param name="side"></param>
        /// <returns></returns>
        static double GetSquareArea(double side)
        {
            double area = side * side;
            return area;
        }
        /// <summary>
        /// Calculation of rectangle area.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        static double GetRectangleArea(double length, double width)
        {
            double area = length * width;
            return area;
        }
        /// <summary>
        /// Calculation of circle area.
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        static double GetCircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }
    }
}
