using System;

namespace СalculatingTheArea
{
    public class Triangle : IFlatFigure
    {

        private double[] _sides;

        // Метод вычисления площади треугольника по трем сторонам

        public double GetArea ()
        {
            var half_p = _sides.Sum() / 2;
            return Math.Sqrt(half_p * (half_p - _sides[0])*(half_p - _sides[1]) *(half_p - _sides[2]));

        }

        // Конструктор класса имеет модификатор internal, чтобы исключить возможность
        // создания объекта с недопустимыми параметрами в обход метода
        // CreateTriangle из класса FigureFactory,
        // где создание объекта сопровождается неоходимыми проверками
        internal Triangle(double a, double b, double c)
        {
            _sides = new double [3] {a, b, c};
        }


        // Метод проверки прямоугольности треугольника

        public bool IsRectangular()
        {

            Array.Sort(_sides);

            return Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2) == Math.Pow(_sides[2], 2);

        }

    }
}
