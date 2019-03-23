using System;

namespace Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int anyNumber = int.Parse(Console.ReadLine());

            PrintSign(anyNumber);
        }

        /// <summary>
        /// White the integer to see his sign - positive, negative or zero, as output. 
        /// </summary>
        /// <param name="number"></param>
        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
