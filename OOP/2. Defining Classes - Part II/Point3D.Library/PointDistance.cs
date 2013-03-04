//Write a static class with a static method to calculate the distance between two points in the 3D space.
namespace Point3D.Library
{
    using System;

    public static class PointDistance
    {
        public static double Calculate(Point start, Point end)
        {
            double xPower = Math.Pow(start.X - end.X, 2);
            double yPower = Math.Pow(start.Y - end.Y, 2);
            double zPower = Math.Pow(start.Z - end.Z, 2);

            return Math.Sqrt(xPower + yPower + zPower);
        }
    }
}
