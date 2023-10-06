namespace Lesson0610Part2
{
    // Обобщенные интерфейсы

    // Самый первый интерфейс - ICloneable

    internal class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person("Bogdan", 24);
            object secondPerson = firstPerson.Clone();

            Person newSecondPerson = (Person)secondPerson;
        }
    }

    interface IInterface<T>
    {
        T SomeField { get; set; }
        T SetField(T value);
    } 

    class SomeClass : IInterface<int>
    {
        public int SomeField { get; set; }
        public int SetField(int value)
        {
            return SomeField;
        }
    }

    class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public object Clone()
        {
            return new Person(Name, Age);
        }
    }
}