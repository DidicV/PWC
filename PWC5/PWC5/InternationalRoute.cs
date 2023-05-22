namespace PWC5
{
    public class InternationalRoute : CarStation
    {
        public string CountryDestination { get; set; } = string.Empty;
        public string CountryDestinationCurrency { get; set; } = string.Empty;

        // Display all fields of the derived class object
        public override void DisplayCarStation()
        {
            base.DisplayCarStation();
            Console.WriteLine($"Country Destination: {CountryDestination}");
            Console.WriteLine($"Country Destination Currency: {CountryDestinationCurrency}");
            Console.WriteLine();
        }
    }
}
