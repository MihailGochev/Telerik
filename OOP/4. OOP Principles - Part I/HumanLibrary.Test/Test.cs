//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
//Initialize a list of 10 workers and sort them by money per hour in descending order. 
//Merge the lists and sort them by first name and last name.
using System;
using System.Collections.Generic;
using System.Linq;
using HumanLibrary;

class Test
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Ivan","Zahariev",1),
            new Student("Pesho","Georgiev",3),
            new Student("Spas","Nedelchev",2),
            new Student("Georgi","Kostadinov",3),
            new Student("Pavel","Ivelinov",4),
            new Student("Gerasim","Dimitrov",3),
            new Student("Angel","Spasov",5),
            new Student("Nenko","Ivanov",1),
        };
        Console.WriteLine(new String('*', 40));
        Console.WriteLine("Unsorted students:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("Sorted students by grade:");
        var sortedStudents = students.OrderBy(stud => stud.Grade);
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student);
        }

        List<Worker> workers = new List<Worker>
        {
            new Worker("Liudmil","Zahariev",100, 50),
            new Worker("Asen","Georgiev",200, 20),
            new Worker("Petyr","Nedelchev",400, 140),
            new Worker("Todor","Kostadinov",500, 110),
            new Worker("Hristo","Ivelinov",1000, 12),
            new Worker("Kolio","Dimitrov",200, 23),
            new Worker("Kaliqn","Spasov",500, 32),
            new Worker("Joro","Ivanov",220, 44),
        };

        Console.WriteLine(new String('*', 40));
        Console.WriteLine("Unsorted workers:");
        foreach (var worker in workers)
        {
            Console.WriteLine(worker);
        }

        Console.WriteLine("Sorted workers by money per hour:");
        var sortedWorkers = workers.OrderBy(worker => worker.MoneyPerHour());
        foreach (var worker in sortedWorkers)
        {
            Console.WriteLine(worker);
        }

        List<Human> mergedLists = new List<Human>();
        foreach (var student in students)
        {
            mergedLists.Add(student);
        }

        foreach (var student in workers)
        {
            mergedLists.Add(student);
        }

        Console.WriteLine(new String('*', 40));
        Console.WriteLine("Sorted humans by name:");
        var sortedHumans = mergedLists.OrderBy(human => human.FirstName).ThenBy(human => human.LastName);
        foreach (var human in sortedHumans)
        {
            Console.WriteLine("Name: {0} {1}", human.FirstName, human.LastName);
        }
    }
}

