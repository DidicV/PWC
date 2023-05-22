namespace PWC4
{
    class Program
    {
        static void Main()
        {
            // object creation
            CarStation car1 = new CarStation();
            car1.RouteNumber = 1;
            car1.Company = "Panda Tour";
            car1.ArrivalTime = DateTime.Now;
            car1.DepartureTime = DateTime.Now.AddHours(1);
            car1.Destination = "Berlin";
            car1.TransportType = "Minibus";
            car1.Price = 10.5m;

            CarStation car2 = new CarStation();
            car2.RouteNumber = 1;
            car2.Company = "Fast Tour";
            car2.ArrivalTime = DateTime.Now;
            car2.DepartureTime = DateTime.Now.AddHours(1);
            car2.Destination = "Paris";
            car2.TransportType = "Minibus";
            car2.Price = 10.5m;


            Console.WriteLine("\nOVERLOADING == and !=");
            Console.WriteLine("------------------------------------------");

            bool areEqual = car1 == car2;  // true
            bool areNotEqual = car1 != car2;  // false

            Console.WriteLine(" == " + areEqual);
            Console.WriteLine(" != " + areNotEqual);


            Console.WriteLine("\n\nOVERLOADING & and +");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("&");

            CarStation combinedStation = car1 & car2;
            combinedStation.DisplayCarStation();


            Console.WriteLine("------------------------------------------");
            Console.WriteLine("+");
            // change price with overloading +
            CarStation updatedStation = car1 + 5.25m;
            updatedStation.DisplayCarStation();



            Console.WriteLine("\n\nOVERLOADING index");
            Console.WriteLine("------------------------------------------");
            car1["RouteNumber"] = 123;
            car1["Company"] = "Transport Lux";
            car1["ArrivalTime"] = DateTime.Now;
            car1["DepartureTime"] = DateTime.Now.AddHours(1);
            car1["Destination"] = "City Falls";
            car1["TransportType"] = "Bus";
            car1["Price"] = 10.5m;
            car1.DisplayCarStation();



            Console.WriteLine("\nConvert CarStation to CarStationV2");
            Console.WriteLine("------------------------------------------");
            // converting object from one class to another class
            CarStationV2 carStationV2 = new CarStationV2(car1);
            carStationV2.DisplayCarStation();



            Console.WriteLine("\nConvert CarStation to primitive types");
            Console.WriteLine("------------------------------------------");
            // converting object to primitive types
            int routeNumber = car1.RouteNumber;
            string company = car1.Company;
            DateTime arrivalTime = car1.ArrivalTime;
            DateTime departureTime = car1.DepartureTime;
            string destination = car1.Destination;
            string transportType = car1.TransportType;
            decimal price = car1.Price;

            Console.WriteLine($"Route Number: {routeNumber}");
            Console.WriteLine($"Company: {company}");
            Console.WriteLine($"Arrival Time: {arrivalTime}");
            Console.WriteLine($"Departure Time: {departureTime}");
            Console.WriteLine($"Destination: {destination}");
            Console.WriteLine($"Transport Type: {transportType}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine();
        }
    }
}
