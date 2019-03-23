﻿using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"\+359 2 \d{3} \d{4}\b|\+359-2-\d{3}-\d{4}\b";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            var array = matches.Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
