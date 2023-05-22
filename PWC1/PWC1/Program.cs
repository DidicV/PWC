// imoprt math library
using static System.Math;

public class Program
{
    static bool IsPrime(int n)
    {
        // block numbers lower than 2
        if (n <= 1)
        {
            return false;
        }

        for (int divisor = 2; divisor <= Sqrt(n); divisor++)
        {
            // check division
            if (n % divisor == 0)
            {
                return false;
            }    
        }

        return true;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Insert number = ");

            // try ito convert input in int digit
            int number = Convert.ToInt32(Console.ReadLine());

            // call the method
            if(IsPrime(number))
            {
                Console.WriteLine("Number is prime");
            }
            else
            {
                Console.WriteLine("Number is not prime");
            }
        }
        catch
        {
            Console.WriteLine("It is not a number");
        }
    }
}