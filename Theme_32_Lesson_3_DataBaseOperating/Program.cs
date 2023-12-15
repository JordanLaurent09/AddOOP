namespace Theme_32_Lesson_3_DataBaseOperating
{
    public class Program
    {
        static void Main(string[] args)
        {
            using(var context = new DataBaseContext())
            {
                // context.Database.CanConnectAsync() // Асинхронная проверка подключения
                if (context.Database.CanConnect()) // Проверка подключения к БД
                {
                    context.Database.EnsureDeleted(); // Данные методы можно определять и в главном методе main,
                    context.Database.EnsureCreated(); // а не только в конструкторе DataBaseContext

                    context.Database.EnsureDeletedAsync(); // Данные методы можно определять и в главном методе main
                    context.Database.EnsureCreatedAsync(); // а не только в конструкторе DataBaseContext
                }
            }
        }
    }
}