using System;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (true)
            {
                
                string ingredient = Console.ReadLine();


                if (ingredient == "Bake!" )
                {
                    i--;
                    Console.WriteLine($"Preparing cake with {i} ingredients.");
                    break;
                }

                //Console.WriteLine($"Adding ingredient {char.ToUpper(ingredient[0]) + ingredient.Substring(1)}.");

                Console.WriteLine($"Adding ingredient {ingredient}.");

                i++;
            }
        }
    }
}
