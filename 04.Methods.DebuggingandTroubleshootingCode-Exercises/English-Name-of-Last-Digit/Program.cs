using System;
using System.Linq;

namespace English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(GetNameOfLastDigit(number));
        }

        static string GetNameOfLastDigit(long number)
        {
            long lastNumber = Math.Abs(number % 10);
            string[] nameOfNumbers = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            return nameOfNumbers[lastNumber];

            //if (lastNumber == 0)
            //{
            //    return "zero";
            //}
            //else if (lastNumber == 1)
            //{
            //    return "one";
            //}
            //else if (lastNumber == 2)
            //{
            //    return "two";
            //}
            //else if (lastNumber == 3)
            //{
            //    return "three";
            //}
            //else if (lastNumber== 4)
            //{
            //    return "four";
            //}
            //else if (lastNumber == 5)
            //{
            //    return "five";
            //}
            //else if (lastNumber == 6)
            //{
            //    return "six";
            //}
            //else if (lastNumber == 7)
            //{
            //    return "seven";
            //}
            //else if(lastNumber== 8)
            //{
            //    return "eight";
            //}
            //else if (lastNumber == 9)
            //{
            //    return "nine";
            //}
            //return "";
        }
    }
}
