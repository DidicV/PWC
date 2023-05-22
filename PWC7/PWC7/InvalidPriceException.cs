namespace PWC7
{
    // custom error hanling
    // inherit Exception class
    public class InvalidPriceException : Exception
    {
        public InvalidPriceException() : base("Invalid price entered.")
        {
        }
    }
}
