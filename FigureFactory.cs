

namespace СalculatingTheArea
{
    public static class FigureFactory
    {
        public static Circle CreateCircle(double radius) 
        { 
            if (radius >= 0) return new Circle(radius);
            else return null;   
        }

        public static Triangle CreateTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0 ||
                (a > b + c) || (b > a + c) || (c > b + a)) return null;
            
            return new Triangle(a, b, c);
        }
    }
}
