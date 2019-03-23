using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection matches = Regex.Matches(Console.ReadLine(), @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b");
            foreach (Match item in matches)
            {
                Console.Write(item.Value + " ");
            }
        }
    }
}
