using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _07.QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //([^=?&]+=)(.+?)(?:&|\?|$)

            while (input!="END")
            {
                Console.WriteLine(new Constructor(input));

                input = Console.ReadLine();
            }
        }
    }
}
