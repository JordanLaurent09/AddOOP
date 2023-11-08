using System.Runtime.CompilerServices;

namespace RepeatLessonThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string, long> genClass = new GenericClass<string, long>();

            genClass.Foo<int>(24);

            ChildClass childClass = new ChildClass()
            {
                Age = 25,
                Id = 12345,
                Name = "Name",
                Password = "dfkjadlk"
            };

            

            IParentClass parentClass = childClass; // Upcast - приведение к вышестоящему
            Console.WriteLine(parentClass.Name);
            Console.WriteLine(parentClass.Id);

            ChildClass newChildClass = (ChildClass) parentClass; // Downcast - приведение к нижестоящему

            Console.WriteLine(newChildClass.Age);

            IParentClass iparent = newChildClass;

            Console.WriteLine(iparent.Id);


            First first = new First();
            Second second = new Second();

            first.Value = 2;
            second.Value = 50;

            Console.WriteLine(first + second);
        }
    }

    class GenericClass<TWords, TNumbers>
    {
        public TNumbers Value { get; set; }
        public TWords Name { get; set; } 

        public T Foo<T>(T value)
        {
            return value;
        }
    }

    interface IParentClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class ChildClass : IParentClass 
    {
        public int Age { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }


    class First
    {
        public int Value { get; set; }

        public static int operator+(First current, Second other)
        {
            return current.Value + other.Value;
        }
    }

    class Second
    {
        public int Value { get; set; }
    }
}