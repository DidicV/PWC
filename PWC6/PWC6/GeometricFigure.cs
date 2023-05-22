namespace PWC6
{
    public abstract class GeometricFigure : IGeometricFigure
    {
        // Constant for PI
        protected const double PI = 3.1415;

        // store the dimension field
        protected double _dimension; 

        // base constructor to set the dimension
        public GeometricFigure(double dimension)
        {
            _dimension = dimension;
        }

        // abstract method of base class
        public abstract double Length();
    }
}
