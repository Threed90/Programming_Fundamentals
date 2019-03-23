using System;
using System.Linq;
using System.Numerics;

namespace _01.SinoTheWalker2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] time = Console.ReadLine().Split(':').Select(x=> int.Parse(x)).ToArray();

            int steps = int.Parse(Console.ReadLine());
            int secPerStep = int.Parse(Console.ReadLine());
            BigInteger totalSec = BigInteger.Multiply(steps, secPerStep);

            int sec = (int)(totalSec % 60);
            totalSec /= 60;
            int min = (int)(totalSec % 60);
            totalSec /= 60;
            int hour = (int)(totalSec % 24);

            sec += time[2];
            if(sec>=60)
            {
                min += sec / 60;
                sec %= 60;
            }
            min += time[1];
            if(min>=60)
            {
                hour += min / 60;
                min %= 60;
            }
            hour += time[0];
            if(hour>=24)
            {
                hour %= 24;
            }

            Console.WriteLine($"Time Arrival: {hour:d2}:{min:d2}:{sec:d2}");
        }
    }
}
