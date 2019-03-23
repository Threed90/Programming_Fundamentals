using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();
            

            while (input != "thetinggoesskrra")
            {
                Match match = Regex.Match(input, @"^(.+) -> (\d+) \| (.+)$");

                if(match.Success)
                {
                    if(data.ContainsKey(match.Groups[3].Value))
                    {
                        data[match.Groups[3].Value].Add(match.Groups[1].Value, long.Parse(match.Groups[2].Value));
                    }
                    else
                    {
                        if(cache.ContainsKey(match.Groups[3].Value) == false)
                        {
                            cache.Add(match.Groups[3].Value, new Dictionary<string, long>());
                            cache[match.Groups[3].Value].Add(match.Groups[1].Value, long.Parse(match.Groups[2].Value));
                        }
                        else
                        {
                            cache[match.Groups[3].Value].Add(match.Groups[1].Value, long.Parse(match.Groups[2].Value));
                        }
                    }
                }
                else
                {
                    if(data.ContainsKey(input) == false)
                    {
                        data.Add(input, new Dictionary<string, long>());

                        if (cache.ContainsKey(input))
                        {
                            foreach (var item in cache[input])
                            {
                                data[input].Add(item.Key, item.Value);
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            //data = data.OrderByDescending(x => x.Value.Values.Sum()).ToDictionary(x => x.Key, y => y.Value);
            //Console.WriteLine($"Data Set: {data.Keys.First()}, Total Size: {data[data.Keys.First()].Values.Sum()}");

            foreach (var item in data.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"Data Set: {item.Key}, Total Size: {item.Value.Values.Sum()}");

                foreach (var item1 in item.Value)
                {
                    Console.WriteLine($"$.{item1.Key}");
                }

                break;
            }
            
        }
    }
}
