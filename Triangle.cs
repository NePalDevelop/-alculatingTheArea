
namespace СalculatingTheArea
{
    internal class Triangle : IFlatFigure
    {
        private readonly string _name = "Triangle";
        private List <double> _sides = new() { default, default, default };
        private bool _isCorrect = false;

        public string Name { get => _name; }

        public bool IsCorrect { get => _isCorrect; }

        public List<double> Sides { get => _sides; }

        public double Area
        {
            get
            {
                if (IsCorrect)
                {
                    var h_perimeter = Sides.Take(3).Sum()/2;
                    var square = h_perimeter;
                    for (int i = 0; i < 3; i++)
                        square = square*(h_perimeter - Sides[i]);
                    return Math.Sqrt(square);
                }
                else return -1.0;
            }
        }

        public Triangle(params double[] inputArray)
        {
            SetSize(inputArray);
        }


        public void SetSize(params double[] inputArray)
        {
            _isCorrect = !(inputArray == null || inputArray.Length < 3);

            for  (int i = 0;  i < 3; i++)
            {
                _isCorrect = _isCorrect && inputArray[i] > 0;

                if (_isCorrect) _sides[i] = inputArray[i];
                
                else _sides[i] = default;
                
            }
            _isCorrect = IsCorrect && (Sides[0] < Sides[1]+Sides[2]) && (Sides[1] < Sides[0] + Sides[2]) && (Sides[2] < Sides[0] + Sides[1]);
        }
    }
}
