using System;

namespace Neighbour_War
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeshoDMG = int.Parse(Console.ReadLine());
            int GoshoDMG = int.Parse(Console.ReadLine());

            int PeshoHealth = 100;
            int GoshoHealth = 100;

            int round = 1;

            while (true)
            {
                


                if (round % 2 == 0)
                {
                    PeshoHealth -= GoshoDMG;

                    if (PeshoHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoHealth} health.");
                    }
                }
                else
                {
                    GoshoHealth -= PeshoDMG;

                    if (GoshoHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoHealth} health.");
                    }
                }
                
                if (PeshoHealth <= 0)
                {
                    Console.WriteLine($"Gosho won in {round}th round.");
                    break;
                }
                else if (GoshoHealth <= 0)
                {
                    Console.WriteLine($"Pesho won in {round}th round.");
                    break;
                }

                if (round % 3 == 0)
                {
                    GoshoHealth += 10;
                    PeshoHealth += 10;
                }

                round++;
                
            }
        }
    }
}
