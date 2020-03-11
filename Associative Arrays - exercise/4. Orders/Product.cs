namespace _4._Orders
{
    public class Product
    {
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{Name} -> {Price * Quantity:F2}";
        }
    }
}
