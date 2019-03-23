using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                                .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' ' },
                                 StringSplitOptions.RemoveEmptyEntries)
                                .ToList();
            PrintSortedLists(input);
        }

        private static void PrintSortedLists(List<string> input)
        {
            List<string> toLowerCase = new List<string>();
            List<string> toUpperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                
                if (input[i] == input[i].ToLower() && input[i].All(Char.IsLetter))
                {
                    toLowerCase.Add(input[i]);
                }
                else if (input[i] == input[i].ToUpper() && input[i].All(Char.IsLetter))
                {
                    toUpperCase.Add(input[i]);
                }
                else
                {
                    mixedCase.Add(input[i]);
                }
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", toLowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", toUpperCase));
        }
    }
}
