using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, long>> army = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, int> legionActivity = new Dictionary<string, int>();

            int iterations = int.Parse(Console.ReadLine());

            for (int i = 0; i < iterations; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { '=', '-', '>', ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 4)
                {
                    FillDictionary(tokens, army, legionActivity);
                }
            }
            PrintResult(Console.ReadLine(), army, legionActivity);
        }
        private static void PrintResult(string v, Dictionary<string, Dictionary<string, long>> army, Dictionary<string, int> legionActivity)
        {
            string[] tokens = v.Split('\\');
            if (tokens.Length == 1)
            {
                foreach (var item in legionActivity.OrderByDescending(x=> x.Value))
                {
                    if(army[item.Key].ContainsKey(tokens[0]))
                    Console.WriteLine($"{item.Value} : {item.Key}");
                }
            }
            else
            {
                int actLimit = int.Parse(tokens[0]);
                string type = tokens[1];

                foreach (var legion in army.Where(x => x.Value.ContainsKey(type)).OrderByDescending(x => x.Value[type]))
                {
                    if (legionActivity[legion.Key] < actLimit)
                        Console.WriteLine($"{legion.Key} -> {legion.Value[type]}");
                }
            }
        }

        private static void FillDictionary(string[] tokens, Dictionary<string, Dictionary<string, long>> army, Dictionary<string, int> legionActivity)
        {
            int activity = int.Parse(tokens[0]);
            string legion = tokens[1];
            string solderType = tokens[2];
            long count = long.Parse(tokens[3]);

            if (army.ContainsKey(legion) == false)
            {
                army.Add(legion, new Dictionary<string, long>());
                legionActivity.Add(legion, activity);
            }

            if (army[legion].ContainsKey(solderType) == false)
            {
                army[legion].Add(solderType, 0);
            }

            army[legion][solderType] += count;

            if (legionActivity[legion] < activity)
            {
                legionActivity[legion] = activity;
            }


        }
    }
}
