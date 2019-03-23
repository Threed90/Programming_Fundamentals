using System;

namespace _01.HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFlaps = int.Parse(Console.ReadLine());

            double metersPer1000Flaps = double.Parse(Console.ReadLine());

            int endurance = int.Parse(Console.ReadLine());

            Console.WriteLine($"{(totalFlaps/1000)*metersPer1000Flaps:f2} m.");

            long totalSec = (totalFlaps / endurance) * 5L; // L is to represent long as value

            totalSec += (totalFlaps / 100);

            Console.WriteLine($"{totalSec} s.");


            // Make a test with this values:
            //                              1000000000
            //                              1000000
            //                              1

        }
    }
}
