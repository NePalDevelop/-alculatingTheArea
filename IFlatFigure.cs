

namespace СalculatingTheArea
{
    public interface IFlatFigure
    {
        public string Name { get;}

        public double Area { get; }

        public bool IsCorrect { get; }     

        public void SetSize(params double[] parameters);
                
    }
}
