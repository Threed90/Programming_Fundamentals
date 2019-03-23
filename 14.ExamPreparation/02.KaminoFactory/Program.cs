using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int DNAlenght = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            List<Tuple<int[], int, int, int, int>> bestDNA = new List<Tuple<int[], int, int, int, int>>();
            int counter = 0;
            while (input != "Clone them!")
            {
                int[] DNA = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                
                int lenght = 0;
                int index = 0;
                int sum = DNA.Sum();
                int bestLenght = -1;
                int bestIndex = -1;
                counter++;
                
                for (int i = 0; i < DNA.Length; i++)
                {
                    if(DNA[i] == 1)
                    {
                        if(lenght==0)
                        {
                            index = i;
                        }
                        lenght++;
                    }
                    else if(DNA[i]==0 || DNA.Length==1)
                    {
                        if(bestLenght<lenght)
                        {
                            bestLenght = lenght;
                            bestIndex = index;
                        }
                        lenght = 0;
                        index = 0;
                    }
                }
                if (bestLenght < lenght)
                {
                    bestLenght = lenght;
                    bestIndex = index;
                }

                bestDNA.Add(new Tuple<int[], int, int, int, int>(DNA, bestLenght, bestIndex, sum, counter));

                input = Console.ReadLine();
            }

            
            bestDNA = bestDNA.OrderByDescending(x => x.Item2).ThenBy(x => x.Item3).ThenByDescending(x => x.Item4).ToList();

            Console.WriteLine($"Best DNA sample {bestDNA[0].Item5} with sum: {bestDNA[0].Item4}.");
            Console.WriteLine($"{string.Join(" ", bestDNA[0].Item1)}");
        }
    }
}
