using System.Collections;

namespace PWC9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create 5 objects
            CarStation carStation1 = new CarStation()
            {
                RouteNumber = 1,
                Company = "Company A",
                ArrivalTime = DateTime.Now.AddHours(1),
                DepartureTime = DateTime.Now.AddHours(2),
                Destination = "Destination X",
                TransportType = "Bus",
                Price = 10.5m
            };

            CarStation carStation2 = new CarStation()
            {
                RouteNumber = 2,
                Company = "Company B",
                ArrivalTime = DateTime.Now.AddHours(2),
                DepartureTime = DateTime.Now.AddHours(3),
                Destination = "Destination Y",
                TransportType = "Train",
                Price = 20.5m
            };

            CarStation carStation3 = new CarStation()
            {
                RouteNumber = 3,
                Company = "Company C",
                ArrivalTime = DateTime.Now.AddHours(3),
                DepartureTime = DateTime.Now.AddHours(4),
                Destination = "Destination Z",
                TransportType = "Bus",
                Price = 15.5m
            };

            CarStation carStation4 = new CarStation()
            {
                RouteNumber = 4,
                Company = "Company D",
                ArrivalTime = DateTime.Now.AddHours(4),
                DepartureTime = DateTime.Now.AddHours(5),
                Destination = "Destination X",
                TransportType = "Train",
                Price = 25.5m
            };

            CarStation carStation5 = new CarStation()
            {
                RouteNumber = 5,
                Company = "Company E",
                ArrivalTime = DateTime.Now.AddHours(5),
                DepartureTime = DateTime.Now.AddHours(6),
                Destination = "Destination Y",
                TransportType = "Bus",
                Price = 12.5m
            };

            // create a List<CarStation> and add 5 objects
            List<CarStation> carStationList = new List<CarStation>();
            carStationList.Add(carStation3);
            carStationList.Add(carStation1);
            carStationList.Add(carStation5);
            carStationList.Add(carStation2);
            carStationList.Add(carStation4);

            Console.WriteLine("Objects in List<CarStation> (unsorted)");
            Console.WriteLine("--------------------------------------");
            DisplayCarStations(carStationList);

            // Sort List<CarStation> by RouteNumber
            carStationList.Sort((x, y) => x.RouteNumber.CompareTo(y.RouteNumber));

            Console.WriteLine("\n\nObjects in List<CarStation> (sorted by RouteNumber):");
            Console.WriteLine("--------------------------------------");
            DisplayCarStations(carStationList);

            // Create an ArrayList and add objects
            ArrayList carStationArrayList = new ArrayList
            {
                carStation1,
                carStation2,
                carStation3,
                carStation4,
                carStation5
            };

            Console.WriteLine("\n\nObjects in ArrayList:");
            Console.WriteLine("--------------------------------------");
            DisplayCarStations(carStationArrayList);

            // Create a LinkedList<CarStation> and add objects
            LinkedList<CarStation> carStationLinkedList = new LinkedList<CarStation>();
            carStationLinkedList.AddLast(carStation5);
            carStationLinkedList.AddLast(carStation2);
            carStationLinkedList.AddLast(carStation4);
            carStationLinkedList.AddLast(carStation1);
            carStationLinkedList.AddLast(carStation3);

            Console.WriteLine("\n\nObjects in LinkedList<CarStation>:");
            Console.WriteLine("--------------------------------------");
            DisplayCarStations(carStationLinkedList);

            // Create a dictionary of type Dictionary<int, CarStation> and add objects
            Dictionary<int, CarStation> carStationDictionary = new Dictionary<int, CarStation>
            {
                { 1, carStation1 },
                { 2, carStation2 },
                { 3, carStation3 },
                { 4, carStation4 },
                { 5, carStation5 }
            };


            Console.WriteLine("\n\nObjects in Dictionary<int, CarStation>:");
            Console.WriteLine("--------------------------------------");

            DisplayCarStations(carStationDictionary);

            foreach (KeyValuePair<int, CarStation> carStation in carStationDictionary)
            {
                var key = carStation.Key;
                var value = carStation.Value;

                Console.WriteLine(key);
                value.DisplayCarStation();
            }

            Console.ReadLine();
        }

        // Display CarStation objects in a collection
        public static void DisplayCarStations(IEnumerable carStations)
        {
            foreach (var carStation in carStations)
            {
                if (carStation is CarStation)
                {
                    var cs = (CarStation)carStation;
                    cs.DisplayCarStation();
                }
            }
        }
    }
}