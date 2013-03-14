using System;
namespace PersonClass
{
    class Test
    {
        static void Main()
        {
            Person joro = new Person("Joro Peshov", 25);
            Person agelessPerson = new Person("Pesho Peshev");
            Person namelessPerson = new Person(15);
            Person empty = new Person();

            Console.WriteLine("Creating Persons with all combinatios of available data and printing them:");
            Console.WriteLine(joro);
            Console.WriteLine(agelessPerson);
            Console.WriteLine(namelessPerson);
            Console.WriteLine(empty);
        }
    }
}
