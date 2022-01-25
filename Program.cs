using System;

namespace СalculatingTheArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sides = { 1, 2, 3,
                              4, 5, 6,
                              6, -7, 8,
                              7, 3, 9,
                              3, 4, 5,
                              7, 7, 9,
                              10, 10, 10
            };
            double[] sidesTriangle = new double[3];

            List<IFlatFigure> figures = new();
            Triangle triangle; 

            figures.Add(new Triangle(3,4,5));
            figures.Add(new Circle(6));
            for (int i = 0; i < sides.Length; i = i + 3)
            {
                Array.ConstrainedCopy(sides, i, sidesTriangle, 0, 3);
                figures.Add(new Triangle(sidesTriangle));
                figures.Add(new Circle(sidesTriangle[0]));
            }

            foreach (IFlatFigure figure in figures)
            {
                if (figure.IsCorrect)
                    {
                        Console.WriteLine(@"The area of the figure - {0} = {1} ", figure.Name, figure.Area);
                        if(figure.Name == "Triangle")
                        {
                            triangle = (Triangle)figure;
                            Console.WriteLine(@"Triangle is Rectangular - {0}", triangle.IsRectangular());
                        }
                            

                }
                   
            }

        }
    }
  
}

