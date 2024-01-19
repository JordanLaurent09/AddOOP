namespace Theme_36_ConsoleShop_V2
{
    public class Client
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public decimal Balance { get; set; }

        public decimal WastedMoney { get; set; }


        public DateTime BuyDate { get; set;}

        public Client(string name, int age, decimal balance)
        {
            Name = name;
            Age = age;
            Balance = balance;
            WastedMoney = 0m;
            BuyDate = DateTime.Now;
        }


        public void BuyProduct(List<Product> merchandise, string productName, int amount)
        {
            bool isBought = false;
            foreach (Product product in merchandise)
            {
                if (product.Name == productName && Balance < 10000m && product.Name != "Блок")
                {
                    Console.WriteLine($"Вы купили {productName} в количестве {amount} за сумму {amount * product.Price}");
                    Balance -= amount * product.Price;
                    isBought = true;
                }
                else if (product.Name == productName && Balance > 10000m && Balance < 50000m && product.Name != "Блок")
                {
                    decimal newPrice = product.Price - ((product.Price * 5) / 100);
                    Console.WriteLine($"Вы купили {productName} в количестве {amount} за сумму {amount * newPrice} при скидке 5%");
                    Balance -= amount * newPrice;
                    isBought = true;
                }
                else if (product.Name == productName && Balance >= 50000m && product.Name != "Блок")
                {
                    decimal newPrice = product.Price - ((product.Price * 10) / 100);
                    Console.WriteLine($"Вы купили {productName} в количестве {amount} за сумму {amount * newPrice} при скидке 10%");
                    Balance -= amount * newPrice;
                    isBought = true;
                }
                else if (productName == "Блок")
                {
                    Console.WriteLine($"Вы купили {productName} в количестве {amount} за сумму {product.Price / 2}");
                }
            }

            if (isBought == false)
            {
                Console.WriteLine("Такого товара нет!");
            }
        }

        private void WriteInfoToFile(string info)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\goods.txt";

            File.AppendAllText(path, info);
        } 
    }
}
