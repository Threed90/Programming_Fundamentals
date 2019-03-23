﻿using System;

namespace Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = width * 2 + height * 2;
            double area = width * height;
            double powSumOfSides = Math.Pow(width, 2) + Math.Pow(height, 2);
            double diagonalOfRectangle = Math.Sqrt(powSumOfSides);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonalOfRectangle);
        }
    }
}
