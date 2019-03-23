using System;
using System.Text.RegularExpressions;

namespace _06.ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                //Regex regex = new Regex(@"^(.*?)<a\s*href=("".+"")>(.+)</a>(.*)$");
                
                //string replacement = $"$1[URL href=$2]$3[/URL]$4";
                //string replased = regex.Replace(input, replacement);

                //Console.WriteLine(replased);
               
                Console.WriteLine(Regex.Replace(input, @"^(.*?)<a\s*href=("".+"")>(.+)</a>(.*)$", $"$1[URL href=$2]$3[/URL]$4"));

                input = Console.ReadLine();
            }
        }
    }
}
