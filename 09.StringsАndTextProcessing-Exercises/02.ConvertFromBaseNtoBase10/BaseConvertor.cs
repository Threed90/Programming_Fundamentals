using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _02.ConvertFromBaseNtoBase10
{
    class BaseConvertor
    {
        public static BigInteger ConvertFromBaseNtoBase10(long baseNum, string N)
        {
            BigInteger num = BigInteger.Parse(N);

            BigInteger result = 0;
            int i = 0;
            while(num>0)
            {
                int holder = (int)(num % 10);
                result += holder * BigInteger.Pow(baseNum, i);
                num /= 10;
                i++;
            }

            return result;
        }
    }
}
