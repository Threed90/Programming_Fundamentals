using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> snowmans = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> losers = new List<int>();

            while (snowmans.Count != 1)
            {
                for (int i = 0; i < snowmans.Count; i++)
                {
                    if (Math.Abs(snowmans.Count - losers.Count) == 1)
                    {
                        continue;
                    }
                    if (losers.Contains(i))
                    {
                        snowmans[i] = int.MinValue;
                        continue;
                    }
                    
                    int atacker = i;
                    int target = snowmans[i];

                    if (target >= snowmans.Count)
                    {
                        target = target % snowmans.Count;
                    }

                    int diffrence = Math.Abs(atacker - target);

                    if (diffrence == 0)
                    {
                        Console.WriteLine($"{i} performed harakiri");
                        snowmans[i] = int.MinValue;
                        losers.Add(i);
                        losers = losers.Distinct().ToList();

                        continue;
                    }
                    if (diffrence % 2 == 1)
                    {
                        snowmans[atacker] = int.MinValue;
                        Console.WriteLine($"{atacker} x {target} -> {target} wins");
                        losers.Add(atacker);
                        losers = losers.Distinct().ToList();
                        continue;
                    }
                    if (diffrence % 2 == 0 && diffrence != 0)
                    {
                        snowmans[target] = int.MinValue;
                        Console.WriteLine($"{atacker} x {target} -> {atacker} wins");
                        losers.Add(target);
                        losers = losers.Distinct().ToList();
                        continue;
                    }

                }
                losers.Clear();
                snowmans.RemoveAll(x => x == int.MinValue);
            }
        }
    }
}
