using Microsoft.EntityFrameworkCore;

namespace Theme_35_Lesson_3_LINQtoEntities
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<User> userList = new List<User>()
            //{
            //    new User("Валерий",25, new TelephoneNumber("00000000000")),
            //    new User("Дмитрий",30, new TelephoneNumber("11111111111")),
            //    new User("Анна",28, new TelephoneNumber("22222222222")),
            //    new User("Алексей",22, new TelephoneNumber("33333333333")),
            //    new User("Богдан",35, new TelephoneNumber("44444444444")),
            //    new User("Светлана",29, new TelephoneNumber("55555555555")),

            //};

            //List<User> users;

            using (DataBaseContext db = new())
            {
                // Заполнение таблицу данными
                //db.Users.AddRange(userList);
                //db.SaveChanges();

                // Исп. ЛИНК для работы с БД
                //users = (from user in db.Users.Include(p => p.Number)
                //         where user.Id % 2 == 0
                //         select user).ToList();

                // Использование JOIN
                //var users = db.Users.Join(db.TelephoneNumber,
                //    u => u.Number.Id,
                //    n => n.Id,
                //    (u, n) => new
                //    {
                //        Name = u.Name,
                //        Number = n.Number,
                //        Age = u.Age
                //    });

                // Это работает только с локальными клиентскими ДБ (такими, как SQLITE)
                //var grouppedByAge = db.Users
                //    .GroupBy(u => u.Age)
                //    .OrderBy(g => g.Key);

                // А это сработает c MySQL
                var grouppedByAge = db.Users // DbSet<> - не реализует интерфейс IEnumerable, поэтому ее нужно приводить к такому типу(при необходимости), либо пользоваться "родными" способами работы с DbSet<>
                    .AsEnumerable()
                    .GroupBy(u => u.Age) // так как работает только для IEnumerable
                    .OrderBy(g => g.Key);



                foreach (var group in grouppedByAge)
                {
                    Console.WriteLine($"Группа пользователей с возрастом {group.Key}");

                    foreach(var user in group)
                    {
                        Console.WriteLine(user.Name);
                    }
                    Console.WriteLine();
                }

            }

            
        }
    }
}