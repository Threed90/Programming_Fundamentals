using System;

namespace SumOfOdd
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int currentNum = 1;
            int totalSum = 0;

            for (int i = 1; i <= n; i++)
            {
                
                totalSum += currentNum;
                Console.WriteLine(currentNum);
                currentNum += 2;
            }
            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}
