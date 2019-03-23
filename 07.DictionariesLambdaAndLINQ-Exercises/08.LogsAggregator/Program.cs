using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> userDutationAndIP = new Dictionary<string, Dictionary<string, int>>();

            FillAndPrintDict(iterations, userDutationAndIP);
            
        }

        

        private static void FillAndPrintDict(int iterations, Dictionary<string, Dictionary<string, int>> userDutationAndIP)
        {
            for (int i = 0; i < iterations; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                FillDict(userDutationAndIP, input);
            }

            PrintResult(userDutationAndIP);
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, int>> userDutationAndIP)
        {
            string ipResult = "";
            foreach (KeyValuePair<string, Dictionary<string, int>> item in userDutationAndIP.OrderBy(x => x.Key))
            {
                Console.Write($"{item.Key}: {item.Value.Values.Sum()} ");

                foreach (KeyValuePair<string, int> pair in userDutationAndIP[item.Key].OrderBy(x => x.Key))
                {
                    ipResult += $"{pair.Key}, ";
                }

                Console.WriteLine($"[{ipResult.TrimEnd(',', ' ')}]");
                ipResult = "";
            }
        }

        private static void FillDict(Dictionary<string, Dictionary<string, int>> userDutationAndIP, string[] input)
        {
            if (!userDutationAndIP.ContainsKey(input[1]))
            {
                userDutationAndIP.Add(input[1], new Dictionary<string, int>());
                userDutationAndIP[input[1]].Add(input[0], int.Parse(input[2]));
            }
            else
            {
                if (userDutationAndIP[input[1]].ContainsKey(input[0]))
                {
                    userDutationAndIP[input[1]][input[0]] += int.Parse(input[2]);
                }
                else
                {
                    userDutationAndIP[input[1]].Add(input[0], int.Parse(input[2]));
                }
            }
        }
    }
}
