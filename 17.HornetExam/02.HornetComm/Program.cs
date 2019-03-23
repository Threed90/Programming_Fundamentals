using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> broadcast = new List<string>();
            List<string> massage = new List<string>();

            string input = "";

            Regex regex = new Regex(@"^(\d+) <-> ([A-Za-z0-9]+)$");
            Regex regex1 = new Regex(@"^(\D+) <-> ([A-Za-z0-9]+)$");

            while ((input = Console.ReadLine()) != "Hornet is Green")
            {
                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    string holder = new string(match.Groups[1].Value.Reverse().ToArray());

                    massage.Add($"{holder} -> {match.Groups[2].Value}");
                }
                else if (regex1.IsMatch(input))
                {
                    Match match1 = regex1.Match(input);
                    FillBroadcastList(broadcast, match1);
                }
            }

            PrintResult(broadcast, massage);
        }

        private static void FillBroadcastList(List<string> broadcast, Match match1)
        {
            string holder = "";
            for (int i = 0; i < match1.Groups[2].Value.Length; i++)
            {
                if (char.IsLetter(match1.Groups[2].Value[i]))
                {
                    if (char.IsLower(match1.Groups[2].Value[i]))
                    {
                        //holder.Append(char.ToUpper(match1.Groups[2].Value[i]));
                        holder += char.ToUpper(match1.Groups[2].Value[i]);
                    }
                    else
                    {
                        //holder.Append(char.ToLower(match1.Groups[2].Value[i]));
                        holder += char.ToLower(match1.Groups[2].Value[i]);
                    }
                }
                else
                {
                    holder += match1.Groups[2].Value[i];
                }
            }
            broadcast.Add($"{holder} -> {match1.Groups[1].Value}");
        }

        private static void PrintResult(List<string> broadcast, List<string> massage)
        {
            Console.WriteLine("Broadcasts:");
            if (broadcast.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (string item in broadcast)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("Messages:");
            if (massage.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (string item in massage)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
