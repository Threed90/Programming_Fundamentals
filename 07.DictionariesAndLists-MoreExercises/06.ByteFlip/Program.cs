using System;
using System.Linq;

namespace _06.ByteFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(null, Console.ReadLine().Split().Select(x => new string(x.Reverse().ToArray()))
                                               .Where(x => x.Length == 2).Select(x => Convert.ToInt32(x, 16).ToString())
                                               .Reverse().Select(x => Convert.ToChar(int.Parse(x)).ToString()).ToArray()));

            
            
        }
    }
}
