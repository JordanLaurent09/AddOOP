namespace Theme_36_ConsoleShop
{
    public class Client
    {
        public string Name { get; set; }

        public decimal Balance { get; set; }


        public Client(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
        }


        public void BuyProduct(List<Product> merchandise, string productName, int amount)
        {
            bool isBought = false;
            foreach (Product product in merchandise)
            {
                if (product.Name == productName && Balance < 10000m)
                {
                    Console.WriteLine($"Вы купили {productName} в количестве {amount} за сумму {amount * product.Price}");
                    Balance -= amount * product.Price;
                    isBought = true;
                }
                else if (product.Name == productName && Balance > 10000m && Balance < 50000m)
                {
                    decimal newPrice = product.Price - ((product.Price * 5) / 100);
                    Console.WriteLine($"Вы купили {productName} в количестве {amount} за сумму {amount * newPrice} при скидке 5%");
                    Balance -= amount * newPrice;
                    isBought = true;
                }
                else if (product.Name == productName && Balance >= 50000m)
                {
                    decimal newPrice = product.Price - ((product.Price * 10) / 100);
                    Console.WriteLine($"Вы купили {productName} в количестве {amount} за сумму {amount * newPrice} при скидке 10%");
                    Balance -= amount * newPrice;
                    isBought = true;
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
