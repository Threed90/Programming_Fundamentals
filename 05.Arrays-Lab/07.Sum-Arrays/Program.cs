using System;
using System.Linq;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(" ",GetSumArray(firstArray, secondArray)));
        }

        private static int[] GetSumArray(int[] first, int[] second)
        {
            int max = Math.Max(first.Length, second.Length);

            int[] sumArray = new int[max];

            if (first.Length >= second.Length)
            {
                for (int i = 0; i < max; i++)
                {
                    sumArray[i] = first[i] + second[i%second.Length];
                    

                }

            }
            else
            {
                for (int i = 0; i < max; i++)
                {
                    sumArray[i] = second[i] + first[i%first.Length];
                    

                }
            }
            return sumArray;

        }
    }
}
