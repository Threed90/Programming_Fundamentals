using System;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int totalCalories = 0;

            for (int i = 0; i < n; i++)
            {
                string ingredients = Console.ReadLine().ToLower();

                if (ingredients == "cheese")
                {
                    totalCalories += 500;
                }
                else if (ingredients == "tomato sauce")
                {
                    totalCalories += 150;
                }
                else if(ingredients == "salami")
                {
                    totalCalories += 600;
                }
                else if (ingredients == "pepper")
                {
                    totalCalories += 50;
                }
            }

            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
