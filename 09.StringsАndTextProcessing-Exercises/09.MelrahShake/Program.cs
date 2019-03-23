using System;
using System.Linq;
using System.Text;

namespace _09.MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (pattern.Length > 0 && input.Length > 0)
            {
                int firstInx = input.IndexOf(pattern);
                int lastInx = input.LastIndexOf(pattern);
                if (firstInx >= 0 && lastInx >= 0 && firstInx != lastInx)
                {
                    Console.WriteLine("Shaked it.");

                    input = input.Remove(firstInx, pattern.Length);
                    lastInx = input.LastIndexOf(pattern);
                    input = input.Remove(lastInx, pattern.Length);

                    pattern = GetNewPattern(pattern);
                }
                else
                {
                    
                    break;
                }
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }

        private static string GetNewPattern(string pattern)
        {
            int indexToSkip = pattern.Length / 2;

            StringBuilder newPattern = new StringBuilder();

            for (int i = 0; i < pattern.Length; i++)
            {
                if (i == indexToSkip)
                {
                    continue;
                }
                else
                {
                    newPattern.Append(pattern[i]);
                }
            }

            return newPattern.ToString();
        }
    }
}
