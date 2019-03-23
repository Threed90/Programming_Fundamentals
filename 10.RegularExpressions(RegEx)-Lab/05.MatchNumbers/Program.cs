using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _05.MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Regex.Matches(Console.ReadLine(), @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))")
                                                    .Cast<Match>()
                                                    .Select(m => m.Value)
                                                    .ToArray()));
        }
    }
}
