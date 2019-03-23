using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());

            List<Student> result = new List<Student>();

            FillList(result, iterations);

            foreach (Student item in result.OrderBy(x => x.Name).ThenByDescending(x => x.Average))
            {
                if(item.Average>=5.00)
                {
                    Console.WriteLine($"{item.Name} -> {item.Average:f2}");
                }
            }
        }

        private static Student readStutentInfo()
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string name = input.First();
            double[] grades = input.Skip(1).Select(double.Parse).ToArray();

            return new Student(name, grades);
        }

        private static void FillList(List<Student> list, int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                list.Add(readStutentInfo());
            }
        }
    }
}
