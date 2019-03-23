using System;
using System.Text;

namespace _03.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            StringBuilder result = new StringBuilder();

            foreach (var item in input)
            {
                result.Append($@"\u{(int)item:x4}");
            }

            Console.WriteLine(result.ToString());
        }
    }
}
