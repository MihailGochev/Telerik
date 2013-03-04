//Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Implement the ToString() to enable printing a 3D point.
namespace Point3D.Library
{
    public struct Point
    {

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        //Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. Add a static property to return the point O.
        private static readonly Point start = new Point(0, 0, 0);
        public static Point Start
        {
            get { return start; }
        }

        public Point(int x, int y, int z):this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }



        public override string ToString()
        {
            return string.Format("[{0},{1},{2}]", X, Y, Z);
        }
    }
}
