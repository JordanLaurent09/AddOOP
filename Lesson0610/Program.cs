using System.Drawing;

namespace Lesson0610
{
    // ИНТЕРФЕЙСЫ
    // Контракт - то, что обязательно нужно реализовать классом
    // Правило - интерфейс начинается с буквы I
    // Интерфейсы - реализуются
    // Приведение класса к интерфейсу - upcast,
    // только в том случае, если класс реализует данный интерфейс


    public enum Priority
    {
        Low,
        Medium, 
        High
    }


    class Program
    {
        static void Main(string[] args)
        {
            TaskManager manager = new TaskManager();
            manager.AddTask(new Task("Поход к врачу", new DateTime(2003, 3, 3), Priority.Low));
            manager.AddTask(new Task("Поход в кафе", new DateTime(2023, 10, 13), Priority.High));
            manager.AddTask(new Task("Отдых", new DateTime(2005, 6, 1), Priority.Medium));

            manager.Display();

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


    // Самостоятельная работа

    public interface ITask
    {
        string Title { get; set; }
        DateTime DueDate { get; set; }
        Priority Priority { get; set; }

        void Display();
    }


    public class Task : ITask
    {
        public string Title { get; set; }
        public DateTime DueDate { get; set;}
        public Priority Priority { get; set; }

        public void Display()
        {

        }

        public Task(string title, DateTime dueDate, Priority priority)
        {
            Title = title;
            DueDate = dueDate;
            Priority = priority;
        }
    }

    public class Event : ITask
    {
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }

        public string Location { get; set; }

        public  Event(string title, DateTime dueDate, Priority priority, string location)
        {
            Title = title;
            DueDate = dueDate;
            Priority = priority;
            Location = location;
        }

        public void Display()
        {

        }
    }

    public class TaskManager
    {
        public List<ITask> DataList { get; set; }

        public TaskManager()
        {
            DataList = new List<ITask>(); 
        }

        public void AddTask(Task task)
        {
            DataList.Add(task);
        }

        public void AddEvent(Event someEvent)
        {
            DataList.Add(someEvent);
        }

        public void Display()
        {
            foreach(var item in DataList)
            {
                Console.WriteLine(
                    "{0}\n{1}\n{2}\n",
                    item.Title, 
                    item.DueDate, 
                    item.Priority 
                    );
            }
        }


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