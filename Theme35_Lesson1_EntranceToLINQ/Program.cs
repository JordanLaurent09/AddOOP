using System.Runtime.CompilerServices;

namespace Theme35_Lesson1_EntranceToLINQ
{
    // интерфейс IEnumerable
    // 1. Where(p => p.property) Выборка данных по условию

    // 2. DB-Style: FROM item IN items
    //           WHERE(item_condition)
    //           SELECT(item);

    // LINQ-запросы - отложенные и выполняются только при обращении к коллекции(например, с помощью foreach)


    // 3. OfType<Тип>() - фильтрация по типу

    // 4. DB-Style: ключевой оператор orderby
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Product> products = new List<Product>()
            //{
            //    new Product(0, "Apple", "Red delicious", 1.50, 10),
            //    new Product(1, "Banana", "Yellow delicious", 1.20, 13),
            //    new Product(2, "Lollipop", "Lollipop-lollipop", 1.40, 20),
            //    new Product(3, "Lemon", "Yellow delicates", 1.70, 21),
            //    new Product(4, "Orange", "Orange pleasure", 2.50, 22)
            //};

            // Выборка данных по условию в лямбда-выражении
            //IEnumerable<Product> items = products.Where(p => p.Price < 2.0);

            //foreach(Product item in items)
            //{
            //    Console.WriteLine(item.Name);
            //}

            // Запрос на LINQ
            //IEnumerable<string> result = from good in products
            //                             where good.Price < 2.0
            //                             select good.Name;

            //// Запрос на LINQ методах расширения
            //IEnumerable<string> extensionMethodsResult = products.Where(good => good.Price < 2.0).Select(good => good.Name);



            // Практика

            //Product[] prods = new Product[]
            //{
            //    new Product(1, "LED-Телевизор", "Красота", 1200, 20),
            //    new Product(2, "Ноутбук", "Красота", 900, 20),
            //    new Product(3, "Кофе-машина", "Красота", 150, 20),
            //    new Product(4, "Блютуз-наушники", "Красота", 80, 20),
            //    new Product(5, "Фитнес-браслет", "Красота", 50, 20),
            //    new Product(6, "Внешний жесткий диск", "Красота", 120, 20),
            //    new Product(7, "Беспроводная мышь", "Красота", 25, 20),
            //    new Product(8, "Игровое кресло", "Красота", 200, 20),
            //    new Product(9, "Умные часы", "Красота", 180, 20),
            //    new Product(10, "Игровая клавиатура", "Красота", 100, 20),
            //};

            // Все продукты дороже 150
            // 1 способ
            //IEnumerable<Product> luxury = prods.Where(p => p.Price > 150.0);

            //foreach(Product item in luxury)
            //{
            //    Console.WriteLine(item.Name);
            //}

            // 2 способ
            //IEnumerable<string> luxNames = from good in prods
            //                               where good.Price > 150
            //                               select good.Name;

            //var events = new List<Event>
            //{
            //    new Event{Id = 1, Name = "Презентация новых продуктов", Date = DateTime.Now.AddDays(10), Priority = Priority.High},
            //    new Event{Id = 2, Name = "Обучающий вебинар по программированию", Date = DateTime.Now.AddMonths(1), Priority = Priority.Low},
            //    new Event{Id = 3, Name = "Выставка искусства", Date = DateTime.Now.AddDays(20), Priority = Priority.Low},
            //    new Event{Id = 4, Name = "Спортивный турнир по футболу", Date = DateTime.Now.AddDays(30), Priority = Priority.High},
            //    new Event{Id = 5, Name = "Фестиваль культурных традиций", Date = DateTime.Now.AddMonths(2), Priority = Priority.Medium},
            //    new Event{Id = 6, Name = "Научная конференция по биологии", Date = DateTime.Now.AddMonths(3), Priority = Priority.High},
            //    new Event{Id = 7, Name = "Празднование Дня города", Date = DateTime.Now.AddMonths(4), Priority = Priority.Medium},
            //    new Event{Id = 8, Name = "Концерт мировых хитов", Date = DateTime.Now.AddDays(25), Priority = Priority.High},
            //    new Event{Id = 9, Name = "Выставка технологических новинок", Date = DateTime.Now.AddMonths(2), Priority = Priority.High},
            //    new Event{Id = 10, Name = "Обучающий семинар по управлению временем", Date = DateTime.Now.AddDays(12), Priority = Priority.High}
            //};

            // Фильтрация на чистом LINQ
            //IEnumerable<Event> concreteLinqEvents = from evs in events
            //                                  where evs.Date >= new DateTime(2024, 02, 01)  
            //                                  where evs.Priority == Priority.High
            //                                  //&& evs.Date < DateTime.Now.AddDays(31)
            //                                  select evs;

            //// Фильтрация на методах расширения
            //IEnumerable<string> concreteExtensionEvents = events
            //    .Where(e => e.Date >= new DateTime(2024, 02, 01))
            //    .Where(e => e.Priority == Priority.High)
            //    .Select(e => e.Name); // select используется когда нужен не весь объект, а его какое-нибудь свойство

            //foreach(var item in concreteLinqEvents)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //List<Animal> animals = new List<Animal>()
            //{
            //    new Animal("Конь", 700),
            //    new Dog("Hound", 250.0, "Hunt you"),
            //    new Cat("Sebastian", 30.0, "Murrr"),
            //    new Dragon("Dragon", 50000.0, "Burn, baby, like an animal")
            //};

            //var items = animals.OfType<Dog>();

            //foreach(var item in items)
            //{
            //    Console.WriteLine(item.Name);
            //}

            double[] arrayOfDoubles = new double[]
            {

            };

            // Сортировка на чистом LINQ
            IOrderedEnumerable<double> sortedArr = from item in arrayOfDoubles
                                                   orderby item
                                                   select item;

            // Сортировка на методах расширения
            IOrderedEnumerable<double> sortedArrExtensions = arrayOfDoubles
                .OrderBy(item => item);
            // ThenBy() вызывается ТОЛЬКО при интерфейсе IOrderedEnumerable
        }
    }

    public class Animal
    {       
        public string Name { get; set; }
        public double Weight { get; set; }

        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
    }

    public class Dog : Animal
    {
        public string Noise { get; set; } = "Woof";

        public Dog(string name, double weight, string noise) : base(name, weight)
        {
            Noise = noise;
        }
    }

    public class Cat : Animal
    {
        public string Noise { get; set; } = "Meow";

        public Cat(string name, double weight, string noise) : base(name, weight)
        {
            Noise = noise;
        }
    }

    public class Dragon : Animal
    {
        public string Noise { get; set; } = "Rghhh";

        public Dragon(string name, double weight, string noise) : base(name, weight)
        {
            Noise = noise;
        }
    }
}