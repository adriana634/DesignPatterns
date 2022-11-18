namespace DesignPatterns.Behavioral.Strategy
{
    public class Shipment
    {
        private IShippingStrategy? strategy;

        public Shipment() {}

        public Shipment(IShippingStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(IShippingStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Ship(string origin, string destination)
        {
            if (strategy is null)
            {
                throw new InvalidOperationException("Shipping strategy is required");
            }

            var reference = Guid.NewGuid().ToString();
            strategy.Ship(reference, origin, destination);
        }
    }
}
