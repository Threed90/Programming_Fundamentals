using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            Console.WriteLine(Changeable.Checkable(input));
        }
    }
}
