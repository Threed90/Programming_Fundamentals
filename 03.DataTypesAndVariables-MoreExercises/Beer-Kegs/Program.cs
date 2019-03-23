using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfKegs = byte.Parse(Console.ReadLine());

            double kegArea = 0;
            string kegName = "";

            for (byte forEachKeg = 1; forEachKeg <= numberOfKegs ; forEachKeg++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                double area = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;

                if (kegArea < area)
                {
                    kegArea = area;
                    kegName = kegModel;
                }
            }

            Console.WriteLine(kegName);
        }
    }
}
