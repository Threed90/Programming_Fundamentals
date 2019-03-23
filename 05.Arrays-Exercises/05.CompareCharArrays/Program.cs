using System;
using System.Linq;

namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            char[] array2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

            PrintByAlphabeticalOrder(array1, array2);
        }

        private static void PrintByAlphabeticalOrder(char[] array1, char[] array2)
        {
            int index = Math.Min(array1.Length, array2.Length);

            bool isEqual = false;

            for (int i = 0, j =0; i < index; i++)
            {
                if (array1[i] == array2[i])
                {
                    isEqual = true;
                    j++;
                }

                if (j==index)
                {
                    if(array1.Length > array2.Length)
                    {
                        Console.WriteLine(string.Join(null, array2));
                        Console.WriteLine(string.Join(null, array1));
                    }
                    else
                    {
                        Console.WriteLine(string.Join(null, array1));
                        Console.WriteLine(string.Join(null, array2));
                    }
                }
                if (array1[i] > array2[i] && isEqual )
                {
                    Console.WriteLine(string.Join(null, array2));
                    Console.WriteLine(string.Join(null, array1));
                    break;
                }
                else if (array1[i] < array2[i]  && isEqual)
                {
                    Console.WriteLine(string.Join(null, array1));
                    Console.WriteLine(string.Join(null, array2));
                    break;
                }

                if (array1[i] > array2[i])
                {
                    Console.WriteLine(string.Join(null, array2));
                    Console.WriteLine(string.Join(null, array1));
                    break;
                }
                else if (array1[i] < array2[i])
                {
                    Console.WriteLine(string.Join(null, array1));
                    Console.WriteLine(string.Join(null, array2));
                    break;
                }
            }
        }
    }
}
