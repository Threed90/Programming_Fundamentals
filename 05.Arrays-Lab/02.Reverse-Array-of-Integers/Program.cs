using System;
using System.Linq;

namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());

            int[] array = new int[numberOfNumbers];

            for (int numbers = 0; numbers < numberOfNumbers; numbers++)
            {
                array[array.Length - 1 - numbers] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", array).Trim());
        }
    }
}
