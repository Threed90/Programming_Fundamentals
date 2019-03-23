using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int numberPower = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(number,numberPower));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="power"></param>
        /// <returns></returns>
        static double RaiseToPower(double number, int power)
        {
            double result = 1.0;
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
