using System;
using System.Linq;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] word2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            PrintCommon(word, word2);
        }

        private static void PrintCommon(string[] word, string[] word2)
        {
            int max = Math.Max(word.Length, word2.Length);
            int min = Math.Min(word.Length, word2.Length);

            int j = 0;
            int k = 0;

            for (int i = 0; i < min; i++)
            {
                if (word[i] == word2[i])
                {
                    j++;
                }

                if (word[word.Length - 1 - i] == word2[word2.Length - 1 - i])
                {
                    k++;
                }

            }

            Console.WriteLine(Math.Max(j, k));

            //string[] commonPart = new string[max];
            //int j = 0;



            //if (word[0] == word2[0])
            //{
            //    for (int i = 0; i <= min; i++)
            //    {

            //        if (word[i].Contains(word2[i]))
            //        {
            //            commonPart[j] = word[i];
            //            j++;
            //        }
            //    }

            //    Console.WriteLine($"The largest common end is at the left: {string.Join(" ", commonPart).TrimEnd()}");
            //}
            //else if (word[word.Length-1] == word2[word2.Length-1])
            //{
            //    for (int i = min - 1, k = max-1; i >= 0; i--, k--)
            //    {
            //        if (word[k].Contains(word2[i]))
            //        {
            //            commonPart[max - 1 - j] = word[k];
            //            j++;
            //        }
            //    }
            //    Console.WriteLine($"The largest common end is at the right: {string.Join(" ", commonPart).Trim()}");
            //}
            //else
            //{
            //    Console.WriteLine("No common words at the left and right");
            //}
        }
    }
}
