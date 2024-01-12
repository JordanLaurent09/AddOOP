namespace Theme35_Lesson1_EntranceToLINQ
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(int id, string name, string description, double price, int quantity)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
        }
    }
}
