using System;

namespace Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());

            string celsius = $"{CalculateCelsius(fahrenheit):f2}";
            Console.WriteLine(celsius);

        }

        /// <summary>
        /// White double value to calculate fahrenheit to celsius.
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        /// 
        static double CalculateCelsius(double celsius)
        {
            celsius = (celsius - 32) * 5 / 9;
            return celsius;
        }
    }
}
