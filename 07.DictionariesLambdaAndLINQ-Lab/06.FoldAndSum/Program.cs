using System;
using System.Collections.Generic;

namespace _06.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string splitedParts = "";
            List<int> numbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    numbers.Add(int.Parse(splitedParts));
                    splitedParts = "";
                }
                else
                {
                    splitedParts += input[i];
                    if (i == input.Length - 1)
                    {
                        numbers.Add(int.Parse(splitedParts));
                    }
                }
            }

            int k = numbers.Count / 4;

            int[] leftRight = new int[2 * k];
            
            int counter = k-1;
            for (int i = 0; i < k; i++)
            {
                leftRight[i] = numbers[counter--];
            }

            int count = numbers.Count - 1;
            for (int i = k; i < k * 2; i++)
            {
                leftRight[i] = numbers[count--];
            }

            int[] mid = new int[2 * k];

            for (int i = 0; i < 2*k; i++)
            {
                mid[i] = numbers[i + k] + leftRight[i];
                if (i == 2 * k - 1)
                {
                    Console.Write(mid[i]);
                    break;
                }
                Console.Write(mid[i] + " ");
            }

            Console.WriteLine();
            
        }
    }
}
