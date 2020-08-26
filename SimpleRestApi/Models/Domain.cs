using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleRestApi.Models
{
    public class Domain
    {
        public class Student
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Phone { get; set; }
        }

        public class StudentManager
        {
            private static List<Student> _students;

            static StudentManager()
            {
                _students = new List<Student>
                {
                    new Student { Id = 1, FirstName = "John", LastName = "Doe", Phone = "403-555-1234" },
                    new Student { Id = 2, FirstName = "Ken", LastName = "Hunter", Phone = "403-555-3344" },
                    new Student { Id = 3, FirstName = "Sarah", LastName = "Carr", Phone = "403-555-4560" },
                    new Student { Id = 4, FirstName = "Paul", LastName = "Kwan", Phone = "403-555-3244" }
                };
            }

            public static List<Student> GetAll()
            {
                return _students;
            }

            public static void Add(Student student)
            {
                var id = _students.Max(s => s.Id);
                id++;
                student.Id = id;
                _students.Add(student);
            }

            public static Student Find(int id)
            {
                var student = _students.Find(s => s.Id == id);
                return student;
            }
        }
    }
}
