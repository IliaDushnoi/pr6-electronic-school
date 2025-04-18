using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Journal
{
    public class Student
    {
        public string name;
        public int age;
        public double averageGrade;

        public Student(string name, int age, double averageGrade)
        {
            this.name = name;
            this.age = age;
            this.averageGrade = averageGrade;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public double AverageGrade {  get => averageGrade; set => averageGrade = value; }

        public override string ToString()
        {
            return $"{name} ({age} лет) - Оценка: {averageGrade}";
        }
    }
}
