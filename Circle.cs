

namespace СalculatingTheArea
{
    sealed public class Circle : IFlatFigure
    {

        private double _radius; 

        public double GetArea()
        {
             return Math.PI * Math.Pow(_radius, 2);
        }

        internal Circle( double radius)
        {
            _radius = radius;
        }
        
    }
}
