using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');

                Team teamName = teams.FirstOrDefault(t => t.Name == input[1]);
                Team teamCreator = teams.FirstOrDefault(t => t.Creator == input[0]);

                RegistryTeamsAndPrintResult(teamName, teamCreator, teams, input);

            }

            while (true)
            {
                string[] input = Console.ReadLine().Split("->");

                if (input[0] == "end of assignment")
                {
                    break;
                }

                RegistryMemberAndPrintResult(teams, input);
            }

            foreach (Team item in teams.OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name))
            {
                int memberNum = item.Members.Count - 1;

                if (memberNum > 0)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine($"- {item.Creator}");
                    item.Members.Where(x => x != item.Creator).OrderBy(x => x).ToList().ForEach(x => Console.WriteLine($"-- {x}"));
                }
                
            }
            Console.WriteLine("Teams to disband:");
            foreach (Team item in teams.OrderBy(t => t.Name))
            {
                if(item.Members.Count-1 == 0)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }

        private static void RegistryMemberAndPrintResult(List<Team> teams, string[] input)
        {
            Team teamExist = teams.FirstOrDefault(p => p.Name == input[1]);
            Team teamMembership = teams.FirstOrDefault(x => x.Members.Contains(input[0]));

            if (teamExist == null)
            {
                Console.WriteLine($"Team {input[1]} does not exist!");
            }
            else if (teamMembership != null)
            {
                Console.WriteLine($"Member {input[0]} cannot join team {input[1]}!");
            }
            else
            {
                teamExist.Members.Add(input[0]);
            }
        }

        private static void RegistryTeamsAndPrintResult(Team teamName, Team teamCreator, List<Team> teams, string[] input)
        {
            if (teamName == null && teamCreator == null)
            {
                Team newTeam = new Team(input[1], input[0]);
                teams.Add(newTeam);
            }
            else if (teamName != null)
            {
                Console.WriteLine($"Team {input[1]} was already created!");
            }
            else if (teamCreator != null)
            {
                Console.WriteLine($"{input[0]} cannot create another team!");
            }
        }
    }
}
