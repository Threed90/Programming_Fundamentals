using System;
using System.Linq;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            if (array.Length == 1)
            {
                Console.WriteLine($"{array[0]} is already condensed to number");
            }
            else
            {
                Console.WriteLine(GetCondence(array));
            }
        }

        private static int GetCondence(int[] array)
        {
            int sum = 0;
            int[] newArray = array.Clone() as int[];

            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = 0; j< array.Length-1; j++)
                {
                    sum = newArray[j] + newArray[j + 1];
                    newArray[j] = sum;
                }
            }
            sum = newArray[0];
            return sum;
        }
    }
}
