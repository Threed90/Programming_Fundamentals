using System;

namespace House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstMaterial = int.Parse(Console.ReadLine());
            int secondMaterial = int.Parse(Console.ReadLine());

            long totalPrice = 0;

            if (firstMaterial <= sbyte.MaxValue && secondMaterial> sbyte.MaxValue)
            {
                totalPrice = (firstMaterial * 4L) + (secondMaterial * 10L);
            }
            else
            {
                totalPrice = (firstMaterial * 10L) + (secondMaterial * 4L);
            }

            Console.WriteLine(totalPrice);
        }
    }
}
