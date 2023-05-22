namespace PWC6
{
    public class Circle : GeometricFigure
    {
        // constructor
        public Circle(double radius) : base(radius)
        {
        }

        public override double Length()
        {
            return 2 * PI * _dimension; // Circumference formula
        }
    }
}
