namespace GeometryApi
{
    using System;

    public class Circle : Figure, IAreaMeasurable, IFlat
    {
        public double Radius { get; private set; }

        public Circle(Vector3D center, double radius)
            : base(center)
        {
            this.Radius = radius;
        }

        public override double GetPrimaryMeasure()
        {
            return GetArea();
        }

        public double GetArea()
        {
            return this.Radius * this.Radius * Math.PI;
        }

        public Vector3D GetNormal()
        {
            return new Vector3D(0, 0, 1);
        }
    }
}
