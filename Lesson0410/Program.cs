namespace Lesson0410
{
    internal class Program
    {
        // immutable (неизменяемость) есть ТОЛЬКО у значимых типов и у String, который содержит свой адрес(ссылку)
        // в стеке, а свой объект в виде массива char - в куче, т.е. он имеет свойства как стека, так и кучи


        // Boxing-unboxing
        // boxing - упаковка значимого типа в ссылочный тип
        // unboxing - распаковка ссылочного типа в значимый тип
        // проблемы - расход памяти, нагрузка на производительность
        static void Main(string[] args)
        {
            int a = 6; // Число находится в стеке

            object referenceQbject = a; // Упаковали его в ссылочный тип, сделали из него класс. Возникла УТЕЧКА ПЯМЯТИ

            int newNumber = (int) referenceQbject; // Распаковали его обратно в значимый тип

            Person man = new Person();

            object newMan = man;

            Person someMan = (Person)newMan;
        }

        class Person // Все что касается этого класса находися в куче
        {
            public int Id { get; set; }
        }
    }
}