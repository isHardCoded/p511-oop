using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public double AverageGrade {  get; set; }

        public Student(string name, int age, double averageGrade)
        {
            Name = name;
            Age = age;
            AverageGrade = averageGrade;
        }

        public override string ToString()
        {
            return $"{Name};{Age};{AverageGrade}";
        }
    }
}
