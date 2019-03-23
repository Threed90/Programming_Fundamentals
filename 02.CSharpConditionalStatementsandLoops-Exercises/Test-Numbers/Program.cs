using System;

namespace Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int sumBoundary = int.Parse(Console.ReadLine());

            int combinationCount = 0;
            int currentSum = 0;

            for (int i = N; i > 0; i--)
            {
                for (int j = 1; j <= M; j++)
                {
                    currentSum += (3 * (i * j));
                    combinationCount++;

                    if (currentSum >= sumBoundary)
                    {
                        break;
                    }

                }

                if (currentSum >= sumBoundary)
                {
                    break;
                }
            }

            Console.WriteLine($"{combinationCount} combinations");

            if (currentSum >= sumBoundary)
            {
                
                Console.WriteLine($"Sum: {currentSum} >= {sumBoundary}");
            }
            else
            {
                Console.WriteLine($"Sum: {currentSum}");
            }
            
        }
    }
}
