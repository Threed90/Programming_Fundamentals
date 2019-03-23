using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace _05.WriteToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllText(@"..\..\..\output.txt",
            string.Join(null, Regex.Matches(File.ReadAllText(@"..\..\..\input.txt"), @"[^.,:!?]+")
                                                .Cast<Match>()
                                                .Select(e => e.Groups[0].ToString())
                                                .ToArray()));
        }
    }
}
