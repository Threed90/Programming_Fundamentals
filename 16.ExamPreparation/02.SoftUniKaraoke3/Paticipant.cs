using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.SoftUniKaraoke3
{
    class Paticipant
    {
        public string Name { get; set; }
        public HashSet<string> Awards { get; set; }

        public Paticipant(string name)
        {
            Name = name;
            Awards = new HashSet<string>();
        }

        public static bool IsValid(string[] input)
        {
            if (input.Length == 3)
            {
                return false;
            }
            return true;
        }

        public static void PrintResult(List<Paticipant> participants)
        {
            if(participants.Count==0)
            {
                Console.WriteLine("No awards");
                return;
            }
            foreach (var item in participants.OrderByDescending(x => x.Awards.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{item.Name}: {item.Awards.Count} awards");

                foreach (var award in item.Awards.OrderBy(x => x))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
