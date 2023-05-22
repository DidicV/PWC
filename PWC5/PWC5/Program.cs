namespace PWC5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an object from the base class
            CarStation carStation = new CarStation()
            {
                RouteNumber = 1,
                Company = "Lux Transport",
                ArrivalTime = DateTime.Now,
                DepartureTime = DateTime.Now.AddHours(2),
                Destination = "Soroca",
                TransportType = "Bus",
                Price = 50.00m
            };

            // Create an object from the derived class
            InternationalRoute internationalRoute = new InternationalRoute()
            {
                RouteNumber = 2,
                Company = "Vite Transport",
                ArrivalTime = DateTime.Now,
                DepartureTime = DateTime.Now.AddHours(4),
                Destination = "Nice",
                TransportType = "Train",
                Price = 100.00m,
                CountryDestination = "France",
                CountryDestinationCurrency = "Euro"
            };

            Console.WriteLine("BASE OBJECT");
            Console.WriteLine("-------------------------");
            carStation.DisplayCarStation();


            Console.WriteLine("\n\nDERIVED OBJECT");
            Console.WriteLine("-------------------------");
            internationalRoute.DisplayCarStation();
        }
    }
}