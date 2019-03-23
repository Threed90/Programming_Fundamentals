using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace _03.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> resouces = new Dictionary<string, long>();
            List<string> input = new List<string>();

            ResouceDict(resouces);

            foreach (KeyValuePair<string, long> item in resouces)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        private static void ResouceDict(Dictionary<string, long> resouces)
        {
            while (true)
            {
                string omg = Console.ReadLine();
                if (omg == "stop")
                {
                    break;
                }
                if (!resouces.ContainsKey(omg))
                {
                    resouces.Add(omg, long.Parse(Console.ReadLine()));
                }
                else
                {
                    resouces[omg] += long.Parse(Console.ReadLine());
                }


            }
        }
    }
}
