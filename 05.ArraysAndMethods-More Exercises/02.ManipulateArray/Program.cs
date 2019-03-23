using System;
using System.Linq;

namespace _02.ManipulateArray
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            int commands = int.Parse(Console.ReadLine());

            string result = GetResult(words, commands);
            Console.WriteLine(result);
        }

        private static string GetResult(string[] words, int commands)
        {
            for (int i = 0; i < commands; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0].ToLower().Contains("reverse"))
                {
                    Array.Reverse(words);
                }
                else if (command[0].ToLower().Contains("distinct"))
                {
                    string[] newArray = words.Distinct().ToArray();
                    Array.Resize(ref words, newArray.Length);
                    newArray.CopyTo(words, 0);
                }
                else if (command[0].ToLower().Contains("replace"))
                {
                    int num = int.Parse(command[1]);
                    words[num] = command[2];
                }
            }

            string result = string.Join(", ", words);
            return result;
        }
    }
}
