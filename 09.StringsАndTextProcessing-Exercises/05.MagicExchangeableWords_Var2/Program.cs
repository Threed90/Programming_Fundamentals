using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.MagicExchangeableWords_Var2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lengths = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                              .Select(x => new HashSet<char>(x).Count)
                                              .ToArray();

            Console.WriteLine((lengths[0] == lengths[1]) ? "true": "false");
        }
    }
}
