//Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.

namespace Point3D.Library
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private readonly List<Point> route;

        public List<Point> Route
        {
            get { return route; }
        }

        public void AddPoint(Point point)
        {
            route.Add(point);
        }

        public Path()
        {
            route = new List<Point>();
        }

        public Path(int pathSize)
        {
            route = new List<Point>(pathSize);
        }

    }
}
