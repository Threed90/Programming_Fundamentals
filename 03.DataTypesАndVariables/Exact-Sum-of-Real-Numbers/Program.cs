using System;

namespace Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int entranceNumber = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 0; i < entranceNumber; i++)
            {
                decimal numberForSum = decimal.Parse(Console.ReadLine());

                sum += numberForSum;
            }

            Console.WriteLine(sum);
        }
    }
}
