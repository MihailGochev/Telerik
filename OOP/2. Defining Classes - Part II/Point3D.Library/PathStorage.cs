//Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.

namespace Point3D.Library
{
    using System;
    using System.IO;

    public static class PathStorage
    {
        public static Path LoadPath(string filePath)
        {
            StreamReader input = new StreamReader(filePath);
            Path output = new Path();

            using (input)
            {
                string line = input.ReadLine();
                while (line != null)
                {
                    string[] point = line.Split(' ');
                    output.AddPoint(new Point(int.Parse(point[0]), int.Parse(point[1]), int.Parse(point[2])));
                    line = input.ReadLine();
                }
            }

            return output;
        }

        public static void SavePath(string filePath, Path path)
        {
            StreamWriter output = new StreamWriter(filePath);

            using (output)
            {
                foreach (var point in path.Route)
                {
                    output.WriteLine("{0} {1} {2}", point.X, point.Y, point.Z);
                }
            }
        }
    }
}
