using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> karaoke = new Dictionary<string, Dictionary<string, string>>();
            karaoke = Console.ReadLine().Split(',').ToDictionary(x => x.Trim(), y => new Dictionary<string, string>());
            string[] songs = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();

            string onTheStage = "";
            
            while ((onTheStage = Console.ReadLine()) != "dawn")
            {
                string[] tokens = onTheStage.Split(',').Select(x => x.Trim()).ToArray();
                string participantName = tokens[0];
                string song = tokens[1];
                string award = tokens[2];

                if (karaoke.ContainsKey(participantName) && songs.Contains(song))
                {
                    if (!karaoke[participantName].ContainsKey(award))
                        karaoke[participantName].Add(award, song);
                }
            }
            if (karaoke.Values.Select(x => x.Values.Count).Sum() == 0)
            {
                Console.WriteLine("No awards");
                return;
            }
            foreach (var item in karaoke.OrderByDescending(x => x.Value.Values.Count).ThenBy(x => x.Key))
            {
                if (item.Value.Values.Count > 0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value.Values.Count} awards");

                    foreach (var award in item.Value.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"--{award.Key}");
                    }
                }
            }
        }
    }
}
