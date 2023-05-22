namespace PWC8
{
    public class CarStation
    {
        public int RouteNumber { get; set; }
        public string Company { get; set; } = string.Empty;
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public string Destination { get; set; } = string.Empty;
        public string TransportType { get; set; } = string.Empty;
        public decimal Price { get; set; }

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
