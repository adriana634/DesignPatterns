using System.Globalization;

namespace DesignPatterns.Structural.Composite
{
    public class Box : IOrderItem
    {
        private string guid;
        private List<IOrderItem> items;
        private readonly BoxSize size;
        private readonly decimal packagingCost;

        public Box(BoxSize size, decimal packagingCost)
        {
            this.guid = Guid.NewGuid().ToString();
            this.items = new List<IOrderItem>();
            this.size = size;
            this.packagingCost = packagingCost;
        }

        public void AddItem(IOrderItem item)
        {
            items.Add(item);
        }

        public decimal CalcPrice()
        {
            decimal totalItemsPrice = items.Sum(item => item.CalcPrice());
            decimal totalItemsPricePlusPackagingCost = totalItemsPrice + packagingCost;

            Console.WriteLine($"Box {guid} [{size.ToString().ToUpperInvariant()}] totalPrice: {totalItemsPricePlusPackagingCost.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");

            return totalItemsPricePlusPackagingCost;
        }
    }
}
