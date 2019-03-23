using System;

namespace Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int fromNumber = int.Parse(Console.ReadLine());
            int tillNumber = int.Parse(Console.ReadLine());

            char firstSymbol = Convert.ToChar(fromNumber);

            for (char numberRange = firstSymbol; numberRange <= tillNumber; numberRange++)
            {
                Console.Write(numberRange + " ");
            }
        }
    }
}
