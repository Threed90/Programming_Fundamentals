using System;

namespace Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            OutputHello(name);
        }

        static void OutputHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
