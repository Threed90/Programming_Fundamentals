using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _10._StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();
            List<Town> towns = new List<Town>();
            int counter = -1;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                if (input.Contains("=>"))
                {
                    string[] input1 = input.Split("=>", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

                    Town town = new Town(input1[0], int.Parse(input1[1].Split().First()));
                    towns.Add(town);
                    counter++;
                }
                else
                {
                    string[] input2 = input.Split('|').Select(x => x.Trim()).ToArray();

                    towns[counter].Students
                             .Add(new Student(input2[0], input2[1], DateTime.ParseExact(input2[2], "d-MMM-yyyy", CultureInfo.InvariantCulture)));
                }

            }
            IEnumerable<Student> students = new List<Student>();
            foreach (Town item in towns.OrderBy(x => x.Name))
            {
                students = item.Students.OrderBy(x => x.RegistrationDate).ThenBy(x => x.Name).ThenBy(x => x.Email);
                
                while (students.Any())
                {
                    var group = new Group(item);
                    group.Members = students.Take(item.GroupCapacity).ToList();
                    students = students.Skip(item.GroupCapacity);
                    groups.Add(group);
                }
            }


            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");
            foreach (Group item in groups)
            {
                Console.WriteLine($"{item.Town.Name} => {string.Join(", ", item.Members.Select(x => x.Email).ToList())}");
            }
        }
    }
}
