using System;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] lines =  File.ReadAllLines(@"..\..\..\input.txt");

            //File.Create(@"..\..\..\output.txt");

            int num = 1;

            foreach (string line in lines)
            {
                File.AppendAllText(@"..\..\..\output.txt", $"{num++}. {line}\n");
            }
        }
    }
}
