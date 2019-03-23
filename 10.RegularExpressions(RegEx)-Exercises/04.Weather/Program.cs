using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string[]> weather = new Dictionary<string, string[]>();
            string input = Console.ReadLine();

            while (input!="end")
            {
                Match match = Regex.Match(input, @"([A-Z]{2})([0-9]+\.[0-9]+)([A-Za-z]+)(?=\|)");

                if(match.Success)
                {
                    if(weather.ContainsKey(match.Groups[1].Value) == false)
                    {
                        weather.Add(match.Groups[1].Value, new string[2]);
                        weather[match.Groups[1].Value][0] = match.Groups[2].Value;
                        weather[match.Groups[1].Value][1] = match.Groups[3].Value;
                    }
                    else
                    {
                        weather[match.Groups[1].Value][0] = match.Groups[2].Value;
                        weather[match.Groups[1].Value][1] = match.Groups[3].Value;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, string[]> prognosis in weather.OrderBy(e => double.Parse(e.Value[0])))
            {
                Console.WriteLine($"{prognosis.Key} => {double.Parse(prognosis.Value[0]):f2} => {prognosis.Value[1]}");
            }
        }
    }
}
