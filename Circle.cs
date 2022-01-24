

namespace СalculatingTheArea
{
    public class Circle : IFlatFigure
    {
        private readonly string _name = "Circle";
        private double _radius = 0.0;

        public string Name { get => _name; }

        public double Radius { get => _radius; 
            private set
            { 
                if (IsCorrectData(value)) _radius = value;
                else throw new ArgumentException("Radius must exist and have a positive value");
            } 
        }

        public double AreaOfFigure { get
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
         }

        public Circle()
        { }    

        public Circle(params double[] inputArray)
        {

            Radius = inputArray[0];
        }



        public bool IsCorrectData(params double[] inputArray)
        {
           return !((inputArray == null || inputArray.Length == 0 || inputArray[0] < 0.0));
        }

        public bool SetNewParameters(params double[] inputArray)
        {
            if (!IsCorrectData(inputArray))
                return false;
            else
            {
                _radius = inputArray[0];
            }
            
            return true;
        }
    }
}
