//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. Use LINQ query operators.
using System;
using System.Linq;
using System.Collections.Generic;
using StudentClass;

class FindStudent
{
    static void Main()
    {
        List<Student> students = new List<Student>{
                new Student("Ivav","Biroslavov",19),
                new Student("Georgi","Leshperov",18),
                new Student("Pesho","Ivanov",41),
                new Student("Pavel","Dobrev",31),
                new Student("Angel","Georgiev",21),
                new Student("Spas","Zahariev",15),
                new Student("Zahari","Georgiev",27),
            };

        Console.WriteLine("All students:");
        foreach (var stud in students)
        {
            Console.WriteLine("Name:{0} {1}", stud.FirstName, stud.LastName);
        }

        var foundStudents = students.Where(stud => stud.FirstName.CompareTo(stud.LastName) > 0 ? true : false);

        Console.WriteLine();
        Console.WriteLine("Found students using lambda expressions:");
        foreach (var stud in foundStudents)
        {
            Console.WriteLine("Name:{0} {1}", stud.FirstName, stud.LastName);
        }

        foundStudents =
            from stud in students
            where stud.FirstName.CompareTo(stud.LastName) > 0 ? true : false
            select stud;

        Console.WriteLine();
        Console.WriteLine("Found students using LINQ query operators:");
        foreach (var stud in foundStudents)
        {
            Console.WriteLine("Name:{0} {1}", stud.FirstName, stud.LastName);
        }

    }
}
