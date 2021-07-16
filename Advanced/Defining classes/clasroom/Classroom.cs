using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    class Classroom
    {
        private List<Student> students;
        public int Capacity { get; private set; }
        public int Count
        {
            get
            {
                return students.Count;
            }

        }

        public string RegisterStudent(Student student)
        {
            if (Capacity <= Count)
            {
                return "No seats in the classroom";
            }
            else
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            if (students.Exists(x => x.FirstName == firstName && x.LastName == lastName))
            {
                students.Remove(students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName));
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return "Student not found";
            }
        }

        public string GetSubjectInfo(string subject)
        {
            List<Student> studentsBySubject = students
                .Where(x => x.Subject == subject)
                .ToList();
            if (studentsBySubject.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");
                foreach (var item in studentsBySubject)
                {
                    sb.AppendLine($"{item.FirstName} {item.LastName}");
                }
                return sb.ToString().TrimEnd();
            }
            else
            {
                return "No students enrolled for the subject";
            }
        }

        public int GetStudentsCount()
        {
            return students.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            return students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
        }
        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }


    }

    //public void RegisterStudent(Student student, List<Student> stud)
    //{
    //    students.Add(student);
    //}
}
