

namespace СalculatingTheArea
{
    public class Circle : IFlatFigure
    {
        private readonly string _name = "Circle";
        private double _radius = default;
        private bool _isCorrect = false;

        public string Name { get => _name; }

        public bool IsCorrect { get => _isCorrect; }    

        public double Radius { get => _radius; }

        public double Area{ get
            {
                if (IsCorrect) return Math.PI * Math.Pow(Radius, 2);
                else return -1.0;
            }
         }

        public Circle(params double[] inputArray)
        {
            SetSize(inputArray);
        }


        public void SetSize(params double[] inputArray)
        {
            _isCorrect = !((inputArray == null || inputArray.Length == 0 || inputArray[0] < 0.0));

            if (_isCorrect)
                _radius = inputArray[0];
            else
                _radius = default;
        }
    }
}
