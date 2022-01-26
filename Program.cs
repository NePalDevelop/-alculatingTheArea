using System;
using СalculatingTheArea;


    class Program
    {
        static void Main(string[] args)
        {
            double[] sides = { 1, 2, 3,
                              4, 5, 6,
                              -6, -7, 8,
                              7, 1, 9,
                              3, 4, 5,
                              7, 7, 9,
                              10, 10, 10
            };

            List<IFlatFigure> figures = new();
            IFlatFigure figure; 

            for (int i = 0; i < sides.Length; i = i + 3)
            {
                figure = FigureFactory.CreateCircle(sides[i]);
                if (figure != null)
                {
                    figures.Add(figure);
                }

                figure = FigureFactory.CreateTriangle(sides[i], sides[i+1], sides[i+2]);
                if (figure != null)
                {
                    figures.Add(figure);

                }
        }

            foreach (IFlatFigure fig in figures)
            {
                        Console.WriteLine(@"The area of the figure  = {0} ",  fig.GetArea());
            }

        }
    }
  


