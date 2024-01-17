using Microsoft.EntityFrameworkCore;

namespace Theme_35_Lesson_3_LINQtoEntities
{
    public class DataBaseContext: DbContext
    {
        public DbSet<User> Users { get; set; } = null!;


        public DbSet<TelephoneNumber> TelephoneNumber { get; set; } = null!;

        public DataBaseContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=192.168.10.184;user=cifra-student-remote;password=Cifra39;database=remote_database;", new MySqlServerVersion(new Version(8, 0, 25)));
        }
    }
}
