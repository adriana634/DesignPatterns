namespace DesignPatterns.Behavioral.Strategy
{
    public class RailFreight : IShippingStrategy
    {
        public void Ship(string reference, string origin, string destination)
        {
            Console.WriteLine($"Shipping ({reference}) from {origin} to {destination} via Rail freight");
        }
    }
}
