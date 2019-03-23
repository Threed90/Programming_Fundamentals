using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordsCount = File.ReadAllText(@"..\..\..\words.txt")
                                                .Split()
                                                .Distinct()
                                                .Select(e => new KeyValuePair<string, int>(e, 0))
                                                .ToDictionary(e => e.Key, e => e.Value);

            Regex.Matches(File.ReadAllText(@"..\..\..\input.txt").ToLower(), @"[a-zA-Z']+").Cast<Match>().ToList().ForEach(e =>
            {
                if (wordsCount.ContainsKey(e.Value))
                {
                    wordsCount[e.Value]++;
                }
            });
            //if (!File.Exists(@"..\..\..\output.txt"))
            //{
            //    File.Create(@"..\..\..\output.txt");
            //}
            foreach (var word in wordsCount.OrderByDescending(e => e.Value))
            {
                File.AppendAllText(@"..\..\..\output.txt", $"{word.Key} - {word.Value}\n");
            }
        }
    }
}
