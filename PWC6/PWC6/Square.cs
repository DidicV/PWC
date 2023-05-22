namespace PWC6
{
    public class Square : GeometricFigure
    {
        // constructor
        public Square(double side) : base(side)
        {
        }

        public override double Length()
        {
            return 4 * _dimension; // Perimeter formula
        }
    }
}
