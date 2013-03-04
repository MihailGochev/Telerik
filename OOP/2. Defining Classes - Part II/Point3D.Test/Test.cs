using System;
using Point3D.Library;

namespace Point3D.Test
{
    public class Test
    {
        static void Main(string[] args)
        {
            Point myPoint1 = new Point();
            Point myPoint2 = new Point(5, 77, 31);

            Console.WriteLine("First point: {0}", myPoint1);
            Console.WriteLine("First point: {0}", myPoint2);

            Console.WriteLine("Distance between the two points: {0}", PointDistance.Calculate(myPoint1, myPoint2));

            Path myPath = new Path(6);
            Random random = new Random();

            for (int index = 0; index < 6; index++)
            {
                myPath.AddPoint(new Point(random.Next(0, 100), random.Next(0, 100), random.Next(0, 100)));
            }

            Console.WriteLine();
            Console.WriteLine("Points added into the Path class:");
            foreach (var point in myPath.Route)
            {
                Console.WriteLine(point);
            }

            PathStorage.SavePath(@"..\..\output.txt", myPath);

            myPath = PathStorage.LoadPath(@"..\..\output.txt");
            Console.WriteLine();
            Console.WriteLine("Same points added to file and then reloaded again:");
            foreach (var point in myPath.Route)
            {
                Console.WriteLine(point);
            }

            myPath = PathStorage.LoadPath(@"..\..\input.txt");
            Console.WriteLine();
            Console.WriteLine("Points loaded from a sample input file:");
            foreach (var point in myPath.Route)
            {
                Console.WriteLine(point);
            }
        }
    }
}
