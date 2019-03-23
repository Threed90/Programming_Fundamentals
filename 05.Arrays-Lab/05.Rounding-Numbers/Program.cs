using System;
using System.Linq;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            GetRounding(input);

            
        }

        static double[] GetRounding(double[] array)
        {
            int i = 0;
            double[] roundedArray = new double[array.Length];

            foreach (double item in array)
            {
                roundedArray[i] = Math.Round(array[i], MidpointRounding.AwayFromZero);

                

                Console.WriteLine($"{array[i]} => {roundedArray[i]}");
                i++;
            }
            
            return roundedArray;
        }

    }
}
