using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplyNum = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculation.Multiply(number, multiplyNum));
        }
    }
}
