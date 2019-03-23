using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] values = Console.ReadLine().Split("{}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            MatchCollection matches = Regex.Matches(input, @"([a-zA-Z]+)(.+)(\1)");
            int index = -1;
            foreach (Match match in matches)
            {
                string placeholder = match.Groups[2].Value;

                input = GetResult(input, placeholder, values[++index]);

                if(index == values.Length)
                {
                    break;
                }
            }

            Console.WriteLine(input);
        }

        private static string GetResult(string input, string placeholder, string v)
        {
            string oldSubInput = input.Substring(0, placeholder.Length + input.IndexOf(placeholder));
            string newSubInput = oldSubInput.Replace(placeholder, v);
            return input.Replace(oldSubInput, newSubInput);

            //return newSubInput + input.Substring(oldSubInput.Length);
        }
    }
}
