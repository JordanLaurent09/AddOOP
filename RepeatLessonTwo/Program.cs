namespace RepeatLessonTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Person
    {        
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class User : Person
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public User(int id,  string userName, int age) : base(userName, age)
        {
            Id = id;
        }
    }
}