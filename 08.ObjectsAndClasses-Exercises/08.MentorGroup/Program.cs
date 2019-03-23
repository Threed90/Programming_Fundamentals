using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08.MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "end of dates")
                {
                    break;
                }
                string[] separated = input.Split(" ,".ToCharArray());
                FillStudentsNameAndDates(students, separated);
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split('-');

                if(input[0].ToLower() == "end of comments")
                {
                    break;
                }

                Student student = students.FirstOrDefault(s => s.Name == input[0]);

                if(student == null)
                {
                    continue;
                }
                else
                {
                    student.Comments.Add(input[1]);
                }
            }

            foreach (Student item in students.OrderBy(s=>s.Name))
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("Comments:");
                foreach  (string comment in item.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (DateTime date in item.Dates.OrderBy(d => d))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }

        private static void FillStudentsNameAndDates(List<Student> students, string[] separated)
        {
            Student student = students.FirstOrDefault(s => s.Name == separated[0]);

            if (student == null)
            {
                Student newStudent = new Student(separated[0]);
                newStudent.Dates.AddRange(separated.Skip(1)
                                         .Select(d => DateTime.ParseExact(d, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                                         .ToArray());
                students.Add(newStudent);
            }
            else
            {
                student.Dates.AddRange(separated.Skip(1)
                                         .Select(d => DateTime.ParseExact(d, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                                         .ToArray());
            }
        }
    }
}
