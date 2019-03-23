using System;

namespace Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnits = Console.ReadLine().ToLower();
            double imperialUntsValue = double.Parse(Console.ReadLine());


            Console.Write($"{imperialUntsValue} {imperialUnits} = ");
            switch (imperialUnits)
            {
                case "miles":
                    Console.WriteLine($"{imperialUntsValue * 1.6:f2} kilometers");
                    break;
                case "inches":
                    Console.WriteLine($"{imperialUntsValue * 2.54:f2} centimeters");
                    break;
                case "feet":
                    Console.WriteLine($"{imperialUntsValue * 30:f2} centimeters");
                    break;
                case "yards":
                    Console.WriteLine($"{imperialUntsValue * 0.91:f2} meters");
                    break;
                case "gallons":
                    Console.WriteLine($"{imperialUntsValue * 3.8:f2} liters");
                    break;
            }
            

        }
    }
}
