using System;
using System.Collections.Generic;

namespace _01.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> gameSet = new Dictionary<string, int>();

            gameSet.Add("headset", 0);
            gameSet.Add("mouse", 0);
            gameSet.Add("keyboard", 0);
            gameSet.Add("display", 0);

            int losedGames = int.Parse(Console.ReadLine());

            GetTotalTrashedItems(gameSet, losedGames);
        }

        public static void GetTotalTrashedItems(Dictionary<string, int> gameSet, int losedGames)
        {
            for (int i = 1; i <= losedGames; i++)
            {
                if (i % 2 == 0)
                {
                    gameSet["headset"]++;
                }
                if (i % 3 == 0)
                {
                    gameSet["mouse"]++;
                }
                if (i % 6 == 0)
                {
                    gameSet["keyboard"]++;
                }
                if (i % 12 == 0)
                {
                    gameSet["display"]++;
                }
            }

            PrintResult((gameSet["headset"] * double.Parse(Console.ReadLine())),
                        (gameSet["mouse"] * double.Parse(Console.ReadLine())),
                        (gameSet["keyboard"] * double.Parse(Console.ReadLine())),
                        (gameSet["display"] * double.Parse(Console.ReadLine())));
        }

        public static void PrintResult(double expenses1, double expenses2, double expenses3, double expenses4)
        {
            double total = expenses1 + expenses2 + expenses3 + expenses4;

            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
