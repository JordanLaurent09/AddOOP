using Microsoft.EntityFrameworkCore;

namespace Theme_32_Lesson_4_DatabaseOperatingMethods
{
    // CRUD - Create Read Update Delete
    public class Program
    {
        static void Main(string[] args)
        {
            // СREATE
            //List<Person> people = new List<Person>()
            //{
            //    new Person(){Id = 1, Name = "Archie", Age = 20},
            //    new Person(){Id = 2, Name = "Robbie", Age = 21},
            //    new Person(){Id = 3, Name = "Nico", Age = 22},
            //    new Person(){Id = 4, Name = "Shaft", Age = 24}
            //};

            // Работа в лоб
            //using(PersonDBContext dBContext = new PersonDBContext())
            //{
            //    foreach(Person person in people)
            //    {
            //        dBContext.People.Add(person);
            //    }
            //    dBContext.SaveChanges();
            //}

            // Есть альтернaтива работе в лоб,  метод AddRange()
            //using (PersonDBContext dBContext = new PersonDBContext())
            //{              
            //    dBContext.People.AddRange(people);
            //    // dBContext.People.AddRange(people[1], people[2]); Можно и так
            //    dBContext.SaveChanges();
            //}

            // READ
            //List<Person> people;

            //using(PersonDBContext dBContext = new PersonDBContext())
            //{
            //    people = dBContext.People.ToList();

            //    foreach(Person person in people)
            //    {
            //        Console.WriteLine($"{person.Id} {person.Name} {person.Age}");
            //    }
            //}


            // DELETE

            //using (PersonDBContext dBContext = new PersonDBContext())
            //{
            //    Person? person = dBContext.People.FirstOrDefault();

            //    if(person != null)
            //    {
            //        dBContext.People.Remove(person);
            //    }
            //    dBContext.SaveChanges();
            //}
            // FirstOrDefault() - позволяет получить первый элемент из БД
            // Remove(entity) - позволяет удалить элемент БД


            // UPDATE
            using (PersonDBContext dBContext = new PersonDBContext())
            {
                Person? person = dBContext.People.FirstOrDefault();

                //Task.Run(async () => { List<Person> persons = await dbContext.People.ToListAsync(); });

                //Person? person =  await dBContext.People.FirstOrDefaultAsync(); можно использовать в асинхронном режиме, если есть Task
                // List<Person> persons = await dbContext.People.ToListAsync();

                person!.Name = "Fox";
                person.Age = 27;

                Person? foundPerson = dBContext.People.Find(2);

                //Person? foundAsyncPerson = await dBContext.People.FindAsync(2);

                int counter = dBContext.People.Count(p => p.Name == "Fox"); // Метод для подсчета сущностей с конкретными атрибутами


                dBContext.People.Update(person);
                
                dBContext.SaveChanges();
            }
        }     
    }
}