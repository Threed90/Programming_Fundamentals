using System;
using System.Numerics;

namespace Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            sbyte maxSbyte = sbyte.MaxValue;
            sbyte minSbyte = sbyte.MinValue;
            byte maxByte = byte.MaxValue;
            byte minByte = byte.MinValue;
            short maxShort = short.MaxValue;
            short minShort = short.MinValue;
            ushort maxUshort = ushort.MaxValue;
            ushort minUshort = ushort.MinValue;
            int maxIntiger = int.MaxValue;
            int minIntriger = int.MinValue;
            uint maxUintriger = uint.MaxValue;
            uint minUintriger = uint.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            try
            {
                long numberForDataTypeTest = long.Parse(number);


                Console.WriteLine($"{numberForDataTypeTest} can fit in:");
                if (maxSbyte>=numberForDataTypeTest && minSbyte <= numberForDataTypeTest)
                {
                    Console.WriteLine($"* sbyte");
                }
                if (maxByte>=numberForDataTypeTest && minByte <= numberForDataTypeTest)
                {
                    Console.WriteLine($"* byte");
                }
                if (maxShort>=numberForDataTypeTest && minShort <= numberForDataTypeTest)
                {
                    Console.WriteLine($"* short");
                }
                if (maxUshort >= numberForDataTypeTest && minUshort <= numberForDataTypeTest)
                {
                    Console.WriteLine($"* ushort");
                }
                if (maxIntiger >= numberForDataTypeTest && minIntriger <= numberForDataTypeTest)
                {
                    Console.WriteLine($"* int");
                }
                if (maxUintriger >= numberForDataTypeTest && minUintriger <= numberForDataTypeTest)
                {
                    Console.WriteLine($"* uint");
                }
                if (maxLong>=numberForDataTypeTest && minLong <= numberForDataTypeTest)
                {
                    Console.WriteLine($"* long");
                }
                
            }
            catch (Exception)
            {

                Console.WriteLine($"{number} can't fit in any type");

            }
        }
    }
}
