using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Student(string name, string id, string age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = int.Parse(age);
        }
    }
}
