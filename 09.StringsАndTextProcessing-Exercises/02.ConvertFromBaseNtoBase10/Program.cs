using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _02.ConvertFromBaseNtoBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            long baseN = long.Parse(input[0]);
            string n = input[1];

            if(baseN>=2 && baseN<=10)
            {
                Console.WriteLine(BaseConvertor.ConvertFromBaseNtoBase10(baseN, n));
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
