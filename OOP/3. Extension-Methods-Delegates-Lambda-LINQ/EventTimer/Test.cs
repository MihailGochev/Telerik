﻿// Read in MSDN about the keyword event in C# and how to publish events. Re-implement the above using .NET events and following the best practices
namespace EventTimer
{
    using System;
    using TimerClass;

    public class Test
    {
        //Methods attached to the timer
        static void FirstMethod()
        {
            Console.WriteLine("FirstMethod!");
        }

        static void SecondMethod()
        {
            Console.WriteLine("SecondMethod!");
        }

        static void ThirdMethod()
        {
            Console.WriteLine("ThirdMethod!");
        }

        static void Main()
        {
            Timer myTimer = new Timer();

            Console.WriteLine("Calling the timer with no methods attached:");
            myTimer.Run(1, 1);

            Console.WriteLine("Adding one method to the timer and running it for 3 seconds (each 0.5 seconds):");
            myTimer.AddMethod(FirstMethod);
            myTimer.Run(3, 0.5);

            Console.WriteLine("Adding two more methods and running the timer again for 3 seconds (each 1 second):");
            myTimer.AddMethod(SecondMethod);
            myTimer.AddMethod(ThirdMethod);
            myTimer.Run(3, 1);
        }
    }
}
