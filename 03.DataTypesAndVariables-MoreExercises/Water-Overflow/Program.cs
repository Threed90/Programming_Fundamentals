using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            int tankCapacity = 255;
            int tankFilling = 0;

            for (int pours = 1; pours <= numberOfLines; pours++)
            {
                int liters = int.Parse(Console.ReadLine());

                tankFilling += liters;

                if( tankFilling> tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");

                    tankFilling -= liters;
                }
            }
            Console.WriteLine(tankFilling);
        }
    }
}
