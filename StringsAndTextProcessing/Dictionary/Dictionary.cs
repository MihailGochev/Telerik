using System;
using System.Collections;
using System.Linq;

class Dictionary
{
    static void Main()
    {
        Hashtable dictionary = new Hashtable();
        dictionary[".NET"] = "platform for applications from Microsoft";
        dictionary["CLR"] = "managed execution environment for .NET";
        dictionary["namespace"] = "hierarchical organization of classes";

        Console.WriteLine("Please enter a word:");
        string input = Console.ReadLine().Trim();
        if (dictionary[input] != null)
        {
            Console.WriteLine("{0} - {1}", input, dictionary[input]);
        }
        else
        {
            Console.WriteLine("The dictionary doesn't know of this word.");
        }


    }
}