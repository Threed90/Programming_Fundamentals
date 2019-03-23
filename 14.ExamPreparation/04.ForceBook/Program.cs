using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                Match match1 = Regex.Match(input, @"(.+) \| (.+)");
                Match match2 = Regex.Match(input, @"(.+) -> (.+)");

                if (match1.Success)
                {
                    if (!users.ContainsKey(match1.Groups[1].Value))
                    {
                        users.Add(match1.Groups[1].Value, new List<string>());
                    }
                    if (!users[match1.Groups[1].Value].Contains(match1.Groups[2].Value) && !users.Values.Any(x => x.Contains(match1.Groups[2].Value)))
                    {
                        users[match1.Groups[1].Value].Add(match1.Groups[2].Value);
                    }

                }

                if (match2.Success)
                {
                    if (!users.Any(x => x.Value.Contains(match2.Groups[1].Value)))
                    {
                        if (!users.ContainsKey(match2.Groups[2].Value))
                        {
                            users.Add(match2.Groups[2].Value, new List<string>());

                        }
                        users[match2.Groups[2].Value].Add(match2.Groups[1].Value);
                        Console.WriteLine($"{match2.Groups[1]} joins the {match2.Groups[2]} side!");
                    }
                    else
                    {
                        foreach (var item in users)
                        {
                            if (item.Value.Contains(match2.Groups[1].Value))
                            {
                                item.Value.Remove(match2.Groups[1].Value);
                            }
                        }
                        if (users.ContainsKey(match2.Groups[2].Value) == false)
                        {
                            users.Add(match2.Groups[2].Value, new List<string>());
                        }
                        users[match2.Groups[2].Value].Add(match2.Groups[1].Value);
                        Console.WriteLine($"{match2.Groups[1]} joins the {match2.Groups[2]} side!");
                    }

                }

                input = Console.ReadLine();
            }



            foreach (var pair in users.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (pair.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {pair.Key}, Members: {pair.Value.Count()}");

                    foreach (var user in pair.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}
