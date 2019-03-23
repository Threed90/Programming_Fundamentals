using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<double>>> dragons = new Dictionary<string, Dictionary<string, List<double>>>();

            int iterations = int.Parse(Console.ReadLine());

            while (iterations > 0)
            {
                InputAndFillDictionary(dragons);

                iterations--;
            }

            PrintResult(dragons);
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, List<double>>> dragons)
        {
            foreach (var pair in dragons)
            {
                double dmg = 0.00;
                double health = 0.00;
                double armor = 0.00;
                int counter = 0;

                foreach (var item1 in dragons[pair.Key])
                {
                    counter++;
                    dmg += item1.Value[0];
                    health += item1.Value[1];
                    armor += item1.Value[2];
                }
                Console.WriteLine($"{pair.Key}::({dmg / counter:f2}/{health / counter:f2}/{armor / counter:f2})");

                foreach (var item1 in dragons[pair.Key].OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{item1.Key} -> damage: {item1.Value[0]}, health: {item1.Value[1]}, armor: {item1.Value[2]}");
                }
            }
        }

        private static void InputAndFillDictionary(Dictionary<string, Dictionary<string, List<double>>> dragons)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            if (input[2] == "null")
            {
                input[2] = "45";
            }
            if (input[3] == "null")
            {
                input[3] = "250";
            }
            if (input[4] == "null")
            {
                input[4] = "10";
            }

            string type = input[0];
            string name = input[1];
            double dmg = double.Parse(input[2]);
            double health = double.Parse(input[3]);
            double armor = double.Parse(input[4]);

            if (!dragons.ContainsKey(type))
            {
                dragons[type] = new Dictionary<string, List<double>>();
                dragons[type][name] = new List<double>();
                dragons[type][name].Add(dmg);
                dragons[type][name].Add(health);
                dragons[type][name].Add(armor);
            }
            else
            {
                if (!dragons[type].ContainsKey(name))
                {
                    dragons[type][name] = new List<double>();
                    dragons[type][name].Add(dmg);
                    dragons[type][name].Add(health);
                    dragons[type][name].Add(armor);
                }
                else
                {
                    dragons[type][name][0] = dmg;
                    dragons[type][name][1] = health;
                    dragons[type][name][2] = armor;
                }
            }
        }
    }
}
