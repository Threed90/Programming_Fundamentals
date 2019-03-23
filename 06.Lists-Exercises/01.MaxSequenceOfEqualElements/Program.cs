using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int bestSequnce = 0;
            int sequnceNumber = 0;

            foreach (int num in nums)
            {
                int counter = 0;
                foreach (int num2 in nums)
                {
                    if (num == num2)
                    {
                        counter++;
                    }
                }
                if (bestSequnce < counter)
                {
                    bestSequnce = counter;
                    sequnceNumber = num;
                }
            }

            for (int i = 0; i < bestSequnce; i++)
            {
                Console.Write(sequnceNumber + " ");
            }
            Console.WriteLine();
        }
    }
}
