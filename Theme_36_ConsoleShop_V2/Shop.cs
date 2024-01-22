namespace Theme_36_ConsoleShop_V2
{
    public class Shop
    {
        public List<Product> Goods { get; set; }

        public List<DateTime> Holidays { get; }

        public List<string> PurchaseLog { get; set; } = new List<string>();
        public Shop()
        {
            Goods = new List<Product>()
            {
                new CPU(1,"Processor", 23450m),
                new Motherboard(2, "Motherboard", 12350m),
                new PowerSupply(3, "PowerSupply", 5450m),
                new Videocard(4, "Videocard", 20000m),
                new Case(5, "Case", 11000m),
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

            Client client;
            if (IsLucky() == true)
            {
                Console.WriteLine("Ура! И у нас - победитель!");

                client = new LuckyClient(name, age, balance);
            }
            else
            {
                client = new Client(name, age, balance);
            }

            Console.WriteLine($"Привет, {client.Name}!\nВаш баланс: {client.Balance}\nВы совершили покупок на сумму: {client.WastedMoney}");

            ShopOptions(products, client);

            WriteToFile(PurchaseLog);
        }

        /// <summary>
        /// Главное меню магазина
        /// </summary>
        /// <param name="products"></param>
        /// <param name="client"></param>
        private void ShopOptions(List<Product> products, Client client)
        {
            while (true)
            {
                Console.WriteLine("Чего изволите?\n1.Посмотреть товары и закупиться - [1]\n2.Покинуть магазин - [2]");
                string option = Console.ReadLine()!;

                switch (option)
                {
                    case "1":
                        ProductMenu(products, client);
                        break;
                    case "2":
                        Console.WriteLine("До свидания, до новых встреч!");
                        return;
                }
            }
        }


        /// <summary>
        /// Вывод информации о товарах с учетом скидок и совершение покупок
        /// </summary>
        /// <param name="goods"></param>
        /// <param name="client"></param>
        private void ProductMenu(List<Product> goods, Client client)
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

            
 
            if(client.Balance - wastedValue < 0)
            {
                Console.WriteLine("У Вас не хватает баланса для совершения данной покупки!");
                return;
            }

            client.WastedMoney += wastedValue;

            client.Balance -= wastedValue;

            Console.WriteLine($"Вы успешно купили {product.Title} в количестве {amount} единиц, потратив {wastedValue} рублей.");

            string info = $"Покупатель {client.Name} приобрел {product.Title} в количестве {amount} единиц, потратив {wastedValue} рублей.";

            PurchaseLog.Add(info);

            Console.WriteLine("Спасибо за покупку!");
          
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
        /// Акция по увеличению баланса(устраревший метод)
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

        /// <summary>
        /// Проверка на счастливого пользователя
        /// </summary>
        /// <returns></returns>
        private bool IsLucky()
        {
            bool isLucky = false;

            Random random = new Random();

            int number = random.Next(1, 4);

            Console.WriteLine("Попробуйте угадать число от 1 до 3");

            int guessNumber = int.Parse(Console.ReadLine()!);

            if (guessNumber == number) isLucky = true;

            return isLucky;
        }

        /// <summary>
        /// Запись в файл информации о покупках
        /// </summary>
        /// <param name="info"></param>
        public void WriteToFile(List<string> info)
        {
            File.AppendAllLines("buysInfo.txt", info);
        }
    }
}
