using System;

namespace _4Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexadecimalFormat = Console.ReadLine();

            int hexaToInteger = Convert.ToInt32(hexadecimalFormat, 16);

            Console.WriteLine(hexaToInteger);
        }
    }
}
