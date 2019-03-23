using System;
using System.Linq;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] values = input.Split(' ');

            int[] array = new int[values.Length];

            GetArrayElements(array, values);

            PrintSumOfElements(array);


        }

        private static void PrintSumOfElements(int[] array)
        {
            bool isNotContain = true;
            for (int i = 0; i < array.Length-1; i++)
            {
                int sum = 0;
                for (int j = i+1; j < array.Length; j++)
                {
                    sum = array[i] + array[j];
                    if (array.Contains(sum))
                    {
                        Console.WriteLine($"{array[i]} + {array[j]} == {sum}");
                        isNotContain = false;
                    }

                }
            }
            if (isNotContain)
            {
                Console.WriteLine("No");
            }
        }

        static void GetArrayElements(int[] array, string[] values)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(values[i]);
            }
        }

    }
}
