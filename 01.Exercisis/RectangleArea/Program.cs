using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double wigth = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = wigth * height;

            Console.WriteLine($"{area:f2}");
        }
    }
}
