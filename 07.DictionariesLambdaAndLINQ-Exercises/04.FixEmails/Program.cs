using System;
using System.Collections.Generic;

namespace _04.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "stop")
                {
                    break;
                }

                if (!emails.ContainsKey(input))
                {
                    emails.Add(input, Console.ReadLine());

                    if(emails[input].ToLower().EndsWith("uk") || emails[input].ToLower().EndsWith("us"))
                    {
                        emails.Remove(input);
                    }
                }
                else
                {
                    emails[input] = Console.ReadLine();

                    if (emails[input].ToLower().EndsWith("uk") || emails[input].ToLower().EndsWith("us"))
                    {
                        emails.Remove(input);
                    }
                }
            }

            foreach (KeyValuePair<string,string> pair in emails)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
