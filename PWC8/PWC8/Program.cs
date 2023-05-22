namespace PWC8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<CarStation> carStations = new List<CarStation>()
            {
                new CarStation
                {
                    RouteNumber = 1,
                    Company = "Lux Transport",
                    ArrivalTime = DateTime.Now,
                    DepartureTime = DateTime.Now.AddHours(2),
                    Destination = "Soroca",
                    TransportType = "Bus",
                    Price = 50.00m
                },
                new CarStation
                {
                    RouteNumber = 2,
                    Company = "Vite Transport",
                    ArrivalTime = DateTime.Now,
                    DepartureTime = DateTime.Now.AddHours(4),
                    Destination = "Nice",
                    TransportType = "Train",
                    Price = 100.00m
                }
            };

            Console.WriteLine("Price sum of stations");
            Console.WriteLine("----------------------------------------------------");
            // calculate the total price of all car stations
            decimal totalPrice = carStations.Sum(cs => cs.Price);
            Console.WriteLine("Total price of all stations: " + totalPrice);


            Console.WriteLine("\n\nSort stations by departure time");
            Console.WriteLine("----------------------------------------------------");
            // sort car stations by departure time
            List<CarStation> sortedCarStations = carStations.OrderBy(cs => cs.DepartureTime).ToList();
            foreach(var station in sortedCarStations)
            {
                station.DisplayCarStation();
            }

            Console.WriteLine("\n\n Station name with upper case");
            Console.WriteLine("----------------------------------------------------");
            // sort car stations by departure time
            carStations.ForEach(cs => cs.Company = cs.Company.ToUpper());
            foreach (var station in sortedCarStations)
            {
                station.DisplayCarStation();
            }
        }
    }
}