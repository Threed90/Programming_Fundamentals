using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] len = new int[numbers.Count];
            int[] prev = new int[numbers.Count];
            List<int> longestSequence = new List<int>();
            int maxLen = 0;
            int maxIndex = -1;

            for (int i = 0; i < len.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if(numbers[j]<numbers[i] && len[j] + 1 > len[i])
                    {
                        len[i] = 1 + len[j];
                        prev[i] = j;
                    }
                }
                if (len[i] > maxLen)
                {
                    maxLen = len[i];
                    maxIndex = i;
                }
            }

            while (maxIndex != -1)
            {
                longestSequence.Add(numbers[maxIndex]);
                maxIndex = prev[maxIndex];
            }

            longestSequence.Reverse();
            Console.WriteLine(string.Join(" ", longestSequence));
        }
    }
}
