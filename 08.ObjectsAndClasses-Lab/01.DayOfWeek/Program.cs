using System;
using System.Globalization;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);

            //Console.WriteLine(date.ToString("dddd", new CultureInfo("en-En")));
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
