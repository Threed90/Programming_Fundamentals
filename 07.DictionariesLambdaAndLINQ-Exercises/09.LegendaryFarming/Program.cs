using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> materialDict = new Dictionary<string, Dictionary<string, int>>();


            materialDict.Add("materials", new Dictionary<string, int>());
            materialDict.Add("junks", new Dictionary<string, int>());
            materialDict["materials"].Add("shards", 0);
            materialDict["materials"].Add("fragments", 0);
            materialDict["materials"].Add("motes", 0);

            FillDictAndPrintItem(materialDict);
            
        }

        static void FillDictAndPrintItem(Dictionary<string, Dictionary<string, int>> materialDict)
        {

            while (true)
            {
                string[] input = Console.ReadLine().ToLower().Split().ToArray();

                FillDictionary(materialDict, input);

                if (materialDict["materials"]["shards"] >= 250)
                {

                    materialDict["materials"]["shards"] -= 250;
                    Console.WriteLine("Shadowmourne obtained!");
                    break;
                }
                else if (materialDict["materials"]["fragments"] >= 250)
                {
                    materialDict["materials"]["fragments"] -= 250;
                    Console.WriteLine("Valanyr obtained!");
                    break;
                }
                else if (materialDict["materials"]["motes"] >= 250)
                {
                    materialDict["materials"]["motes"] -= 250;
                    Console.WriteLine("Dragonwrath obtained!");
                    break;
                }

            }

            PrinfLeftedMats(materialDict);
        }

        private static void FillDictionary(Dictionary<string, Dictionary<string, int>> materialDict, string[] input)
        {
            for (int i = 1; i < input.Length; i += 2)
            {
                if (materialDict["materials"].ContainsKey(input[i]))
                {
                    materialDict["materials"][input[i]] += int.Parse(input[i - 1]);
                    if (materialDict["materials"][input[i]] >= 250)
                    {
                        break;
                    }
                }
                else if (!materialDict["junks"].ContainsKey(input[i]))
                {
                    materialDict["junks"].Add(input[i], int.Parse(input[i - 1]));
                }
                else
                {
                    materialDict["junks"][input[i]] += int.Parse(input[i - 1]);
                }

            }
        }

        private static void PrinfLeftedMats(Dictionary<string, Dictionary<string, int>> materialDict)
        {
            foreach (var pair in materialDict["materials"].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            foreach (var pair in materialDict["junks"].OrderBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
