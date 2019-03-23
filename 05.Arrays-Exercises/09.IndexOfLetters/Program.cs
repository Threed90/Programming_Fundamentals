using System;
using System.Linq;

namespace _09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine().ToLower();

            char[] letters = new char[word.Length];

            int i = 0;
            foreach  (char item in letters)
            {
                letters[i] = word[i];
                i++;
            }

            PrintLetterIndex(letters);
        }

        private static void PrintLetterIndex(char[] letters)
        {
            for (int i = 0; i <letters.Length ; i++)
            {
                for (int j = 'a'; j <= 'z'; j++)
                {
                    if(letters[i] == j)
                    {
                        Console.WriteLine($"{letters[i]} -> {j-97}");
                    }
                }
            }
        }
    }
}
