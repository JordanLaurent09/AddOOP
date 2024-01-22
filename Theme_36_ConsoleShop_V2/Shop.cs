namespace Theme_36_ConsoleShop_V2
{
    public class Shop
    {
        //Сеттер списка товаров - приватный
        public List<Product> Goods { get; set; }

        public List<DateTime> Holidays { get; }
        public Shop()
        {
            Goods = new List<Product>()
            {
                new CPU(1,"Processor", 23450m),
                new Motherboard(2, "Motherboard", 12350m),
                new PowerSupply(3, "PowerSupply", 5450m),
                new Videocard(4, "Videocard", 20000m),
                new Corpus(5, "Corpus", 11000m),
                new CoolingSystem(6, "CoolingSystem", 15500m)
            };

            Holidays = new List<DateTime>()
            {
                new DateTime(DateTime.Now.Year, 1, 7),
                new DateTime(DateTime.Now.Year, 2, 14),
                new DateTime(DateTime.Now.Year, 3, 8),
                new DateTime(DateTime.Now.Year, 4, 26),
                new DateTime(DateTime.Now.Year, 5, 9),
                new DateTime(DateTime.Now.Year, 6, 19),
                new DateTime(DateTime.Now.Year, 7, 1),
                new DateTime(DateTime.Now.Year, 8, 9),
                new DateTime(DateTime.Now.Year, 10, 30),
                new DateTime(DateTime.Now.Year, 11, 30),
                new DateTime(DateTime.Now.Year, 12, 31)
            };
        }


        /// <summary>
        /// Запуск магазина
        /// </summary>
        /// <param name="products"></param>
        public void Start(List<Product> products)
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine()!;
            Console.WriteLine("Введите возраст:");
            int age = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Введите баланс:");
            decimal balance = decimal.Parse(Console.ReadLine()!);

            Client client = new Client(name, age, balance);

            SpecialGift(client);

            Console.WriteLine($"Hello, {client.Name}");

            ProductMenu(products, client);
        }

        /// <summary>
        /// Вывод информации о товарах с учетом скидок и совершение покупок
        /// </summary>
        /// <param name="goods"></param>
        /// <param name="client"></param>
        private void ProductMenu(List<Product> goods, Client client)
        {
            while (true)
            {
                Console.WriteLine($"Ваш текущий баланс: {client.Balance}");
                foreach (Product item in goods)
                {
                    decimal salePrice = 0m;
                    decimal sale = item.GetDiscount(client);
                    if (item is not PowerSupply)
                    {
                        decimal holidaySale = HolidaySale(item.Price);
                        salePrice = item.Price - sale - holidaySale;
                    }
                    else
                    {
                        salePrice = item.Price - sale;
                    }                   
                    Console.WriteLine($"[{item.Id}] Название товара: {item.Title} Цена товара:{salePrice}");
                }


                Console.WriteLine("Введите номер товара:");
                int index = int.Parse(Console.ReadLine()!);

                Product product = goods[index - 1];

                decimal newPrice = 0m;
                decimal discount = product.GetDiscount(client);
                if (product is not PowerSupply)
                {
                    decimal holidaySale = HolidaySale(product.Price);
                    newPrice = product.Price - discount - holidaySale;
                }
                else 
                {
                    newPrice = product.Price - discount;
                }
                
                Console.WriteLine("Введите количество товара для покупки:");
                int amount = int.Parse(Console.ReadLine()!);

                decimal wastedValue = amount * newPrice;

                client.WastedMoney += wastedValue;

                client.Balance -= wastedValue;
            }
        }

        /// <summary>
        /// Скидка от магазина по выходным
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        private decimal HolidaySale(decimal price)
        {
            decimal discount = 0m;
            if (Holidays.Contains(DateTime.Now.Date))
            {
                discount += price / 5m;
            }
            return discount;
        }

        /// <summary>
        /// Акция по увеличению баланса
        /// </summary>
        /// <param name="client"></param>
        private void SpecialGift(Client client)
        {
            Random random = new Random();

            int number = random.Next(1, 4);

            Console.WriteLine("Попробуйте угадать число от 1 до 3");

            int guessNumber = int.Parse(Console.ReadLine()!);

            if (guessNumber == number)
            {
                Console.WriteLine("Ура! Ваш баланс удвоился!");
                client.Balance *= 2;
            }
        }
    }
}
