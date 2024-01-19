namespace Theme_36_ConsoleShop
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            
            Client client = Start();

            List<Product> products = CreateProductList();

            ClientPrivateMenu(client, products);

        }

        public static List<Product> CreateProductList()
        {
            List<Product>merchandise = new List<Product>()
            {
                new Motherboard("Материнская плата", 6000m),
                new CPU("Процессор", 2500m),
                new Videocard("Видеокарта", 20000m)
            };

            return merchandise;
        }

        public static void ShowMenu(List<Product> goods, decimal balance)
        {
            foreach(Product good in goods)
            {
                if(balance < 10000m)
                {
                    Console.WriteLine($"Без учета скидки товар {good.Name} стоит {good.Price}");
                }
                if(balance >= 10000m && balance <= 50000m)
                {
                    decimal newPrice = good.Price - ((good.Price * 5) / 100);

                    Console.WriteLine($"С учетом скидки 5% товар {good.Name} стоит {newPrice}");
                }
                if(balance > 50000m)
                {
                    decimal newPrice = good.Price - ((good.Price * 10) / 100);

                    Console.WriteLine($"С учетом скидки 10% товар {good.Name} стоит {newPrice}");
                }
            }
        }

        public static Client Start()
        {
            Console.WriteLine("Введите имя и баланс");
            string username = Console.ReadLine()!;
            decimal userBalance = decimal.Parse(Console.ReadLine()!);

            Client client = new Client(username, userBalance);

            return client;
        }

        public static void ClientPrivateMenu(Client client, List<Product> goods)
        {
            while (true)
            {
                Console.WriteLine("Гляньте, что у нас есть!");

                ShowMenu(goods, client.Balance);

                Console.WriteLine("Что хотите купить? Введите название товара:");

                string chosenGood = Console.ReadLine()!;

                Console.WriteLine("Введите, сколько хотите товаров купить:");

                int totalAmount = int.Parse(Console.ReadLine()!);

                client.BuyProduct(goods, chosenGood, totalAmount);
            }
            

        }

    }
}