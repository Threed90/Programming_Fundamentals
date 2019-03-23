using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> player = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Season end")
                {
                    break;
                }

                FillDictionary(player, input);
            }

            PrintResult(player);
        }

        private static void FillDictionary(Dictionary<string, Dictionary<string, int>> player, string input)
        {
            if (Regex.IsMatch(input, @"^(.+) -> (.+) -> (\d+)$"))
            {
                GetPlayers(player, input);
            }
            else if (Regex.IsMatch(input, @"^(.+) vs (.+)$"))
            {
                DeleteLosers(player, input);
            }
        }

        private static void GetPlayers(Dictionary<string, Dictionary<string, int>> player, string input)
        {
            Match match = Regex.Match(input, @"^(.+) -> (.+) -> (\d+)$");

            if (!player.ContainsKey(match.Groups[1].Value))
            {
                player.Add(match.Groups[1].Value, new Dictionary<string, int>());
                player[match.Groups[1].Value].Add(match.Groups[2].Value, int.Parse(match.Groups[3].Value));
            }
            else
            {
                if (!player[match.Groups[1].Value].ContainsKey(match.Groups[2].Value))
                {
                    player[match.Groups[1].Value].Add(match.Groups[2].Value, int.Parse(match.Groups[3].Value));
                }
                else
                {
                    player[match.Groups[1].Value][match.Groups[2].Value] = Math.Max(player[match.Groups[1].Value][match.Groups[2].Value], int.Parse(match.Groups[3].Value));
                }
            }
        }

        private static void DeleteLosers(Dictionary<string, Dictionary<string, int>> player, string input)
        {
            Match match = Regex.Match(input, @"^(.+) vs (.+)$");

            if (player.ContainsKey(match.Groups[1].Value) && player.ContainsKey(match.Groups[2].Value))
            {
                DeleteDuelLoser(player, match);
            }
        }

        private static void DeleteDuelLoser(Dictionary<string, Dictionary<string, int>> player, Match match)
        {
            foreach (var item in player[match.Groups[1].Value])
            {
                foreach (var item2 in player[match.Groups[2].Value])
                {
                    if (item.Key == item2.Key)
                    {
                        if (item.Value > item2.Value)
                        {
                            player.Remove(match.Groups[2].Value);
                            return;
                        }
                        else if(item.Value < item2.Value)
                        {
                            player.Remove(match.Groups[1].Value);
                            return;
                        }
                    }
                }
            }
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, int>> player)
        {
            foreach (var item in player.OrderByDescending(el => el.Value.Select(x => x.Value).Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Select(x => x.Value).Sum()} skill");

                foreach (var element in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {element.Key} <::> {element.Value}");
                }
            }
        }
    }
}
