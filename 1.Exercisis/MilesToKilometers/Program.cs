using System;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal miles = decimal.Parse(Console.ReadLine());

            decimal kilometers = miles * 1.60934m;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
