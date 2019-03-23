using System;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int ID = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}{Environment.NewLine}Age: {age}" +
                    $"{Environment.NewLine}Employee ID: {ID:d8}{Environment.NewLine}Salary: {salary:f2}");
        }
    }
}
