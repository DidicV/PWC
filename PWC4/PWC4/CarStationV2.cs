namespace PWC4
{
    // Example of converting objects from one class to another class
    public class CarStationV2
    {
        public int RouteNumber { get; set; }
        public string Company { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public string Destination { get; set; }
        public string TransportType { get; set; }
        public decimal Price { get; set; }

        public CarStationV2(CarStation car)
        {
            RouteNumber = car.RouteNumber;
            Company = car.Company;
            ArrivalTime = car.ArrivalTime;
            DepartureTime = car.DepartureTime;
            Destination = car.Destination;
            TransportType = car.TransportType;
            Price = car.Price;
        }

        // Display all fields of the class object
        public void DisplayCarStation()
        {
            Console.WriteLine($"Route Number: {RouteNumber}");
            Console.WriteLine($"Company: {Company}");
            Console.WriteLine($"Arrival Time: {ArrivalTime}");
            Console.WriteLine($"Departure Time: {DepartureTime}");
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"Transport Type: {TransportType}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine();
        }
    }
}
