

namespace СalculatingTheArea
{
    public static class FigureFactory
    {
        // Метод создания экземпляра класса Circle с заданным радиусом,
        // при условии корректности этого параметра, в противном случае 
        // возвращается null

        // Чтобы рассчитываемая площадь круга не выходила за рамки  Double.MaxValue
        // радиус должен быть не более корня из MaxValue деленного на Пи
        // Math.Sqrt(double.MaxValue / Math.PI);
        // Но вычисления с таки большими числами сильно округляются и операции сравнения
        // работают не корректно, да и смысла в таких расчетах нет.
        // Зададим разумное ограничение сверху 10^8

        public readonly static double maxRadius = 1E8;

        // Максимальная площадь треугольника получается при равенстве всех сторон
        // и равна при этом  a^2*(Sqrt(3)/4).
        // Логично ограничить сверху длину стороны треугольника изходя из этой формулы.
        // Чтобы площадь в любом случае была не более Double.MaxValue
        // 2 * Math.Sqrt(double.MaxValue / Math.Sqrt(3))
        // Но также зададим разумное ограничение 10^8

        public readonly static double maxSide = 1E8;

        public static Circle CreateCircle(double radius)
        {
            if (radius <= 0) return null;               // радиус должен быть больше нуля

            if (radius.CompareTo(maxRadius) >= 0) return null;       // не должен превышать максимального значения

            return new Circle(radius);

        }

        // Метод создания экземпляра класса Triangle с заданными сторонами,
        // при условии корректности этих параметров, в противном случае 
        // возвращается null


        public static Triangle CreateTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) return null;                           // длина сторон должна быть положительной
            if (a >= maxSide || b >= maxSide || c >= maxSide) return null;       // длины сторон не должны превышать maxSide
            if ((a > b + c) || (b > a + c) || (c > b + a)) return null;         // любая сторона должна быть меньше суммы двух других

            return new Triangle(a, b, c);
        }
    }
}
