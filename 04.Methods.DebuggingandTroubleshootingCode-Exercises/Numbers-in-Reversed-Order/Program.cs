using System;

namespace Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine(GetReversedNumber(number));
        }

        static string GetReversedNumber(double number)
        {
            string numberToString = Convert.ToString(number);

            while (numberToString.EndsWith("0"))
            {
                numberToString = numberToString.Remove(numberToString.Length - 1);
            }
            char[] stringToChar = numberToString.ToCharArray();
            string reversedNumber = "";
           
            for (int digitsCounter = stringToChar.Length - 1; digitsCounter >= 0; digitsCounter--)
            {
                reversedNumber += stringToChar[digitsCounter];
            }

            return reversedNumber;
        }
    }
}
