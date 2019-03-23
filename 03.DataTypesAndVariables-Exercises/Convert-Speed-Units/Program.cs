using System;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            double distanceInMeters = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());

            double distanceInKilometers = distanceInMeters / 1000;
            double distanceInMiles = distanceInMeters / 1609;

            double allInSeconds = hours * 3600 + minutes * 60 + seconds;
            double allInHours = allInSeconds / 3600;

            Console.WriteLine($"{distanceInMeters/allInSeconds:f7}");
            Console.WriteLine($"{distanceInKilometers / allInHours:f7}");
            Console.WriteLine($"{distanceInMiles/allInHours:f7}");
        }
    }
}
