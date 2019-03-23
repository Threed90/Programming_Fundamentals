using System;

namespace Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            bool isEqual = false;

            if (Math.Abs(firstNumber-secondNumber) <= 0.000001)
            {
                isEqual = true;
            }

            Console.WriteLine(isEqual);
        }
    }
}
