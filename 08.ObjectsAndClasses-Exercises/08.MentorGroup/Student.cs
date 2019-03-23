using System;
using System.Collections.Generic;
using System.Text;

namespace _08.MentorGroup
{
    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }

        public Student(string name)
        {
            this.Name = name;
            this.Comments = new List<string>();
            this.Dates = new List<DateTime>();
        }
    }
}
