using System;
using System.Linq;

namespace _09.JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int sum = GetSum(array);

            Console.WriteLine(sum);
        }

        private static int GetSum(int[] array)
        {

            int index = 0;
            int sum = array[0];
            int i = 0;
            while (true)
            {
                

                


                if (index+array[i] > array.Length - 1)
                {
                    index -= array[i];

                    if (index >= 0 && index < array.Length && index != i)
                    {
                        i = index;
                        sum += array[i];
                    }
                    else
                    {
                        break;
                    }

                }
                else if(index+array[i]<= array.Length)
                {
                    index += array[i];
                    i = index;
                    sum += array[i];

                }
            }
            return sum;
        }
    }
}
