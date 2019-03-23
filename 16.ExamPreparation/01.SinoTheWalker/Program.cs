using System;
using System.Globalization;
using System.Numerics;

namespace _01.SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);

            int steps = int.Parse(Console.ReadLine());
            int stepPerSec = int.Parse(Console.ReadLine());

            BigInteger total = BigInteger.Multiply(stepPerSec, steps);

            int sec = (int)(total % 60);
            total = total / 60;
            int min = (int)(total % 60);
            total = total / 60;
            int hour = (int)(total%24);

            //string result = $"{hour:d2}:{min:d2}:{sec:d2}";

            time = time.Add(new TimeSpan(hour, min, sec));

            Console.WriteLine($"Time Arrival: {time.Hour:d2}:{time.Minute:d2}:{time.Second:d2}");
            
        }
    }
}
