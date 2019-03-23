using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.TseamAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            while (command != "Play!")
            {
                string[] commandTokens = command.Split();

                GetFinalList(games, commandTokens);

                command = Console.ReadLine();
            }

            //for (int i = 0; i < games.Count; i++)
            //{
            //    games[i] = games[i].Replace('-', ':');
            //}

            Console.WriteLine(string.Join(" ", games));
        }

        private static void GetFinalList(List<string> games, string[] commandTokens)
        {
            string gameName = string.Join(" ", commandTokens.Where(x => x != commandTokens[0]));
            
            if(commandTokens[0] == "Install" && !games.Contains(gameName))
            {
                games.Add(gameName);
            }
            else if(commandTokens[0] == "Uninstall" && games.Contains(gameName))
            {
                games.Remove(gameName);
                //games.RemoveAll(x => x == gameName);
            }
            else if(commandTokens[0] == "Update" && games.Contains(gameName))
            {
                games.RemoveAll(el => el == gameName);
                games.Add(gameName);
                
            }
            else if(commandTokens[0] == "Expansion" && games.Contains(gameName.Split('-').First()))
            {
                int index = games.IndexOf(gameName.Split('-').First()) + 1;
                games.Insert(index, gameName.Replace('-', ':'));
            }

            
        }
    }
}
