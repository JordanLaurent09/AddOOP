namespace Theme_35_Lesson_4_OOPTasks
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Animal snake = new Animal() { Name = "Plissken", Species = "ColdBlooded", Weight = 6};

            //Animal hound = new Animal() { Name = "Bloodhound", Species = "MilkEaters", Weight = 16 };

            //Animal spider = new Animal() { Name = "Shalob", Species = "Chlenistonogye", Weight = 200 };


            //Console.WriteLine($"{snake.Name} {snake.Species} {snake.Weight}");
            //Console.WriteLine($"{hound.Name} {hound.Species} {hound.Weight}");
            //Console.WriteLine($"{spider.Name} {spider.Species} {spider.Weight}");


            //snake.MakeSound("Hisss");
            //hound.MakeSound("Guff");
            //spider.MakeSound("???");

            //Animal[] animals = new Animal[] { snake, hound, spider };

            //Animal.FeedAll(animals);

            Fruit apple = new Fruit("Apple", 23273.3m, "Tommy", 23.3);
            Fruit lemon = new Fruit("Lemon", 4545.3m, "Ricardo", 3.3);

            Drink coffee = new Drink("Coffee", 232m, "Sanchez", false);

            Cereal rice = new Cereal("Rice", 4534m, "Pedro", CerealType.РИС);


        }
    }
}