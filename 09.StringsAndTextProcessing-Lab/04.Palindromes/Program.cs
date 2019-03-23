﻿using System;
using System.Linq;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", Console.ReadLine()
                                    .Split(" ,.?!:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                                    .Where(x => x == new string(x.ToCharArray().Reverse().ToArray()))
                                    .OrderBy(x=>x)
                                    .Select(x=>x.Trim())
                                    .Distinct()
                                    .ToArray()));
        }
    }
}
