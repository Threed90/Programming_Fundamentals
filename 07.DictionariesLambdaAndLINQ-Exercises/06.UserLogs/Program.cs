using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> IPbook = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input[0] == "end")
                {
                    break;
                }

                FillIPDict(IPbook, input);
            }
            PrintResult(IPbook);

        }

        private static void PrintResult(SortedDictionary<string, Dictionary<string, int>> IPbook)
        {
            string result = "";
            foreach (KeyValuePair<string, Dictionary<string, int>> pair in IPbook)
            {
                Console.WriteLine($"{pair.Key}:");

                foreach (KeyValuePair<string, int> item in IPbook[pair.Key])
                {
                    result += $"{item.Key} => {item.Value}, ";
                }
                Console.WriteLine($"{result.TrimEnd(' ', ',')}.");
                result = "";
            }
        }

        private static void FillIPDict(SortedDictionary<string, Dictionary<string, int>> IPbook, string[] input)
        {
            string[] IPs = input.Select(x => x).Where((x, y) => y == 1 || y == 5).ToArray();

            if (!IPbook.ContainsKey(IPs[1]))
            {
                IPbook.Add(IPs[1], new Dictionary<string, int>());
                IPbook[IPs[1]].Add(IPs[0], 1);

            }
            else if (IPbook.ContainsKey(IPs[1]))
            {
                if (!IPbook[IPs[1]].ContainsKey(IPs[0]))
                {
                    IPbook[IPs[1]].Add(IPs[0], 1);
                }
                else
                {
                    IPbook[IPs[1]][IPs[0]]++;
                }
            }
        }
    }
}
