using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUniKaraoke3
{
    class Program
    {
        static void Main(string[] args)
        {
            KaraokeMemers members = new KaraokeMemers(Console.ReadLine(), Console.ReadLine());
            if (members.IsEmpty)
            {
                Console.WriteLine("No awards");
                return;
            }

            List<Paticipant> participants = new List<Paticipant>();
            string input = "";
            while ((input = Console.ReadLine()) != "dawn")
            {
                string[] inputTokens = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(x => x.Trim()).ToArray();

                if (Paticipant.IsValid(inputTokens))
                    continue;

                string name = inputTokens[0];
                string song = inputTokens[1];
                string award = inputTokens[2];

                if (members.IsValidParticapnt(name, song))
                {
                    if (participants.FirstOrDefault(x => x.Name == name) == null)
                    {
                        participants.Add(new Paticipant(name));
                    }

                    var omg = participants.First(x => x.Name == name);
                    omg.Awards.Add(award);
                }
            }

            Paticipant.PrintResult(participants);
        }
    }
}
