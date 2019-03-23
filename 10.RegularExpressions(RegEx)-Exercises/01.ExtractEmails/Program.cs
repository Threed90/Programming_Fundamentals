using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex.Matches(Console.ReadLine(), @"(^|(?<=\s))[A-Za-z0-9]+([-._][A-Za-z0-9]+)*@[A-Za-z]+(\-[A-Za-z]+)*(\.[A-Za-z]+)+")
                 .Cast<Match>().ToList().ForEach(e =>
                 {
                     Console.WriteLine(e.Value);
                 });
        }
    }
}
