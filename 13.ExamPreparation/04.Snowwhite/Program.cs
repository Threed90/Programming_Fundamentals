using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dwarfs = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "Once upon a time")
            {
                string[] dwarfStats = input.Split(" <:>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (dwarfs.ContainsKey(dwarfStats[1]) == false)
                {
                    dwarfs.Add(dwarfStats[1], new Dictionary<string, int>());
                    dwarfs[dwarfStats[1]].Add(dwarfStats[0], int.Parse(dwarfStats[2]));
                }
                else
                {
                    if(!dwarfs[dwarfStats[1]].ContainsKey(dwarfStats[0]))
                    {
                        dwarfs[dwarfStats[1]].Add(dwarfStats[0], int.Parse(dwarfStats[2]));
                    }
                    else
                    {
                        dwarfs[dwarfStats[1]][dwarfStats[0]] = Math.Max(dwarfs[dwarfStats[1]][dwarfStats[0]], int.Parse(dwarfStats[2]));
                    }
                }

                input = Console.ReadLine();
            }
            List<Tuple<string, int>> forResult = new List<Tuple<string, int>>();
            foreach (var item in dwarfs.OrderByDescending(x => x.Value.Values.Max()).ThenByDescending(x => x.Value.Count()))
            {
                foreach (var item1 in item.Value.OrderByDescending(x => x.Value))
                {
                    forResult.Add(new Tuple<string, int>($"({item.Key}) {item1.Key} <-> ", item1.Value));
                }
            }

            foreach (var token in forResult.OrderByDescending(x => x.Item2))
            {
                Console.WriteLine($"{token.Item1}{token.Item2}");
            }
        }
    }
}
