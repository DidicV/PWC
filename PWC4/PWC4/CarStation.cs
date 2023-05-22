namespace PWC4
{
    public class CarStation
    {
        // proprieties
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

        //calculate a new value of fields (example: price conversion)
        public void ConvertPrice(decimal exchangeRate)
        {
            Price *= exchangeRate;
        }

        public static bool operator ==(CarStation car1, CarStation car2)
        {
            if (ReferenceEquals(car1, car2))
                return true;

            if (ReferenceEquals(car1, null) || ReferenceEquals(car2, null))
                return false;

            return car1.RouteNumber == car2.RouteNumber &&
                   car1.Company == car2.Company &&
                   car1.ArrivalTime == car2.ArrivalTime &&
                   car1.DepartureTime == car2.DepartureTime &&
                   car1.Destination == car2.Destination &&
                   car1.TransportType == car2.TransportType &&
                   car1.Price == car2.Price;
        }

        public static bool operator !=(CarStation car1, CarStation car2)
        {
            return !(car1 == car2);
        }

        // Overload the '&' operator to combine two CarStation objects
        public static CarStation operator &(CarStation car1, CarStation car2)
        {
            CarStation combinedStation = new CarStation();
            combinedStation.RouteNumber = car1.RouteNumber;
            combinedStation.Company = $"{car1.Company} & {car2.Company}";
            combinedStation.ArrivalTime = car1.ArrivalTime < car2.ArrivalTime ? car1.ArrivalTime : car2.ArrivalTime;
            combinedStation.DepartureTime = car1.DepartureTime > car2.DepartureTime ? car1.DepartureTime : car2.DepartureTime;
            combinedStation.Destination = $"{car1.Destination} & {car2.Destination}";
            combinedStation.TransportType = $"{car1.TransportType} & {car2.TransportType}";
            combinedStation.Price = car1.Price + car2.Price;

            return combinedStation;
        }

        // Overload the '+' operator to add a value to the Price property of a CarStation object
        public static CarStation operator +(CarStation car, decimal value)
        {
            CarStation updatedStation = new CarStation();
            updatedStation.RouteNumber = car.RouteNumber;
            updatedStation.Company = car.Company;
            updatedStation.ArrivalTime = car.ArrivalTime;
            updatedStation.DepartureTime = car.DepartureTime;
            updatedStation.Destination = car.Destination;
            updatedStation.TransportType = car.TransportType;
            updatedStation.Price = car.Price + value;

            return updatedStation;
        }

        // Indexer
        public object this[string propertyName]
        {
            get
            {
                var property = GetType().GetProperty(propertyName);
                return property?.GetValue(this);
            }
            set
            {
                var property = GetType().GetProperty(propertyName);
                property?.SetValue(this, value);
            }
        }
    }
}
