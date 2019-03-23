using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = int.Parse(Console.ReadLine());

            string virus = Console.ReadLine();
            int currentHealth = health;

            Dictionary<string, List<int>> virusBook = new Dictionary<string, List<int>>();


            while (virus != "end")
            {
                
                double sum = virus.ToCharArray().Select(x => Convert.ToInt32(x)).Sum();
                //int virusStrenght = (int)(sum / 3);
                //int defeatTime = virusStrenght * virus.Length;
                if (!virusBook.ContainsKey(virus))
                {
                    virusBook.Add(virus, new List<int>());
                    virusBook[virus].Add((int)(sum / 3));
                    virusBook[virus].Add(virusBook[virus][0] * virus.Length);
                }
                else
                {
                    virusBook[virus][1] = (int)(virusBook[virus][1] / 3);
                }
                Console.WriteLine($"Virus {virus}: {virusBook[virus][0]} => {virusBook[virus][1]} seconds");

                currentHealth -= virusBook[virus][1];

                if (currentHealth < 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }

                Console.WriteLine($"{virus} defeated in {virusBook[virus][1] / 60}m {virusBook[virus][1] % 60}s.");
                Console.WriteLine($"Remaining health: {currentHealth}");

                currentHealth += (int)(currentHealth * 0.20);

                if (currentHealth > health)
                {
                    currentHealth = health;
                }

                virus = Console.ReadLine();
            }
            Console.WriteLine($"Final Health: {currentHealth}");
        }
    }
}
