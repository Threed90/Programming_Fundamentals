using System;

namespace Choice_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int numberOfDrinks = int.Parse(Console.ReadLine());

            double drinkPrice = 0;


            switch (profession)
            {
                case "Athlete":
                    drinkPrice = 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                    drinkPrice = 1.00;
                    break;
                case "SoftUni Student":
                    drinkPrice = 1.70;
                    break;
                default:
                    drinkPrice = 1.20;
                    break;
            }
            
            

            Console.WriteLine($"The {profession} has to pay {drinkPrice*numberOfDrinks:f2}.");
        }
    }
}
