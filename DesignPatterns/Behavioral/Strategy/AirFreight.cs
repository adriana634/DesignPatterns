namespace DesignPatterns.Behavioral.Strategy
{
    public class AirFreight : IShippingStrategy
    {
        public void Ship(string reference, string origin, string destination)
        {
            Console.WriteLine($"Shipping ({reference}) from {origin} to {destination} via Air freight");
        }
    }
}
