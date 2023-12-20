using Microsoft.EntityFrameworkCore;

namespace Theme_32_Lesson_4_DatabaseOperatingMethods
{
    public class PersonDBContext : DbContext
    {
        public DbSet<Person> People => Set<Person>();


        public PersonDBContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MyDataBase.db");
        }

    }
}
