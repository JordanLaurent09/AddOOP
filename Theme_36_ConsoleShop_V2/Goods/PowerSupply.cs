namespace Theme_36_ConsoleShop_V2
{
    public class PowerSupply:Product
    {
        public PowerSupply(int id, string title, decimal price) : base(id, title, price)
        {
        }

        public override decimal GetDiscount(Client client)
        {
            decimal discount = 0m;

            discount += Price / 2;

            return discount;
        }
    }
}
