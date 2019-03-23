using System;

namespace Choice_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine().ToLower();

            string drink;
            bool number = int.TryParse(profession, out int num);

            switch (profession)
            {
                case "athlete":
                    drink = "Water";
                    break;
                case "businessman":
                case "businesswoman":
                    drink = "Coffee";
                    break;
                case "softuni student":
                    drink = "Beer";
                    break;
                default:
                    drink = "Tea";
                    break;
            }
            if (!number)
                Console.WriteLine(drink);


        }
    }
}
