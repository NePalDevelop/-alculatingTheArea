using System;

namespace СalculatingTheArea
{
    sealed public class Circle : IFlatFigure
    {

        private double _radius; 

        // Метод вычисления площади созданного круга

        public double GetArea()
        {
             return Math.PI * Math.Pow(_radius, 2);
        }

        // Конструктор класса имеет модификатор internal, чтобы исключить возможность
        // создания объекта с недопустимыми параметрами в обход метода
        // CreateTriangle из класса FigureFactory,
        // где создание объекта сопровождается неоходимыми проверками
        internal Circle( double radius)
        {
            _radius = radius;
        }
        
    }
}
