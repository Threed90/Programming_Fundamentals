using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split().ToArray();

            List<string> result = GetResult(input);

            Console.WriteLine(string.Join(", ", result));
        }

        private static List<string> GetResult(string[] input)
        {
            Dictionary<string, int> wordsCounter = new Dictionary<string, int>();

            FillDictionary(input, wordsCounter);

            List<string> result = new List<string>();

            FillList(wordsCounter, result);
            return result;
        }

        private static void FillList(Dictionary<string, int> wordsCounter, List<string> result)
        {
            foreach (KeyValuePair<string, int> pairs in wordsCounter)
            {
                if (pairs.Value % 2 != 0)
                {
                    result.Add(pairs.Key);
                }
            }
        }

        private static void FillDictionary(string[] input, Dictionary<string, int> wordsCounter)
        {
            foreach (string word in input)
            {
                if (!wordsCounter.ContainsKey(word))
                {
                    wordsCounter.Add(word, 1);
                }
                else
                {
                    wordsCounter[word]++;
                }
            }
        }
    }
}
