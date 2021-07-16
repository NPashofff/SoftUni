using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Student
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Student student = new Student()
                {
                    FirstName = input[0],
                    LastName = input[1],
                    Grade = double.Parse(input[2])                    
                };

                students.Add(student);
            }

            List<Student> sorted = students
                .OrderByDescending(x => x.Grade)
                .ToList();
            
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
