using System;
using System.Linq;

namespace _03.SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            PrintResult(words);
        }

        private static void PrintResult(string[] words)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                        
            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "Distinct":
                        string[] newArray = words.Distinct().ToArray();
                        Array.Resize(ref words, newArray.Length);
                        newArray.CopyTo(words, 0);
                        break;
                    case "Reverse":
                        Array.Reverse(words);
                        break;
                    case "Replace":
                        int num = int.Parse(input[1]);
                        if (num>words.Length-1 || num<0)
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }
                        else
                        {
                            words[num] = input[2];
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            Console.WriteLine(string.Join(", ", words));
            
        }
    }
}
