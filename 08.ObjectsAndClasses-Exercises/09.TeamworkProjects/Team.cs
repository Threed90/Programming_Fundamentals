using System;
using System.Collections.Generic;
using System.Text;

namespace _09.TeamworkProjects
{
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;
            this.Members = new List<string>();
            Members.Add(Creator);
            Console.WriteLine($"Team {name} has been created by {creator}!");
        }
    }
}
