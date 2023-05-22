namespace PWC6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // objects of different geometric figures
            GeometricFigure circle = new Circle(5);
            GeometricFigure square = new Square(4);

            // using of polymorphism to call the Length() method
            Console.WriteLine("Length of Circle: " + circle.Length());
            Console.WriteLine("Length of Square: " + square.Length());
        }
    }
}