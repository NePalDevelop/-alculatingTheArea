

namespace СalculatingTheArea
{
    public static class FigureFactory
    {
        // Метод создания экземпляра класса Circle с заданным радиусом,
        // при условии корректности этого параметра, в противном случае 
        // возвращается null
        public static Circle CreateCircle(double radius) 
        { 
            if (radius >= 0) return new Circle(radius);                       // радиус не может быть отрицательным
            else return null;   
        }

        // Метод создания экземпляра класса Triangle с заданными сторонами,
        // при условии корректности этих параметров, в противном случае 
        // возвращается null


        public static Triangle CreateTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0 ||                                   // длина сторон не должна быть отрицательной
                (a > b + c) || (b > a + c) || (c > b + a)) return null;         // любая сторона должна быть меньше суммы двух других
            
            return new Triangle(a, b, c);
        }
    }
}
