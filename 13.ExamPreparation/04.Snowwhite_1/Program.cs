using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Snowwhite_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> dwarfs = new List<Dwarf>();

            string line = Console.ReadLine();
            while(line!="Once upon a time")
            {
                string[] input = line.Split(" <>:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                dwarfs.Add(new Dwarf(input[0], input[1], input[2]));

                line = Console.ReadLine();
            }

            Dwarf.CheckDwarfs(dwarfs);

            foreach (var item in dwarfs.OrderByDescending(x => x.Physics).ThenByDescending(x=> x.ColorNum))
            {
                Console.WriteLine($"({item.Color}) {item.Name} <-> {item.Physics}");
            }
        }
    }
}
