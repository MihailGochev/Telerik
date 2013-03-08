//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

using System;
using System.Collections.Generic;
using System.Linq;
using StudentClass;

class StudentsWithSpecificAge
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
            Console.WriteLine("Name:{0} {1} Age:{2}", stud.FirstName, stud.LastName, stud.Age);
        }

        var foundStudents = students.Where(stud => stud.Age >= 18 && stud.Age <= 24);

        Console.WriteLine();
        Console.WriteLine("Found students using lambda expressions:");
        foreach (var stud in foundStudents)
        {
            Console.WriteLine("Name:{0} {1} Age:{2}", stud.FirstName, stud.LastName, stud.Age);
        }

        foundStudents =
            from stud in students
            where stud.Age >= 18 && stud.Age <= 24
            select stud;

        Console.WriteLine();
        Console.WriteLine("Found students using LINQ query operators:");
        foreach (var stud in foundStudents)
        {
            Console.WriteLine("Name:{0} {1} Age:{2}", stud.FirstName, stud.LastName, stud.Age);
        }
    }
}

