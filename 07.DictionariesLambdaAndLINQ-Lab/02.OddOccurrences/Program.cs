using System;
using System.Collections.Generic;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            List<string> splitedInput = new List<string>();

            string splitedPart = "";

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == ' ')
                {
                    splitedInput.Add(splitedPart);
                    splitedPart = "";
                }
                else
                {
                    splitedPart += input[i];
                    if(i == input.Length - 1)
                    {
                        splitedInput.Add(splitedPart);
                    }
                }
            }

            int[] counters = new int[splitedInput.Count];
            bool[] isChecked = new bool[splitedInput.Count];
            for (int i = 0; i < isChecked.Length; i++)
            {
                isChecked[i] = true;
            }

            for (int i = 0; i < splitedInput.Count; i++)
            {
                for (int j = 0; j < splitedInput.Count; j++)
                {
                    if(splitedInput[i] == splitedInput[j] && isChecked[j])
                    {
                        counters[i]++;
                        isChecked[j] = false;
                    }
                    else if (splitedInput[i] == splitedInput[j])
                    {
                        counters[i] = 0;
                    }
                }
                
            }

            string result = "";
            for (int i = 0; i < splitedInput.Count; i++)
            {
                if (counters[i] > 0 && counters[i]%2 !=0)
                {
                    result += splitedInput[i] + ", ";
                }
            }

            for (int i = 0; i < result.Length-2; i++)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
    }
}
