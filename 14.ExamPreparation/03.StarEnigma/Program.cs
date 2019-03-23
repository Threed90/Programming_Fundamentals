using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Dictionary<char, List<Tuple<string, int>>> planets = new Dictionary<char, List<Tuple<string, int>>>();

            planets.Add('A', new List<Tuple<string, int>>());
            planets.Add('D', new List<Tuple<string, int>>());

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                int lettersCount = input.ToLower().Where(x => x == 's' || x == 't' || x == 'a' || x == 'r').ToArray().Length;

                string decryptedMSG = "";

                input.Select(x => x).ToList().ForEach(x =>
                {
                    decryptedMSG += (char)(x - lettersCount);
                });

                Match match = Regex.Match(decryptedMSG, @"(?<=@)([A-Za-z]+)(?:[^A-Za-z@!:>-]*):\d+(?:[^0-9@!:>-]*)!(A|D)!(?:[^@!:>-]*)->(\d+)");

                if(match.Groups[2].Value == "A")
                {
                    planets['A'].Add(new Tuple<string, int>(match.Groups[1].Value, 1));
                }
                else if(match.Groups[2].Value == "D")
                {
                    planets['D'].Add(new Tuple<string, int>(match.Groups[1].Value, 1));
                }
            }

            
            foreach (var planet in planets)
            {
                if(planet.Key == 'A')
                {
                    Console.WriteLine($"Attacked planets: {planet.Value.Sum(x => x.Item2)}");
                }
                else
                {
                    Console.WriteLine($"Destroyed planets: {planet.Value.Sum(x => x.Item2)}");
                }

                foreach (var name in planet.Value.OrderBy(x => x.Item1))
                {
                    Console.WriteLine($"-> {name.Item1}");
                }
            }
        }
    }
}
