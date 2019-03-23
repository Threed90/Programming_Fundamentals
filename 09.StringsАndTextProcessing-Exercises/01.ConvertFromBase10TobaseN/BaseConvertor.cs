using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _01.ConvertFromBase10TobaseN
{
    class BaseConvertor
    {

        public static string ConvertFromBase10TobaseN(int baseNum, BigInteger number)
        {
            string result = "";
            while (number>0)
            {
                BigInteger remainder = number % baseNum;
                result = remainder + result;
                number /= baseNum;
            }
            return result;
        }
    }
}
