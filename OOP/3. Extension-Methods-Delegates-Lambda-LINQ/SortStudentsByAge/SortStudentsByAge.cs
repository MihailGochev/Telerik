//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ.
using System;
using System.Collections.Generic;
using System.Linq;
using StudentClass;

    class SortStudentsByAge
    {
        static void Main()
        {
            List<Student> students = new List<Student>{
                new Student("Ivav","Biroslavov",19),
                new Student("Ivav","Zahariev",19),
                new Student("Georgi","Leshperov",18),
                new Student("Pesho","Ivanov",41),
                new Student("Pavel","Dobrev",31),
                new Student("Pavel","Alexandrov",31),
                new Student("Pavel","Zogravski",31),
                new Student("Angel","Georgiev",21),
                new Student("Spas","Zahariev",15),
                new Student("Zahari","Georgiev",27),
            };

            Console.WriteLine("All students:");
            foreach (var stud in students)
            {
                Console.WriteLine("Name:{0} {1} Age:{2}", stud.FirstName, stud.LastName, stud.Age);
            }

            var sortedStudents = students.OrderBy(stud => stud.FirstName).ThenBy(stud => stud.LastName);

            Console.WriteLine();
            Console.WriteLine("Sorted students using lambda expressions:");
            foreach (var stud in sortedStudents)
            {
                Console.WriteLine("Name:{0} {1} Age:{2}", stud.FirstName, stud.LastName, stud.Age);
            }

            sortedStudents =
                from stud in students
                orderby stud.FirstName, stud.LastName
                select stud;

            Console.WriteLine();
            Console.WriteLine("Sorted students using LINQ query operators:");
            foreach (var stud in sortedStudents)
            {
                Console.WriteLine("Name:{0} {1} Age:{2}", stud.FirstName, stud.LastName, stud.Age);
            }
        }
    }

