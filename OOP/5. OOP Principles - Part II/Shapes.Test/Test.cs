//Write a program that tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.
using System;
using System.Collections.Generic;
using Shapes.Library;

namespace Shapes.Test
{
    class Test
    {
        static void Main()
        {
            List<Shape> figures = new List<Shape>
            {
                new Circle(13.5),
                new Rectangle(5.5,12),
                new Triangle(3.2,7.6),
            };

            Console.WriteLine("Calculating the surface of the figures:");
            foreach (var figure in figures)
            {
                Console.WriteLine();
                Console.WriteLine("{0}:", figure.GetType().Name);
                Console.WriteLine("{0:F2}", figure.CalculateSurface());
            }
        }
    }
}
