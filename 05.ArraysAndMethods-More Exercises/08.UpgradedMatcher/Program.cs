using System;
using System.Linq;

namespace _08.UpgradedMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productName = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            long[] quantity = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();

            PrintTotalPrice(productName, quantity, price);
        }

        private static void PrintTotalPrice(string[] productName, long[] quantity, decimal[] price)
        {
            string[] requestedProductAndQuantity = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            Array.Resize(ref quantity, productName.Length);


            while (requestedProductAndQuantity[0] != "done")
            {
                long requestedQunatity = long.Parse(requestedProductAndQuantity[1]);

                int index = Array.IndexOf(productName, requestedProductAndQuantity[0]);

                if (quantity[index] == 0 || quantity[index] - requestedQunatity < 0)
                {
                    Console.WriteLine($"We do not have enough {productName[index]}");

                }
                else
                {
                    Console.WriteLine($"{productName[index]} x {requestedQunatity} costs {price[index] * requestedQunatity:f2}");
                    quantity[index] -= requestedQunatity;
                }

                //for (int i = 0; i < productName.Length; i++)
                //{
                //    if (productName[i] == requestedProductAndQuantity[0])
                //    {
                //        if (quantity[i] == 0 || quantity[i] - requestedQunatity < 0)
                //        {
                //            Console.WriteLine($"We do not have enough {productName[i]}");

                //        }
                //        else
                //        {
                //            Console.WriteLine($"{productName[i]} x {requestedQunatity} costs {price[i] * requestedQunatity:f2}");
                //            quantity[i] -= requestedQunatity;
                //        }

                //    }
                //}
                requestedProductAndQuantity = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
        }
    }
}
