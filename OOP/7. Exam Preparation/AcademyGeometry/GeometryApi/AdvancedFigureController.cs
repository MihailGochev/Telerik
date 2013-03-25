namespace GeometryApi
{
    using System;

    public class AdvancedFigureController : FigureController
    {
        public override void ExecuteFigureCreationCommand(string[] splitFigString)
        {
            switch (splitFigString[0])
            {
                case "circle":
                    {
                        Vector3D center = Vector3D.Parse(splitFigString[1]);
                        currentFigure = new Circle(center, double.Parse(splitFigString[2]));
                        break;
                    }
                case "cylinder":
                    {
                        Vector3D top = Vector3D.Parse(splitFigString[1]);
                        Vector3D bot = Vector3D.Parse(splitFigString[2]);
                        currentFigure = new Cylinder(top, bot, double.Parse(splitFigString[3]));
                        break;
                    }
            }

            base.ExecuteFigureCreationCommand(splitFigString);
        }

        protected override void ExecuteFigureInstanceCommand(string[] splitCommand)
        {
            switch (splitCommand[0])
            {
                case "area":
                    {
                        var figure = this.currentFigure as IAreaMeasurable;
                        if (figure != null)
                        {
                            Console.WriteLine("{0:0.00}", figure.GetArea());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                case "volume":
                    {
                        var figure = this.currentFigure as IVolumeMeasurable;
                        if (figure != null)
                        {
                            Console.WriteLine("{0:0.00}", figure.GetVolume());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                case "normal":
                    {
                        var figure = this.currentFigure as IFlat;
                        if (figure != null)
                        {
                            Console.WriteLine("{0:0.00}", figure.GetNormal());

                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
            }

            base.ExecuteFigureInstanceCommand(splitCommand);
        }

    }
}
