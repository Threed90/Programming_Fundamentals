using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.PunctuationFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllText(@"..\..\..\output.txt",
            string.Join(", ", Regex.Matches(File.ReadAllText(@"..\..\..\input.txt"), @"[.,:!?]")
                                                .Cast<Match>()
                                                .Select(e => e.Groups[0].ToString())
                                                .ToArray()));
        }
    }
}
