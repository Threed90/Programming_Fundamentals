using System;
using System.Linq;

namespace _03.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string input = Console.ReadLine();
            
            foreach (var item in bannedWords)
            {
                input = input.Replace(item, new string('*', item.Length));
            }

            Console.WriteLine(input);
        }
    }
}
