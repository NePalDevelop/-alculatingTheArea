

namespace СalculatingTheArea
{
    public interface IFlatFigure
    {
        public string Name { get;}

        public double AreaOfFigure { get; }

        public bool IsCorrectData(params double[] parameters);

        public bool SetNewParameters(params double[] parameters);
                
    }
}
