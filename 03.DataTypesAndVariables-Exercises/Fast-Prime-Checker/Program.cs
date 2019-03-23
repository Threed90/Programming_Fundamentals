using System;

namespace Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberMaxRange = int.Parse(Console.ReadLine());
            for (int numberCounter = 2; numberCounter <= numberMaxRange; numberCounter++)
            {
                bool isPrime = true;
                for (int primeChecker = 2; primeChecker <= Math.Sqrt(numberCounter); primeChecker++)
                {
                    if (numberCounter % primeChecker == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{numberCounter} -> {isPrime}");
            }

        }
    }
}
