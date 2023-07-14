namespace FigureLibrary.Figures
{
    public class Cirle : IFigure
    {
        private double radius;
        public double Radius
        {
            get => radius;
            set 
            {
                if (value <= 0) throw new ArgumentException("Incorrect cirle radius");
                radius = value;
            }
        }
        /// <summary>
        /// Круг, задается радиусом.
        /// </summary>
        /// <param name="radius"></param>
        public Cirle(double radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
