using Microsoft.EntityFrameworkCore;
namespace Theme_32_Lesson_3_DataBaseOperating
{
    public class DataBaseContext:DbContext
    {
        public DbSet<Person> People => Set<Person>();

        public DataBaseContext()
        {
            Database.EnsureDeleted();  // Удаление БД
            Database.EnsureCreated();  // Создание БД


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=TitanicPassengers.db");
        }
    }
}
