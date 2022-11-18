namespace DesignPatterns.Behavioral.Strategy
{
    public interface IShippingStrategy
    {
        void Ship(string reference, string origin, string destination);
    }
}
