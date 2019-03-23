using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> result = new Dictionary<string, Dictionary<string, int>>();


            string[] cardPower = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] cardType = { "0", "C", "D", "H", "S" };

            FillDictCartPoints(result, cardPower, cardType);

            foreach (KeyValuePair<string, Dictionary<string, int>> pair in result)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Values.Sum()}");
            }
        }

        private static void FillDictCartPoints(Dictionary<string, Dictionary<string, int>> result, string[] cardPower, string[] cardType)
        {
            while (true)
            {

                string[] input1 = Console.ReadLine().Split(':').ToArray();
                if (input1[0] == "JOKER")
                {
                    break;
                }

                string[] input = input1[1].Split(" ,:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();


                if (!result.ContainsKey(input1[0]))
                {
                    result.Add(input1[0], new Dictionary<string, int>());
                }

                for (int i = 0; i < input.Length; i++)
                {
                    if (!result[input1[0]].ContainsKey(input[i]))
                    {
                        int value = Array.IndexOf(cardPower, input[i].Remove(input[i].Length - 1)) * Array.IndexOf(cardType, Convert.ToString(input[i].Last()));

                        result[input1[0]].Add(input[i], value);
                    }
                }


            }
        }
    }
}
