using System;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 5;
            int second = 10;

            Console.WriteLine($"Before:{Environment.NewLine}a = {first}{Environment.NewLine}b = {second}");

            int third = first;
            first = second;

            Console.WriteLine($"After:{Environment.NewLine}a = {first}{Environment.NewLine}b = {third}");
        }
    }
}
