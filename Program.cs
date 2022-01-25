using System;

namespace СalculatingTheArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double[]sides = { 1, 2, 3, 
                              4, 0, 6, 
                              6, -7, 8, 
                              7, 3, 9}; 
            double[] sidesTriangle = new double[3];

            IFlatFigure figure = new Circle();

            if (figure.IsCorrect)
                Console.WriteLine(@"The area of the figure - {0} = {1} ", figure.Name, figure.Area);

            figure.SetSize(8);
            if (figure.IsCorrect) 
                Console.WriteLine(@"The area of the figure - {0} = {1} ", figure.Name, figure.Area);
            
            
            Circle circle = new Circle(-2);
            if (circle.IsCorrect)
                Console.WriteLine(@"The area of the figure - {0} = {1} ", circle.Name, circle.Area);

            circle.SetSize(0);
            if (circle.IsCorrect)
                Console.WriteLine(@"The area of the figure - {0} = {1} ", circle.Name, circle.Area);

            circle.SetSize(-5);
            if (circle.IsCorrect)
                Console.WriteLine(@"The area of the figure - {0} = {1} ", circle.Name, circle.Area);


            IFlatFigure figure2 = new Triangle();
            if (figure2.IsCorrect)
                Console.WriteLine(@"The area of the figure - {0} = {1} ", figure.Name, figure.Area);

            for (int i = 0; i < sides.Length; i = i + 3)
            {
                Array.ConstrainedCopy(sides, i, sidesTriangle, 0, 3);
                figure2.SetSize(sidesTriangle);
                Console.WriteLine(@"Sides Triangle is {0} - {1}  - {2}", sidesTriangle[0], sidesTriangle[1], sidesTriangle[2]);
                if (figure2.IsCorrect)
                    Console.WriteLine(@"The area of the figure - {0} = {1} ", figure2.Name, figure2.Area);
                Console.ReadLine();
            } 
                




        }

    }
  
}

