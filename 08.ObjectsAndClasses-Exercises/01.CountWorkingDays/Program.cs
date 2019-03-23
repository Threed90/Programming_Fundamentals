using System;
using System.Globalization;
using System.Linq;

namespace _01.CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays = new DateTime[] 
            {
                new DateTime(4,01,01),
                new DateTime(4,03,03),
                new DateTime(4,05,01),
                new DateTime(4,05,06),
                new DateTime(4,05,24),
                new DateTime(4,09,06),
                new DateTime(4,09,22),
                new DateTime(4,11,01),
                new DateTime(4,12,24),
                new DateTime(4,12,25),
                new DateTime(4,12,26)
            };
            

            int counter = 0;
            for (DateTime i = startDate; i<=endDate; i = i.AddDays(1))
            {
                DateTime currDay = new DateTime(4, i.Month, i.Day);
                counter = GetWrkingDays(holidays, counter, i, currDay);
            }

            Console.WriteLine(counter);
        }

        private static int GetWrkingDays(DateTime[] holidays, int counter, DateTime i, DateTime currDay)
        {
            if ((i.DayOfWeek != DayOfWeek.Sunday) && (i.DayOfWeek != DayOfWeek.Saturday) &&
                               !holidays.Contains(currDay))
            {
                counter++;

            }

            return counter;
        }
    }
}
