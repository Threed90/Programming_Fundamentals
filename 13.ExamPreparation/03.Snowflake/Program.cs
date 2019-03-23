using System;
using System.Text.RegularExpressions;

namespace _03.Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex surface = new Regex(@"[^A-Za-z0-9]+");
            Regex mantle = new Regex(@"[0-9_]+");
            Regex core = new Regex(@"[a-zA-Z]+");
            string input = "";
            int coreLenght = 0;
            for (int i = 0; i < 5; i++)
            {
                string singleLine = Console.ReadLine();
                if ((i == 0 || i == 4) && !Regex.Match(singleLine, $@"^{surface}$").Success)
                {
                    Console.WriteLine("Invalid");
                    return;
                }
                if ((i == 1 || i == 3) && !Regex.Match(singleLine, $@"^{mantle}$").Success)
                {
                    Console.WriteLine("Invalid");
                    return;
                }
                if (i == 2 && Regex.IsMatch(singleLine, $@"^{surface}{mantle}{core}{mantle}{surface}$"))
                {
                    coreLenght = Regex.Match(singleLine, $@"^{surface}{mantle}({core}){mantle}{surface}$").Groups[1].ToString().Length;
                }
                input += singleLine;
            }

            if (Regex.IsMatch(input, $@"^{surface}{mantle}{surface}{mantle}{core}{mantle}{surface}{mantle}{surface}$"))
            {
                Console.WriteLine("Valid");
                Console.WriteLine($"{coreLenght}");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
