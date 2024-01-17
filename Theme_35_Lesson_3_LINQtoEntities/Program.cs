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

            List<User> users;

            using (DataBaseContext db = new())
            {
                //db.Users.AddRange(userList);
                //db.SaveChanges();

                users = (from user in db.Users.Include(p => p.Number)
                         where user.Id % 2 == 0
                         select user).ToList();
            }

            foreach(var user in users)
            {
                Console.WriteLine($"{user.Id} {user.Name} {user.Age} {user?.Number?.Number}");
            }
        }
    }
}