using System;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(isPrime(number));
        }

        static bool isPrime(long number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int primeChecker = 2; primeChecker <= Math.Sqrt(number); primeChecker++)
            {
                if (number%primeChecker == 0)
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
