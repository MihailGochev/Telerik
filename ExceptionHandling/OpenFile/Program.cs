﻿using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Please enter the file path:");
        string path = Console.ReadLine();

        try
        {
            string[] file = File.ReadAllLines(@"C:\WINDOWS\win.ini");
            foreach (var item in file)
            {
                Console.WriteLine(item);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file cannot be found!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The directory cannot be found!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("No file path is given!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The path was too long!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Incorrect path!");
        }
        catch (System.Security.SecurityException)
        {
            Console.WriteLine("You don't have the required permission to access this file!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Unauthorized Access!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Invalid file path!");
        }
        catch (IOException)
        {
            Console.WriteLine("Invalid file path!");
        }
    }
}
