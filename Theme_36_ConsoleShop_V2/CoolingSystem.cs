namespace Theme_36_ConsoleShop_V2
{
    public class CoolingSystem : Product
    {
        public CoolingSystem(int id, string title, decimal price) : base(id, title, price)
        {
        }

        public override decimal GetDiscount(Client client)
        {
            decimal discount = 0m;

            if (client.Age > 30)
            {
                discount += Price / 4m;
            }

            if (client.WastedMoney >= 10000m && client.WastedMoney < 50000m)
            {
                discount += Price / 20m;
            }
            else if (client.WastedMoney >= 50000m)
            {
                discount += Price / 10m;
            }

            return discount;
        }


    }
}
