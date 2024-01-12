namespace Theme35_Lesson1_EntranceToLINQ
{
    // интерфейс IEnumerable
    // 1. Where(p => p.property) Выборка данных по условию

    // DB-Style: FROM item IN items
    //           WHERE item_condition
    //           SELECT item

    // LINQ-запросы - отложенные и выполняются только при обращении к коллекции(например, с помощью foreach)
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product(0, "Apple", "Red delicious", 1.50, 10),
                new Product(1, "Banana", "Yellow delicious", 1.20, 13),
                new Product(2, "Lollipop", "Lollipop-lollipop", 1.40, 20),
                new Product(3, "Lemon", "Yellow delicates", 1.70, 21),
                new Product(4, "Orange", "Orange pleasure", 2.50, 22)
            };

            // Выборка данных по условию в лямбда-выражении
            //IEnumerable<Product> items = products.Where(p => p.Price < 2.0);

            //foreach(Product item in items)
            //{
            //    Console.WriteLine(item.Name);
            //}

            // Запрос на LINQ
            IEnumerable<string> result = from good in products
                                         where good.Price < 2.0
                                         select good.Name;

            // Запрос на LINQ методах расширения
            IEnumerable<string> extensionMethodsResult = products.Where(good => good.Price < 2.0).Select(good => good.Name);
            
        }
    }
}