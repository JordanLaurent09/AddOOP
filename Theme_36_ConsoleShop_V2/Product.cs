namespace Theme_36_ConsoleShop_V2
{
    public class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public decimal GetDiscount(Client client)
        {
            decimal discount = 0m;
            if(client.WastedMoney > 10000m && client.WastedMoney < 50000m)
            {
                discount += (Price / 100) * 5;
            }
            if(client.WastedMoney > 50000m)
            {
                discount += (Price / 100) * 10;
            }

            return discount;
        }
    }
}
