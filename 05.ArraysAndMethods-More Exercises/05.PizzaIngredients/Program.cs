using System;
using System.Linq;

namespace _05.PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            int ingredientsLength = int.Parse(Console.ReadLine());

            PrintRecipe(ingredients, ingredientsLength);
        }

        private static void PrintRecipe(string[] ingredients, int ingredientsLength)
        {
            string[] usefull_Ingredients = new string[10];

            int count = 0;

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (count == 10)
                {
                    break;
                }
                if (ingredients[i].Length == ingredientsLength)
                {
                    usefull_Ingredients[count] = ingredients[i];

                    count++;
                    

                    Console.WriteLine($"Adding {ingredients[i]}.");
                }
                
            }

            Array.Resize(ref usefull_Ingredients, count);

            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", usefull_Ingredients).TrimEnd(',')}.");
        }
    }
}
