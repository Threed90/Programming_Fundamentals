using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllLines(@"..\..\..\output.txt", File.ReadAllLines(@"..\..\..\Input1.txt")
                                                            .Concat(File.ReadAllLines(@"..\..\..\Input2.txt"))
                                                            .OrderBy(e => int.Parse(e))
                                                            .ToList());
        }
    }
}
