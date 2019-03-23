using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    if (!phoneBook.ContainsKey(input[1]))
                    {
                        phoneBook.Add(input[1], input[2]);
                    }
                    else
                    {
                        phoneBook[input[1]] = input[2];
                    }
                }
                else if (input[0] == "S")
                {
                    if (phoneBook.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} -> {phoneBook[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }

                input = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
