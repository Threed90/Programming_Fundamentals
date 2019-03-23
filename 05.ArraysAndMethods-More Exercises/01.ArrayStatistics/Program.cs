using System;
using System.Linq;

namespace _01.ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            PrintValues(array);
        }

        private static void PrintValues(double[] array)
        {
            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;
            

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];

                if (min > array[i])
                {
                    min = array[i];
                }

                if (max < array[i])
                {
                    max = array[i];
                }
            }

            double average = sum / array.Length;

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
