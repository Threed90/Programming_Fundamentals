
using System;
using System.Collections.Generic;


class InstructionSet_broken
{
    static void Main()
    {
        List<long> result = new List<long>();
        string opCode = "";
        do
        {
            opCode = Console.ReadLine();
            string[] codeArgs = opCode.Split(' ');


            switch (codeArgs[0])
            {
                case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        operandOne++;
                        Console.WriteLine(operandOne); ;
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        operandOne--;
                        Console.WriteLine(operandOne); ;
                        break;
                    }
                case "ADD":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        Console.WriteLine((operandOne + operandTwo));
                        break;
                    }
                case "MLA":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        Console.WriteLine((operandOne * operandTwo));
                        break;
                    }

            }
        } while (opCode != "END");
    }
}


