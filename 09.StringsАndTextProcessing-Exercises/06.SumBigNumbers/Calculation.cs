using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.SumBigNumbers
{
    class Calculation
    {
        public static string Sum(string lowerLength, string bigerLength)
        {
            StringBuilder sum = new StringBuilder();

            int[] firstNum = lowerLength.Select(x => (int)char.GetNumericValue(x)).ToArray();
            int[] secondNum = bigerLength.Select(x => (int)char.GetNumericValue(x)).ToArray();
            int currentNum = 0;

            for (int i = 0; i < secondNum.Length - 1; i++)
            {
                if (i < firstNum.Length)
                {
                    currentNum = firstNum[firstNum.Length - 1 - i] + secondNum[secondNum.Length - 1 - i];
                }
                else
                {
                    currentNum = secondNum[secondNum.Length - 1 - i];
                }

                sum.Append(currentNum % 10);
                secondNum[secondNum.Length - 2 - i] += (currentNum / 10);
            }
            if(firstNum.Length!=secondNum.Length)
            {
                sum.Append(secondNum[0] % 10);
            }
            else
            {
                sum.Append((secondNum[0] + firstNum[0]) % 10);
            }
            
            if (secondNum[0] / 10 > 0)
                sum.Append(secondNum[0] / 10);

            return new string(sum.ToString().Reverse().ToArray()).TrimStart('0');
        }

    }
}
