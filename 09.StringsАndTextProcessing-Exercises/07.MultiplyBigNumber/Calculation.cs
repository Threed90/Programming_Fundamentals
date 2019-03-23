using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.MultiplyBigNumber
{
    class Calculation
    {
        public static string Multiply(string number, int multiplyNum)
        {
            StringBuilder result = new StringBuilder();

            int[] numbers = number.Select(x => (int)char.GetNumericValue(x)).ToArray();

            if (multiplyNum == 0)
            {
                return "0";
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = numbers[i] * multiplyNum;
                }

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    int currentNum = numbers[numbers.Length - 1 - i];

                    result.Append(currentNum % 10);

                    numbers[numbers.Length - 2 - i] += currentNum / 10;
                }
            }

            result.Append(numbers[0] % 10);

            if (numbers[0] / 10 > 0)
            {
                result.Append(numbers[0] / 10);
            }

            return string.Join("", result.ToString().Reverse()).TrimStart('0');
        }
    }
}
