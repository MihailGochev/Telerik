using System;
using System.Globalization;
using System.Threading;
using GeometryApi;

namespace AcademyGeometry
{
    class Program
    {
        private static FigureController GetFigureController()
        {
            return new  AdvancedFigureController();
        }

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);

            var figController = GetFigureController();

            int figCreationsCount = int.Parse(Console.ReadLine());
            int endCommandsCount = 0;

            while (endCommandsCount < figCreationsCount)
            {
                figController.ExecuteCommand(Console.ReadLine());
                if (figController.EndCommandExecuted)
                {
                    endCommandsCount++;
                }
            }
        }
    }
}
