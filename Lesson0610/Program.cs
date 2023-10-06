using System.Drawing;

namespace Lesson0610
{
    // ИНТЕРФЕЙСЫ
    // Контракт - то, что обязательно нужно реализовать классом
    // Правило - интерфейс начинается с буквы I
    // Интерфейсы - реализуются

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public interface ILogger1
    {
        void LogMessage(string v);
    }

    public interface ILogger2
    {
        void LogMessage(string v);
    }

    public class FileLogger : ILogger1, ILogger2
    {
        // если реализованы сразу два метода из двух интерфейсов, будет работать самый первый
        // поэтому надо делать по-другому:
        void ILogger1.LogMessage(string v)
        {
            Console.WriteLine(v);
        }

        void ILogger2.LogMessage(string v)
        {
            Console.WriteLine(v);
        }
    }


    public interface IDrawable
    {
        void Draw();
    } 



    public abstract class Shape : IDrawable
    {
        public abstract void Draw();

        public abstract double Square { get; set; }
    }


    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Рисуем круг");
        }

        public override double Square { get; set; }
    }


    // Попугаи

    public interface IFly
    {
        void Fly();
    }

    public abstract class Birds : IFly
    {
        public abstract void Fly();

        public abstract Color Color { get; set; }
    }


    public class Parrot : Birds
    {
        public override void Fly()
        {
            Console.WriteLine("Не летает, а в клетке сидит");
        }

        public override Color Color { get; set; }   
    }




    // Повторение прошлого урока
    public abstract class People
    {
        protected abstract string Name { get; set; }
        protected abstract int Age { get; set; }

        protected abstract DateTime GetBirthYear();
    }

    public class Person:People
    {
        protected override string Name { get; set; }
        protected override int Age { get; set;}

        protected override DateTime GetBirthYear()
        {
            int currentYear = DateTime.Now.Year;
            int birthYear = currentYear - Age;
            return new DateTime(birthYear);
        }
    }
}