using System;
using System.Linq;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            

            Console.WriteLine(string.Join(" ", Reverse_Array_of_Strings(array)));
        }

        //private static string[] Reverse_Array_of_Strings(string[] array)
        //{
            //string temporalHolder = "";
            
            //for (int i = 0; i < array.Length/2; i++)
            //{
            //    temporalHolder = array[i];
            //    array[i] = array[array.Length - 1 - i];
            //    array[array.Length - 1 - i] = temporalHolder;
            //}
        //}

        //private static string[] Reverse_Array_of_Strings(string[] array)
        //{
        //    string[] newArray = new string[array.Length];

        //    for (int i = array.Length -1, j=0; i >= 0; i--, j++)
        //    {
        //        newArray[i] = array[j];
        //    }
        //    return newArray;
        //}

        private static string[] Reverse_Array_of_Strings(string[] array)
        {
            Array.Reverse(array);
            return array;

        }
    }
}
