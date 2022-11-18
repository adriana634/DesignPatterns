using System.Globalization;

namespace DesignPatterns.Structural.Composite
{
    public class Product : IOrderItem
    {
        private readonly string description;
        private readonly decimal price;

        public Product(string description, decimal price)
        {
            this.description = description;
            this.price = price;
        }

        public decimal CalcPrice()
        {
            Console.WriteLine($"{description} price: {price.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
            return price;
        }
    }
}
