namespace GeometryApi
{
    using System;

    public class Cylinder : Figure, IAreaMeasurable, IVolumeMeasurable
    {
        public double Radius { get; private set; }

        public Cylinder(Vector3D top, Vector3D bottom, double radius)
            : base(top, bottom)
        {
            this.Radius = radius;
        }

        public override double GetPrimaryMeasure()
        {
            return GetVolume();
        }

        public double GetArea()
        {
            double basesArea = Math.PI * this.Radius * this.Radius * 2;
            double sideArea = (vertices[0] - vertices[1]).Magnitude * Radius;

            return basesArea + sideArea;
        }

        public double GetVolume()
        {
            return (vertices[0] - vertices[1]).Magnitude * Math.PI * this.Radius * this.Radius;
        }
    }
}
