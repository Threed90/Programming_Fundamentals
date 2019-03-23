using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            
            if (inputType.ToLower() == "int")
            {
                int firstInput = int.Parse(Console.ReadLine());
                int secondInput = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstInput,secondInput));
            }
            else if (inputType.ToLower() == "char")
            {
                char firstInput = char.Parse(Console.ReadLine());
                char secondInput = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstInput, secondInput));
            }
            else if (inputType.ToLower() == "string")
            {
                string firstInput = Console.ReadLine();
                string secondInput = Console.ReadLine();
                Console.WriteLine(GetMax(firstInput, secondInput));
            }
        }
        /// <summary>
        /// Write 2 int values to get max value betwin them. 
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        static int GetMax(int firstValue, int secondValue)
        {
            if (firstValue >= secondValue)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
        /// <summary>
        /// Write 2 char values to get max value betwin them. 
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        static char GetMax(char firstValue, char secondValue)
        {
            if (firstValue >= secondValue)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
        /// <summary>
        /// Write 2 string values to get max value betwin them. 
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        static string GetMax(string firstValue, string secondValue)
        {
            if (firstValue.CompareTo(secondValue)>=0)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
    }
}
