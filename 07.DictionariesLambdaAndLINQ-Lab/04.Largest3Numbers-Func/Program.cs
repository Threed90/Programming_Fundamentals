using System;
using System.Linq;

namespace _04.Largest3Numbers_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ",Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).Take(3).ToArray()));
        }
    }
}
