using System;
using System.Linq;

namespace _04.GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            long sum = GetSUm(array, number);

            if (isNoNumber(array, number))
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                Console.WriteLine(sum);
            }
        }

        private static bool isNoNumber(int[] array, int number)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == number)
                {
                    counter++;
                    break;
                }
                
            }
            if(counter == 0)
            {
                return true;
            }

            return false;
        }

        private static long GetSUm(int[] array, int number)
        {
            int count = 0;
            long sum = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                count++;
                if (array[i] == number)
                {
                    break;
                }
                
            }

            Array.Resize(ref array, array.Length - count);

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            

            return sum;
        }
    }
}
