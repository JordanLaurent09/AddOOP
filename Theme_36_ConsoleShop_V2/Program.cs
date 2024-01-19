namespace Theme_36_ConsoleShop_V2
{
    public class Program
    {
        private static List<DateTime> holidays = new List<DateTime>()
        {
            new DateTime(DateTime.Now.Year, 1, 7),
            new DateTime(DateTime.Now.Year, 2, 14),
            new DateTime(DateTime.Now.Year, 3, 8),
            new DateTime(DateTime.Now.Year, 4, 26),
            new DateTime(DateTime.Now.Year, 5, 9),
            new DateTime(DateTime.Now.Year, 6, 19),
            new DateTime(DateTime.Now.Year, 7, 1),
            new DateTime(DateTime.Now.Year, 8, 9),
            new DateTime(DateTime.Now.Year, 9, 1),
            new DateTime(DateTime.Now.Year, 10, 30),
            new DateTime(DateTime.Now.Year, 11, 30),
            new DateTime(DateTime.Now.Year, 12, 31)
        };


        static void Main(string[] args)
        {

            Client client = Start();

            List<Product> products = CreateProductList();

            ClientPrivateMenu(client, products);

        }

        public static List<Product> CreateProductList()
        {
            List<Product> merchandise = new List<Product>()
            {
                new Motherboard("Материнская плата", 6000m),
                new CPU("Процессор", 2500m),
                new Videocard("Видеокарта", 20000m)
            };

            return merchandise;
        }

        public static void ShowMenu(List<Product> goods, decimal balance)
        {
            foreach (Product good in goods)
            {
                
                if (balance < 10000m)
                {
                    if (good.Name == "Блок")
                    {
                        decimal eternalPrice = good.Price / 2; 
                        Console.WriteLine($"Товар {good.Name} всегда стоит {eternalPrice}");
                    }
                    else
                    {
                        if (IsHoliday() == true)
                        {
                            Console.WriteLine($"В праздничный день товар {good.Name} стоит {good.Price * 0.8m}");
                        }
                        else
                        {
                            Console.WriteLine($"Без учета скидки товар {good.Name} стоит {good.Price}");
                        }
                    }
                }
                if (balance >= 10000m && balance <= 50000m)
                {
                    if (good.Name == "Блок")
                    {
                        decimal eternalPrice = good.Price / 2;
                        Console.WriteLine($"Товар {good.Name} всегда стоит {eternalPrice}");
                    }

                    else
                    {
                        if (IsHoliday() == true)
                        {

                            decimal newPrice = good.Price - ((good.Price * 5) / 100);

                            Console.WriteLine($"С учетом скидки 5% товар {good.Name} стоит {newPrice}");
                        }
                    }
                }
                if (balance > 50000m)
                {
                    if (good.Name == "Блок")
                    {
                        decimal eternalPrice = good.Price / 2;
                        Console.WriteLine($"Товар {good.Name} всегда стоит {eternalPrice}");
                    }
                    else
                    {
                        decimal newPrice = good.Price - ((good.Price * 10) / 100);

                        Console.WriteLine($"С учетом скидки 10% товар {good.Name} стоит {newPrice}");
                    }
                }
            }
        }

        public static Client Start()
        {
            Console.WriteLine("Введите имя:");
            string username = Console.ReadLine()!;
            Console.WriteLine("Введите возраст:");
            int age = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Введите свой баланс");
            decimal userBalance = decimal.Parse(Console.ReadLine()!);
            Client client = new Client(username, age, userBalance);

            return client;
        }

        public static void ClientPrivateMenu(Client client, List<Product> goods)
        {
            while (true)
            {
                Console.WriteLine($"Добрый день,{client.Name}");
                Console.WriteLine($"Ваш баланс: {client.Balance}");
                Console.WriteLine("Гляньте, что у нас есть!");

                ShowMenu(goods, client.Balance);

                Console.WriteLine("Что хотите купить? Введите название товара:");

                string chosenGood = Console.ReadLine()!;

                Console.WriteLine("Введите, сколько хотите товаров купить:");

                int totalAmount = int.Parse(Console.ReadLine()!);

                client.BuyProduct(goods, chosenGood, totalAmount);
            }

        }

        public static bool IsHoliday()
        {
            bool isHoliday = false;

            if (holidays.Contains(DateTime.Today))
            {
                isHoliday = true;
            }
            //foreach(DateTime day in holidays)
            //{
            //    if(day == DateTime.Today)
            //    {
            //        isHoliday = true;
            //    }
            //}
            return isHoliday;
        }
    }
}