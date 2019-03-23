using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double Average
        {
            get
            {
                return this.Grades.Average();
            }
        }

        public Student(string name, double[] grades)
        {
            this.Name = name;
            this.Grades = grades;
        }
    }
}
