namespace PWC7
{
    class Program
    {
        static void Main()
        {
            CarStation station = new CarStation();

            // exception block
            try
            {
                Console.Write("Enter Route Number (number): ");
                station.RouteNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter Company: ");
                station.Company = Console.ReadLine();

                station.ArrivalTime = DateTime.Now;

                station.DepartureTime = DateTime.Now.AddHours(2);

                Console.Write("Enter Destination: ");
                station.Destination = Console.ReadLine();

                Console.Write("Enter Transport Type: ");
                station.TransportType = Console.ReadLine();

                Console.Write("Enter Price (decimal number): ");
                station.Price = decimal.Parse(Console.ReadLine());

                Console.WriteLine();

                station.DisplayCarStation();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter a valid value.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Input value is too large or too small.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}