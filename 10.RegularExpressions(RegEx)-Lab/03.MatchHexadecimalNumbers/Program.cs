using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03.MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, @"\b(?:0x)?[0-9A-F]+\b");

            //string[] result =

            Console.WriteLine(string.Join(" ", matches.Cast<Match>().Select(x => x.Value).ToArray()));
        }
    }
}
