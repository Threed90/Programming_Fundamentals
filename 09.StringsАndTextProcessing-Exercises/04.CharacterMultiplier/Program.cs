using System;
using System.Linq;

namespace _04.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int max = Math.Max(input[0].Length, input[1].Length);

            int sum = 0;

            for (int i = 0; i < max; i++)
            {
                int first = input[0].ElementAtOrDefault(i);
                int second = input[1].ElementAtOrDefault(i);

                if (first == 0 || second == 0)
                {
                    sum += (first + second);
                }
                else
                {
                    sum += first * second;
                }

            }

            Console.WriteLine(sum);
        }
    }
}
