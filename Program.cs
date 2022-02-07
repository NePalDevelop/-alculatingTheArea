using System;
using СalculatingTheArea;

// Пример вычисление площади фигуры без знания типа фигуры в compile-time

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
        // создание списка объектов типа интерфейса IFlatFigure

        List<IFlatFigure> figures = new();

        IFlatFigure figure;

        // заполнение списка объектами Circle и Triangle с использованием 
        // методов класса FigureFactory

        for (int i = 0; i < sides.Length; i = i + 3)
        {
            figure = FigureFactory.CreateCircle(sides[i]);
            if (figure != null)
            {
                figures.Add(figure);
            }

            figure = FigureFactory.CreateTriangle(sides[i], sides[i + 1], sides[i + 2]);
            if (figure != null)
            {
                figures.Add(figure);
            }
        }


        // Вычисление площади фигур безотносительно их конкретного типа,
        // используя метод GetArea, определенный в интерфейсе IFlatFigure и
        // реализованный во всех классах

        foreach (IFlatFigure fig in figures)
        {
            Console.WriteLine(@"The area of the figure  = {0} ", fig.GetArea());
        }

    }
}



