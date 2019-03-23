using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> reports = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split('|').ToArray();

                if(input[0] == "report")
                {
                    break;
                }

                if (!reports.ContainsKey(input[1]))
                {
                    reports.Add(input[1], new Dictionary<string, long>());
                    reports[input[1]].Add(input[0], long.Parse(input[2]));
                }
                else
                {
                    if (reports[input[1]].ContainsKey(input[0]))
                    {
                        reports[input[1]][input[0]] += long.Parse(input[2]);
                    }
                    else
                    {
                        reports[input[1]].Add(input[0], long.Parse(input[2]));
                    }
                }
            }
            foreach (KeyValuePair<string, Dictionary<string,long>> item in reports.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value.Values.Sum()})");

                foreach (KeyValuePair<string,long> pair in reports[item.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{pair.Key}: {pair.Value}");
                }
            }
        }
    }
}
