namespace FigureLibrary.Figures
{
    public class Triangle : IFigure
    {
        private double a;
        private double b;
        private double c;
        /// <summary>
        /// Сторона A
        /// </summary>
        public double A 
        { 
            get =>a; 
            set
            {
                if (value <= 0) throw new ArgumentException("Incorrect a side");
                a = value;
            }
        }
        /// <summary>
        /// Сторона B
        /// </summary>
        public double B 
        { 
            get=>b; 
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Incorrect b side");
                b = value;
            } 
        }
        /// <summary>
        /// Сторона C
        /// </summary>
        public double C 
        { 
            get=>c; 
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Incorrect c side");
                c = value;
            } 
        }
        /// <summary>
        /// Периметр треугольника
        /// </summary>
        public double Perimeter { get => (a + b + c); } 

        /// <summary>
        /// Является ли треугольник прямоугольным, проверка с точностью до 3 цифр после запятой
        /// </summary>
        public bool isRectangular
        {
            get 
            {
                var powa = Math.Round(a * a,3);
                var powb = Math.Round(b * b,3);
                var powc = Math.Round(c * c,3);
                return powa == powc+powb || powc == powb+powa || powb == powc+powa;
            }
        }

        /// <summary>
        /// Треуголник
        /// </summary>
        /// <param name="a">Сторона А</param>
        /// <param name="b"> Сторона B</param>
        /// <param name="c">Сторона C</param>
        /// <exception cref="ArgumentException">Ошибка если сторона отрицательна или ноль, либо если треугольника с такими сторонами не существует</exception>
        public Triangle(double a, double b, double c)
        {
            if (a + b < c || b + c < a || a + c < b) throw new ArgumentException("Triangle with such sides doesn't exist");
            A = a;
            B = b;
            C = c;

        }
        public double CalculateArea()
        {
            var halfPerimeter = Perimeter / 2.0d;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
        }

    }
}
