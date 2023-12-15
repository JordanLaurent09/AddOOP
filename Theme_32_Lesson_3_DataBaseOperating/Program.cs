namespace Theme_32_Lesson_3_DataBaseOperating
{
    public class Program
    {
        static void Main(string[] args)
        {
            //using(var context = new DataBaseContext())
            //{
            //    // context.Database.CanConnectAsync() // Асинхронная проверка подключения
            //    if (context.Database.CanConnect()) // Проверка подключения к БД
            //    {
            //        context.Database.EnsureDeleted(); // Данные методы можно определять и в главном методе main,
            //        context.Database.EnsureCreated(); // а не только в конструкторе DataBaseContext

            //        context.Database.EnsureDeletedAsync(); // Данные методы можно определять и в главном методе main
            //        context.Database.EnsureCreatedAsync(); // а не только в конструкторе DataBaseContext
            //    }
            //}

            using(var context = new TitanicPassengersContext())
            {
                List<Passenger> passengers = context.Passengers.ToList();

                foreach(Passenger item in passengers)
                {
                    Console.WriteLine($"{item.PassengerId} {item.Name} {item.Survived} {item.Pclass}" +
                        $"{item.Sex} {item.Age} {item.SibSp} {item.Parch} {item.Ticket} {item.Fare} {item.Cabin} {item.Embarked}");
                }
            }
        }
    }
}