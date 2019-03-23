using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string servicePackage = Console.ReadLine().ToLower();

            double HallPrice = 0;
            double PackagePrice = 0;
            double totalPrice = 0;

            if (numberOfPeople > 100 && numberOfPeople < 121)
            {
                HallPrice = 7500;

                Console.WriteLine("We can offer you the Great Hall");
            }
            else if (numberOfPeople <= 50 && numberOfPeople>0)
            {
                HallPrice = 2500;

                Console.WriteLine($"We can offer you the Small Hall");
            }
            else if (numberOfPeople>50 && numberOfPeople <= 100)
            {
                HallPrice = 5000;

                Console.WriteLine("We can offer you the Terrace");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

            switch (servicePackage)
            {
                case "normal":
                    PackagePrice = 500;
                    totalPrice = HallPrice + PackagePrice;
                    totalPrice -= totalPrice / 20;
                    break;
                case "gold":
                    PackagePrice = 750;
                    totalPrice = HallPrice + PackagePrice;
                    totalPrice -= totalPrice / 10;
                    break;
                case "platinum":
                    PackagePrice = 1000;
                    totalPrice = HallPrice + PackagePrice;
                    totalPrice -= (totalPrice*3/20);
                    break;
            }

            if (numberOfPeople > 0 && numberOfPeople < 121)
            {
                Console.WriteLine($"The price per person is {totalPrice/numberOfPeople:f2}$");
            }

        }
    }
}
