using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SortTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", Console.ReadLine().Split().OrderBy(x=>x).ToList()));
        }
    }
}
