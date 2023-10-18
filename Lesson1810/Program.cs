using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;

namespace Lesson1810
{
    
    class Program
    {
        public static event MyDelegate MyEvent;
        static void Main(string[] args)
        {
            // Реализация IComparable
            Person one = new Person(22, "Tommy");
            Person two = new Person(13, "Bobby");

            Console.WriteLine(one.CompareTo(two));
            // Если класс реализует IComparable, то к нему можно применять метод Array.Sort()



            // Работа с событиями

            MyEvent += Displayed;
            if (true)
            {
                MyEvent();
            }

        }
        // Работа с событиями
        public static void Displayed()
        {
            Console.WriteLine("Я отработал");
        }
    }


    // События (Events)
    // События и делегаты схожи по синтаксису, но разные по применению
    // Событие является реакцией на внешнее действие, делегат является участником общего кода 
    // У событий НЕТ возвращаемого значения, они соданы чтобы уведомлять либо производить вычисления
    // У делегатов БЫВАЕТ возвращаемое значение

    public delegate void MyDelegate();




    // Продолжение обобщенных интерфейсов
    // Interface IComparable
    class Person : IComparable<Person> {
        public int Age { get; set; }

        public string Name { get; set; }

        public Animal Animal { get; set; }
        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public int CompareTo(Person other)
        {
            return Age.CompareTo(other.Age);
            return Animal.Age.CompareTo(other.Animal.Age); // Так получать доступ к полям поля класса типа класс
        }
    }

    class Animal
    {
        public int Age { get; set; }
        public Animal(int age)
        {
            Age = age;
        }
    }
}