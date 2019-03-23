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
            List<string> partic = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.TrimStart()).ToList();
            if(partic.Count==0)
            {
                Console.WriteLine("No awards");
                return;
            }
            string[] songs = Console.ReadLine().Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries).Select(x=> x.TrimStart()).ToArray();
            if(songs.Length==0)
            {
                Console.WriteLine("No awards");
                return;
            }

            string onTheStage = "";

            while ((onTheStage = Console.ReadLine()) != "dawn")
            {
                string[] tokens = onTheStage.Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(tokens.Length !=3)
                {
                    continue;
                }
                string participantName = tokens[0].TrimStart();
                string song = tokens[1].TrimStart();
                string award = tokens[2].TrimStart();

                if (partic.Contains(participantName) && songs.Contains(song))
                {
                    if (karaoke.ContainsKey(participantName) == false)
                        karaoke.Add(participantName, new Dictionary<string, string>());

                    if (!karaoke[participantName].ContainsKey(award))
                        karaoke[participantName].Add(award, song);
                }
            }
            if(karaoke.Count==0)
            {
                Console.WriteLine("No awards");
                return;
            }
            foreach (var item in karaoke.OrderByDescending(x => x.Value.Keys.Count).ThenBy(x => x.Key))
            {
                    Console.WriteLine($"{item.Key}: {item.Value.Values.Count} awards");

                    foreach (var award in item.Value.OrderBy(x=>x.Key))
                    {
                        Console.WriteLine($"--{award.Key}");
                    }
                
            }
        }
    }
}
