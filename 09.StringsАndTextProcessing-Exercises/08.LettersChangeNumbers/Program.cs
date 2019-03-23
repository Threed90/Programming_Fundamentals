using System;
using System.Linq;
using System.Numerics;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            var sum = 0.0;

            foreach (string item in input)
            {
                sum += GetValue(item);
            }

            Console.WriteLine($"{sum:f2}");
        }

        private static double GetValue(string str)
        {
            char firstLetter = str.First();
            char lastLetter = str.Last();
            var number = double.Parse(str.Substring(1, str.Length - 2));
            

            if (firstLetter == char.ToUpper(firstLetter))
            {
                number = number / (firstLetter - 64);
            }
            else
            {
                number = number * (firstLetter - 96);
            }

            if (lastLetter == char.ToUpper(lastLetter))
            {
                number = number - (lastLetter - 64);
            }
            else
            {
                number = number + (lastLetter - 96);
            }
            return number;
        }
    }
}
