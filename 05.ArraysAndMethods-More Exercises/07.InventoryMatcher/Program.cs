using System;
using System.Linq;

namespace _07.InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productName = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            long[] quantities = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();

            PrintProductsInfo(productName, quantities, price);
        }

        private static void PrintProductsInfo(string[] productName, long[] quantities, decimal[] price)
        {
            string requestedProductInfo = Console.ReadLine();

            while (requestedProductInfo != "done")
            {
                //for (int i = 0; i < productName.Length; i++)
                //{
                //    if(requestedProductInfo == productName[i])
                //    {
                //        Console.WriteLine($"{productName[i]} costs: {price[i]}; Available quantity: {quantities[i]}");
                //    }
                //}

                int index = Array.IndexOf(productName, requestedProductInfo);

                Console.WriteLine($"{productName[index]} costs: {price[index]}; Available quantity: {quantities[index]}");

                requestedProductInfo = Console.ReadLine();
            }
        }
    }
}
