using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if(input[0]=="End")
                {
                    break;
                }

                students.Add(new Student(input[0], input[1], input[2]));
            }

            foreach (Student student in students.OrderBy(s => s.Age))
            {
                Console.WriteLine($"{student.Name} with ID: {student.ID} is {student.Age} years old.");
            }
        }
    }
}
