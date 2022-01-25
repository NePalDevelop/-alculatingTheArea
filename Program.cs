namespace СalculatingTheArea
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlatFigure figure = new Circle();

            if (figure.IsCorrect)
                Console.WriteLine(@"The area of the figure - {0} = {1} ", figure.Name, figure.Area);

            figure.SetSize(8);
            if (figure.IsCorrect) 
                Console.WriteLine(@"The area of the figure - {0} = {1} ", figure.Name, figure.Area);
            
            
            Circle circle = new Circle(-2);
            if (circle.IsCorrect)
                Console.WriteLine(@"The area of the figure - {0} = {1} ", circle.Name, circle.Area);

            circle.SetSize(0);
            if (circle.IsCorrect)
                Console.WriteLine(@"The area of the figure - {0} = {1} ", circle.Name, circle.Area);

            circle.SetSize(-5);
            if (circle.IsCorrect)
                Console.WriteLine(@"The area of the figure - {0} = {1} ", circle.Name, circle.Area);

        }

    }
  
}

