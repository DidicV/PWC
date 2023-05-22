using PWC3;

class Program
{
    static void Main()
    {
        Console.WriteLine("DEFAULT CONSTRUCTOR");
        Console.WriteLine("----------------------------");
        // Create an instance using the default constructor
        CarStation carStation1 = new CarStation();
        carStation1.DisplayCarStation();

        Console.WriteLine("\nCOPY CONSTRUCTOR");
        Console.WriteLine("----------------------------");
        // Create an instance using the copy constructor
        CarStation carStation2 = new CarStation(carStation1);
        carStation2.DisplayCarStation();

        Console.WriteLine("\nCONSTRUCTOR WITH ALL PARAMETERS");
        Console.WriteLine("----------------------------");
        // Create an instance using the constructor with all parameters
        CarStation carStation3 = new CarStation(123, "ABC Company", DateTime.Now, DateTime.Now.AddHours(2),
                                               "City XYZ", "coach", 50);
        carStation3.DisplayCarStation();

        Console.WriteLine("\nCONSTRUCTOR WITH A FEW PARAMETERS");
        Console.WriteLine("----------------------------");
        // Create an instance using the constructor with selected parameters
        CarStation carStation4 = new CarStation(456, "XYZ Company", "City PQR", "minibus");
        carStation4.DisplayCarStation();

        Console.WriteLine("\nUPDATE PRICE");
        Console.WriteLine("----------------------------");
        // Update price by converting to EURO
        decimal exchangeRate = 0.85m;
        carStation3.ConvertPrice(exchangeRate);
        carStation3.DisplayCarStation();
    }
}
