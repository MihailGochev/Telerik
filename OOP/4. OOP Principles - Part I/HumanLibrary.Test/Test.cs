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

        Console.WriteLine("Unsorted students:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("Sorted students:");
        var sortedStudents = students.OrderBy(stud => stud.Grade);
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student);
        }

        List<Worker> workers = new List<Worker>
        {
                new Worker("Ivan","Zahariev",100, 50),
                new Worker("Pesho","Georgiev",200, 20),
                new Worker("Spas","Nedelchev",400, 140),
                new Worker("Georgi","Kostadinov",500, 110),
                new Worker("Pavel","Ivelinov",1000, 12),
                new Worker("Gerasim","Dimitrov",200, 23),
                new Worker("Angel","Spasov",500, 32),
                new Worker("Nenko","Ivanov",220, 44),
        };

        Console.WriteLine("Unsorted workers:");
        foreach (var worker in workers)
        {
            Console.WriteLine("Name: {0} {1} | MPH: {2}",worker.FirstName,worker.LastName,worker.MoneyPerHour());
        }

        Console.WriteLine("Sorted workers:");
        var sortedWorkers = workers.OrderBy(worker => worker.MoneyPerHour());
        foreach (var worker in sortedWorkers)
        {
            Console.WriteLine("Name: {0} {1} | MPH: {2:F2}", worker.FirstName, worker.LastName, worker.MoneyPerHour());
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

        Console.WriteLine("Sorted humans:");
        var sortedHumans = mergedLists.OrderBy(human => human.FirstName).ThenBy(human => human.LastName);
        foreach (var human in sortedHumans)
        {
            Console.WriteLine("Name: {0} {1}", human.FirstName, human.LastName);
        }
    }
}

