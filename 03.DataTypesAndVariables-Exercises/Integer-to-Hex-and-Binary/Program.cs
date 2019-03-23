using System;

namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int entranceNumber = int.Parse(Console.ReadLine());

            string binaryNumber = Convert.ToString(entranceNumber, 2);
            string hexaNuber = Convert.ToString(entranceNumber, 16);

            Console.WriteLine(hexaNuber.ToUpper());
            Console.WriteLine(binaryNumber);
            
        }
    }
}
