namespace СalculatingTheArea
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlatFigure figure = new Circle();

            Console.WriteLine(@"Площадь фигуры - {0} = {1} ", figure.Name, figure.AreaOfFigure);

            if (figure.SetNewParameters(8)) 
                Console.WriteLine(@"Площадь фигуры - {0} = {1} ", figure.Name, figure.AreaOfFigure);
            
            
            Circle circle = new Circle(-2);
            Console.WriteLine(@"Площадь фигуры - {0} = {1} ", circle.Name, circle.AreaOfFigure);
        }

    }
  
}

