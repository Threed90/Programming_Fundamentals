using System;

namespace _03.MinMaxSumAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());

            int divisor = iterations;
            double sum = 0;
            int min = int.MaxValue;
            int max = int.MinValue;

            while (iterations>0)
            {
                int number = int.Parse(Console.ReadLine());

                sum += number;
                if (min > number)
                {
                    min = number;
                }
                if (max < number)
                {
                    max = number;
                }
                iterations--;
            }

            double average = sum / divisor;

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
