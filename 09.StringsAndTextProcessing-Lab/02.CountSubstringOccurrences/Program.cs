using System;
using System.Linq;

namespace _02.CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            GetAppersNumber(word, pattern);
        }

        private static void GetAppersNumber(string word, string pattern)
        {
            int number = 0;
            for (int i = 0; i < word.Length; i++)
            {
                int omg = word.IndexOf(pattern, i);
                if (omg != -1)
                {
                    number++;
                }
                else
                {
                    break;
                }
                i = omg;
            }

            Console.WriteLine(number);
        }
    }
}
