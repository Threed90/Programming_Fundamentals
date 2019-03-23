using System;
using System.IO;
using System.Linq;

namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"..\..\..\input.txt").Where((e, i) => i % 2 != 0).ToArray();
            //Console.WriteLine();
            //File.Delete(@"..\..\..\output.txt");
            //File.Create(@"..\..\..\output.txt");
            File.AppendAllLines(@"..\..\..\output.txt", lines);
        }
    }
}
