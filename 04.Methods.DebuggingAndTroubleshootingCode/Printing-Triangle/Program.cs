using System;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int anyNumber = int.Parse(Console.ReadLine());
            PrintTriangle(anyNumber);
        }
        /// <summary>
        /// Write integer to pring triangle with numbers - max value is the integer's value.
        /// </summary>
        /// <param name="number"></param>
        static void PrintTriangle(int number)
        {
            int counter = number;
            for (int row = 1; row <= number*2-1; row++)
            {
                if (row <= number)
                {
                    for (int col = 1; col <= row; col++)
                    {
                        Console.Write(col + " ");
                        
                    }
                }
                else
                {
                    counter--;
                    for (int col = 1; col <= counter; col++)
                    {
                        Console.Write(col + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
