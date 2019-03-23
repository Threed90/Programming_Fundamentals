using System;
using System.Collections.Generic;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> number = new List<int>();
            string splitedPart = "";

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == ' ')
                {
                    number.Add(int.Parse(splitedPart));
                    splitedPart = "";
                }
                else
                {
                    splitedPart += input[i];
                    if(i == input.Length - 1)
                    {
                        number.Add(int.Parse(splitedPart));
                    }
                }
            }

            for (int i = 0; i < number.Count; i++)
            {
                for (int j = i+1; j < number.Count; j++)
                {
                    if (number[i] < number[j])
                    {
                        int holder = number[i];
                        number[i] = number[j];
                        number[j] = holder;
                        j = i;
                    }
                }
            }

            int k = 3;
            if (number.Count < k)
            {
                k = number.Count;
            }
            for (int i = 0; i < k; i++)
            {
                if(i == k - 1)
                {
                    Console.Write(number[i]);
                    break;
                }
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
