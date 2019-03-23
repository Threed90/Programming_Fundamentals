using System;
using System.Numerics;

namespace NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //string numberChecker = Console.ReadLine();
            // 1 method
            //if (int.TryParse(numberChecker, out int intNum))
            //{
            //    Console.WriteLine("integer");
            //}
            //else if (double.TryParse(numberChecker, out double doubleNum))
            //{
            //    Console.WriteLine("floating-point");
            //}

            // 2 method
            //int.TryParse(numberChecker, out int intNum);

            //if (numberChecker.Contains("."))
            //{
            //    Console.WriteLine("floating-point");
            //}
            //else
            //{
            //    Console.WriteLine("integer");
            //}

            try
            {
                BigInteger numberChecker = BigInteger.Parse(Console.ReadLine());

                Console.WriteLine("integer");
            }
            catch (Exception)
            {

                Console.WriteLine("floating-point");
            }
        }
        
    }
}
