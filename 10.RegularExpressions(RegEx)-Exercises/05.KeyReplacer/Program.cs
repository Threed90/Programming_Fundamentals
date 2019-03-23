using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Delimiter(Console.ReadLine(), Console.ReadLine()).Result);
        }
    }
}
