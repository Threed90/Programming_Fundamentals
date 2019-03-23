using System;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacciNumber(number));
        }

        static int GetFibonacciNumber(int number)
        {
            int previousNumber = 0;
            int nextNumber = 1;
            int sum = 0;

            for (int counter = 0; counter <= number; counter++)
            {
                sum = previousNumber + nextNumber;
                previousNumber = nextNumber;
                nextNumber = sum;
            }
            return previousNumber;
        }
    }
}
