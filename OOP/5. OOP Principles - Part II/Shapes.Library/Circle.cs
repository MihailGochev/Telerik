//Define class Circle and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method. 
namespace Shapes.Library
{
    using System;

    public class Circle : Shape
    {
        //keeping height and width the same at initialization
        public Circle(double radius)
            :base(radius,radius)
        {
        }

        public override double CalculateSurface()
        {
            return Width * Width * System.Math.PI;
        }
    }
}
