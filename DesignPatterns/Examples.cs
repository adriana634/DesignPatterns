using DesignPatterns.Behavioral.Strategy;

namespace DesignPatterns
{
    public static class Examples
    {
        public static void StrategyPattern()
        {
            var shipment = new Shipment();

            shipment.SetStrategy(new AirFreight());
            shipment.Ship("Hong Kong", "Spain");

            shipment.SetStrategy(new RailFreight());
            shipment.Ship("USA", "Canada");

            shipment.SetStrategy(new SeaFreight());
            shipment.Ship("Spain", "UK");

            shipment.SetStrategy(new RoadFreight());
            shipment.Ship("Portugal", "Spain");
        }
    }
}
