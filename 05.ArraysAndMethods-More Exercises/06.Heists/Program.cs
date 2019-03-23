using System;
using System.Linq;

namespace _06.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int jewelPrice = prices[0];
            int goldPrice = prices[1];

            PrintResult(jewelPrice, goldPrice);
        }

        private static void PrintResult(int jewelPrice, int goldPrice)
        {
            string[] loot = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            long earnedMoney = 0;
            long expenses = 0;

            while (loot[0] != "Jail" && loot[1] != "Time")
            {
                for (int i = 0; i < loot[0].Length; i++)
                {
                    if (loot[0][i].Equals('%'))
                    {
                        earnedMoney += jewelPrice;
                    }
                    else if (loot[0][i].Equals('$'))
                    {
                        earnedMoney += goldPrice;
                    }
                }
                int costs = int.Parse(loot[1]);
                expenses += costs;

                loot = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            if (earnedMoney >= expenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {earnedMoney-expenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {expenses-earnedMoney}.");
            }
        }
    }
}
