using System;
using System.Linq;

namespace _04.SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            PrintErathosthenesNumbers(n);
        }

        private static void PrintErathosthenesNumbers(int n)
        {
            int[] array = new int[n + 1];
            bool[] checkNum = new bool[n + 1];

            string result = "";

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                checkNum[i] = true;
            }

            checkNum[0] = false;
            checkNum[1] = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (checkNum[i])
                {
                    result += $"{array[i]} ";

                    for (int j = 2; j < array.Length; j++)
                    {
                        if (j%i == 0 && checkNum[j])
                        {
                            checkNum[j] = false;
                        }
                    }
                }
            }

            Console.WriteLine(result.Trim());

            //int j = 0;
            //int[] array = new int[] { };
            //if (n >= 2)
            //{
            //    Array.Resize(ref array, 1);
            //    array[0] = 2;
            //    j = 1;
            //}
            //if (n >= 3)
            //{
            //    Array.Resize(ref array, 2);
            //    array[1] = 3;
            //    j = 2;
            //}
            //if (n >= 5)
            //{
            //    Array.Resize(ref array, 3);
            //    array[2] = 5;
            //    j = 3;
            //}
            //if (n >= 7)
            //{
            //    Array.Resize(ref array, 4);
            //    array[3] = 7;
            //    j = 4;
            //}

            //for (int i = 0; i <= n; i++)
            //{
            //    if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i != 0 && i != 1)
            //    {
            //        Array.Resize(ref array, ++j);
            //        array[j - 1] = i;
                    
            //    }
            //}
            
            
            //Console.WriteLine(string.Join(" ", array));
        }
    }
}
