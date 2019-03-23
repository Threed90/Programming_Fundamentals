using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result = new List<string>();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(", ",Regex.Matches(Console.ReadLine(), $@"(?<=\|<.{{{input[0]}}})([^|]{{0,{input[1]}}})")
                                                     .Cast<Match>().ToList()));
        }
    }
}
