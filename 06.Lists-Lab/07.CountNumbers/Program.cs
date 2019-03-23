using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            bool[] isChecked = new bool[numbers.Count];

            Array.Fill(isChecked, true);

            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int counter = 0;
                if (isChecked[i])
                {
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            counter++;
                            isChecked[j] = false;
                        }
                    }
                    result.Add(numbers[i], counter);
                }
                
            }

            result = result.OrderBy(i => i.Key).ToDictionary(i => i.Key, i => i.Value);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
