using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            foreach (string ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                string left = ticket.Substring(0, 10);
                string right = ticket.Substring(10, 10);

                Match match1 = Regex.Match(left, @"@{6,10}|#{6,10}|\${6,10}|\^{6,10}"); //@"[$@#^]{6,10}" -> marge 2 diffrend symbols are one combo
                Match match2 = Regex.Match(right, @"@{6,10}|#{6,10}|\${6,10}|\^{6,10}"); 

                if (match1.Success == false || match2.Success == false)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                    continue;
                }
                else 
                {
                    int length = Math.Min(match1.Value.Length, match2.Value.Length);
                    string holder1 = match1.Value.Substring(0, length);
                    string holder2 = match2.Value.Substring(0, length);
                    if (holder1==holder2)
                    {
                        if (length == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - 10{match1.Value[0]} Jackpot!");
                            continue;
                        }

                        Console.WriteLine($"ticket \"{ticket}\" - {length}{match1.Value[0]}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}
