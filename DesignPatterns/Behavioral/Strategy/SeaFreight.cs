namespace DesignPatterns.Behavioral.Strategy
{
    public class SeaFreight : IShippingStrategy
    {
        public void Ship(string reference, string origin, string destination)
        {
            Console.WriteLine($"Shipping ({reference}) from {origin} to {destination} via Sea freight");
        }
    }
}
