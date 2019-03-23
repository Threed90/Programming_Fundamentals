using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintResult(Regex.Matches(Console.ReadLine(), @"(^|(?<=[)(\/\\ ]))[A-Za-z]\w{2,24}\b").Cast<Match>().Select(e => e.Value).ToList());
        }

        static void PrintResult(List<string> input)
        {
            if(input.Count<2)
            {
                return;
            }
            int counter = -1;
            int holder = -1;
            for (int i = 0; i < input.Count - 1; i++)
            {
                int sum = input[i].Length + input[i + 1].Length;

                if (holder < sum)
                {
                    counter = i;
                    holder = sum;
                }
            }

            if (counter > -1)
            {
                Console.WriteLine(input[counter]);
                Console.WriteLine(input[counter + 1]);
            }
        }
    }
}
