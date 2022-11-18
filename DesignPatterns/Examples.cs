using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Structural.Composite;
using System.Globalization;

namespace DesignPatterns
{
    public static class Examples
    {
        public static void StrategyPattern()
        {
            Shipment shipment = new();

            shipment.SetStrategy(new AirFreight());
            shipment.Ship("Hong Kong", "Spain");

            shipment.SetStrategy(new RailFreight());
            shipment.Ship("USA", "Canada");

            shipment.SetStrategy(new SeaFreight());
            shipment.Ship("Spain", "UK");

            shipment.SetStrategy(new RoadFreight());
            shipment.Ship("Portugal", "Spain");
        }

        public static void CompositePattern()
        {
            Box package = new(BoxSize.Big, 35.8m);

            Box hammerBox = new(BoxSize.Small, 2.5m);
            hammerBox.AddItem(new Product("Hammer", 12.7m));
            package.AddItem(hammerBox);

            Box middleBox = new(BoxSize.Middle, 8m);

            Box phoneHeadphonesBox = new(BoxSize.Small, 2.5m);
            phoneHeadphonesBox.AddItem(new Product("Phone", 1000m));
            phoneHeadphonesBox.AddItem(new Product("Headphones", 100m));

            Box chargerBox = new(BoxSize.Small, 2.5m);
            chargerBox.AddItem(new Product("Charger", 30m));

            middleBox.AddItem(phoneHeadphonesBox);
            middleBox.AddItem(chargerBox);
            package.AddItem(middleBox);

            decimal totalOrderPrice = package.CalcPrice();
            Console.WriteLine($"Total Order Price: {totalOrderPrice.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
        }
    }
}
