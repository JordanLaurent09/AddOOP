namespace Theme_36_ConsoleShop_V2
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string title, decimal price)
        {
            Id = id;
            Title = title;
            Price = price;
        }


        public virtual decimal GetDiscount(Client client)
        {
            decimal discount = 0m;
            
            if (client.WastedMoney >= 50000m)
            {
                discount += Price / 10m;
            }
            else if (client.WastedMoney >= 10000m)
            {
                discount += Price / 20m;
            }

            return discount;
        }
    }
}
