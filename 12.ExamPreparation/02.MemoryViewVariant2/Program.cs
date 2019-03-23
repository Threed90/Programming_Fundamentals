using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.MemoryViewVariant2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder all = new StringBuilder();

            string input = Console.ReadLine();

            while (input != "Visual Studio crash")
            {
                all.Append(input + " ");
                input = Console.ReadLine();
            }

            string[] cleanedInput = Regex.Split(all.ToString(), @"(?<!\d)0\s|\s").Where(el => !string.IsNullOrEmpty(el)).ToArray();

            

            for (int i = 0; i < cleanedInput.Length; i++)
            {
                StringBuilder result = new StringBuilder();
                if (cleanedInput[i] == "32656" && cleanedInput[i + 1] == "19759" && cleanedInput[i + 2] == "32763")
                {
                    for (int j = 0; j < int.Parse(cleanedInput[i+3]); j++)
                    {
                        result.Append((char)int.Parse(cleanedInput[i + 4 + j]));
                    }
                    Console.WriteLine(result.ToString());
                }
                i = i + 3 + int.Parse(cleanedInput[i + 3]);
            }
        }
    }
}
