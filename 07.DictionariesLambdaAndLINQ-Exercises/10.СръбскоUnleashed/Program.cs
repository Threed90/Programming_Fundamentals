using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10.СръбскоUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> result = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                if (!input.Contains('@'))
                {
                    continue;
                }

                string singerName = input.Substring(0, input.IndexOf("@")).TrimEnd();
                if (singerName.Split().ToArray().Length > 3)
                {
                    continue;
                }

                string[] otherParts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(singerName.Split().ToArray().Length).ToArray();
                if (otherParts.Length < 3)
                {
                    continue;
                }
                int ticketPrice = 0;
                int ticketCount = 0;
                if (int.TryParse(otherParts[otherParts.Length - 2], out int num))
                {
                    ticketPrice = num;
                    ticketCount = int.Parse(otherParts[otherParts.Length - 1]);
                }
                else
                {
                    continue;
                }
                string town = "";


                for (int i = 0; i < otherParts.Length - 2; i++)
                {
                    town += otherParts[i] + " ";
                }
                if (town.Split().ToArray().Length > 3 && !town.StartsWith("@"))
                {
                    continue;
                }
                town = town.Trim('@', ' ');

                FillDictionaryAndPrint(result, singerName, town, ticketPrice, ticketCount);

            }

            PrintResult(result);
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, int>> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item.Key);
                foreach (var pair in result[item.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {pair.Key} -> {pair.Value}");
                }
            }
        }

        private static void FillDictionaryAndPrint(Dictionary<string, Dictionary<string, int>> result, string singerName, string town, int ticketPrice, int ticketCount)
        {
            if (!result.ContainsKey(town))
            {
                result[town] = new Dictionary<string, int>();
                result[town][singerName] = ticketPrice * ticketCount;
            }
            else
            {
                if (!result[town].ContainsKey(singerName))
                {
                    result[town][singerName] = ticketPrice * ticketCount;
                }
                else
                {
                    result[town][singerName] += (ticketPrice * ticketCount);
                }
            }


        }
    }
}
