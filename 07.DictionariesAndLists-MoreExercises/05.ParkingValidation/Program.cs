using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ParkingValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());

            Dictionary<string, string> register = new Dictionary<string, string>();

            for (int i = 0; i < commands; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                Registration(input, register);
            }

            PrintAllRegisted(register);
        }

        private static void PrintAllRegisted(Dictionary<string, string> register)
        {
            foreach (KeyValuePair<string, string> item in register)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }

        private static void Registration(string[] input, Dictionary<string, string> register)
        {
            if(input[0] == "register")
            {
                if (register.ContainsKey(input[1]))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {register[input[1]]}");
                }
                else if (register.ContainsValue(input[2]))
                {
                    Console.WriteLine($"ERROR: license plate {input[2]} is busy");
                }
                else if(!register.ContainsKey(input[1]) && isValid(input))
                {
                    register.Add(input[1], input[2]);
                    Console.WriteLine($"{input[1]} registered {input[2]} successfully");
                }
                else if (!isValid(input))
                {
                    Console.WriteLine($"ERROR: invalid license plate {input[2]}");
                }
                
            }
            else if(input[0]=="unregister")
            {
                if(!register.ContainsKey(input[1]))
                {
                    Console.WriteLine($"ERROR: user {input[1]} not found");
                }
                else
                {
                    register.Remove(input[1]);
                    Console.WriteLine($"user {input[1]} unregistered successfully");
                }
            }
        }

        private static bool isValid(string[] input)
        {
            if(input[2].Length==8 && input[2].Equals(input[2].ToUpper()) && input[2].Skip(2).Take(4).All(char.IsDigit))
            {
                return true;
            }
            return false;
        }
    }
}
