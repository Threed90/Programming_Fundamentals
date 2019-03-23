using System;

namespace Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintFilledSquare(number);

        }
        /// <summary>
        /// Write integer value to draw a filled square
        /// </summary>
        /// <param name="num"></param>
        static void PrintFilledSquare(int num)
        {
            Console.WriteLine(new string ('-', num*2));

            for (int row = 0; row < num-2; row++)
            {
                Console.Write('-');
                for (int col = 0; col < num-1; col++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }

            Console.WriteLine(new string('-', num * 2));
        }
    }
}
