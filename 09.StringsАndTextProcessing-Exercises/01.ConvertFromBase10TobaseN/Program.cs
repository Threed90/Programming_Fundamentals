using System;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _01.ConvertFromBase10TobaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int baseNum = int.Parse(input[0]);
            BigInteger num = BigInteger.Parse(input[1]);

            if (baseNum >= 2 && baseNum <= 10)
            {

                Console.WriteLine(BaseConvertor.ConvertFromBase10TobaseN(baseNum, num));
            }
            else
            {
                Console.WriteLine(0);
            }
        }

    }
}
