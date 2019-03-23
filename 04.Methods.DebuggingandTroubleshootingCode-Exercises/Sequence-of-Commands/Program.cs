using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = Console.ReadLine().Trim();

        while (!command.Contains("stop"))
        {
            string[] stringParams = command.Split(ArgumentsDelimiter);
            int[] args = new int[2];

            if (command.Contains("add") ||
                command.Contains("subtract") ||
                command.Contains("multiply"))
            {

                args[0] = int.Parse(stringParams[1]);
                args[1] = int.Parse(stringParams[2]);

                array = PerformAction(array, stringParams[0], args).Clone() as long[];

                PrintArray(array);

            }
            else if(command.Contains("rshift") ||
                command.Contains("lshift"))
            {
                array = PerformAction(array, stringParams[0], args).Clone() as long[];
                PrintArray(array);
            }




            command = Console.ReadLine().Trim();
        }
    }

    static long[] PerformAction(long[] arr, string action, int[] args)
    {
        long[] array = arr.Clone() as long[];
        int pos = args[0];
        int value = args[1];

        
        
            switch (action)
            {
                case "multiply":
                    array[pos - 1] *= value;
                    break;
                case "add":
                    array[pos - 1] += value;
                    break;
                case "subtract":
                    array[pos - 1] -= value;
                    break;
                case "lshift":
                    array = ArrayShiftLeft(array).Clone() as long[];
                    break;
                case "rshift":
                    array = ArrayShiftRight(array).Clone() as long[];
                    break;
            }

        
        return array;
    }

    static long[] ArrayShiftRight(long[] array)
    {
        long[] newArray = new long[array.Length];
        newArray[0] = array[array.Length - 1];
        
        for (int i = 1; i < array.Length; i++)
        {
            newArray[i] = array[i-1];
        }
        
        return newArray;
    }

    static long[] ArrayShiftLeft(long[] array)
    {
        long[] newArray = new long[array.Length];
        newArray[array.Length-1] = array[0];

        for (int i = 0; i < array.Length-1; i++)
        {
            newArray[i] = array[i + 1];
        }
        return newArray;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i <= array.Length - 1; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

    }
}
