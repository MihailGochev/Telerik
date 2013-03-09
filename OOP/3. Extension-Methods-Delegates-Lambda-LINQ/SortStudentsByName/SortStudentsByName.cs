//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ.
using System;
using System.Collections.Generic;
using System.Linq;
using StudentClass;

class SortStudentsByName
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
            Console.WriteLine(stud);
        }

        var sortedStudents = students.OrderByDescending(stud => stud.FirstName).ThenByDescending(stud => stud.LastName);

        Console.WriteLine();
        Console.WriteLine("Sorted students using lambda expressions:");
        foreach (var stud in sortedStudents)
        {
            Console.WriteLine(stud);
        }

        sortedStudents =
            from stud in students
            orderby stud.FirstName descending, stud.LastName descending
            select stud;

        Console.WriteLine();
        Console.WriteLine("Sorted students using LINQ query operators:");
        foreach (var stud in sortedStudents)
        {
            Console.WriteLine(stud);
        }
    }
}

