namespace PWC3
{
    public class CarStation
    {
        // Private fields
        private int routeNumber;

        private string company;

        private DateTime arrivalTime;

        private DateTime departureTime;

        private string destination;

        private string transportType;

        private decimal price;

        // Default constructor
        public CarStation()
        {
            // Set default or standard values
            routeNumber = 0;
            company = string.Empty;
            arrivalTime = DateTime.MinValue;
            departureTime = DateTime.MinValue;
            destination = string.Empty;
            transportType = string.Empty;
            price = 0;
        }

        // Copy constructor
        public CarStation(CarStation other)
        {
            routeNumber = other.routeNumber;
            company = other.company;
            arrivalTime = other.arrivalTime;
            departureTime = other.departureTime;
            destination = other.destination;
            transportType = other.transportType;
            price = other.price;
        }

        // Constructor with all parameters
        public CarStation(int routeNumber, string company, DateTime arrivalTime, DateTime departureTime,
                          string destination, string transportType, decimal price)
        {
            this.routeNumber = routeNumber;
            this.company = company;
            this.arrivalTime = arrivalTime;
            this.departureTime = departureTime;
            this.destination = destination;
            this.transportType = transportType;
            this.price = price;
        }

        // Constructor with selected parameters
        public CarStation(int routeNumber, string company, string destination, string transportType)
        {
            this.routeNumber = routeNumber;
            this.company = company;
            this.destination = destination;
            this.transportType = transportType;

            // Set default or standard values for other fields
            arrivalTime = DateTime.MinValue;
            departureTime = DateTime.MinValue;
            price = 0;
        }

        // Properties (getters and setters)
        public int RouteNumber
        {
            get { return routeNumber; }
            set { routeNumber = value; }
        }

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public DateTime ArrivalTime
        {
            get { return arrivalTime; }
            set { arrivalTime = value; }
        }

        public DateTime DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public string TransportType
        {
            get { return transportType; }
            set { transportType = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        // Display all fields of the class object
        public void DisplayCarStation()
        {
            Console.WriteLine($"Route Number: {routeNumber}");
            Console.WriteLine($"Company: {company}");
            Console.WriteLine($"Arrival Time: {arrivalTime}");
            Console.WriteLine($"Departure Time: {departureTime}");
            Console.WriteLine($"Destination: {destination}");
            Console.WriteLine($"Transport Type: {transportType}");
            Console.WriteLine($"Price: {price}");
        }

        // Method to calculate a new value of fields (example: price conversion)
        public void ConvertPrice(decimal exchangeRate)
        {
            price *= exchangeRate;
        }
    }
}
