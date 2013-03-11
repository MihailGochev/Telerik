//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
namespace Shapes.Library
{
    using System;
    public abstract class Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The width cannot be negative.");
                }
                width = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The height cannot be negative.");
                }
                height = value;
            }
        }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculateSurface();
    }
}
