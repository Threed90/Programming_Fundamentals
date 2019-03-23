using System;
using System.Linq;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            //string symbolChecker = Console.ReadLine().ToLower();

            //bool isDigit = double.TryParse(symbolChecker, out double number);
            //string[] list = new string[] { "a", "y", "o", "u", "e", "i" }; //създава array с str [] name = new str[] {...}

            //if (isDigit)
            //{
            //    Console.WriteLine("digit");
            //}
            //else if (list.Any(symbolChecker.Equals))//(list.Contains(symbolChecker)) 
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("other");
            //}

            char symbolChecker = char.Parse(Console.ReadLine());

            if(symbolChecker == 'a' || symbolChecker == 'y'||
                symbolChecker == 'o'|| symbolChecker == 'u'||
                symbolChecker == 'e'|| symbolChecker == 'i')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsDigit(symbolChecker))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
