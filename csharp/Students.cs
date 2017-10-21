using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox
{
    /// <summary>
    ///     Searches for a student from an in memory database using LINQ.
    /// </summary>
    public static class Students
    {
        private static IEnumerable<Student> InMemoryDatabase { get; } = new List<Student>
        {
            new Student {Firstname = "Joe", Lastname = "Ricky", Grade = 78.3},
            new Student {Firstname = "Sue", Lastname = "Sally", Grade = 80.3},
            new Student {Firstname = "Frank", Lastname = "Hammer", Grade = 90.3}
        };

        public static void Run()
        {
            Console.Write("Enter Student Name to Search: ");

            var input = Console.ReadLine();
            if (input == null)
            {
                return;
            }

            var student = InMemoryDatabase.FirstOrDefault(x => string.Equals(x.Fullname, input, StringComparison.CurrentCultureIgnoreCase));

            if (student == null)
            {
                Console.WriteLine("Student Not Found!");
                return;
            }

            Console.WriteLine("Student Found!");
            Console.WriteLine($"Name: {student.Fullname}");
            Console.WriteLine($"Grade: {student.Grade}");
        }
    }

    internal class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double Grade { get; set; }

        public string Fullname => Firstname + " " + Lastname;
    }
}